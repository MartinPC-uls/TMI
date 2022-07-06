using System;
using System.Windows.Forms;
using System.IO;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using TMI_Project.Sound;

namespace TMI_Project
{
    public partial class IntefazGrabacion : Form
    {

        RecordAudio audio = null;
        Audio _audio = null;
        string Instrumento = "";
        public IntefazGrabacion()
        {
            InitializeComponent();
            graphicAudio();
            btnStop.Enabled = false;
            audio = new RecordAudio();
        }

        static int Fs;
        static readonly int FrameSize = 16384;

        public void graphicAudio()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "acordes4.wav";

            Audio audio = new Audio(path);
            _audio = audio;
            Fs = audio.SampleRate;
            Complex[] samples = new Complex[audio.RealData.Length];
            for (int i = 0; i < audio.RealData.Length; i++)
            {
                samples[i] = new Complex(audio.RealData[i], 0);
            }

            DeterminarEscala(samples, FrameSize);
        }

        public void DeterminarEscala(Complex[] s_samples, int frameSize)
        {
            NotasMusicales nm = new NotasMusicales();
            int nFrame = 1;
            List<Complex[]> fft_frames = new List<Complex[]>();
            for (int i = 0; i < s_samples.Length; i += frameSize)
            {

                if (i+frameSize > s_samples.Length)
                {
                    Console.WriteLine("------");
                    Console.WriteLine("C: " + nm.get("C"));
                    Console.WriteLine("C#: " + nm.get("C#"));
                    Console.WriteLine("D: " + nm.get("D"));
                    Console.WriteLine("D#: " + nm.get("D#"));
                    Console.WriteLine("E: " + nm.get("E"));
                    Console.WriteLine("F: " + nm.get("F"));
                    Console.WriteLine("F#: " + nm.get("F#"));
                    Console.WriteLine("G: " + nm.get("G"));
                    Console.WriteLine("G#: " + nm.get("G#"));
                    Console.WriteLine("A: " + nm.get("A"));
                    Console.WriteLine("A#: " + nm.get("A#"));
                    Console.WriteLine("B: " + nm.get("B"));
                    getMusicalScale(nm);
                    return;
                }
                Complex[] frame = getFrame(s_samples, i, i + frameSize);
                HannWindow(ref frame);
                Complex[] fft_values = FFT(frame);
                fft_frames.Add(fft_values);
                double f = getPicks(fft_values, nm);
                nm.add(f,2);
                double avg = Queryable.Average(fft_values.Select(m => m.Magnitude).ToList().AsQueryable());

                Armonicos armonicos = new Armonicos(fft_values, f, _audio, avg);
                int[] arm = armonicos.Armonico;
                for (int j = 0; j < arm.Length; j++)
                {
                    nm.add(nm.getNota(arm[j]), 20);
                }
                nFrame++;
                i -= frameSize / 2;
            }
            Console.WriteLine("------");
            Console.WriteLine("C: " + nm.get("C"));
            Console.WriteLine("C#: " + nm.get("C#"));
            Console.WriteLine("D: " + nm.get("D"));
            Console.WriteLine("D#: " + nm.get("D#"));
            Console.WriteLine("E: " + nm.get("E"));
            Console.WriteLine("F: " + nm.get("F"));
            Console.WriteLine("F#: " + nm.get("F#"));
            Console.WriteLine("G: " + nm.get("G"));
            Console.WriteLine("G#: " + nm.get("G#"));
            Console.WriteLine("A: " + nm.get("A"));
            Console.WriteLine("A#: " + nm.get("A#"));
            Console.WriteLine("B: " + nm.get("B"));
            getMusicalScale(nm);
        }

