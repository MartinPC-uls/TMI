using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;
using TMI_Project.Grabacion;

namespace TMI_Project.Analisis
{
    public class AnalizadorFrecuencias
    {

        private Audio _audio;
        private readonly int Fs;
        private readonly int FrameSize = 16384; // 2^14

        public AnalizadorFrecuencias(ref PictureBox pictureBox, ref Label nombreEscalaLabel, ref ComboBox comboBox)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "temp.wav";

            Audio audio = new Audio(path);
            _audio = audio;
            Fs = audio.SampleRate;
            Complex[] samples = new Complex[audio.RealData.Length];
            for (int i = 0; i < audio.RealData.Length; i++)
            {
                samples[i] = new Complex(audio.RealData[i], 0);
            }

            DeterminarEscala(samples, FrameSize, ref pictureBox, ref nombreEscalaLabel, ref comboBox);
        }

        public void DeterminarEscala(Complex[] s_samples, int frameSize, ref PictureBox pictureBox, ref Label nombreEscalaLabel, ref ComboBox comboBox)
        {
            NotasMusicales nm = new NotasMusicales();
            int nFrame = 1;
            List<Complex[]> fft_frames = new List<Complex[]>();
            for (int i = 0; i < s_samples.Length; i += frameSize)
            {

                if (i + frameSize > s_samples.Length)
                {
                    Console.WriteLine("------");
                    Console.WriteLine("C: " + nm.Get("C"));
                    Console.WriteLine("C#: " + nm.Get("C#"));
                    Console.WriteLine("D: " + nm.Get("D"));
                    Console.WriteLine("D#: " + nm.Get("D#"));
                    Console.WriteLine("E: " + nm.Get("E"));
                    Console.WriteLine("F: " + nm.Get("F"));
                    Console.WriteLine("F#: " + nm.Get("F#"));
                    Console.WriteLine("G: " + nm.Get("G"));
                    Console.WriteLine("G#: " + nm.Get("G#"));
                    Console.WriteLine("A: " + nm.Get("A"));
                    Console.WriteLine("A#: " + nm.Get("A#"));
                    Console.WriteLine("B: " + nm.Get("B"));
                    getMusicalScale(nm, ref pictureBox, ref nombreEscalaLabel, ref comboBox);
                    return;
                }
                Complex[] frame = GetFrame(s_samples, i, i + frameSize);
                HannWindow(ref frame);
                Complex[] fft_values = FFT(frame);
                fft_frames.Add(fft_values);
                double f = GetPicks(fft_values);
                nm.Add(f, 2);
                double avg = Queryable.Average(fft_values.Select(m => m.Magnitude).ToList().AsQueryable());

                Armonicos armonicos = new Armonicos(fft_values, f, _audio, avg);
                int[] arm = armonicos.Armonico;
                for (int j = 0; j < arm.Length; j++)
                {
                    nm.Add(nm.GetNota(arm[j]), 20);
                }
                nFrame++;
                i -= frameSize / 2;
            }
            Console.WriteLine("------");
            Console.WriteLine("C: " + nm.Get("C"));
            Console.WriteLine("C#: " + nm.Get("C#"));
            Console.WriteLine("D: " + nm.Get("D"));
            Console.WriteLine("D#: " + nm.Get("D#"));
            Console.WriteLine("E: " + nm.Get("E"));
            Console.WriteLine("F: " + nm.Get("F"));
            Console.WriteLine("F#: " + nm.Get("F#"));
            Console.WriteLine("G: " + nm.Get("G"));
            Console.WriteLine("G#: " + nm.Get("G#"));
            Console.WriteLine("A: " + nm.Get("A"));
            Console.WriteLine("A#: " + nm.Get("A#"));
            Console.WriteLine("B: " + nm.Get("B"));
            getMusicalScale(nm, ref pictureBox, ref nombreEscalaLabel, ref comboBox);
        }
        public void getMusicalScale(NotasMusicales nm, ref PictureBox pictureBox, ref Label nombreEscalaMusical, ref ComboBox comboBox)
        {
            int[] repeticiones = new int[12];
            repeticiones[0] = nm.Get("C");
            repeticiones[1] = nm.Get("C#");
            repeticiones[2] = nm.Get("D");
            repeticiones[3] = nm.Get("D#");
            repeticiones[4] = nm.Get("E");
            repeticiones[5] = nm.Get("F");
            repeticiones[6] = nm.Get("F#");
            repeticiones[7] = nm.Get("G");
            repeticiones[8] = nm.Get("G#");
            repeticiones[9] = nm.Get("A");
            repeticiones[10] = nm.Get("A#");
            repeticiones[11] = nm.Get("B");

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
            //Console.WriteLine("-----------------x-xxxxxxxxxx-------------x------------------");
            //Console.WriteLine("Notas identificadas: " + cantidad);
            int nota = 0;
            int[] ordenNotas = new int[12];
            for (int i = 0; i < repeticiones.Length; i++)
            {
                if (repeticiones[i] == nm.Get("C"))
                {
                    nota = 1;
                    ordenNotas[i] = 1;
                }
                else if (repeticiones[i] == nm.Get("C#"))
                {
                    nota = 2;
                    ordenNotas[i] = 2;
                }
                else if (repeticiones[i] == nm.Get("D"))
                {
                    nota = 3;
                    ordenNotas[i] = 3;
                }
                else if (repeticiones[i] == nm.Get("D#"))
                {
                    nota = 4;
                    ordenNotas[i] = 4;
                }
                else if (repeticiones[i] == nm.Get("E"))
                {
                    nota = 5;
                    ordenNotas[i] = 5;
                }
                else if (repeticiones[i] == nm.Get("F"))
                {
                    nota = 6;
                    ordenNotas[i] = 6;
                }
                else if (repeticiones[i] == nm.Get("F#"))
                {
                    nota = 7;
                    ordenNotas[i] = 7;
                }
                else if (repeticiones[i] == nm.Get("G"))
                {
                    nota = 8;
                    ordenNotas[i] = 8;
                }
                else if (repeticiones[i] == nm.Get("G#"))
                {
                    nota = 9;
                    ordenNotas[i] = 9;
                }
                else if (repeticiones[i] == nm.Get("A"))
                {
                    nota = 10;
                    ordenNotas[i] = 10;
                }
                else if (repeticiones[i] == nm.Get("A#"))
                {
                    nota = 11;
                    ordenNotas[i] = 11;
                }
                else if (repeticiones[i] == nm.Get("B"))
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
            string notaDominante = nm.GetNota(nota);

            string[] musicalScale = CalcularEscala(notaDominante, nm, ref comboBox);
            GeneradorEscala sg = new GeneradorEscala();

            sg.MostrarEscalaMusical(musicalScale, pictureBox, "Guitarra", nombreEscalaMusical);
        }
        public string[] CalcularEscala(string notaDominante, NotasMusicales nm, ref ComboBox comboBox)
        {
            EscalasMusicales em = new EscalasMusicales();
            List<string[]> escala = null;
            int[] pesos = new int[7];
            int peso_major = 0;
            int peso_minor = 0;
            int peso_dorian = 0;
            int peso_phrygian = 0;
            int peso_lydian = 0;
            int peso_mixolydian = 0;
            int peso_locrian = 0;

            int pesoNota;

            switch (notaDominante)
            {
                case "C":
                    escala = em.Cescalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = nm.Get(_escala[i]);
                            if (_escala == em.CMajor)
                                peso_major += pesoNota;
                            else if (_escala == em.CMinor)
                                peso_minor += pesoNota;
                            else if (_escala == em.CDorian)
                                peso_dorian += pesoNota;
                            else if (_escala == em.CPhrygian)
                                peso_phrygian += pesoNota;
                            else if (_escala == em.CLydian)
                                peso_lydian += pesoNota;
                            else if (_escala == em.CMixolydian)
                                peso_mixolydian += pesoNota;
                            else if (_escala == em.CLocrian)
                                peso_locrian += pesoNota;
                        }
                    }
                    break;
                case "C#":
                    escala = em.C_escalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = nm.Get(_escala[i]);
                            if (_escala == em.C_Major)
                                peso_major += pesoNota;
                            else if (_escala == em.C_Minor)
                                peso_minor += pesoNota;
                            else if (_escala == em.C_Dorian)
                                peso_dorian += pesoNota;
                            else if (_escala == em.C_Phrygian)
                                peso_phrygian += pesoNota;
                            else if (_escala == em.C_Lydian)
                                peso_lydian += pesoNota;
                            else if (_escala == em.C_Mixolydian)
                                peso_mixolydian += pesoNota;
                            else if (_escala == em.C_Locrian)
                                peso_locrian += pesoNota;
                        }
                    }
                    break;
                case "D":
                    escala = em.Descalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = nm.Get(_escala[i]);
                            if (_escala == em.DMajor)
                                peso_major += pesoNota;
                            else if (_escala == em.DMinor)
                                peso_minor += pesoNota;
                            else if (_escala == em.DDorian)
                                peso_dorian += pesoNota;
                            else if (_escala == em.DPhrygian)
                                peso_phrygian += pesoNota;
                            else if (_escala == em.DLydian)
                                peso_lydian += pesoNota;
                            else if (_escala == em.DMixolydian)
                                peso_mixolydian += pesoNota;
                            else if (_escala == em.DLocrian)
                                peso_locrian += pesoNota;
                        }
                    }
                    break;
                case "D#":
                    escala = em.D_escalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = nm.Get(_escala[i]);
                            if (_escala == em.D_Major)
                                peso_major += pesoNota;
                            else if (_escala == em.D_Minor)
                                peso_minor += pesoNota;
                            else if (_escala == em.D_Dorian)
                                peso_dorian += pesoNota;
                            else if (_escala == em.D_Phrygian)
                                peso_phrygian += pesoNota;
                            else if (_escala == em.D_Lydian)
                                peso_lydian += pesoNota;
                            else if (_escala == em.D_Mixolydian)
                                peso_mixolydian += pesoNota;
                            else if (_escala == em.D_Locrian)
                                peso_locrian += pesoNota;
                        }
                    }
                    break;
                case "E":
                    escala = em.Eescalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = nm.Get(_escala[i]);
                            if (_escala == em.EMajor)
                                peso_major += pesoNota;
                            else if (_escala == em.EMinor)
                                peso_minor += pesoNota;
                            else if (_escala == em.EDorian)
                                peso_dorian += pesoNota;
                            else if (_escala == em.EPhrygian)
                                peso_phrygian += pesoNota;
                            else if (_escala == em.ELydian)
                                peso_lydian += pesoNota;
                            else if (_escala == em.EMixolydian)
                                peso_mixolydian += pesoNota;
                            else if (_escala == em.ELocrian)
                                peso_locrian += pesoNota;
                        }
                    }
                    break;
                case "F":
                    escala = em.Fescalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = nm.Get(_escala[i]);
                            if (_escala == em.FMajor)
                                peso_major += pesoNota;
                            else if (_escala == em.FMinor)
                                peso_minor += pesoNota;
                            else if (_escala == em.FDorian)
                                peso_dorian += pesoNota;
                            else if (_escala == em.FPhrygian)
                                peso_phrygian += pesoNota;
                            else if (_escala == em.FLydian)
                                peso_lydian += pesoNota;
                            else if (_escala == em.FMixolydian)
                                peso_mixolydian += pesoNota;
                            else if (_escala == em.FLocrian)
                                peso_locrian += pesoNota;
                        }
                    }
                    break;
                case "F#":
                    escala = em.F_escalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = nm.Get(_escala[i]);
                            if (_escala == em.F_Major)
                                peso_major += pesoNota;
                            else if (_escala == em.F_Minor)
                                peso_minor += pesoNota;
                            else if (_escala == em.F_Dorian)
                                peso_dorian += pesoNota;
                            else if (_escala == em.F_Phrygian)
                                peso_phrygian += pesoNota;
                            else if (_escala == em.F_Lydian)
                                peso_lydian += pesoNota;
                            else if (_escala == em.F_Mixolydian)
                                peso_mixolydian += pesoNota;
                            else if (_escala == em.F_Locrian)
                                peso_locrian += pesoNota;
                        }
                    }
                    break;
                case "G":
                    escala = em.Gescalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = nm.Get(_escala[i]);
                            if (_escala == em.GMajor)
                                peso_major += pesoNota;
                            else if (_escala == em.GMinor)
                                peso_minor += pesoNota;
                            else if (_escala == em.GDorian)
                                peso_dorian += pesoNota;
                            else if (_escala == em.GPhrygian)
                                peso_phrygian += pesoNota;
                            else if (_escala == em.GLydian)
                                peso_lydian += pesoNota;
                            else if (_escala == em.GMixolydian)
                                peso_mixolydian += pesoNota;
                            else if (_escala == em.GLocrian)
                                peso_locrian += pesoNota;
                        }
                    }
                    break;
                case "G#":
                    escala = em.G_escalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = nm.Get(_escala[i]);
                            if (_escala == em.G_Major)
                                peso_major += pesoNota;
                            else if (_escala == em.G_Minor)
                                peso_minor += pesoNota;
                            else if (_escala == em.G_Dorian)
                                peso_dorian += pesoNota;
                            else if (_escala == em.G_Phrygian)
                                peso_phrygian += pesoNota;
                            else if (_escala == em.G_Lydian)
                                peso_lydian += pesoNota;
                            else if (_escala == em.G_Mixolydian)
                                peso_mixolydian += pesoNota;
                            else if (_escala == em.G_Locrian)
                                peso_locrian += pesoNota;
                        }
                    }
                    break;
                case "A":
                    escala = em.Aescalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = nm.Get(_escala[i]);
                            if (_escala == em.AMajor)
                                peso_major += pesoNota;
                            else if (_escala == em.AMinor)
                                peso_minor += pesoNota;
                            else if (_escala == em.ADorian)
                                peso_dorian += pesoNota;
                            else if (_escala == em.APhrygian)
                                peso_phrygian += pesoNota;
                            else if (_escala == em.ALydian)
                                peso_lydian += pesoNota;
                            else if (_escala == em.AMixolydian)
                                peso_mixolydian += pesoNota;
                            else if (_escala == em.ALocrian)
                                peso_locrian += pesoNota;
                        }
                    }
                    break;
                case "A#":
                    escala = em.A_escalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = nm.Get(_escala[i]);
                            if (_escala == em.A_Major)
                                peso_major += pesoNota;
                            else if (_escala == em.A_Minor)
                                peso_minor += pesoNota;
                            else if (_escala == em.A_Dorian)
                                peso_dorian += pesoNota;
                            else if (_escala == em.A_Phrygian)
                                peso_phrygian += pesoNota;
                            else if (_escala == em.A_Lydian)
                                peso_lydian += pesoNota;
                            else if (_escala == em.A_Mixolydian)
                                peso_mixolydian += pesoNota;
                            else if (_escala == em.A_Locrian)
                                peso_locrian += pesoNota;
                        }
                    }
                    break;
                case "B":
                    escala = em.Bescalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = nm.Get(_escala[i]);
                            if (_escala == em.BMajor)
                                peso_major += pesoNota;
                            else if (_escala == em.BMinor)
                                peso_minor += pesoNota;
                            else if (_escala == em.BDorian)
                                peso_dorian += pesoNota;
                            else if (_escala == em.BPhrygian)
                                peso_phrygian += pesoNota;
                            else if (_escala == em.BLydian)
                                peso_lydian += pesoNota;
                            else if (_escala == em.BMixolydian)
                                peso_mixolydian += pesoNota;
                            else if (_escala == em.BLocrian)
                                peso_locrian += pesoNota;
                        }
                    }
                    break;
            }
            pesos[0] = peso_major;
            pesos[1] = peso_minor;
            pesos[2] = peso_dorian;
            pesos[3] = peso_phrygian;
            pesos[4] = peso_lydian;
            pesos[5] = peso_mixolydian;
            pesos[6] = peso_locrian;

            int aux = pesos[0];
            int point = 0;
            for (int i = 1; i < pesos.Length; i++)
            {
                if (pesos[i] > aux)
                {
                    aux = pesos[i];
                    point = i;
                }
            }

            int fundamental = nm.GetNota(notaDominante);
            int ajusteAfinacion = comboBox.SelectedIndex + 1;
            Console.WriteLine(comboBox.SelectedIndex);
            fundamental = (fundamental + ajusteAfinacion) <= 12 ? (fundamental + ajusteAfinacion) : (fundamental + ajusteAfinacion) - 12;

            notaDominante = nm.GetNota(fundamental);

            string modo = null;
            if (point == 0)
                modo = "Major";
            else if (point == 1)
                modo = "Minor";
            else if (point == 2)
                modo = "Dorian";
            else if (point == 3)
                modo = "Phrygian";
            else if (point == 4)
                modo = "Lydian";
            else if (point == 5)
                modo = "Mixolydian";
            else if (point == 6)
                modo = "Locrian";

            return em.GetEscalaMusical(notaDominante, modo);


        }

        public Complex[] GetFrame(Complex[] signal, int from, int to)
        {
            Complex[] frame = new Complex[to - from];
            for (int i = 0, j = from; i < frame.Length && j < to; i++, j++)
            {
                frame[i] = signal[j];
            }
            return frame;
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

        public double GetPicks(Complex[] signal)
        {
            Frecuencias[] frqs = new Frecuencias[signal.Length / 2];
            for (int i = 0; i < signal.Length / 2; i++)
            {
                frqs[i] = new Frecuencias { Freqbin = i, Amplitude = signal[i].Magnitude };
            }
            var _f = frqs.OrderByDescending(amp => amp.Amplitude);
            int j = 0;
            foreach (Frecuencias f in _f)
            {
                if (j == 1)
                {
                    return Math.Round((double)f.Freqbin * Fs / FrameSize, 2, MidpointRounding.AwayFromZero);
                }
                j++;
            }
            return 0;
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
                    double exp = -2 * k * Math.PI / N;
                    Complex even = Feven[k];
                    Complex odd = new Complex(Math.Cos(exp), Math.Sin(exp));
                    odd *= Fodd[k];
                    freqbins[k] = even + odd;
                    freqbins[k + N / 2] = even - odd;
                }
                return freqbins;
            }
        }
    }
}
