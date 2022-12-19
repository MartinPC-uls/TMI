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
        private readonly Audio _audio;
        private readonly int Fs;
        private readonly int FrameSize = 16384; // 2^14
        private string[] Afinacion;
        private string Instrumento;
        private AnalizadorMusical am;

        public static string NOTA = "";
        public static string MODO = "";

        /// <summary>
        /// Constructor de la clase AnalizadorFrecuencias
        /// </summary>
        /// <param name="diagramaInstrumento"></param>
        /// <param name="nombreEscalaLabel"></param>
        /// <param name="afinacionCB"></param>
        /// <param name="instrumentoCB"></param>
        public AnalizadorFrecuencias(ref PictureBox diagramaInstrumento, ref Label nombreEscalaLabel, ref ComboBox afinacionCB, ref ComboBox instrumentoCB)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "temp.wav";
            Instrumento = afinacionCB.Text;

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
        public AnalizadorFrecuencias(string fileName, string[] afinacion, string instrumento)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Project\_" + fileName + ".wav";
            Afinacion = afinacion;
            foreach (var nota in Afinacion)
            {
                Console.WriteLine("af: " + nota);
            }
            Instrumento = instrumento;
            Audio audio = new Audio(path);
            _audio = audio;
            Fs = audio.SampleRate;
            Complex[] samples = new Complex[audio.RealData.Length];
            for (int i = 0; i < audio.RealData.Length; i++)
            {
                samples[i] = new Complex(audio.RealData[i], 0);
            }
            am = new AnalizadorMusical();
            DeterminarEscala(samples, FrameSize);
        }
        public AnalizadorFrecuencias() {}
        /// <summary>
        /// Determina la escala musical y la muestra en un PictureBox.
        /// </summary>
        /// <param name="s_samples"></param>
        /// <param name="frameSize"></param>
        /// <param name="pictureBox"></param>
        /// <param name="nombreEscalaLabel"></param>
        /// <param name="comboBox"></param>
        public void DeterminarEscala(Complex[] s_samples, int frameSize)
        {
            //NotasMusicales nm = new NotasMusicales();
            int nFrame = 1;
            for (int i = 0; i < s_samples.Length; i += frameSize)
            {

                if (i + frameSize > s_samples.Length)
                {
                    GetMusicalScale(am);
                    return;
                }
                Complex[] frame = GetFrame(s_samples, i, i + frameSize);
                GaussianWindow(ref frame);
                Complex[] fft_values = FFT(frame);
                am.ObtenerNotasMusicales(fft_values);
                nFrame++;
                i -= frameSize / 2;
            }
            GetMusicalScale(am);
        }
        /// <summary>
        /// Obtiene la escala musical basado en las notas musicales encontradas.
        /// </summary>
        /// <param name="am"></param>
        /// <param name="pictureBox"></param>
        /// <param name="nombreEscalaMusical"></param>
        /// <param name="comboBox"></param>
        public void GetMusicalScale(AnalizadorMusical am)
        {
            // TODO
            string notaDominante = am.GetDominantNote();

            string[] musicalScale = CalcularEscala(notaDominante, am);
            string musicalScaleName = NOTA + " " + MODO;

            //sg.MostrarEscalaMusical(musicalScale, Instrumento);
            if (Instrumento == "Piano")
            {
                new Piano(musicalScale).ShowDialog();
                return;
            }
            new MostradorEscalaMusical(musicalScale, Afinacion, musicalScaleName).ShowDialog(); // TODO
        }
        /// <summary>
        /// Calcula la escala musical para determinar cuál es la más adecuada.
        /// </summary>
        /// <param name="notaDominante"></param>
        /// <param name="am"></param>
        /// <param name="comboBox"></param>
        /// <returns></returns>
        public string[] CalcularEscala(string notaDominante, AnalizadorMusical am)
        {
            EscalasMusicales em = new EscalasMusicales();
            List<string[]> escala;
            double[] pesos = new double[9];
            double peso_major = 0;
            double peso_minor = 0;
            double peso_dorian = 0;
            double peso_phrygian = 0;
            double peso_lydian = 0;
            double peso_mixolydian = 0;
            double peso_locrian = 0;

            double peso_harmonicminor = 0;
            double peso_harmonicmajor = 0;

            double pesoNota;

            switch (notaDominante)
            {
                case "C":
                    escala = em.Cescalas;
                    NOTA = "C";
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = am.GetMagnitude(_escala[i]);
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
                            else if (_escala == em.CHarmonicMinor)
                                peso_harmonicminor += pesoNota;
                            else if (_escala == em.CHarmonicMajor)
                                peso_harmonicmajor += pesoNota;
                        }
                    }
                    break;
                case "C#":
                    escala = em.C_escalas;
                    NOTA = "C#";
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = am.GetMagnitude(_escala[i]);
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
                            else if (_escala == em.C_HarmonicMinor)
                                peso_harmonicminor += pesoNota;
                            else if (_escala == em.C_HarmonicMajor)
                                peso_harmonicmajor += pesoNota;
                        }
                    }
                    break;
                case "D":
                    escala = em.Descalas;
                    NOTA = "D";
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = am.GetMagnitude(_escala[i]);
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
                            else if (_escala == em.DHarmonicMinor)
                                peso_harmonicminor += pesoNota;
                            else if (_escala == em.DHarmonicMajor)
                                peso_harmonicmajor += pesoNota;
                        }
                    }
                    break;
                case "D#":
                    NOTA = "D#";
                    escala = em.D_escalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = am.GetMagnitude(_escala[i]);
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
                            else if (_escala == em.D_HarmonicMinor)
                                peso_harmonicminor += pesoNota;
                            else if (_escala == em.D_HarmonicMajor)
                                peso_harmonicmajor += pesoNota;
                        }
                    }
                    break;
                case "E":
                    NOTA = "E";
                    escala = em.Eescalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = am.GetMagnitude(_escala[i]);
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
                            else if (_escala == em.EHarmonicMinor)
                                peso_harmonicminor += pesoNota;
                            else if (_escala == em.EHarmonicMajor)
                                peso_harmonicmajor += pesoNota;
                        }
                    }
                    break;
                case "F":
                    NOTA = "F";
                    escala = em.Fescalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = am.GetMagnitude(_escala[i]);
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
                            else if (_escala == em.FHarmonicMinor)
                                peso_harmonicminor += pesoNota;
                            else if (_escala == em.FHarmonicMajor)
                                peso_harmonicmajor += pesoNota;
                        }
                    }
                    break;
                case "F#":
                    NOTA = "F#";
                    escala = em.F_escalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = am.GetMagnitude(_escala[i]);
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
                            else if (_escala == em.F_HarmonicMinor)
                                peso_harmonicminor += pesoNota;
                            else if (_escala == em.F_HarmonicMajor)
                                peso_harmonicmajor += pesoNota;
                        }
                    }
                    break;
                case "G":
                    NOTA = "G";
                    escala = em.Gescalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = am.GetMagnitude(_escala[i]);
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
                            else if (_escala == em.GHarmonicMinor)
                                peso_harmonicminor += pesoNota;
                            else if (_escala == em.GHarmonicMajor)
                                peso_harmonicmajor += pesoNota;
                        }
                    }
                    break;
                case "G#":
                    NOTA = "G#";
                    escala = em.G_escalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = am.GetMagnitude(_escala[i]);
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
                            else if (_escala == em.G_HarmonicMinor)
                                peso_harmonicminor += pesoNota;
                            else if (_escala == em.G_HarmonicMajor)
                                peso_harmonicmajor += pesoNota;
                        }
                    }
                    break;
                case "A":
                    NOTA = "A";
                    escala = em.Aescalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = am.GetMagnitude(_escala[i]);
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
                            else if (_escala == em.AHarmonicMinor)
                                peso_harmonicminor += pesoNota;
                            else if (_escala == em.AHarmonicMajor)
                                peso_harmonicmajor += pesoNota;
                        }
                    }
                    break;
                case "A#":
                    NOTA = "A#";
                    escala = em.A_escalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = am.GetMagnitude(_escala[i]);
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
                            else if (_escala == em.A_HarmonicMinor)
                                peso_harmonicminor += pesoNota;
                            else if (_escala == em.A_HarmonicMajor)
                                peso_harmonicmajor += pesoNota;
                        }
                    }
                    break;
                case "B":
                    NOTA = "B";
                    escala = em.Bescalas;
                    foreach (string[] _escala in escala)
                    {
                        for (int i = 0; i < _escala.Length; i++)
                        {
                            pesoNota = am.GetMagnitude(_escala[i]);
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
                            else if (_escala == em.BHarmonicMinor)
                                peso_harmonicminor += pesoNota;
                            else if (_escala == em.BHarmonicMajor)
                                peso_harmonicmajor += pesoNota;
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

            pesos[7] = peso_harmonicminor;
            pesos[8] = peso_harmonicmajor;


            double aux = pesos[0];
            int point = 0;
            for (int i = 1; i < pesos.Length; i++)
            {
                if (pesos[i] > aux)
                {
                    aux = pesos[i];
                    point = i;
                }
            }
            // get the second best peso
            double aux2 = 0;
            int point2 = 0;
            for (int i = 0; i < pesos.Length; i++)
            {
                if (pesos[i] > aux2 && pesos[i] < aux)
                {
                    aux2 = pesos[i];
                    point2 = i;
                }
            }

            int fundamental = am.GetNote(notaDominante);

            notaDominante = am.GetNote(fundamental);

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
            else if (point == 7)
                modo = "HarmonicMinor";
            else if (point == 8)
                modo = "HarmonicMajor";

            string modo2 = null;
            if (point2 == 0)
                modo2 = "Major";
            else if (point2 == 1)
                modo2 = "Minor";
            else if (point2 == 2)
                modo2 = "Dorian";
            else if (point2 == 3)
                modo2 = "Phrygian";
            else if (point2 == 4)
                modo2 = "Lydian";
            else if (point2 == 5)
                modo2 = "Mixolydian";
            else if (point2 == 6)
                modo2 = "Locrian";
            else if (point2 == 7)
                modo2 = "HarmonicMinor";
            else if (point2 == 8)
                modo2 = "HarmonicMajor";

            Console.WriteLine("First best scale: " + notaDominante + " " + modo);

            MODO = modo;
            return em.GetEscalaMusical(notaDominante, modo);
        }

        /// <summary>
        /// Obtiene un Frame de la señal de audio, desde un punto a otro
        /// </summary>
        /// <param name="signal"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public Complex[] GetFrame(Complex[] signal, int from, int to)
        {
            Complex[] frame = new Complex[to - from];
            for (int i = 0, j = from; i < frame.Length && j < to; i++, j++)
            {
                frame[i] = signal[j];
            }
            /*Complex[] e_frame = new Complex[22050];
            for (int i = 0; i < e_frame.Length; i++)
            {
                if (i < frame.Length)
                    e_frame[i] = frame[i];
                else
                    e_frame[i] = new Complex(0, 0);
            }
            //Console.WriteLine("FrameSize: " + e_frame.Length);
            return e_frame;*/
            return frame;
        }
        /// <summary>
        /// Aplica la función de Hann Window a una determinada señal de audio
        /// </summary>
        /// <param name="data"></param>
        public void HannWindow(ref Complex[] data)
        {
            double aux;
            for (int i = 0; i < data.Length; i++)
            {
                aux = 0.5 * (1 - Math.Cos((2 * Math.PI * i) / (data.Length - 1)));
                data[i] *= new Complex(aux, 0);
            }
        }
        public void GaussianWindow(ref Complex[] data)
        {
            double aux;
            for (int i = 0; i < data.Length; i++)
            {
                aux = Math.Exp(-0.5 * Math.Pow(((i - (data.Length - 1) / 2) / ((0.4 * (data.Length - 1)) / 2)), 2));
                data[i] *= new Complex(aux, 0);
            }
        }
        public void HammingWindow(ref Complex[] data)
        {
            double aux;
            for (int i = 0; i < data.Length; i++)
            {
                aux = 0.54 - (0.46 * Math.Cos((2 * Math.PI * i) / (data.Length - 1)));
                data[i] *= new Complex(aux, 0);
            }
        }
        /// <summary>
        /// Obtiene el pick más alto de la señal
        /// </summary>
        /// <param name="signal"></param>
        /// <returns></returns>
        public double GetPick(Complex[] signal)
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
        public double GetPick(Complex[] signal, int Fs, int FrameSize)
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
                /* ANTES:
                if (j == 1)
                {
                    return Math.Round((double)f.Freqbin * Fs / FrameSize, 2, MidpointRounding.AwayFromZero);
                }*/
                if (j == 0)
                {
                    return Math.Round((double)f.Freqbin * Fs / FrameSize, 2, MidpointRounding.AwayFromZero);
                }
                j++;
            }
            return 0;
        }
        /*public double GetPick(Complex[] signal, int frameSize, int fs)
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
                    return Math.Round((double)f.Freqbin * (fs/2) / frameSize, 2, MidpointRounding.AwayFromZero);
                }
                j++;
            }
            return 0;
        }*/

        /// <summary>
        /// Realiza la Transformada Rápida de Fourier a la señal de audio dada
        /// </summary>
        /// <param name="samples"></param>
        /// <returns></returns>
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
