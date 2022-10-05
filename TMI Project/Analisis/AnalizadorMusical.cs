using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TMI_Project.Analisis
{
    public class AnalizadorMusical
    {
        private Complex[] Frequencies;
        public double C;
        public double C_;
        public double D;
        public double D_;
        public double E;
        public double F;
        public double F_;
        public double G;
        public double G_;
        public double A;
        public double A_;
        public double B;
        public AnalizadorMusical(Complex[] frequencies)
        {
            Frequencies = frequencies;
        }
        public AnalizadorMusical() { }
        public string GetDominantNote()
        {
            double[] vals = new double[12];
            int note = 0;
            vals[0] = C;
            vals[1] = C_;
            vals[2] = D;
            vals[3] = D_;
            vals[4] = E;
            vals[5] = F;
            vals[6] = F_;
            vals[7] = G;
            vals[8] = G_;
            vals[9] = A;
            vals[10] = A_;
            vals[11] = B;
            // get pick
            double max = vals.Max();
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == max)
                {
                    note = i + 1;
                    break;
                }
            }
            return GetNote(note);
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
        public double GetMagnitude(string note)
        {
            switch (note)
            {
                case "C":
                    return C;
                case "C#":
                    return C_;
                case "D":
                    return D;
                case "D#":
                    return D_;
                case "E":
                    return E;
                case "F":
                    return F;
                case "F#":
                    return F_;
                case "G":
                    return G;
                case "G#":
                    return G_;
                case "A":
                    return A;
                case "A#":
                    return A_;
                case "B":
                    return B;
                default:
                    return 0;
            }
        }
        public double GetMagnitude(int note)
        {
            switch (note)
            {
                case 1:
                    return C;
                case 2:
                    return C_;
                case 3:
                    return D;
                case 4:
                    return D_;
                case 5:
                    return E;
                case 6:
                    return F;
                case 7:
                    return F_;
                case 8:
                    return G;
                case 9:
                    return G_;
                case 10:
                    return A;
                case 11:
                    return A_;
                case 12:
                    return B;
                default:
                    return 0;
            }
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
        public void ObtenerNotasMusicales(Complex[] frequencies = null)
        {
            if (frequencies != null)
                Frequencies = frequencies;
            
            for (int i = 0; i < Frequencies.Length/2; i++)
            {
                switch (i)
                {
                    case 16:
                    case 33:
                    case 65:
                    case 131:
                    case 262:
                    case 523:
                    case 1047:
                    case 2093:
                    case 4186:
                        C += Frequencies[i].Magnitude;
                        break;
                    case 17:
                    case 35:
                    case 69:
                    case 139:
                    case 277:
                    case 554:
                    case 1109:
                    case 2216:
                    case 4435:
                        C_ += Frequencies[i].Magnitude;
                        break;
                    case 18:
                    case 37:
                    case 73:
                    case 147:
                    case 294:
                    case 587:
                    case 1175:
                    case 2349:
                    case 4699:
                        D += Frequencies[i].Magnitude;
                        break;
                    case 19:
                    case 39:
                    case 78:
                    case 156:
                    case 311:
                    case 622:
                    case 1245:
                    case 2489:
                    case 4978:
                        D_ += Frequencies[i].Magnitude;
                        break;
                    case 21:
                    case 41:
                    case 82:
                    case 165:
                    case 330:
                    case 659:
                    case 1319:
                    case 2637:
                    case 5274:
                        E += Frequencies[i].Magnitude;
                        break;
                    case 22:
                    case 44:
                    case 87:
                    case 175:
                    case 349:
                    case 699:
                    case 1397:
                    case 2794:
                    case 5588:
                        F += Frequencies[i].Magnitude;
                        break;
                    case 23:
                    case 46:
                    case 93:
                    case 185:
                    case 370:
                    case 740:
                    case 1480:
                    case 2960:
                    case 5920:
                        F_ += Frequencies[i].Magnitude;
                        break;
                    case 25:
                    case 49:
                    case 98:
                    case 196:
                    case 392:
                    case 784:
                    case 1567:
                    case 3136:
                    case 3272:
                        G += Frequencies[i].Magnitude;
                        break;
                    case 26:
                    case 52:
                    case 104:
                    case 208:
                    case 415:
                    case 831:
                    case 1661:
                    case 3322:
                    case 6645:
                        G_ += Frequencies[i].Magnitude;
                        break;
                    case 28:
                    case 55:
                    case 110:
                    case 220:
                    case 440:
                    case 880:
                    case 1760:
                    case 3520:
                    case 7040:
                        A += Frequencies[i].Magnitude;
                        break;
                    case 29:
                    case 58:
                    case 117:
                    case 233:
                    case 466:
                    case 932:
                    case 1865:
                    case 3729:
                    case 7459:
                        A_ += Frequencies[i].Magnitude;
                        break;
                    case 31:
                    case 62:
                    case 124:
                    case 247:
                    case 494:
                    case 988:
                    case 1976:
                    case 3951:
                    case 7902:
                        B += Frequencies[i].Magnitude;
                        break;
                }
                
            }
        }
        public override string ToString()
        {
            return "C: " + C + "\nC#: " + C_ + "\nD: " + D + "\nD#: " + D_ + "\nE: " +
                E + "\nF: " + F + "\nF#: " + F_ + "\nG: " + G + "\nG#: " + G_ + "\nA: " +
                A + "\nA#: " + A_ + "\nB: " + B;
        }
    }
}
