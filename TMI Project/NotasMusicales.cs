using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMI_Project
{
    public class NotasMusicales
    {
        int C, C_, D, D_, E, F, F_, G, G_, A, A_, B;

        public NotasMusicales(int C = 0, int C_ = 0, int D = 0, int D_ = 0, int E = 0, int F = 0, int F_ = 0,
            int G = 0, int G_ = 0, int A = 0, int A_ = 0, int B = 0)
        {
            this.C = C;
            this.C_ = C_;
            this.D = D;
            this.D_ = D_;
            this.E = E;
            this.F = F;
            this.F_ = F_;
            this.G = G;
            this.G_ = G_;
            this.A = A;
            this.A_ = A_;
            this.B = B;
        }
        public int cantidadNotasValidas(int average)
        {
            int cantidad = 0;
            if (C > average)
                cantidad++;
            if (C_ > average)
                cantidad++;
            if (D > average)
                cantidad++;
            if (D_ > average)
                cantidad++;
            if (E > average)
                cantidad++;
            if (F > average)
                cantidad++;
            if (F_ > average)
                cantidad++;
            if (G > average)
                cantidad++;
            if (G_ > average)
                cantidad++;
            if (A > average)
                cantidad++;
            if (A_ > average)
                cantidad++;
            if (B > average)
                cantidad++;

            return cantidad;
        }
        public bool notaExiste(string nota, int average = 0)
        {
            switch (nota)
            {
                case "C":
                    if (C > average)
                        return true;
                    return false;
                case "C#":
                    if (C_ > average)
                        return true;
                    return false;
                case "D":
                    if (D > average)
                        return true;
                    return false;
                case "D#":
                    if (D_ > average)
                        return true;
                    return false;
                case "E":
                    if (E > average)
                        return true;
                    return false;
                case "F":
                    if (F > average)
                        return true;
                    return false;
                case "F#":
                    if (F_ > average)
                        return true;
                    return false;
                case "G":
                    if (G > average)
                        return true;
                    return false;
                case "G#":
                    if (G_ > average)
                        return true;
                    return false;
                case "A":
                    if (A > average)
                        return true;
                    return false;
                case "A#":
                    if (A_ > average)
                        return true;
                    return false;
                case "B":
                    if (B > average)
                        return true;
                    return false;
                default:
                    return false;
            }
        }
        public string getNota(int nota)
        {
            switch (nota)
            {
                case 1: return "C";
                case 2: return "C#";
                case 3: return "D";
                case 4: return "D#";
                case 5: return "E";
                case 6: return "F";
                case 7: return "F#";
                case 8: return "G";
                case 9: return "G#";
                case 10: return "A";
                case 11: return "A#";
                case 12: return "B";
                default: return null;
            }
        }
        public int getNotaDominante()
        {
            int note = 0;
            int aux = 0;
            int _aux = 0;
            for (int i = 1; i <= 12; i++)
            {
                note = get(i);
                if (note > aux)
                {
                    aux = note;
                    _aux = i;
                }
            }
            return _aux;
        }
        public int getNota(string note)
        {
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
                    //Console.WriteLine("[NotasMusicales.getNota(>" + note + ")] No se ha identificado la nota especificada en el parámetro.");
                    return 0;
            }
        }
        public int get(int note)
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
                    //Console.WriteLine("[NotasMusicales.get(>" + note + ")] No se ha identificado la nota especificada en el parámetro.");
                    return 0;
            }
            }
        public int get(string note)
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
                    //Console.WriteLine("[NotasMusicales.get(>" + note + ")] No2 se ha identificado la nota especificada en el parámetro.");
                    return 0;
            }
        }
        // ejemplo: add('C', 3); añade 3 repeticiones para la nota C (Do)
        public void add(string note, int times = 1)
        {
            switch (note)
            {
                case "C":
                    C += times;
                    return;
                case "C#":
                    C_ += times;
                    return;
                case "D":
                    D += times;
                    return;
                case "D#":
                    D_ += times;
                    return;
                case "E":
                    E += times;
                    return;
                case "F":
                    F += times;
                    return;
                case "F#":
                    F_ += times;
                    return;
                case "G":
                    G += times;
                    return;
                case "G#":
                    G_ += times;
                    return;
                case "A":
                    A += times;
                    return;
                case "A#":
                    A_ += times;
                    return;
                case "B":
                    B += times;
                    return;
                default:
                    //Console.WriteLine("[NotasMusicales.add(>" + note + "<, " + times + ")] Nos se ha identificado la nota especificada en el parámetro.");
                    return;
            }
        }

        public void add(double freq, int t = 1)
        {
            switch (freq)
            {
                case 32.3:
                case 64.6:
                case 131.89:
                case 261.09:
                case 522.18:
                case 1047.05:
                case 2094.1:
                    C += t;
                    return;
                case 34.99:
                case 69.98:
                case 137.27:
                case 277.24:
                case 554.48:
                case 1108.96:
                case 2217.92:
                    C_ += t;
                    return;
                //case 37.68:
                case 72.67:
                case 148.04:
                case 293.39:
                case 586.78:
                case 1173.56:
                case 2349.81:
                    D += t;
                    return;
                //case 37.68:
                case 78.06:
                case 156.12:
                case 312.23:
                case 621.77:
                case 1243.54:
                case 2487.08:
                    D_ += t;
                    return;
                case 40.37:
                case 83.44:
                case 164.19:
                case 328.38:
                case 659.45:
                case 1318.91:
                case 2637.82:
                    E += t;
                    return;
                case 43.07:
                case 86.13:
                case 174.96:
                case 349.91:
                case 697.14:
                case 1396.97:
                case 2793.93:
                    F += t;
                    return;
                case 45.76:
                case 91.52:
                case 185.72:
                case 368.76:
                case 740.2:
                case 1480.41:
                case 2960.82:
                    F_ += t;
                    return;
                case 48.45:
                case 96.9:
                case 196.49:
                case 392.98:
                case 783.27:
                case 1569.23:
                case 3135.77:
                    G += t;
                    return;
                case 51.14:
                case 104.97:
                case 207.26:
                case 414.51:
                case 831.72:
                case 1660.75:
                case 3321.5:
                    G_ += t;
                    return;
                case 53.83:
                case 110.36:
                case 220.72:
                case 438.74:
                case 880.17:
                case 1760.34:
                case 3520.68:
                    A += t;
                    return;
                case 59.22:
                case 115.74:
                case 234.17:
                case 465.66:
                case 931.31:
                case 1865.31:
                case 3730.63:
                    A_ += t;
                    return;
                case 61.91:
                case 123.82:
                case 247.63:
                case 492.57:
                case 987.84:
                case 1975.67:
                case 3951.34:
                    B += t;
                    return;
            }
        }

        public int getNota(double freq)
        {
            switch (freq)
            {
                // C
                case 32.3:
                case 64.6:
                case 131.89:
                case 261.09:
                case 522.18:
                case 1047.05:
                case 2094.1:
                    return 1;
                // C#
                case 34.99:
                case 69.98:
                case 137.27:
                case 277.24:
                case 554.48:
                case 1108.96:
                case 2217.92:
                    return 2;
                // D
                //case 37.68:
                case 72.67:
                case 148.04:
                case 293.39:
                case 586.78:
                case 1173.56:
                case 2349.81:
                    return 3;
                // D#
                //case 37.68:
                case 78.06:
                case 156.12:
                case 312.23:
                case 621.77:
                case 1243.54:
                case 2487.08:
                    return 4;
                // E
                case 40.37:
                case 83.44:
                case 164.19:
                case 328.38:
                case 659.45:
                case 1318.91:
                case 2637.82:
                    return 5;
                // F
                case 43.07:
                case 86.13:
                case 174.96:
                case 349.91:
                case 697.14:
                case 1396.97:
                case 2793.93:
                    return 6;
                // F#
                case 45.76:
                case 91.52:
                case 185.72:
                case 368.76:
                case 740.2:
                case 1480.41:
                case 2960.82:
                    return 7;
                // G
                case 48.45:
                case 96.9:
                case 196.49:
                case 392.98:
                case 783.27:
                case 1569.23:
                case 3135.77:
                    return 8;
                // G#
                case 51.14:
                case 104.97:
                case 207.26:
                case 414.51:
                case 831.72:
                case 1660.75:
                case 3321.5:
                    return 9;
                // A
                case 53.83:
                case 56.52:
                case 110.36:
                case 220.72:
                case 438.74:
                case 880.17:
                case 1760.34:
                case 3520.68:
                    return 10;
                // A#
                case 59.22:
                case 115.74:
                case 234.17:
                case 465.66:
                case 931.31:
                case 1865.31:
                case 3730.63:
                    return 11;
                // B
                case 61.91:
                case 123.82:
                case 247.63:
                case 492.57:
                case 987.84:
                case 1975.67:
                case 3951.34:
                    return 12;
                default:
                    //Console.WriteLine("<freq no identificada>");
                    return 0;
            }
        }

        /*public void add(double freq, int times = 1)
        {
            //freq *= 2;
            //freq = Math.Round(freq/2, 2, MidpointRounding.AwayFromZero);
            //Console.WriteLine("Reading: " + freq);
            switch (freq)
            {
                /*case 32.38:
                    C += times;
                    C_ += times;
                    D += times;
                    break;
                case 43.17:
                    D_ += times;
                    E += times;
                    F += times;
                    F_ += times;
                    break;
                case 53.96:
                    G += times;
                    G_ += times;
                    A += times;
                    A_ += times;
                    break;
                case 64.76:
                    B += times;
                    C += times;
                    C_ += times;
                    break;
                case 75.55:
                    D += times;
                    D_ += times;
                    break;
                case 86.34:
                    E += times;
                    F += times;
                    break;
                case 97.14:
                    F_ += times;
                    G += times;
                    break;
                case 107.93:
                    G_ += times;
                    A += times;
                    break;
                case 118.72:
                    A_ += times;
                    B += times;
                    break;
                case 151.1:
                    D += times;
                    D_ += times;
                    break;
                    // otro nivel

                case 129.52:
                case 259.03:
                case 528.85:
                case 1046.92:
                case 2093.83:
                    C += times;
                    break;
                case 140.31:
                case 280.62:
                case 550.44:
                case 1111.67:
                case 2223.35:
                    C_ += times;
                    break;
                case 291.41:
                case 593.61:
                case 1176.43:
                case 2352.86:
                    D += times;
                    break;
                case 313:
                case 625.99:
                case 1251.98:
                case 2493.17:
                    D_ += times;
                    break;
                case 161.89:
                case 334.58:
                case 658.37:
                case 1316.74:
                case 2644.27:
                    E += times;
                    break;
                case 172.69:
                case 345.37:
                case 701.54:
                case 1403.08:
                case 2795.37:
                    F += times;
                    break;
                case 183.48:
                case 366.96:
                case 744.71:
                case 1478.63:
                case 2968.06:
                    F_ += times;
                    break;
                case 194.27:
                case 388.55:
                case 787.89:
                case 1575.77:
                case 3140.75:
                    G += times;
                    break;
                case 205.07:
                case 420.93:
                case 831.06:
                case 1662.11:
                case 3335.02:
                    G_ += times;
                    break;
                case 215.86:
                case 442.51:
                case 885.02:
                case 1759.25:
                case 3529.3:
                    A += times;
                    break;
                case 237.44:
                case 464.1:
                case 938.99:
                case 1867.18:
                case 3734.36:
                    A_ += times;
                    break;
                case 248.24:
                case 496.48:
                case 992.95:
                case 1975.11:
                case 3961.01:
                    B += times;
                    break;

                default:
                    return;
            }
        }*/
    }
}
