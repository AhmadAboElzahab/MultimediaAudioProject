using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimediaAudioProject
{

    class FunctionProvider
    {
        public WaveStream reader;
        public WaveOut waveOut = new WaveOut();


        public short[] readData(WaveStream song)
        {
            song.Seek(0, SeekOrigin.Begin);
            byte[] bytes = new byte[song.Length];
            song.Read(bytes, 0, bytes.Length);

            short[] data = new short[bytes.Length / 2];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (short)(bytes[i * 2] + bytes[i * 2 + 1] * 256);
            }
            return data;
        }

        public void saveData(short[] data)
        {
            byte[] bytes = new byte[data.Length * 2];
            for (int i = 0; i < data.Length; i++)
            {
                bytes[i * 2] = (byte)(data[i] % 256);
                bytes[i * 2 + 1] = (byte)(data[i] / 256);
            }
            RawSourceWaveStream waveStream = new RawSourceWaveStream(
              bytes,
              0,
              bytes.Length,
              reader.WaveFormat);
            reader = ((WaveStream)waveStream);
        }

        public void play()
        {
            reader.Seek(0, System.IO.SeekOrigin.Begin);
            waveOut.Init(reader);
            waveOut.Play();
        }
        public void pause()
        {
            waveOut.Stop();
        }
        public void resume()
        {
            waveOut.Init(reader);
            waveOut.Play();
        }
        public void volume()
        {
            AddVolumeRatio f = new AddVolumeRatio();
            if (f.ShowDialog() == DialogResult.OK)
            {
                short[] data = readData(reader);
                //Volume Up
                if (f.Vl == 0)
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        data[i] = (short)(data[i] * f.MyVal);
                    }
                    saveData(data);
                }
                else if (f.Vl == 1)
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        data[i] = (short)(data[i] / f.MyVal);
                    }
                }
                else if (f.Vl == 3)
                {
                    return;
                }

                saveData(data);
            }
        }

        public void speed()
        {
            AddSpeed f = new AddSpeed();
            if (f.ShowDialog() == DialogResult.OK)
            {


                float ratio = f.MyVal;


                short[] data = readData(reader);

                int newL = (int)((data.Length / 2) * ratio) * 2;
                var newData = new short[newL];
                for (int i = 0; i < newData.Length; i += 2)
                {
                    int index = (int)((i / 2) / ratio) * 2;
                    newData[i] = data[index];
                    newData[i + 1] = data[index + 1];
                }

                saveData(newData);
            }
        }



        public void mergeAudio(short[] FirstData, short[] SecondData)
        {
            try {
            AddTime f = new AddTime();
            if (f.ShowDialog() == DialogResult.OK)
            {
                double t = double.Parse(f.MyVal) * 60;
                double MergeIndex = t * reader.WaveFormat.SampleRate * reader.WaveFormat.Channels;
                short[] MergedArray = new short[Math.Max(FirstData.Length, SecondData.Length) + (short)MergeIndex];
                for (int i = 0; i < MergedArray.Length; i++)
                {
                    int i2 = (int)(i - MergeIndex);
                    if (i >= FirstData.Length)
                        MergedArray[i] = SecondData[i2];
                    else if (i < MergeIndex || i2 >= SecondData.Length)
                        MergedArray[i] = FirstData[i];
                    else
                    {
                        MergedArray[i] = (short)((FirstData[i] + SecondData[i2]) / 2);
                    }
                }
                saveData(MergedArray);
            }
            }
            catch
            {

                return;
            }

        }
    }
}