        public void getMusicalScale(NotasMusicales nm)
        {
            int[] repeticiones = new int[12];
            repeticiones[0] = nm.get("C");
            repeticiones[1] = nm.get("C#");
            repeticiones[2] = nm.get("D");
            repeticiones[3] = nm.get("D#");
            repeticiones[4] = nm.get("E");
            repeticiones[5] = nm.get("F");
            repeticiones[6] = nm.get("F#");
            repeticiones[7] = nm.get("G");
            repeticiones[8] = nm.get("G#");
            repeticiones[9] = nm.get("A");
            repeticiones[10] = nm.get("A#");
            repeticiones[11] = nm.get("B");

            int average = 0;
            for (int j = 0; j < repeticiones.Length; j++)
            {
                average += repeticiones[j];
            }
            average /= repeticiones.Length;

            int cantidad = 12;
            for (int k = 0; k < repeticiones.Length; k++)
            {
                if (repeticiones[k] < average)
                {
                    repeticiones[k] = 0;
                    cantidad -= 1;
                }
            }

            Array.Sort(repeticiones);
            Console.WriteLine("-----------------x-xxxxxxxxxx-------------x------------------");
            Console.WriteLine("Notas identificadas: " + cantidad);
            int nota = 0;
            int[] ordenNotas = new int[12];
            for (int i = 0; i < repeticiones.Length; i++)
            {
                if (repeticiones[i] == nm.get("C"))
                {
                    nota = 1;
                    ordenNotas[i] = 1;
                }
                else if (repeticiones[i] == nm.get("C#"))
                {
                    nota = 2;
                    ordenNotas[i] = 2;
                }
                else if (repeticiones[i] == nm.get("D"))
                {
                    nota = 3;
                    ordenNotas[i] = 3;
                }
                else if (repeticiones[i] == nm.get("D#"))
                {
                    nota = 4;
                    ordenNotas[i] = 4;
                }
                else if (repeticiones[i] == nm.get("E"))
                {
                    nota = 5;
                    ordenNotas[i] = 5;
                }
                else if (repeticiones[i] == nm.get("F"))
                {
                    nota = 6;
                    ordenNotas[i] = 6;
                }
                else if (repeticiones[i] == nm.get("F#"))
                {
                    nota = 7;
                    ordenNotas[i] = 7;
                }
                else if (repeticiones[i] == nm.get("G"))
                {
                    nota = 8;
                    ordenNotas[i] = 8;
                }
                else if (repeticiones[i] == nm.get("G#"))
                {
                    nota = 9;
                    ordenNotas[i] = 9;
                }
                else if (repeticiones[i] == nm.get("A"))
                {
                    nota = 10;
                    ordenNotas[i] = 10;
                }
                else if (repeticiones[i] == nm.get("A#"))
                {
                    nota = 11;
                    ordenNotas[i] = 11;
                }
                else if (repeticiones[i] == nm.get("B"))
                {
                    nota = 12;
                    ordenNotas[i] = 12;
                }
            }
            int[] _ordenNotas = new int[ordenNotas.Length];
            for (int i = 0; i < ordenNotas.Length; i++)
            {
                _ordenNotas[i] = ordenNotas[i];
            }

            for (int i = 0; i < _ordenNotas.Length; i++)
            {
                Console.WriteLine(nm.getNota(_ordenNotas[i]));
            }

            Console.WriteLine("Nota dominante: " + nm.getNota(nota));
            int nextNota = getFifth(nota);
            for (int i = 0; i < ordenNotas.Length; i++)
            {
                if (nextNota == ordenNotas[i] && nm.get(nm.getNota(ordenNotas[i])) < average)
                {
                    break;
                }
                else if (nextNota == ordenNotas[i])
                {
                    nota = ordenNotas[i];
                    nextNota = getFifth(nota);
                    i = 0;
                }
            }

            Console.WriteLine("nextNota: " + nm.getNota(nextNota));

            ScaleGenerator escala = new ScaleGenerator(nm);
            escala.print();
            escala.print2();

            string[] escalaGenerada = escala.getMusicalScale();
            EscalasMusicales escalasMusicales = new EscalasMusicales();
            List<string[]> escalas = escalasMusicales.escalas;
            foreach (string[] _escala in escalas) {
                if (Enumerable.SequenceEqual(escalaGenerada, _escala)) {
                    Console.WriteLine("Escala Musical encontrada!");
                    escala.printScaleImage(_escala, escalasMusicales, pictureBox1, Instrumento, nombreEscala);
                    return;
                }
            }
            Console.WriteLine("Escala musical no encontrada.");
        }

