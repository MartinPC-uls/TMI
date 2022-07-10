using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TMI_Project
{
    public class GeneradorEscala
    {

        private readonly int NotaDominante;
        private readonly NotasMusicales nm;

        public GeneradorEscala(NotasMusicales nm)
        {
            this.nm = nm;
            NotaDominante = nm.GetNotaDominante();
        }

        public GeneradorEscala()
        {
            nm = new NotasMusicales();
        }
        public void MostrarEscalaMusical(string[] escala, PictureBox pictureBox, string instrumento, Label nombreEscala)
        {
            EscalasMusicales escalasMusicales = new EscalasMusicales();
            instrumento = instrumento.Equals("Guitarra") ? "GuitarScales" : "PianoScales";
            if (escala.SequenceEqual(escalasMusicales.CMajor))
            {
                nombreEscala.Text = "C Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C/C-Ionian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.CMinor))
            {
                nombreEscala.Text = "C Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C/C-Aeolian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.CDorian))
            {
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C/C-Dorian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.CPhrygian))
            {
                nombreEscala.Text = "C Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C/C-Phrygian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.CLydian))
            {
                nombreEscala.Text = "C Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C/C-Lydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.CMixolydian))
            {
                nombreEscala.Text = "C Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C/C-Mixolydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.CLocrian))
            {
                nombreEscala.Text = "C Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C/C-Locrian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.C_Major))
            {
                nombreEscala.Text = "C# Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C#/Csharp-Ionian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.C_Minor))
            {
                nombreEscala.Text = "C# Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C#/Csharp-Aeolian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.C_Dorian))
            {
                nombreEscala.Text = "C# Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C#/Csharp-Dorian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.C_Phrygian))
            {
                nombreEscala.Text = "C# Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C#/Csharp-Phrygian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.C_Lydian))
            {
                nombreEscala.Text = "C# Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C#/Csharp-Lydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.C_Mixolydian))
            {
                nombreEscala.Text = "C# Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C#/Csharp-Mixolydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.C_Locrian))
            {
                nombreEscala.Text = "C# Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C#/Csharp-Locrian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.DMajor))
            {
                nombreEscala.Text = "D Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D/D-Ionian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.DMinor))
            {
                nombreEscala.Text = "D Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D/D-Aeolian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.DDorian))
            {
                nombreEscala.Text = "D Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D/D-Dorian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.DPhrygian))
            {
                nombreEscala.Text = "D Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D/D-Phrygian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.DLydian))
            {
                nombreEscala.Text = "D Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D/D-Lydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.DMixolydian))
            {
                nombreEscala.Text = "D Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D/D-Mixolydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.DLocrian))
            {
                nombreEscala.Text = "D Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D/D-Locrian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.D_Major))
            {
                nombreEscala.Text = "D# Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D#/Dsharp-Ionian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.D_Minor))
            {
                nombreEscala.Text = "D# Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D#/Dsharp-Aeolian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.D_Dorian))
            {
                nombreEscala.Text = "D# Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D#/Dsharp-Dorian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.D_Phrygian))
            {
                nombreEscala.Text = "D# Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D#/Dsharp-Phrygian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.D_Lydian))
            {
                nombreEscala.Text = "D# Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D#/Dsharp-Lydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.D_Mixolydian))
            {
                nombreEscala.Text = "D# Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D#/Dsharp-Mixolydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.D_Locrian))
            {
                nombreEscala.Text = "D# Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D#/Dsharp-Locrian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.EMajor))
            {
                nombreEscala.Text = "E Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/E/E-Ionian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.EMinor))
            {
                nombreEscala.Text = "E Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/E/E-Aeolian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.EDorian))
            {
                nombreEscala.Text = "E Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/E/E-Dorian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.EPhrygian))
            {
                nombreEscala.Text = "E Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/E/E-Phrygian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.ELydian))
            {
                nombreEscala.Text = "E Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/E/E-Lydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.EMixolydian))
            {
                nombreEscala.Text = "E Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/E/E-Mixolydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.ELocrian))
            {
                nombreEscala.Text = "E Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/E/E-Locrian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.FMajor))
            {
                nombreEscala.Text = "F Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F/F-Ionian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.FMinor))
            {
                nombreEscala.Text = "F Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F/F-Aeolian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.FDorian))
            {
                nombreEscala.Text = "F Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F/F-Dorian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.FPhrygian))
            {
                nombreEscala.Text = "F Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F/F-Phrygian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.FLydian))
            {
                nombreEscala.Text = "F Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F/F-Lydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.FMixolydian))
            {
                nombreEscala.Text = "F Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F/F-Mixolydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.FLocrian))
            {
                nombreEscala.Text = "F Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F/F-Locrian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.F_Major))
            {
                nombreEscala.Text = "F# Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F#/Fsharp-Ionian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.F_Minor))
            {
                nombreEscala.Text = "F# Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F#/Fsharp-Aeolian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.F_Dorian))
            {
                nombreEscala.Text = "F# Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F#/Fsharp-Dorian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.F_Phrygian))
            {
                nombreEscala.Text = "F# Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F#/Fsharp-Phrygian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.F_Lydian))
            {
                nombreEscala.Text = "F# Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F#/Fsharp-Lydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.F_Mixolydian))
            {
                nombreEscala.Text = "F# Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F#/Fsharp-Mixolydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.F_Locrian))
            {
                nombreEscala.Text = "F# Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F#/Fsharp-Locrian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.GMajor))
            {
                nombreEscala.Text = "G Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G/G-Ionian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.GMinor))
            {
                nombreEscala.Text = "G Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G/G-Aeolian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.GDorian))
            {
                nombreEscala.Text = "G Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G/G-Dorian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.GPhrygian))
            {
                nombreEscala.Text = "G Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G/-Phrygian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.GLydian))
            {
                nombreEscala.Text = "G Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G/G-Lydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.GMixolydian))
            {
                nombreEscala.Text = "G Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G/G-Mixolydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.GLocrian))
            {
                nombreEscala.Text = "G Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G/G-Locrian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.G_Major))
            {
                nombreEscala.Text = "G# Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G#/Gsharp-Ionian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.G_Minor))
            {
                nombreEscala.Text = "G# Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G#/Gsharp-Aeolian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.G_Dorian))
            {
                nombreEscala.Text = "G# Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G#/Gsharp-Dorian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.G_Phrygian))
            {
                nombreEscala.Text = "G# Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G#/Gsharp-Phrygian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.G_Lydian))
            {
                nombreEscala.Text = "G# Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G#/Gsharp-Lydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.G_Mixolydian))
            {
                nombreEscala.Text = "G# Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G#/Gsharp-Mixolydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.G_Locrian))
            {
                nombreEscala.Text = "G# Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G#/Gsharp-Locrian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.AMajor))
            {
                nombreEscala.Text = "A Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A/A-Ionian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.AMinor))
            {
                nombreEscala.Text = "A Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A/A-Aeolian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.ADorian))
            {
                nombreEscala.Text = "A Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A/A-Dorian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.APhrygian))
            {
                nombreEscala.Text = "A Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A/A-Phrygian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.ALydian))
            {
                nombreEscala.Text = "A Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A/A-Lydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.AMixolydian))
            {
                nombreEscala.Text = "A Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A/A-Mixolydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.ALocrian))
            {
                nombreEscala.Text = "A Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A/A-Locrian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.A_Major))
            {
                nombreEscala.Text = "A# Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A#/Asharp-Ionian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.A_Minor))
            {
                nombreEscala.Text = "A# Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A#/Asharp-Aeolian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.A_Dorian))
            {
                nombreEscala.Text = "A# Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A#/Asharp-Dorian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.A_Phrygian))
            {
                nombreEscala.Text = "A# Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A#/Asharp-Phrygian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.A_Lydian))
            {
                nombreEscala.Text = "A# Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A#/Asharp-Lydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.A_Mixolydian))
            {
                nombreEscala.Text = "A# Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A#/Asharp-Mixolydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.A_Locrian))
            {
                nombreEscala.Text = "A# Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A#/Asharp-Locrian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.BMajor))
            {
                nombreEscala.Text = "B Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/B/B-Ionian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.BMinor))
            {
                nombreEscala.Text = "B Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/B/B-Aeolian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.BDorian))
            {
                nombreEscala.Text = "B Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/B/B-Dorian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.BPhrygian))
            {
                nombreEscala.Text = "B Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/B/B-Phrygian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.BLydian))
            {
                nombreEscala.Text = "B Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/B/B-Lydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.BMixolydian))
            {
                nombreEscala.Text = "B Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/B/B-Mixolydian.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.BLocrian))
            {
                nombreEscala.Text = "B Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/B/B-Locrian.png");
            } else {
                Console.WriteLine("Escala musical no encontrada");
            }
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public int GetSegunda()
        {
            // segunda mayor = 2 nc
            // segunda menor = 1 nc
            int terceraMayor = (NotaDominante + 2) <= 12 ? (NotaDominante + 2) : (NotaDominante + 2) - 12;
            int terceraMenor = (NotaDominante + 1) <= 12 ? (NotaDominante + 1) : (NotaDominante + 1) - 12;

            return nm.Get(terceraMayor) > nm.Get(terceraMenor) ? terceraMayor : terceraMenor;
        }
        public int GetCuarta()
        {
            // cuarta justa = 5 nc
            // cuarta aumentada = 6 nc
            int cuartaJusta = (NotaDominante + 5) <= 12 ? (NotaDominante + 5) : (NotaDominante + 5) - 12;
            int cuartaAumentada = (NotaDominante + 6) <= 12 ? (NotaDominante + 6) : (NotaDominante + 6) - 12;

            return nm.Get(cuartaJusta) > nm.Get(cuartaAumentada) ? cuartaJusta : cuartaAumentada;
        }
        public int GetSexta()
        {
            // sexta mayor = 9 nc
            // sexta menor = 8 nc
            int sextaMayor = (NotaDominante + 9) <= 12 ? (NotaDominante + 9) : (NotaDominante + 9) - 12;
            int sextaMenor = (NotaDominante + 8) <= 12 ? (NotaDominante + 8) : (NotaDominante + 8) - 12;

            return nm.Get(sextaMenor) > nm.Get(sextaMayor) ? sextaMenor : sextaMayor;
        }
        public int GetSeptima() // séptima
        {
            // nota anterior menor = -2 nc
            // nota anterior Mayor = -1 nc

            int naMenor = (NotaDominante - 2) >= 1 ? (NotaDominante - 2) : (NotaDominante - 2) + 12;
            int naMayor = (NotaDominante - 1) >= 1 ? (NotaDominante - 1) : (NotaDominante - 1) + 12;

            return nm.Get(naMenor) > nm.Get(naMayor) ? naMenor : naMayor;

        }
        public int GetTercera()
        {
            // tercera menor = 3 nc
            // tercera Mayor = 4 nc

            int terceraMenor = (NotaDominante + 3) <= 12 ? (NotaDominante + 3) : (NotaDominante + 3) - 12;
            int terceraMayor = (NotaDominante + 4) <= 12 ? (NotaDominante + 3) : (NotaDominante + 3) - 12;

            return nm.Get(terceraMenor) > nm.Get(terceraMayor) ? terceraMenor : terceraMayor;

        }
        public int GetQuinta()
        {
            return (NotaDominante + 7) <= 12 ? (NotaDominante + 7) : (NotaDominante + 7) - 12;
        }
    }
}
