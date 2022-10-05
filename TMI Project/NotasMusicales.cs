using System;

namespace TMI_Project
{
    public class NotasMusicales
    {
        int C, C_, D, D_, E, F, F_, G, G_, A, A_, B;

        /// <summary>
        /// Constructor de la clase NotasMusicales
        /// </summary>
        /// <param name="C"></param>
        /// <param name="C_"></param>
        /// <param name="D"></param>
        /// <param name="D_"></param>
        /// <param name="E"></param>
        /// <param name="F"></param>
        /// <param name="F_"></param>
        /// <param name="G"></param>
        /// <param name="G_"></param>
        /// <param name="A"></param>
        /// <param name="A_"></param>
        /// <param name="B"></param>
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

        /// <summary>
        /// Obtiene el valor string la nota musical dada en int
        /// </summary>
        /// <param name="nota"></param>
        /// <returns></returns>
        public string GetNota(int nota)
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

        /// <summary>
        /// Obtiene la nota musical dominante en int
        /// </summary>
        /// <returns></returns>
        public int GetNotaDominante()
        {
            int note;
            int aux = 0;
            int _aux = 0;
            for (int i = 1; i <= 12; i++)
            {
                note = Get(i);
                if (note > aux)
                {
                    aux = note;
                    _aux = i;
                }
            }
            return _aux;
        }
        public int GetNota(string note)
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

        /// <summary>
        /// Obtiene el número de repeticiones de una nota musical dada en int
        /// </summary>
        /// <param name="nota"></param>
        /// <returns></returns>
        public int Get(int nota)
        {
            switch (nota)
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

        /// <summary>
        /// Obtiene el número de repeticiones de una nota musical dada en string
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public int Get(string note)
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

        /// <summary>
        /// Añade un determinado número de repeticiones a una nota musical dada en string
        /// </summary>
        /// <param name="nota"></param>
        /// <param name="repeticiones"></param>
        public void Add(string nota, int repeticiones = 1)
        {
            switch (nota)
            {
                case "C":
                    C += repeticiones;
                    return;
                case "C#":
                    C_ += repeticiones;
                    return;
                case "D":
                    D += repeticiones;
                    return;
                case "D#":
                    D_ += repeticiones;
                    return;
                case "E":
                    E += repeticiones;
                    return;
                case "F":
                    F += repeticiones;
                    return;
                case "F#":
                    F_ += repeticiones;
                    return;
                case "G":
                    G += repeticiones;
                    return;
                case "G#":
                    G_ += repeticiones;
                    return;
                case "A":
                    A += repeticiones;
                    return;
                case "A#":
                    A_ += repeticiones;
                    return;
                case "B":
                    B += repeticiones;
                    return;
                default:
                    //Console.WriteLine("[NotasMusicales.add(>" + note + "<, " + times + ")] Nos se ha identificado la nota especificada en el parámetro.");
                    return;
            }
        }

        /// <summary>
        /// Añade un determinado número de repeticiones a una nota musical dada en valor de frecuencia (double)
        /// </summary>
        /// <param name="freq"></param>
        /// <param name="repeticiones"></param>
        public void Add(double freq, int repeticiones = 1)
        {
            switch (freq)
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
                    C += repeticiones;
                    return;
                case 17:
                case 35:
                case 69:
                case 139:
                case 277:
                case 554:
                case 1109:
                case 2216:
                case 4435:
                    C_ += repeticiones;
                    return;
                case 18:
                case 37:
                case 73:
                case 147:
                case 294:
                case 587:
                case 1175:
                case 2349:
                case 4699:
                    D += repeticiones;
                    return;
                case 19:
                case 39:
                case 78:
                case 156:
                case 311:
                case 622:
                case 1245:
                case 2489:
                case 4978:
                    D_ += repeticiones;
                    return;
                case 21:
                case 41:
                case 82:
                case 165:
                case 330:
                case 659:
                case 1319:
                case 2637:
                case 5274:
                    E += repeticiones;
                    return;
                case 22:
                case 44:
                case 87:
                case 175:
                case 349:
                case 699:
                case 1397:
                case 2794:
                case 5588:
                    F += repeticiones;
                    return;
                case 23:
                case 46:
                case 93:
                case 185:
                case 370:
                case 740:
                case 1480:
                case 2960:
                case 5920:
                    F_ += repeticiones;
                    return;
                case 25:
                case 49:
                case 98:
                case 196:
                case 392:
                case 784:
                case 1568:
                case 3136:
                case 6272:
                    G += repeticiones;
                    return;
                case 26:
                case 52:
                case 104:
                case 208:
                case 415:
                case 831:
                case 1661:
                case 3322:
                case 6645:
                    G_ += repeticiones;
                    return;
                case 28:
                case 55:
                case 110:
                case 220:
                case 440:
                case 880:
                case 1760:
                case 3520:
                case 7040:
                    A += repeticiones;
                    return;
                case 29:
                case 58:
                case 117:
                case 233:
                case 466:
                case 932:
                case 1865:
                case 3729:
                case 7459:
                    A_ += repeticiones;
                    return;
                case 31:
                case 62:
                case 124:
                case 247:
                case 494:
                case 988:
                case 1976:
                case 3951:
                case 7902:
                    B += repeticiones;
                    return;
            }
        }

        /// <summary>
        /// Obtiene la nota musical en int de una determinada frecuencia
        /// </summary>
        /// <param name="freq"></param>
        /// <returns></returns>
        public int GetNota(double freq)
        {
            switch (freq)
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
                    return 1;
                case 17:
                case 35:
                case 69:
                case 139:
                case 277:
                case 554:
                case 1109:
                case 2216:
                case 4435:
                    return 2;
                case 18:
                case 37:
                case 73:
                case 147:
                case 294:
                case 587:
                case 1175:
                case 2349:
                case 4699:
                    return 3;
                case 19:
                case 39:
                case 78:
                case 156:
                case 311:
                case 622:
                case 1245:
                case 2489:
                case 4978:
                    return 4;
                case 21:
                case 41:
                case 82:
                case 165:
                case 330:
                case 659:
                case 1319:
                case 2637:
                case 5274:
                    return 5;
                case 22:
                case 44:
                case 87:
                case 175:
                case 349:
                case 699:
                case 1397:
                case 2794:
                case 5588:
                    return 6;
                case 23:
                case 46:
                case 93:
                case 185:
                case 370:
                case 740:
                case 1480:
                case 2960:
                case 5920:
                    return 7;
                case 25:
                case 49:
                case 98:
                case 196:
                case 392:
                case 784:
                case 1568:
                case 3136:
                case 6272:
                    return 8;
                case 26:
                case 52:
                case 104:
                case 208:
                case 415:
                case 831:
                case 1661:
                case 3322:
                case 6645:
                    return 9;
                case 28:
                case 55:
                case 110:
                case 220:
                case 440:
                case 880:
                case 1760:
                case 3520:
                case 7040:
                    return 10;
                case 29:
                case 58:
                case 117:
                case 233:
                case 466:
                case 932:
                case 1865:
                case 3729:
                case 7459:
                    return 11;
                case 31:
                case 62:
                case 124:
                case 247:
                case 494:
                case 988:
                case 1976:
                case 3951:
                case 7902:
                    return 12;
                default:
                    return 0;
            }
        }
    }
}
