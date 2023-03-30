using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimediaAudioProject
{
    public partial class AddVolumeRatio : Form
    {



        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();


        public AddVolumeRatio()
        {
            InitializeComponent();
        }
        private void Header_MouseHover(object sender, EventArgs e)
        {
            Focus();
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Focused)
            {
                Focus();
            }
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private int vl;
        private float myVal;



        public int Vl
        {
            get { return vl; }
            set { vl = value; }
        }
        public float MyVal
        {
            get { return myVal; }
            set { myVal = value; }
        }


        private void Add_Click(object sender, EventArgs e)
        {
            if (!Up.Checked && !Down.Checked) {

                MessageBox.Show("Check Please");
                vl = 3;
                myVal =0;
            }
            else
            {
                if (Up.Checked)
                    vl = 0;
                if (Down.Checked)
                    vl = 1;
                myVal = (float)trackBar1.Value / 10;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ratio.Text = ((float)trackBar1.Value/10).ToString();
        }
    }
}
