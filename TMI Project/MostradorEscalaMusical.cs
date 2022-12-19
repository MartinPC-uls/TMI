using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMI_Project
{
    public partial class MostradorEscalaMusical : Form
    {
        private static string[] FirstString;
        private static string[] SecondString;
        private static string[] ThirdString;
        private static string[] FourthString;
        private static string[] FifthString;
        private static string[] SixthString;

        private static readonly int FRET_COUNT = 13; // We're considering the guitar from fret 0 to 12.
        public MostradorEscalaMusical(string[] scale, string[] tuning, string scaleName)
        {
            FirstString = new string[FRET_COUNT];
            SecondString = new string[FRET_COUNT];
            ThirdString = new string[FRET_COUNT];
            FourthString = new string[FRET_COUNT];
            FifthString = new string[FRET_COUNT];
            SixthString = new string[FRET_COUNT];
            InitializeComponent();
            SetTuning(tuning);
            SetMusicalScale(scale);

            lblNombreEscala.Text = scaleName;
        }
        public void SetTuning(string[] tuning)
        {
            /*
             Guitar tuning:
                     Standard: E  A  D  G  B  E
                    -1/2 tone: D# G# C# F# A# D#
                     -2 tones: D  G  C  F  A  D
                 -2 1/2 tones: C# F# B  E  G# C#
            */
            int[] standardTuning = { 5, 10, 3, 8, 12, 5 };
            int sixth = GetNote(tuning[0]);
            int fifth = GetNote(tuning[1]);
            int fourth = GetNote(tuning[2]);
            int third = GetNote(tuning[3]);
            int second = GetNote(tuning[4]);
            int first = GetNote(tuning[5]);
            int[] parameterTuning = { sixth, fifth, fourth, third, second, first };
            
            SetString(GetNote(first), 1);
            SetString(GetNote(second), 2);
            SetString(GetNote(third), 3);
            SetString(GetNote(fourth), 4);
            SetString(GetNote(fifth), 5);
            SetString(GetNote(sixth), 6);

        }
        public void SetMusicalScale(string[] scale)
        {
            for (int i = 0; i < lblNotes.GetLength(0); i++)
            {
                for (int j = 0; j < lblNotes.GetLength(1); j++)
                {
                    if (scale.Contains(lblNotes[i, j].Text))
                    {
                        pbNotes[i, j].Visible = true;
                        // if pbNotes[i, j] is the first note in the scale
                        if (lblNotes[i, j].Text == scale[0])
                        {
                            pbNotes[i, j].BackColor = Color.Green;
                        }
                        if (lblNotes[i, j].Text == scale[2])
                        {
                            pbNotes[i, j].BackColor = Color.GreenYellow;
                        }
                        if (lblNotes[i, j].Text == scale[4])
                        {
                            pbNotes[i, j].BackColor = Color.Orange;
                        }
                        lblNotes[i, j].Visible = true;
                    }
                }
            }
        }
        public void SetString(string firstNote, int stringNumber)
        {
            stringNumber -= 1;
            if (!(stringNumber >= 0 && stringNumber <= 5))
                throw new Exception("String number must be a value between 1 and 6.");
            
            lblNotes[stringNumber, 0].Text = firstNote;
            int note = GetNote(firstNote);
            for (int i = 1; i < lblNotes.GetLength(1); i++)
            {
                note = GetNextNote(note);
                lblNotes[stringNumber, i].Text = GetNote(note);
            }
            for (int i = 0; i < lblNotes.GetLength(1); i++)
            {
                lblNotes[stringNumber, i].Visible = false;
                pbNotes[stringNumber, i].Visible = false;
                pbNotes[stringNumber, i].BackColor = Color.White;
            }
        }
        public int GetNextNote(int note)
        {
            return (note + 1) % 12;
        }
        public int GetPreviousNote(int note)
        {
            return (note - 1) % 12;
        }
        public int GetNote(string note)
        {
            #region Musical Notes
            switch (note)
            {
                case "C":
                    return 1;
                case "C#":
                    return 2;
                case "D":
                    return 3;
                case "D#":
                    return 4;
                case "E":
                    return 5;
                case "F":
                    return 6;
                case "F#":
                    return 7;
                case "G":
                    return 8;
                case "G#":
                    return 9;
                case "A":
                    return 10;
                case "A#":
                    return 11;
                case "B":
                    return 12;
                default:
                    return 12;
            }
            #endregion
        }
        public string GetNote(int note)
        {
            #region Musical Notes
            switch (note)
            {
                case 1:
                    return "C";
                case 2:
                    return "C#";
                case 3:
                    return "D";
                case 4:
                    return "D#";
                case 5:
                    return "E";
                case 6:
                    return "F";
                case 7:
                    return "F#";
                case 8:
                    return "G";
                case 9:
                    return "G#";
                case 10:
                    return "A";
                case 11:
                    return "A#";
                case 12:
                    return "B";
                default:
                    return "B";
            }
            #endregion
        }
    }
}
