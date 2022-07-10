using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMI_Project
{
    public class ScaleGenerator
    {

        /*
         * Escalas musicales existentes:
         *      C   Major -- A  minor
         *      C#  Major -- A# minor
         *      D   Major -- B  minor
         *      D#  Major -- C  minor
         *      E   Major -- C# minor
         *      F   Major -- D  minor
         *      F#  Major -- D# minor
         *      G   Major -- E  minor
         *      G#  Major -- F  minor
         *      A   Major -- F# minor
         *      A#  Major -- G  minor
         *      B   Major -- G# minor
         */

        int notaDominante;
        int notaAnterior;
        int _tercera;
        int _quinta;
        readonly NotasMusicales nm;

        int dominante, segunda, tercera, cuarta, quinta, sexta, septima;

        public ScaleGenerator(NotasMusicales nm)
        {
            this.nm = nm;
            notaDominante = nm.getNotaDominante();
            notaAnterior = getNotaAnterior();
            _tercera = getTercera();
            _quinta = getQuinta();

            int average = (nm.get("C") + nm.get("C#") + nm.get("D") + nm.get("D#") + nm.get("E")
                + nm.get("F") + nm.get("F#") + nm.get("G") + nm.get("G#") + nm.get("A") + nm.get("A#")
                + nm.get("B")) / 12;

            dominante = notaDominante;
            segunda = getSegunda();
            tercera = _tercera;
            cuarta = getCuarta();
            quinta = _quinta;
            sexta = getSexta();
            septima = notaAnterior;
            
        }

        public ScaleGenerator(string[] escala)
        {
            nm = new NotasMusicales();
            dominante = nm.getNota(escala[0]);
            segunda = nm.getNota(escala[1]);
            tercera = nm.getNota(escala[2]);
            cuarta = nm.getNota(escala[3]);
            quinta = nm.getNota(escala[4]);
            sexta = nm.getNota(escala[5]);
            septima = nm.getNota(escala[6]);

        }
        
        public void print()
        {
            string escala = nm.getNota(dominante) + " - " + nm.getNota(segunda) + " - " + nm.getNota(tercera) + " - "
                + nm.getNota(cuarta) + " - " + nm.getNota(quinta) + " - " + nm.getNota(sexta) + " - " + nm.getNota(septima);
            Console.WriteLine(escala);
        }
        public void print2()
        {
            string escala = nm.get(dominante) + " - " + nm.get(segunda) + " - " + nm.get(tercera) + " - "
                + nm.get(cuarta) + " - " + nm.get(quinta) + " - " + nm.get(sexta) + " - " + nm.get(septima);
            Console.WriteLine(escala);
        }
        public string[] getMusicalScale()
        {
            string[] musicalScale = new string[7];
            musicalScale[0] = nm.getNota(dominante);
            musicalScale[1] = nm.getNota(segunda);
            musicalScale[2] = nm.getNota(tercera);
            musicalScale[3] = nm.getNota(cuarta);
            musicalScale[4] = nm.getNota(quinta);
            musicalScale[5] = nm.getNota(sexta);
            musicalScale[6] = nm.getNota(septima);

            return musicalScale;
        }
        public void printScaleImage(string[] scale, PictureBox pictureBox, string Instrumento, Label nombreEscala)
        {
            EscalasMusicales escalasMusicales = new EscalasMusicales();
            Instrumento = Instrumento.Equals("Guitarra") ? "GuitarScales" : "PianoScales";
            for (int i = 0; i < scale.Length; i++)
            {
                Console.WriteLine(scale[i]);
            }

            //if (scale == escalasMusicales.CMajor)
            if (scale.SequenceEqual(escalasMusicales.CMajor))
            {
                Console.WriteLine("C Major");
                nombreEscala.Text = "C Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/C/C-Ionian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.CMinor))
            {
                Console.WriteLine("C Minor");
                nombreEscala.Text = "C Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/C/C-Aeolian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.CDorian))
            {
                Console.WriteLine("C Dorian");
                nombreEscala.Text = "C Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/C/C-Dorian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.CPhrygian))
            {
                Console.WriteLine("C Phrygian");
                nombreEscala.Text = "C Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/C/C-Phrygian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.CLydian))
            {
                Console.WriteLine("C Lydian");
                nombreEscala.Text = "C Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/C/C-Lydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.CMixolydian))
            {
                Console.WriteLine("C Mixolydian");
                nombreEscala.Text = "C Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/C/C-Mixolydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.CLocrian))
            {
                Console.WriteLine("C Locrian");
                nombreEscala.Text = "C Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/C/C-Locrian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.C_Major))
            {
                Console.WriteLine("C# Major");
                nombreEscala.Text = "C# Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/C#/C-Ionian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.C_Minor))
            {
                Console.WriteLine("C# Minor");
                nombreEscala.Text = "C# Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/C#/C#-Aeolian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.C_Dorian))
            {
                Console.WriteLine("C# Dorian");
                nombreEscala.Text = "C# Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/C#/C#-Dorian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.C_Phrygian))
            {
                Console.WriteLine("C# Phrygian");
                nombreEscala.Text = "C# Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/C#/C#-Phrygian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.C_Lydian))
            {
                Console.WriteLine("C# Lydian");
                nombreEscala.Text = "C# Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/C#/C#-Lydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.C_Mixolydian))
            {
                Console.WriteLine("C# Mixolydian");
                nombreEscala.Text = "C# Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/C#/C#-Mixolydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.C_Locrian))
            {
                Console.WriteLine("C# Locrian");
                nombreEscala.Text = "C# Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/C#/C#-Locrian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.DMajor))
            {
                Console.WriteLine("D Major");
                nombreEscala.Text = "D Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/D/D-Ionian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.DMinor))
            {
                Console.WriteLine("D Minor");
                nombreEscala.Text = "D Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/D/D-Aeolian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.DDorian))
            {
                Console.WriteLine("D Dorian");
                nombreEscala.Text = "D Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/D/D-Dorian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.DPhrygian))
            {
                Console.WriteLine("D Phrygian");
                nombreEscala.Text = "D Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/D/D-Phrygian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.DLydian))
            {
                Console.WriteLine("D Lydian");
                nombreEscala.Text = "D Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/D/D-Lydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.DMixolydian))
            {
                Console.WriteLine("D Mixolydian");
                nombreEscala.Text = "D Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/D/D-Mixolydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.DLocrian))
            {
                Console.WriteLine("D Locrian");
                nombreEscala.Text = "D Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/D/D-Locrian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.D_Major))
            {
                Console.WriteLine("D# Major");
                nombreEscala.Text = "D# Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/D#/D-Ionian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.D_Minor))
            {
                Console.WriteLine("D# Minor");
                nombreEscala.Text = "D# Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/D#/D#-Aeolian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.D_Dorian))
            {
                Console.WriteLine("D# Dorian");
                nombreEscala.Text = "D# Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/D#/D#-Dorian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.D_Phrygian))
            {
                Console.WriteLine("D# Phrygian");
                nombreEscala.Text = "D# Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/D#/D#-Phrygian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.D_Lydian))
            {
                Console.WriteLine("D# Lydian");
                nombreEscala.Text = "D# Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/D#/D#-Lydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.D_Mixolydian))
            {
                Console.WriteLine("D# Mixolydian");
                nombreEscala.Text = "D# Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/D#/D#-Mixolydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.D_Locrian))
            {
                Console.WriteLine("D# Locrian");
                nombreEscala.Text = "D# Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/D#/D#-Locrian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.EMajor))
            {
                Console.WriteLine("E Major");
                nombreEscala.Text = "E Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/E/E-Ionian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.EMinor))
            {
                Console.WriteLine("E Minor");
                nombreEscala.Text = "E Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/E/E-Aeolian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.EDorian))
            {
                Console.WriteLine("E Dorian");
                nombreEscala.Text = "E Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/E/E-Dorian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.EPhrygian))
            {
                Console.WriteLine("E Phrygian");
                nombreEscala.Text = "E Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/E/E-Phrygian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.ELydian))
            {
                Console.WriteLine("E Lydian");
                nombreEscala.Text = "E Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/E/E-Lydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.EMixolydian))
            {
                Console.WriteLine("E Mixolydian");
                nombreEscala.Text = "E Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/E/E-Mixolydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.ELocrian))
            {
                Console.WriteLine("E Locrian");
                nombreEscala.Text = "E Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/E/E-Locrian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.FMajor))
            {
                Console.WriteLine("F Major");
                nombreEscala.Text = "F Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/F/F-Ionian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.FMinor))
            {
                Console.WriteLine("F Minor");
                nombreEscala.Text = "F Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/F/F-Aeolian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.FDorian))
            {
                Console.WriteLine("F Dorian");
                nombreEscala.Text = "F Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/F/F-Dorian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.FPhrygian))
            {
                Console.WriteLine("F Phrygian");
                nombreEscala.Text = "F Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/F/F-Phrygian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.FLydian))
            {
                Console.WriteLine("F Lydian");
                nombreEscala.Text = "F Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/F/F-Lydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.FMixolydian))
            {
                Console.WriteLine("F Mixolydian");
                nombreEscala.Text = "F Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/F/F-Mixolydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.FLocrian))
            {
                Console.WriteLine("F Locrian");
                nombreEscala.Text = "F Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/F/F-Locrian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.F_Major))
            {
                Console.WriteLine("F# Major");
                nombreEscala.Text = "F# Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/F#/F-Ionian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.F_Minor))
            {
                Console.WriteLine("F# Minor");
                nombreEscala.Text = "F# Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/F#/F#-Aeolian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.F_Dorian))
            {
                Console.WriteLine("F# Dorian");
                nombreEscala.Text = "F# Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/F#/F#-Dorian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.F_Phrygian))
            {
                Console.WriteLine("F# Phrygian");
                nombreEscala.Text = "F# Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/F#/F#-Phrygian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.F_Lydian))
            {
                Console.WriteLine("F# Lydian");
                nombreEscala.Text = "F# Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/F#/F#-Lydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.F_Mixolydian))
            {
                Console.WriteLine("F# Mixolydian");
                nombreEscala.Text = "F# Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/F#/F#-Mixolydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.F_Locrian))
            {
                Console.WriteLine("F# Locrian");
                nombreEscala.Text = "F# Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/F#/F#-Locrian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.GMajor))
            {
                Console.WriteLine("G Major");
                nombreEscala.Text = "G Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/G/G-Ionian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.GMinor))
            {
                Console.WriteLine("G Minor");
                nombreEscala.Text = "G Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/G/G-Aeolian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.GDorian))
            {
                Console.WriteLine("G Dorian");
                nombreEscala.Text = "G Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/G/G-Dorian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.GPhrygian))
            {
                Console.WriteLine("G Phrygian");
                nombreEscala.Text = "G Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/G/-Phrygian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.GLydian))
            {
                Console.WriteLine("G Lydian");
                nombreEscala.Text = "G Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/G/G-Lydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.GMixolydian))
            {
                Console.WriteLine("G Mixolydian");
                nombreEscala.Text = "G Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/G/G-Mixolydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.GLocrian))
            {
                Console.WriteLine("G Locrian");
                nombreEscala.Text = "G Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/G/G-Locrian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.G_Major))
            {
                Console.WriteLine("G# Major");
                nombreEscala.Text = "G# Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/G#/G-Ionian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.G_Minor))
            {
                Console.WriteLine("G# Minor");
                nombreEscala.Text = "G# Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/G#/G#-Aeolian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.G_Dorian))
            {
                Console.WriteLine("G# Dorian");
                nombreEscala.Text = "G# Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/G#/G#-Dorian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.G_Phrygian))
            {
                Console.WriteLine("G# Phrygian");
                nombreEscala.Text = "G# Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/G#/G#-Phrygian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.G_Lydian))
            {
                Console.WriteLine("G# Lydian");
                nombreEscala.Text = "G# Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/G#/G#-Lydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.G_Mixolydian))
            {
                Console.WriteLine("G# Mixolydian");
                nombreEscala.Text = "G# Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/G#/G#-Mixolydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.G_Locrian))
            {
                Console.WriteLine("G# Locrian");
                nombreEscala.Text = "G# Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/G#/G#-Locrian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.AMajor))
            {
                Console.WriteLine("A Major");
                nombreEscala.Text = "A Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/A/A-Ionian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.AMinor))
            {
                Console.WriteLine("A Minor");
                nombreEscala.Text = "A Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/A/A-Aeolian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.ADorian))
            {
                Console.WriteLine("A Dorian");
                nombreEscala.Text = "A Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/A/A-Dorian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.APhrygian))
            {
                Console.WriteLine("A Phrygian");
                nombreEscala.Text = "A Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/A/A-Phrygian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.ALydian))
            {
                Console.WriteLine("A Lydian");
                nombreEscala.Text = "A Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/A/A-Lydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.AMixolydian))
            {
                Console.WriteLine("A Mixolydian");
                nombreEscala.Text = "A Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/A/A-Mixolydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.ALocrian))
            {
                Console.WriteLine("A Locrian");
                nombreEscala.Text = "A Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/A/A-Locrian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.A_Major))
            {
                Console.WriteLine("A# Major");
                nombreEscala.Text = "A# Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/A#/A-Ionian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.A_Minor))
            {
                Console.WriteLine("A# Minor");
                nombreEscala.Text = "A# Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/A#/A#-Aeolian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.A_Dorian))
            {
                Console.WriteLine("A# Dorian");
                nombreEscala.Text = "A# Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/A#/A#-Dorian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.A_Phrygian))
            {
                Console.WriteLine("A# Phrygian");
                nombreEscala.Text = "A# Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/A#/A#-Phrygian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.A_Lydian))
            {
                Console.WriteLine("A# Lydian");
                nombreEscala.Text = "A# Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/A#/A#-Lydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.A_Mixolydian))
            {
                Console.WriteLine("A# Mixolydian");
                nombreEscala.Text = "A# Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/A#/A#-Mixolydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.A_Locrian))
            {
                Console.WriteLine("A# Locrian");
                nombreEscala.Text = "A# Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/A#/A#-Locrian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.BMajor))
            {
                Console.WriteLine("B Major");
                nombreEscala.Text = "B Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/B/B-Ionian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.BMinor))
            {
                Console.WriteLine("B Minor");
                nombreEscala.Text = "B Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/B/B-Aeolian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.BDorian))
            {
                Console.WriteLine("B Dorian");
                nombreEscala.Text = "B Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/B/B-Dorian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.BPhrygian))
            {
                Console.WriteLine("B Phrygian");
                nombreEscala.Text = "B Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/B/B-Phrygian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.BLydian))
            {
                Console.WriteLine("B Lydian");
                nombreEscala.Text = "B Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/B/B-Lydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.BMixolydian))
            {
                Console.WriteLine("B Mixolydian");
                nombreEscala.Text = "B Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/B/B-Mixolydian.png");
            }
            else if (scale.SequenceEqual(escalasMusicales.BLocrian))
            {
                Console.WriteLine("B Locrian");
                nombreEscala.Text = "B Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + Instrumento + "/B/B-Locrian.png");
            } else {
                Console.WriteLine("Escala musical no encontrada");
            }
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public void analizarEscala()
        {
            string modo = "T T st T T T st"; // por defecto: modo jónico, mayor
            int T = 2; // Tono +2 nc
            int st = 1; // semi-tono +1 nc

            


        }
        public int getSegunda()
        {
            // segunda mayor = 2 nc
            // segunda menor = 1 nc
            int terceraMayor = (notaDominante + 2) <= 12 ? (notaDominante + 2) : (notaDominante + 2) - 12;
            int terceraMenor = (notaDominante + 1) <= 12 ? (notaDominante + 1) : (notaDominante + 1) - 12;

            return nm.get(terceraMayor) > nm.get(terceraMenor) ? terceraMayor : terceraMenor;
        }
        public int getCuarta()
        {
            // cuarta justa = 5 nc
            // cuarta aumentada = 6 nc
            int cuartaJusta = (notaDominante + 5) <= 12 ? (notaDominante + 5) : (notaDominante + 5) - 12;
            int cuartaAumentada = (notaDominante + 6) <= 12 ? (notaDominante + 6) : (notaDominante + 6) - 12;

            return nm.get(cuartaJusta) > nm.get(cuartaAumentada) ? cuartaJusta : cuartaAumentada;
        }
        public int getSexta()
        {
            // sexta mayor = 9 nc
            // sexta menor = 8 nc
            int sextaMayor = (notaDominante + 9) <= 12 ? (notaDominante + 9) : (notaDominante + 9) - 12;
            int sextaMenor = (notaDominante + 8) <= 12 ? (notaDominante + 8) : (notaDominante + 8) - 12;

            return nm.get(sextaMenor) > nm.get(sextaMayor) ? sextaMenor : sextaMayor;
        }
        public int getNotaAnterior() // séptima
        {
            // nota anterior menor = -2 nc
            // nota anterior Mayor = -1 nc

            int naMenor = (notaDominante - 2) >= 1 ? (notaDominante - 2) : (notaDominante - 2) + 12;
            int naMayor = (notaDominante - 1) >= 1 ? (notaDominante - 1) : (notaDominante - 1) + 12;

            return nm.get(naMenor) > nm.get(naMayor) ? naMenor : naMayor;

        }
        public int getTercera()
        {
            // tercera menor = 3 nc
            // tercera Mayor = 4 nc

            int terceraMenor = (notaDominante + 3) <= 12 ? (notaDominante + 3) : (notaDominante + 3) - 12;
            int terceraMayor = (notaDominante + 4) <= 12 ? (notaDominante + 3) : (notaDominante + 3) - 12;

            return nm.get(terceraMenor) > nm.get(terceraMayor) ? terceraMenor : terceraMayor;

        }
        public int getQuinta()
        {
            return (notaDominante + 7) <= 12 ? (notaDominante + 7) : (notaDominante + 7) - 12;
        }
    }
}
