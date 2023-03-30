using NAudio.WaveFormRenderer;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;

namespace MultimediaAudioProject
{
    public partial class AudioForm : Form
    {
        FunctionProvider FunctionProvider;
        public AudioForm()
        {
            InitializeComponent();
            FunctionProvider = new FunctionProvider();


        }
        //Start Of Title Bar
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();


        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            Focus();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Focused)
            {
                Focus();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //End Of TitleBar
        String SampleRate;
        String Channels;
        String BitsPerSample;
        String AverageBytesPerSecond_wave;
        String totalTime;
        NAudio.Wave.WaveStream reader;
        WaveOut waveOut = new WaveOut();

        //Start of File
        //Start Of Open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "MP3 Files|*.mp3";
            o.Title = "Select MP3 file";

            if (o.ShowDialog() == DialogResult.Cancel)
                return;



            reader = new Mp3FileReader(o.FileName);
            FunctionProvider.reader = reader;
            ReRender(reader);

        }
        //End of Open
        //Start Of Save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FunctionProvider.reader == null)
                return;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "WAV file|*.wav";
            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;
            WaveFileWriter writer = new WaveFileWriter(dialog.FileName, FunctionProvider.reader.WaveFormat);
            byte[] buffer = new byte[5000000];
            FunctionProvider.reader.Seek(0, SeekOrigin.Begin);
            while (true)
            {
                int r = FunctionProvider.reader.Read(buffer, 0, buffer.Length);
                if (r == 0)
                    break;
                writer.Write(buffer, 0, r);
            }
            writer.Close();
        }
        //End Of Save
        //End Of File

        void ReRender(WaveStream reader)
        {

            SampleRate = FunctionProvider.reader.WaveFormat.SampleRate.ToString();
            Channels = FunctionProvider.reader.WaveFormat.Channels.ToString();
            BitsPerSample = FunctionProvider.reader.WaveFormat.BitsPerSample.ToString();
            AverageBytesPerSecond_wave = FunctionProvider.reader.WaveFormat.AverageBytesPerSecond.ToString();
            totalTime = FunctionProvider.reader.TotalTime.ToString();

            List.Items.Clear();

            List.Items.Add(new ListViewItem(new String[] { "SampleRate", SampleRate }));
            List.Items.Add(new ListViewItem(new String[] { "Channels", Channels }));
            List.Items.Add(new ListViewItem(new String[] { "BitsPerSample", BitsPerSample }));
            List.Items.Add(new ListViewItem(new String[] { "AverageBytesPerSecond", AverageBytesPerSecond_wave }));
            List.Items.Add(new ListViewItem(new String[] { "TotalTime", totalTime }));

            List.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            List.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            AveragePeakProvider averagePeakProvider = new AveragePeakProvider(3);
            StandardWaveFormRendererSettings myRendererSettings = new StandardWaveFormRendererSettings();
            myRendererSettings.Width = Wave.Width;
            myRendererSettings.TopHeight = 50;
            myRendererSettings.BottomHeight = 50;
            myRendererSettings.BackgroundColor = Color.Transparent;
            myRendererSettings.TopPeakPen = new Pen(Color.FromArgb(178, 81, 105));
            myRendererSettings.BottomPeakPen = new Pen(Color.FromArgb(178, 81, 105));
            WaveFormRenderer renderer = new WaveFormRenderer();
            Image image = renderer.Render(FunctionProvider.reader, averagePeakProvider, myRendererSettings);
            Wave.Image = image;
        }
        //Start Of Control
        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FunctionProvider.reader == null)
                return;

            FunctionProvider.play();
            timer1.Enabled = true;
            indicator.Visible = true;


        }
        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FunctionProvider.reader == null)
                return;

            FunctionProvider.resume();
            timer1.Enabled = true;
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FunctionProvider.reader == null)
                return;
            FunctionProvider.pause();
            timer1.Enabled = false;
        }
        //End Of Control




        private void timer1_Tick(object sender, EventArgs e)
        {
            float location1 = (float)(FunctionProvider.reader.Position * Wave.Width / FunctionProvider.reader.Length);

            hScrollBar1.Value = (int)(FunctionProvider.reader.Position * hScrollBar1.Maximum / FunctionProvider.reader.Length);
            time.Text = FunctionProvider.reader.CurrentTime.Minutes.ToString() + " : " + FunctionProvider.reader.CurrentTime.Seconds.ToString();

            indicator.Location = new Point((int)location1, indicator.Location.Y);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (FunctionProvider.reader == null)
                return;
            FunctionProvider.reader.Position = hScrollBar1.Value * FunctionProvider.reader.Length / hScrollBar1.Maximum;

        }

        private void Wave_MouseDown(object sender, MouseEventArgs e)
        {
            if (FunctionProvider.reader == null)
                return;
            FunctionProvider.reader.Position = e.X * FunctionProvider.reader.Length / Wave.Width;
        }



        //Start of Edit

        private void volumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FunctionProvider.reader == null)
                return;
            FunctionProvider.volume();
            ReRender(FunctionProvider.reader);
        }




        private void speedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FunctionProvider.reader == null)
                return;
            FunctionProvider.speed();
            ReRender(FunctionProvider.reader);

        }

        private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FunctionProvider.reader == null)
                return;

            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "MP3 file|*.mp3";
            d.Title = "Choose file";
            if (d.ShowDialog() == DialogResult.Cancel)
                return;
            Mp3FileReader reader2 = new Mp3FileReader(d.FileName);

            if (reader2.WaveFormat.SampleRate != reader.WaveFormat.SampleRate)
            {
                float x = reader.WaveFormat.SampleRate / reader2.WaveFormat.SampleRate;
                WaveFormat z = new WaveFormat(reader.WaveFormat.SampleRate, reader.WaveFormat.Channels);

            }
            short[] FirstData = FunctionProvider.readData(FunctionProvider.reader);
            short[] SecondData = FunctionProvider.readData(reader2);

            FunctionProvider.mergeAudio(FirstData, SecondData);

            ReRender(FunctionProvider.reader);
        }
        //End Of Edit
    }


}