        public int getFifth(int nota)
        {
            int next = 5;
            nota += next;
            if (nota > 12)
                nota -= 12;

            return nota;
        }

        public static void ClearMemory<T>(List<T> lista)
        {
            int identificador = GC.GetGeneration(lista);
            lista.Clear();
            GC.Collect(identificador, GCCollectionMode.Forced);
        }

        public Complex[] getFrame(Complex[] signal, int from, int to)
        {
            Complex[] frame = new Complex[to-from];
            for (int i = 0, j = from; i < frame.Length && j < to; i++, j++)
            {
                frame[i] = signal[j];
            }
            return frame;
        }
         
        public void HannWindow(ref float[] data, int frameSize)
        {

            float[] aux = data;
            for (int i = 0; i < data.Length; i++)
            {
                aux[i] = (float)(0.5 * (1 - Math.Cos((2 * Math.PI * i) / (frameSize - 1))));
                data[i] *= aux[i];
            }
        }
        public void HannWindow(ref Complex[] data)
        {
            double aux;
            for (int i = 0; i < data.Length; i++)
            {
                aux = 0.5 * (1 - Math.Cos((2 * Math.PI * i) / (data.Length - 1)));
                data[i] *= new Complex(aux, 0);
            }
        }

        public double getPicks(Complex[] signal, NotasMusicales nm)
        {
            Frequencies[] frqs = new Frequencies[signal.Length/2];
            for (int i = 0; i < signal.Length/2; i++) 
            {
                frqs[i] = new Frequencies { freqbin = i, amplitude = signal[i].Magnitude };
            }
            var _f = frqs.OrderByDescending(amp => amp.amplitude);
            int j = 0;
            foreach (Frequencies f in _f)
            {
                if (j == 1)
                {
                    return Math.Round((double)f.freqbin * Fs / FrameSize, 2, MidpointRounding.AwayFromZero);
                }
                j++;
            }
            return 0;
        }

        public double getHighestFrequency(Complex[] signal, int _i = 0, int fs_n = 0)
        {
            double maxValue = signal[1].Magnitude;
            double freqbin = 1;
            int upTo = signal.Length/2;
            if (_i != 0)
                upTo = _i;

            fs_n /= 2;

            for (int i = 1; i < upTo; i++)
            {
                if (signal[i].Magnitude > maxValue)
                {
                    maxValue = signal[i].Magnitude;
                    freqbin = Math.Round((double)freqbin * Fs / FrameSize, 2, MidpointRounding.AwayFromZero);
                }
            }
            return freqbin;
        }

        public void copySignal(byte[] from, ref float[] to, int bitsPerSample)
        {
            int eo; // even = 0, odd = 1
            if (from.Length % 2 == 0)
            {
                eo = 0;
            } else
            {
                eo = 1;
            }
            for (int i = 44, j = 0; i < from.Length-eo; i += bitsPerSample/8, j++)
            {
                to[j] = BitConverter.ToInt16(from, i) / 32768f;
            }
        }

        public Complex[] FFT(Complex[] samples)
        {
            int N = samples.Length;
            if (N == 1)
            {
                return samples;
            }
            else
            {
                int M = N / 2;

                Complex[] Xeven = new Complex[M];
                Complex[] Xodd = new Complex[M];

                for (int i = 0; i != M; i++)
                {
                    Xeven[i] = samples[2 * i];
                    Xodd[i] = samples[2 * i + 1];
                }
                Complex[] Feven = FFT(Xeven);
                Complex[] Fodd = FFT(Xodd);

                Complex[] freqbins = new Complex[N];
                for (int k = 0; k != M; k++)
                {
                    double exp = -2 * k * Math.PI/N;
                    Complex even = Feven[k];
                    Complex odd = new Complex(Math.Cos(exp), Math.Sin(exp));
                    odd *= Fodd[k];
                    freqbins[k] = even + odd;
                    freqbins[k + N / 2] = even - odd;
                }
                return freqbins;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            audio.start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            audio.stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            graphicAudio();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instrumento = comboBox1.Text;
        }
    }
}
