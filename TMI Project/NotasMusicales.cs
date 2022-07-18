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
                //case 32.3: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                //case 64.6: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 129.2: // extra
                case 131.89:
                case 261.09:
                case 263.78: // extra
                case 522.18:
                case 524.87: // extra
                case 1044.36: // extra
                case 1047.05:
                case 2091.41: // extra
                case 2094.1:
                    C += repeticiones;
                    return;
                //case 34.99: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                //case 69.98: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 137.27:
                case 139.97: // extra
                case 274.55: // extra
                case 277.24:
                case 279.93: // extra AÑADIDO DE PURO TESTING
                case 551.79: // extra
                case 554.48:
                case 1106.27: // extra
                case 1108.96:
                case 2215.23: // extra
                case 2217.92:
                    C_ += repeticiones;
                    return;
                //case 37.68:
                //case 72.67: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 145.35: // extra
                case 148.04:
                case 293.39:
                case 296.08: // extra
                case 586.78:
                case 589.47: // extra
                case 1173.56:
                case 1176.25: // extra
                case 2347.12: // extra
                case 2349.81:
                    D += repeticiones;
                    return;
                //case 37.68:
                //case 78.06: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 153.42: // extra
                case 156.12:
                case 309.54: // extra
                case 312.23:
                case 621.77:
                case 624.46: // extra
                case 1243.54:
                case 1246.23: // extra
                case 2484.39: // extra
                case 2487.08:
                    D_ += repeticiones;
                    return;
                case 40.37:
                //case 43.07: // extra
                case 80.75: // extra
                case 83.44:
                case 164.19:
                case 166.88: // extra
                case 328.38:
                case 331.07: // extra
                case 656.76: // extra
                case 659.45:
                case 1316.22: // extra
                case 1318.91:
                case 2635.13: // extra
                case 2637.82:
                    E += repeticiones;
                    return;
                //case 43.07: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                //case 45.76: // extra REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 86.13:
                case 88.82: // extra
                case 172.27: // extra
                case 174.96:
                case 347.22: // extra
                case 349.91:
                case 352.22: // extra AÑ
                case 697.14:
                case 699.83: // extra
                case 1394.27: // extra
                case 1396.97:
                case 2791.24: // extra
                case 2793.93:
                    F += repeticiones;
                    return;
                //case 45.76: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                //case 48.45: // extra REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 91.52:
                case 94.21: // extra
                case 183.03: // extra
                case 185.72:
                case 368.76:
                case 371.45: // extra
                case 737.51: // extra
                case 740.2:
                case 1477.72: // extra
                case 1480.41:
                case 2958.12: // extra
                case 2960.82:
                    F_ += repeticiones;
                    return;
                //case 48.45: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 96.9:
                case 99.59: // extra
                case 193.8: // extra
                case 196.49:
                case 199.18: // extra AÑADIDO PORQUE ESTABA ANALIZANDO "acordes.wav"
                case 390.29: // extra
                case 392.98:
                case 783.27:
                case 785.96: // extra
                case 1566.54: // extra
                case 1569.23:
                case 3135.77:
                case 3138.46: // extra
                    G += repeticiones;
                    return;
                //case 51.14: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 102.28: // extra
                case 104.97:
                case 207.26:
                case 209.95: // extra
                case 414.51:
                case 417.21: // extra
                case 829.03: // extra
                case 831.72:
                case 1660.75:
                case 1663.44: // extra
                case 3321.5:
                case 3324.19: // extra
                    G_ += repeticiones;
                    return;
                //case 53.83: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 107.67: // extra
                case 110.36:
                case 218.02: // extra
                case 220.72:
                case 438.74:
                case 441.43: // extra
                case 877.48: // extra
                case 880.17:
                case 1757.65: // extra
                case 1760.34:
                case 3517.99: // extra
                case 3520.68:
                    A += repeticiones;
                    return;
                //case 59.22: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 115.74:
                case 118.43: // extra
                case 231.48: // extra
                case 234.17:
                case 465.66:
                case 468.35: // extra
                case 931.31:
                case 934: // extra
                case 1862.62: // extra
                case 1865.31:
                case 3727.94: // extra
                case 3730.63:
                    A_ += repeticiones;
                    return;
                //case 61.91: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 121.12: // extra
                case 123.82:
                case 244.94: // extra
                case 247.63:
                case 492.57:
                case 495.26: // extra
                case 985.14: // extra
                case 987.84:
                case 1972.98: // extra
                case 1975.67:
                case 3948.65: // extra
                case 3951.34:
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
                //case 32.3: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                //case 64.6: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 129.2: // extra
                case 131.89:
                case 261.09:
                case 263.78: // extra
                case 522.18:
                case 524.87: // extra
                case 1044.36: // extra
                case 1047.05:
                case 2091.41: // extra
                case 2094.1:
                    return 1;
                //case 34.99: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                //case 69.98: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 137.27:
                case 139.97: // extra
                case 274.55: // extra
                case 277.24:
                case 279.93: // extra AÑADIDO DE PURO TESTING
                case 551.79: // extra
                case 554.48:
                case 1106.27: // extra
                case 1108.96:
                case 2215.23: // extra
                case 2217.92:
                    return 2;
                //case 37.68:
                //case 72.67: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 145.35: // extra
                case 148.04:
                case 293.39:
                case 296.08: // extra
                case 586.78:
                case 589.47: // extra
                case 1173.56:
                case 1176.25: // extra
                case 2347.12: // extra
                case 2349.81:
                    return 3;
                //case 37.68:
                //case 78.06: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 153.42: // extra
                case 156.12:
                case 309.54: // extra
                case 312.23:
                case 621.77:
                case 624.46: // extra
                case 1243.54:
                case 1246.23: // extra
                case 2484.39: // extra
                case 2487.08:
                    return 4;
                case 40.37:
                //case 43.07: // extra
                case 80.75: // extra
                case 83.44:
                case 164.19:
                case 166.88: // extra
                case 328.38:
                case 331.07: // extra
                case 656.76: // extra
                case 659.45:
                case 1316.22: // extra
                case 1318.91:
                case 2635.13: // extra
                case 2637.82:
                    return 5;
                //case 43.07: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                //case 45.76: // extra REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 86.13:
                case 88.82: // extra
                case 172.27: // extra
                case 174.96:
                case 347.22: // extra
                case 349.91:
                case 697.14:
                case 699.83: // extra
                case 1394.27: // extra
                case 1396.97:
                case 2791.24: // extra
                case 2793.93:
                    return 6;
                //case 45.76: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                //case 48.45: // extra REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 91.52:
                case 94.21: // extra
                case 183.03: // extra
                case 185.72:
                case 368.76:
                case 371.45: // extra
                case 737.51: // extra
                case 740.2:
                case 1477.72: // extra
                case 1480.41:
                case 2958.12: // extra
                case 2960.82:
                    return 7;
                //case 48.45: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 96.9:
                case 99.59: // extra
                case 193.8: // extra
                case 196.49:
                case 390.29: // extra
                case 392.98:
                case 783.27:
                case 785.96: // extra
                case 1566.54: // extra
                case 1569.23:
                case 3135.77:
                case 3138.46: // extra
                    return 8;
                //case 51.14: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 102.28: // extra
                case 104.97:
                case 207.26:
                case 209.95: // extra
                case 414.51:
                case 417.21: // extra
                case 829.03: // extra
                case 831.72:
                case 1660.75:
                case 1663.44: // extra
                case 3321.5:
                case 3324.19: // extra
                    return 9;
                //case 53.83: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 107.67: // extra
                case 110.36:
                case 218.02: // extra
                case 220.72:
                case 438.74:
                case 441.43: // extra
                case 877.48: // extra
                case 880.17:
                case 1757.65: // extra
                case 1760.34:
                case 3517.99: // extra
                case 3520.68:
                    return 10;
                //case 59.22: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 115.74:
                case 118.43: // extra
                case 231.48: // extra
                case 234.17:
                case 465.66:
                case 468.35: // extra
                case 931.31:
                case 934: // extra
                case 1862.62: // extra
                case 1865.31:
                case 3727.94: // extra
                case 3730.63:
                    return 11;
                //case 61.91: REMOVIDO POR LA COMBINACIÓN MIXTA DE LOS 2 MÉTODOS
                case 121.12: // extra
                case 123.82:
                case 244.94: // extra
                case 247.63:
                case 492.57:
                case 495.26: // extra
                case 985.14: // extra
                case 987.84:
                case 1972.98: // extra
                case 1975.67:
                case 3948.65: // extra
                case 3951.34:
                    return 12;
                default:
                    return 0;
            }
        }

        /*public void Add(double freq, int repeticiones = 1)
        {
            switch (freq)
            {
                // C
                //case 34.99:
                //case 67.29:
                case 129.2:
                case 263.78:
                case 524.87:
                case 1044.36:
                case 2091.41:
                    C += repeticiones;
                    return;
                // C#
                //case 32.3:
                //case 67.29:
                case 139.97:
                case 274.55:
                case 551.79:
                case 1106.27:
                case 2215.23:
                    C_ += repeticiones;
                    return;
                // D
                //case 34.99:
                //case 75.37:
                case 145.35:
                case 296.08:
                case 589.47:
                case 1176.25:
                case 2347.12:
                    D += repeticiones;
                    return;
                // D#
                //case 40.37: //NO ESTÁ MAL, PERO NO SE SI ES CORRECTO
                //case 75.37:
                case 153.42:
                case 309.54:
                case 624.46:
                case 1246.23:
                case 2484.39:
                    D_ += repeticiones;
                    return;
                // E
                case 43.07:
                case 80.75:
                case 166.88:
                case 331.07:
                case 656.76:
                case 1316.22:
                case 2635.13:
                    E += repeticiones;
                    return;
                // F
                case 45.76:
                case 88.82:
                case 172.27:
                case 347.22:
                case 699.83:
                case 1394.27:
                case 2791.24:
                    F += repeticiones;
                    return;
                // F#
                case 48.45:
                case 94.21:
                case 183.03:
                case 371.45:
                case 737.51:
                case 1477.72:
                case 2958.12:
                    F_ += repeticiones;
                    return;
                // G
                case 51.14:
                case 99.59:
                case 193.8:
                case 390.29:
                case 785.96:
                case 1566.54:
                case 3138.46:
                    G += repeticiones;
                    return;
                // G#
                case 53.83:
                case 102.28:
                case 209.95:
                case 417.21:
                case 829.03:
                case 1663.44:
                case 3324.19:
                    G_ += repeticiones;
                    return;
                // A
                //case 56.52:
                case 107.67:
                case 218.02:
                case 441.43:
                case 877.48:
                case 1757.65:
                case 3517.99:
                    A += repeticiones;
                    return;
                // A#
                //case 56.52:
                case 118.43:
                case 231.48:
                case 468.35:
                case 934:
                case 1862.62:
                case 3727.94:
                    A_ += repeticiones;
                    return;
                case 59.22:
                case 121.12:
                case 244.94:
                case 495.26:
                case 985.14:
                case 1972.98:
                case 3948.65:
                    B += repeticiones;
                    return;
            }
        }
        public int GetNota(double freq)
        {
            switch (freq)
            {
                // C
                //case 34.99:
                //case 67.29:
                case 129.2:
                case 263.78:
                case 524.87:
                case 1044.36:
                case 2091.41:
                    return 1;
                // C#
                //case 32.3:
                //case 67.29:
                case 139.97:
                case 274.55:
                case 551.79:
                case 1106.27:
                case 2215.23:
                    return 2;
                // D
                //case 34.99:
                //case 75.37:
                case 145.35:
                case 296.08:
                case 589.47:
                case 1176.25:
                case 2347.12:
                    return 3;
                // D#
                //case 40.37: NO ESTÁ MAL, PERO NO SE SI ES CORRECTO
                //case 75.37:
                case 153.42:
                case 309.54:
                case 624.46:
                case 1246.23:
                case 2484.39:
                    return 4;
                // E
                case 43.07:
                case 80.75:
                case 166.88:
                case 331.07:
                case 656.76:
                case 1316.22:
                case 2635.13:
                    return 5;
                // F
                case 45.76:
                case 88.82:
                case 172.27:
                case 347.22:
                case 699.83:
                case 1394.27:
                case 2791.24:
                    return 6;
                // F#
                case 48.45:
                case 94.21:
                case 183.03:
                case 371.45:
                case 737.51:
                case 1477.72:
                case 2958.12:
                    return 7;
                // G
                case 51.14:
                case 99.59:
                case 193.8:
                case 390.29:
                case 785.96:
                case 1566.54:
                case 3138.46:
                    return 8;
                // G#
                case 53.83:
                case 102.28:
                case 209.95:
                case 417.21:
                case 829.03:
                case 1663.44:
                case 3324.19:
                    return 9;
                // A
                //case 56.52:
                case 107.67:
                case 218.02:
                case 441.43:
                case 877.48:
                case 1757.65:
                case 3517.99:
                    return 10;
                // A#
                //case 56.52:
                case 118.43:
                case 231.48:
                case 468.35:
                case 934:
                case 1862.62:
                case 3727.94:
                    return 11;
                case 59.22:
                case 121.12:
                case 244.94:
                case 495.26:
                case 985.14:
                case 1972.98:
                case 3948.65:
                    return 12;
                default:
                    return 0;
            }
        }*/
    }
}
