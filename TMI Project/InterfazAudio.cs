using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NAudio.Wave; // installed with nuget
using NAudio.CoreAudioApi;
using System.Numerics;
using TMI_Project.Analisis;

namespace TMI_Project
{
    public partial class InterfazAudio : Form
    {

        public WaveIn wi;
        public BufferedWaveProvider bwp;
        public Int32 envelopeMax;

        Afinador afinador;

        private int RATE = 16384; // sample rate of the sound card
        //private int BUFFERSIZE = 4096;
        private int BUFFERSIZE = 4096;
        //private static int BUFFERSIZE2 = 4096;
        private static int BUFFERSIZE2 = 4096;
        private AnalizadorMusical am;

        public InterfazAudio()
        {
            InitializeComponent();
            am = new AnalizadorMusical();
            afinador = new Afinador();

            // see what audio devices are available
            int devcount = WaveIn.DeviceCount;
            Console.Out.WriteLine("Device Count: {0}.", devcount);

            // get the WaveIn class started
            WaveIn wi = new WaveIn
            {
                DeviceNumber = 1,
                WaveFormat = new WaveFormat(RATE, 1),
                BufferMilliseconds = (int)((double)BUFFERSIZE / (double)RATE * 1000.0)
            };

            // create a wave buffer and start the recording
            wi.DataAvailable += new EventHandler<WaveInEventArgs>(wi_DataAvailable);
            bwp = new BufferedWaveProvider(wi.WaveFormat);
            //bwp.BufferLength = BUFFERSIZE * 2;
            bwp.BufferLength = BUFFERSIZE * 2;

            bwp.DiscardOnBufferOverflow = true;
            wi.StartRecording();

        }

        // adds data to the audio recording buffer
        void wi_DataAvailable(object sender, WaveInEventArgs e)
        {
            bwp.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }

        public void UpdateAudioGraph()
        {

            // adjust size of fft charts
            //chart2.ChartAreas[0].AxisX.Maximum = materialSlider1.Value;
            //chart3.ChartAreas[0].AxisX.Maximum = materialSlider1.Value;

            // read the bytes from the stream
            int frameSize = BUFFERSIZE;
            var frames = new byte[frameSize];
            bwp.Read(frames, 0, frameSize);
            if (frames.Length == 0) return;
            if (frames[frameSize - 2] == 0) return;

            // convert it to int32 manually (and a double for scottplot)
            int SAMPLE_RESOLUTION = 16;
            int BYTES_PER_POINT = SAMPLE_RESOLUTION / 8;
            Int32[] vals = new Int32[frames.Length / BYTES_PER_POINT];
            double[] Ys = new double[frames.Length / BYTES_PER_POINT];
            double[] Xs = new double[frames.Length / BYTES_PER_POINT];
            double[] Ys2 = new double[frames.Length / BYTES_PER_POINT];
            double[] Xs2 = new double[frames.Length / BYTES_PER_POINT];
            for (int i = 0; i < vals.Length; i++)
            {
                // bit shift the byte buffer into the right variable format
                byte hByte = frames[i * 2 + 1];
                byte lByte = frames[i * 2 + 0];
                vals[i] = ((int)(short)((hByte << 8) | lByte));
                Xs[i] = i;
                Ys[i] = vals[i] / 32767f;
                Xs2[i] = (double)i / BUFFERSIZE2 * RATE; // units are in Hz
            }

            Complex[] complexValues = new Complex[vals.Length];
            Complex[] complexValues2 = new Complex[vals.Length];
            for (int i = 0; i < vals.Length; i++)
            {
                complexValues[i] = new Complex(vals[i]/32767f, 0);
                complexValues2[i] = new Complex(vals[i]/32767f, 0);
            }

            try
            {
                chart1.Series[0].Points.Clear();
                chart2.Series[0].Points.Clear();
                //chart3.Series[0].Points.Clear();
                chart4.Series[0].Points.Clear();
            } catch (Exception e)
            {
                // do nothing
            }
            int _i = 0;
            foreach (var point in Xs)
            {
                chart1.Series[0].Points.AddXY(point, Ys[_i]);
                _i++;
            }
            AnalizadorFrecuencias asd = new AnalizadorFrecuencias();
            //asd.HannWindow(ref complexValues);
            Complex[] zero_padding = new Complex[BUFFERSIZE2];
            for (int i = 0; i < zero_padding.Length; i++)
            {
                if (i < complexValues.Length)
                {
                    zero_padding[i] = complexValues[i];
                }
                else
                {
                    zero_padding[i] = new Complex(0, 0);
                }
            }
            //asd.HammingWindow(ref zero_padding);
            //Complex[] fftValues = asd.FFT(complexValues);
            asd.GaussianWindow(ref zero_padding);
            //Complex[] fftValues = asd.FFT(zero_padding);
            Complex[] fftValues = asd.FFT(zero_padding);
            double pick = asd.GetPick(fftValues, RATE, BUFFERSIZE2);
            NotasMusicales nm = new NotasMusicales();
            int nota = nm.GetNota(pick);
            //Console.WriteLine(nm.GetNota(nota) + " " + pick);
            //Console.WriteLine("Pick: " + pick + " Hz");
            int j = 1;
            for (int i = 0; i < zero_padding.Length/2; i++)
            {
                chart2.Series[0].Points.AddXY(j, fftValues[i].Magnitude);
                j++;
            }
            am.ObtenerNotasMusicales(fftValues);
            Console.WriteLine(am);
            /*asd.HannWindow(ref zero_padding);
            Complex[] fftValues2 = asd.FFT(zero_padding);
            int k = 1;
            for (int i = 0; i < vals.Length/2; i++)
            {
                chart3.Series[0].Points.AddXY(k, fftValues2[i].Magnitude);
                k++;
            }*/
            
            // for audio signal 2
            asd.GaussianWindow(ref complexValues2);
            int l = 1;
            for (int i = 0; i < complexValues2.Length; i++)
            {
                chart4.Series[0].Points.AddXY(i, complexValues2[i].Real);
                l++;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAudioGraph();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateAudioGraph();
        }

        private void materialSlider1_onValueChanged(object sender, int newValue)
        {
            chart2.ChartAreas[0].AxisX.Maximum = materialSlider1.Value;
            chart3.ChartAreas[0].AxisX.Maximum = materialSlider1.Value;
        }

        private void materialSlider1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.D1)
            {
                materialSlider1.Value--;
                chart2.ChartAreas[0].AxisX.Maximum = materialSlider1.Value;
                chart3.ChartAreas[0].AxisX.Maximum = materialSlider1.Value;
            }
            else if (e.KeyChar == (char)Keys.D2)
            {
                materialSlider1.Value++;
                chart2.ChartAreas[0].AxisX.Maximum = materialSlider1.Value;
                chart3.ChartAreas[0].AxisX.Maximum = materialSlider1.Value;
            }
            
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            int bufferSize = int.Parse(txtBuffer.Text);
            materialSlider2.Value = bufferSize;
            BUFFERSIZE2 = bufferSize;
        }

        private void materialSlider2_onValueChanged(object sender, int newValue)
        {
            BUFFERSIZE2 = newValue;
        }

        private void materialSlider2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D1)
            {
                materialSlider2.Value--;
                BUFFERSIZE2 = materialSlider2.Value;
            }
            else if (e.KeyChar == (char)Keys.D2)
            {
                materialSlider2.Value++;
                BUFFERSIZE2 = materialSlider2.Value;
            }
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            chart2.ChartAreas[0].AxisX.Minimum = int.Parse(txtZoomX1.Text);
            chart2.ChartAreas[0].AxisX.Maximum = int.Parse(txtZoomX2.Text);
            
            chart3.ChartAreas[0].AxisX.Minimum = int.Parse(txtZoomX1.Text);
            chart3.ChartAreas[0].AxisX.Maximum = int.Parse(txtZoomX2.Text);
        }

        private void btnEscala_Click(object sender, EventArgs e)
        {
            EscalasMusicales em = new EscalasMusicales();
            //em.GetEscalaMusical()
        }
    }
}