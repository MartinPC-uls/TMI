using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TMI_Project
{
    public class GeneradorEscala
    {
        /// <summary>
        /// Muestra la escala musical en un PictureBox
        /// </summary>
        /// <param name="escala"></param>
        /// <param name="pictureBox"></param>
        /// <param name="instrumento"></param>
        /// <param name="nombreEscala"></param>
        public void MostrarEscalaMusical(string[] escala, PictureBox pictureBox, string instrumento, Label nombreEscala)
        {
            EscalasMusicales escalasMusicales = new EscalasMusicales();
            instrumento = instrumento.Equals("Guitarra") ? "GuitarScales" : "PianoScales";

            //GC.Collect();

            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            // add return for all if statements
            if (escala == null)
            {
                nombreEscala.Text = "No se determinó ninguna escala";
                Console.WriteLine("Escala no determinada.");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.CMajor))
            {
                nombreEscala.Text = "C Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C/C-Ionian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.CMinor))
            {
                nombreEscala.Text = "C Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C/C-Aeolian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.CDorian))
            {
                nombreEscala.Text = "C Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C/C-Dorian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.CPhrygian))
            {
                nombreEscala.Text = "C Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C/C-Phrygian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.CLydian))
            {
                nombreEscala.Text = "C Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C/C-Lydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.CMixolydian))
            {
                nombreEscala.Text = "C Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C/C-Mixolydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.CLocrian))
            {
                nombreEscala.Text = "C Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C/C-Locrian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.CHarmonicMinor))
            {
                nombreEscala.Text = "C Harmonic Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C/C-HarmonicMinor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.CHarmonicMajor))
            {
                nombreEscala.Text = "C Harmonic Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C/C-HarmonicMajor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.C_Major))
            {
                nombreEscala.Text = "C# Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C#/Csharp-Ionian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.C_Minor))
            {
                nombreEscala.Text = "C# Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C#/Csharp-Aeolian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.C_Dorian))
            {
                nombreEscala.Text = "C# Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C#/Csharp-Dorian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.C_Phrygian))
            {
                nombreEscala.Text = "C# Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C#/Csharp-Phrygian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.C_Lydian))
            {
                nombreEscala.Text = "C# Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C#/Csharp-Lydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.C_Mixolydian))
            {
                nombreEscala.Text = "C# Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C#/Csharp-Mixolydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.C_Locrian))
            {
                nombreEscala.Text = "C# Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C#/Csharp-Locrian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.C_HarmonicMinor))
            {
                nombreEscala.Text = "C# Harmonic Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C#/Csharp-HarmonicMinor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.C_HarmonicMajor))
            {
                nombreEscala.Text = "C# Harmonic Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/C#/Csharp-HarmonicMajor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.DMajor))
            {
                nombreEscala.Text = "D Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D/D-Ionian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.DMinor))
            {
                nombreEscala.Text = "D Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D/D-Aeolian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.DDorian))
            {
                nombreEscala.Text = "D Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D/D-Dorian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.DPhrygian))
            {
                nombreEscala.Text = "D Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D/D-Phrygian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.DLydian))
            {
                nombreEscala.Text = "D Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D/D-Lydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.DMixolydian))
            {
                nombreEscala.Text = "D Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D/D-Mixolydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.DLocrian))
            {
                nombreEscala.Text = "D Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D/D-Locrian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.DHarmonicMinor))
            {
                nombreEscala.Text = "D Harmonic Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D/D-HarmonicMinor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.DHarmonicMajor))
            {
                nombreEscala.Text = "D Harmonic Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D/D-HarmonicMajor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.D_Major))
            {
                nombreEscala.Text = "D# Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D#/Dsharp-Ionian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.D_Minor))
            {
                nombreEscala.Text = "D# Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D#/Dsharp-Aeolian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.D_Dorian))
            {
                nombreEscala.Text = "D# Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D#/Dsharp-Dorian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.D_Phrygian))
            {
                nombreEscala.Text = "D# Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D#/Dsharp-Phrygian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.D_Lydian))
            {
                nombreEscala.Text = "D# Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D#/Dsharp-Lydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.D_Mixolydian))
            {
                nombreEscala.Text = "D# Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D#/Dsharp-Mixolydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.D_Locrian))
            {
                nombreEscala.Text = "D# Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D#/Dsharp-Locrian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.D_HarmonicMinor))
            {
                nombreEscala.Text = "D# Harmonic Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D#/Dsharp-HarmonicMinor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.D_HarmonicMajor))
            {
                nombreEscala.Text = "D# Harmonic Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/D#/Dsharp-HarmonicMajor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.EMajor))
            {
                nombreEscala.Text = "E Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/E/E-Ionian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.EMinor))
            {
                nombreEscala.Text = "E Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/E/E-Aeolian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.EDorian))
            {
                nombreEscala.Text = "E Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/E/E-Dorian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.EPhrygian))
            {
                nombreEscala.Text = "E Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/E/E-Phrygian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.ELydian))
            {
                nombreEscala.Text = "E Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/E/E-Lydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.EMixolydian))
            {
                nombreEscala.Text = "E Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/E/E-Mixolydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.ELocrian))
            {
                nombreEscala.Text = "E Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/E/E-Locrian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.EHarmonicMinor))
            {
                nombreEscala.Text = "E Harmonic Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/E/E-HarmonicMinor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.EHarmonicMajor))
            {
                nombreEscala.Text = "E Harmonic Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/E/E-HarmonicMajor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.FMajor))
            {
                nombreEscala.Text = "F Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F/F-Ionian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.FMinor))
            {
                nombreEscala.Text = "F Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F/F-Aeolian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.FDorian))
            {
                nombreEscala.Text = "F Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F/F-Dorian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.FPhrygian))
            {
                nombreEscala.Text = "F Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F/F-Phrygian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.FLydian))
            {
                nombreEscala.Text = "F Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F/F-Lydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.FMixolydian))
            {
                nombreEscala.Text = "F Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F/F-Mixolydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.FLocrian))
            {
                nombreEscala.Text = "F Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F/F-Locrian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.FHarmonicMinor))
            {
                nombreEscala.Text = "F Harmonic Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F/F-HarmonicMinor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.FHarmonicMajor))
            {
                nombreEscala.Text = "F Harmonic Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F/F-HarmonicMajor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.F_Major))
            {
                nombreEscala.Text = "F# Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F#/Fsharp-Ionian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.F_Minor))
            {
                nombreEscala.Text = "F# Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F#/Fsharp-Aeolian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.F_Dorian))
            {
                nombreEscala.Text = "F# Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F#/Fsharp-Dorian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.F_Phrygian))
            {
                nombreEscala.Text = "F# Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F#/Fsharp-Phrygian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.F_Lydian))
            {
                nombreEscala.Text = "F# Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F#/Fsharp-Lydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.F_Mixolydian))
            {
                nombreEscala.Text = "F# Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F#/Fsharp-Mixolydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.F_Locrian))
            {
                nombreEscala.Text = "F# Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F#/Fsharp-Locrian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.F_HarmonicMinor))
            {
                nombreEscala.Text = "F# Harmonic Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F#/Fsharp-HarmonicMinor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.F_HarmonicMajor))
            {
                nombreEscala.Text = "F# Harmonic Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/F#/Fsharp-HarmonicMajor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.GMajor))
            {
                nombreEscala.Text = "G Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G/G-Ionian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.GMinor))
            {
                nombreEscala.Text = "G Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G/G-Aeolian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.GDorian))
            {
                nombreEscala.Text = "G Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G/G-Dorian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.GPhrygian))
            {
                nombreEscala.Text = "G Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G/-Phrygian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.GLydian))
            {
                nombreEscala.Text = "G Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G/G-Lydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.GMixolydian))
            {
                nombreEscala.Text = "G Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G/G-Mixolydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.GLocrian))
            {
                nombreEscala.Text = "G Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G/G-Locrian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.GHarmonicMinor))
            {
                nombreEscala.Text = "G Harmonic Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G/G-HarmonicMinor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.GHarmonicMajor))
            {
                nombreEscala.Text = "G Harmonic Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G/G-HarmonicMajor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.G_Major))
            {
                nombreEscala.Text = "G# Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G#/Gsharp-Ionian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.G_Minor))
            {
                nombreEscala.Text = "G# Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G#/Gsharp-Aeolian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.G_Dorian))
            {
                nombreEscala.Text = "G# Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G#/Gsharp-Dorian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.G_Phrygian))
            {
                nombreEscala.Text = "G# Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G#/Gsharp-Phrygian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.G_Lydian))
            {
                nombreEscala.Text = "G# Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G#/Gsharp-Lydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.G_Mixolydian))
            {
                nombreEscala.Text = "G# Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G#/Gsharp-Mixolydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.G_Locrian))
            {
                nombreEscala.Text = "G# Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G#/Gsharp-Locrian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.G_HarmonicMinor))
            {
                nombreEscala.Text = "G# Harmonic Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G#/Gsharp-HarmonicMinor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.G_HarmonicMajor))
            {
                nombreEscala.Text = "G# Harmonic Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/G#/Gsharp-HarmonicMajor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.AMajor))
            {
                nombreEscala.Text = "A Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A/A-Ionian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.AMinor))
            {
                nombreEscala.Text = "A Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A/A-Aeolian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.ADorian))
            {
                nombreEscala.Text = "A Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A/A-Dorian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.APhrygian))
            {
                nombreEscala.Text = "A Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A/A-Phrygian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.ALydian))
            {
                nombreEscala.Text = "A Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A/A-Lydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.AMixolydian))
            {
                nombreEscala.Text = "A Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A/A-Mixolydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.ALocrian))
            {
                nombreEscala.Text = "A Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A/A-Locrian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.AHarmonicMinor))
            {
                nombreEscala.Text = "A Harmonic Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A/A-HarmonicMinor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.AHarmonicMajor))
            {
                nombreEscala.Text = "A Harmonic Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A/A-HarmonicMajor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.A_Major))
            {
                nombreEscala.Text = "A# Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A#/Asharp-Ionian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.A_Minor))
            {
                nombreEscala.Text = "A# Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A#/Asharp-Aeolian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.A_Dorian))
            {
                nombreEscala.Text = "A# Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A#/Asharp-Dorian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.A_Phrygian))
            {
                nombreEscala.Text = "A# Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A#/Asharp-Phrygian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.A_Lydian))
            {
                nombreEscala.Text = "A# Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A#/Asharp-Lydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.A_Mixolydian))
            {
                nombreEscala.Text = "A# Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A#/Asharp-Mixolydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.A_Locrian))
            {
                nombreEscala.Text = "A# Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A#/Asharp-Locrian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.A_HarmonicMinor))
            {
                nombreEscala.Text = "A# Harmonic Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A#/Asharp-HarmonicMinor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.A_HarmonicMajor))
            {
                nombreEscala.Text = "A# Harmonic Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/A#/Asharp-HarmonicMajor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.BMajor))
            {
                nombreEscala.Text = "B Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/B/B-Ionian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.BMinor))
            {
                nombreEscala.Text = "B Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/B/B-Aeolian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.BDorian))
            {
                nombreEscala.Text = "B Dorian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/B/B-Dorian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.BPhrygian))
            {
                nombreEscala.Text = "B Phrygian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/B/B-Phrygian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.BLydian))
            {
                nombreEscala.Text = "B Lydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/B/B-Lydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.BMixolydian))
            {
                nombreEscala.Text = "B Mixolydian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/B/B-Mixolydian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.BLocrian))
            {
                nombreEscala.Text = "B Locrian";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/B/B-Locrian.png");
                return;
            }
            else if (escala.SequenceEqual(escalasMusicales.BHarmonicMinor))
            {
                nombreEscala.Text = "B Harmonic Minor";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/B/B-HarmonicMinor.png");
            }
            else if (escala.SequenceEqual(escalasMusicales.BHarmonicMajor))
            {
                nombreEscala.Text = "B Harmonic Major";
                pictureBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "/" + instrumento + "/B/B-HarmonicMajor.png");
            }
            else
            {
                Console.WriteLine("Escala musical no encontrada");
            }
        }
    }
}
