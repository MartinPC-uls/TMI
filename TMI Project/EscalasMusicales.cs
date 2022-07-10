using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMI_Project
{
    public class EscalasMusicales
    {
        private static readonly string C = "C";
        private static readonly string C_ = "C#";
        private static readonly string D = "D";
        private static readonly string D_ = "D#";
        private static readonly string E = "E";
        private static readonly string F = "F";
        private static readonly string F_ = "F#";
        private static readonly string G = "G";
        private static readonly string G_ = "G#";
        private static readonly string A = "A";
        private static readonly string A_ = "A#";
        private static readonly string B = "B";
        public readonly string[] CMajor = { C, D, E, F, G, A, B };
        public readonly string[] C_Major = { C_, D_, F, F_, G_, A_, C };
        public readonly string[] DMajor = { D, E, F_, G, A, B, C_ };
        public readonly string[] D_Major = { D_, F, G, G_, A_, C, D };
        public readonly string[] EMajor = { E, F_, G_, A, B, C_, D_ };
        public readonly string[] FMajor = { F, G, A, A_, C, D, E };
        public readonly string[] F_Major = { F_, G_, A_, B, C_, D_, F };
        public readonly string[] GMajor = { G, A, B, C, D, E, F_ };
        public readonly string[] G_Major = { G_, A_, C, C_, D_, F, G };
        public readonly string[] AMajor = { A, B, C_, D, E, F_, G_ };
        public readonly string[] A_Major = { A, B, C_, D, E, F_, G_ };
        public readonly string[] BMajor = { B, C_, D_, E, F_, G_, A_ };
        public readonly string[] CMinor = { C, D, D_, F, G, G_, A_ };
        public readonly string[] C_Minor = { C_, D_, E, F_, G_, A, B };
        public readonly string[] DMinor = { D, E, F, G, A, A_, C };
        public readonly string[] D_Minor = { D_, F, F_, G_, A_, B, C_ };
        public readonly string[] EMinor = { E, F_, G, A, B, C, D };
        public readonly string[] FMinor = { F, G, G_, A_, C, C_, D_ };
        public readonly string[] F_Minor = { F_, G_, A, B, C_, D, E };
        public readonly string[] GMinor = { G, A, A_, C, D, D_, F };
        public readonly string[] G_Minor = { G_, A_, B, C_, D_, E, F_ };
        public readonly string[] AMinor = { A, B, C, D, E, F, G };
        public readonly string[] A_Minor = { A_, C, C_, D_, F, F_, G_ };
        public readonly string[] BMinor = { B, C_, D, E, F_, G, A };
        public readonly string[] CDorian = { C, D, D_, F, G, A, A_ };
        public readonly string[] CPhrygian = { C, C_, D_, F, G, G_, A_ };
        public readonly string[] CLydian = { C, D, E, F_, G, A, B };
        public readonly string[] CMixolydian = { C, D, E, F, G, A, A_ };
        public readonly string[] CLocrian = { C, C_, D_, F, F_, G_, A_ };
        public readonly string[] C_Dorian = { C_, D_, E, F_, G_, A_, B };
        public readonly string[] C_Phrygian = { C_, D, E, F_, G_, A, B };
        public readonly string[] C_Lydian = { C_, D_, F, G, G_, A_, C };
        public readonly string[] C_Mixolydian = { C_, D_, F, F_, G_, A_, B };
        public readonly string[] C_Locrian = { C_, D, E, F_, G, A, B };
        public readonly string[] DDorian = { D, E, F, G, A, B, C };
        public readonly string[] DPhrygian = { D, D_, F, G, A, A_, C };
        public readonly string[] DLydian = { D, E, F_, G_, A, B, C_ };
        public readonly string[] DMixolydian = { D, E, F_, G, A, B, C };
        public readonly string[] DLocrian = { D, D_, F, G, G_, A_, C };
        public readonly string[] D_Dorian = { D_, F, F_, G_, A_, C, C_ };
        public readonly string[] D_Phrygian = { D_, E, F_, G_, A_, B, C_ };
        public readonly string[] D_Lydian = { D_, F, G, A, A_, C, D };
        public readonly string[] D_Mixolydian = { D_, F, G, G_, A_, C, C_ };
        public readonly string[] D_Locrian = { D_, E, F_, G_, A, B, C_ };
        public readonly string[] EDorian = { E, F_, G, A, B, C_, D };
        public readonly string[] EPhrygian = { E, F, G, A, B, C, D };
        public readonly string[] ELydian = { E, F_, G_, A_, B, C_, D_ };
        public readonly string[] EMixolydian = { E, F_, G_, A, B, C_, D };
        public readonly string[] ELocrian = { E, F, G, A, A_, C, D };
        public readonly string[] FDorian = { F, G, G_, A_, C, D, D_ };
        public readonly string[] FPhrygian = { F, F_, G_, A_, C, C_, D_ };
        public readonly string[] FLydian = { F, G, A, B, C, D, E };
        public readonly string[] FMixolydian = { F, G, A, A_, C, D, D_ };
        public readonly string[] FLocrian = { F, F_, G_, A_, B, C_, D_ };
        public readonly string[] F_Dorian = { F_, G_, A, B, C_, D_, E };
        public readonly string[] F_Phrygian = { F_, G, A, B, C_, D, E };
        public readonly string[] F_Lydian = { F_, G_, A_, C, C_, D_, F };
        public readonly string[] F_Mixolydian = { F_, G_, A_, B, C_, D_, E };
        public readonly string[] F_Locrian = { F_, G, A, B, C, D, E };
        public readonly string[] GDorian = { G, A, A_, C, D, E, F };
        public readonly string[] GPhrygian = { G, G_, A_, C, D, D_, F };
        public readonly string[] GLydian = { G, A, B, C_, D, E, F_ };
        public readonly string[] GMixolydian = { G, A, B, C, D, E, F };
        public readonly string[] GLocrian = { G, G_, A_, C, C_, D_, F };
        public readonly string[] G_Dorian = { G_, A_, B, C_, D_, F, F_ };
        public readonly string[] G_Phrygian = { G_, A, B, C_, D_, E, F_ };
        public readonly string[] G_Lydian = { G_, A_, C, D, D_, F, G };
        public readonly string[] G_Mixolydian = { G_, A_, C, C_, D_, F, F_ };
        public readonly string[] G_Locrian = { G_, A, B, C_, D, E, F_ };
        public readonly string[] ADorian = { A, B, C, D, E, F_, G };
        public readonly string[] APhrygian = { A, A_, C, D, E, F, G };
        public readonly string[] ALydian = { A, B, C_, D_, E, F_, G_ };
        public readonly string[] AMixolydian = { A, B, C_, D, E, F_, G };
        public readonly string[] ALocrian = { A, A_, C, D, D_, F, G };
        public readonly string[] A_Dorian = { A_, C, C_, D_, F, G, G_ };
        public readonly string[] A_Phrygian = { A_, B, C_, D_, F, F_, G_ };
        public readonly string[] A_Lydian = { A_, C, D, E, F, G, A };
        public readonly string[] A_Mixolydian = { A_, C, D, D_, F, G, G_ };
        public readonly string[] A_Locrian = { A_, B, C_, D_, E, F_, G_ };
        public readonly string[] BDorian = { B, C_, D, E, F_, G_, A };
        public readonly string[] BPhrygian = { B, C, D, E, F_, G, A };
        public readonly string[] BLydian = { B, C_, D_, F, F_, G_, A_ };
        public readonly string[] BMixolydian = { B, C_, D_, E, F_, G_, A };
        public readonly string[] BLocrian = { B, C, D, E, F, G, A };

        public List<string[]> escalas = null;
        public List<string[]> Cescalas = null;
        public List<string[]> C_escalas = null;
        public List<string[]> Descalas = null;
        public List<string[]> D_escalas = null;
        public List<string[]> Eescalas = null;
        public List<string[]> Fescalas = null;
        public List<string[]> F_escalas = null;
        public List<string[]> Gescalas = null;
        public List<string[]> G_escalas = null;
        public List<string[]> Aescalas = null;
        public List<string[]> A_escalas = null;
        public List<string[]> Bescalas = null;

        public EscalasMusicales()
        {
            escalas = new List<string[]>();
            Cescalas = new List<string[]>();
            C_escalas = new List<string[]>();
            Descalas = new List<string[]>();
            D_escalas = new List<string[]>();
            Eescalas = new List<string[]>();
            Fescalas = new List<string[]>();
            F_escalas = new List<string[]>();
            Gescalas = new List<string[]>();
            G_escalas = new List<string[]>();
            Aescalas = new List<string[]>();
            A_escalas = new List<string[]>();
            Bescalas = new List<string[]>();

            escalas.Add(CMajor);
            escalas.Add(CMinor);
            escalas.Add(C_Major);
            escalas.Add(C_Minor);
            escalas.Add(DMajor);
            escalas.Add(DMinor);
            escalas.Add(D_Major);
            escalas.Add(D_Minor);
            escalas.Add(EMajor);
            escalas.Add(EMinor);
            escalas.Add(FMajor);
            escalas.Add(FMinor);
            escalas.Add(F_Major);
            escalas.Add(F_Minor);
            escalas.Add(GMajor);
            escalas.Add(GMinor);
            escalas.Add(G_Major);
            escalas.Add(G_Minor);
            escalas.Add(AMajor);
            escalas.Add(AMinor);
            escalas.Add(A_Major);
            escalas.Add(A_Minor);
            escalas.Add(BMajor);
            escalas.Add(CDorian);
            escalas.Add(C_Dorian);
            escalas.Add(DDorian);
            escalas.Add(D_Dorian);
            escalas.Add(EDorian);
            escalas.Add(FDorian);
            escalas.Add(F_Dorian);
            escalas.Add(GDorian);
            escalas.Add(G_Dorian);
            escalas.Add(ADorian);
            escalas.Add(A_Dorian);
            escalas.Add(BDorian);
            escalas.Add(CPhrygian);
            escalas.Add(C_Phrygian);
            escalas.Add(DPhrygian);
            escalas.Add(D_Phrygian);
            escalas.Add(EPhrygian);
            escalas.Add(FPhrygian);
            escalas.Add(F_Phrygian);
            escalas.Add(GPhrygian);
            escalas.Add(G_Phrygian);
            escalas.Add(APhrygian);
            escalas.Add(A_Phrygian);
            escalas.Add(BPhrygian);
            escalas.Add(CLydian);
            escalas.Add(C_Lydian);
            escalas.Add(DLydian);
            escalas.Add(D_Lydian);
            escalas.Add(ELydian);
            escalas.Add(FLydian);
            escalas.Add(F_Lydian);
            escalas.Add(GLydian);
            escalas.Add(G_Lydian);
            escalas.Add(ALydian);
            escalas.Add(A_Lydian);
            escalas.Add(BLydian);
            escalas.Add(CMixolydian);
            escalas.Add(C_Mixolydian);
            escalas.Add(DMixolydian);
            escalas.Add(D_Mixolydian);
            escalas.Add(EMixolydian);
            escalas.Add(FMixolydian);
            escalas.Add(F_Mixolydian);
            escalas.Add(GMixolydian);
            escalas.Add(G_Mixolydian);
            escalas.Add(AMixolydian);
            escalas.Add(A_Mixolydian);
            escalas.Add(BMixolydian);
            escalas.Add(CLocrian);
            escalas.Add(C_Locrian);
            escalas.Add(DLocrian);
            escalas.Add(D_Locrian);
            escalas.Add(ELocrian);
            escalas.Add(FLocrian);
            escalas.Add(F_Locrian);
            escalas.Add(GLocrian);
            escalas.Add(G_Locrian);
            escalas.Add(ALocrian);
            escalas.Add(A_Locrian);
            escalas.Add(BLocrian);

            Cescalas.Add(CMajor);
            Cescalas.Add(CMinor);
            Cescalas.Add(CDorian);
            Cescalas.Add(CPhrygian);
            Cescalas.Add(CLydian);
            Cescalas.Add(CMixolydian);
            Cescalas.Add(CLocrian);
            C_escalas.Add(C_Major);
            C_escalas.Add(C_Minor);
            C_escalas.Add(C_Dorian);
            C_escalas.Add(C_Phrygian);
            C_escalas.Add(C_Lydian);
            C_escalas.Add(C_Mixolydian);
            C_escalas.Add(C_Locrian);
            Descalas.Add(DMajor);
            Descalas.Add(DMinor);
            Descalas.Add(DDorian);
            Descalas.Add(DPhrygian);
            Descalas.Add(DLydian);
            Descalas.Add(DMixolydian);
            Descalas.Add(DLocrian);
            D_escalas.Add(D_Major);
            D_escalas.Add(D_Minor);
            D_escalas.Add(D_Dorian);
            D_escalas.Add(D_Phrygian);
            D_escalas.Add(D_Lydian);
            D_escalas.Add(D_Mixolydian);
            D_escalas.Add(D_Locrian);
            Eescalas.Add(EMajor);
            Eescalas.Add(EMinor);
            Eescalas.Add(EDorian);
            Eescalas.Add(EPhrygian);
            Eescalas.Add(ELydian);
            Eescalas.Add(EMixolydian);
            Eescalas.Add(ELocrian);
            Fescalas.Add(FMajor);
            Fescalas.Add(FMinor);
            Fescalas.Add(FDorian);
            Fescalas.Add(FPhrygian);
            Fescalas.Add(FLydian);
            Fescalas.Add(FMixolydian);
            Fescalas.Add(FLocrian);
            F_escalas.Add(F_Major);
            F_escalas.Add(F_Minor);
            F_escalas.Add(F_Dorian);
            F_escalas.Add(F_Phrygian);
            F_escalas.Add(F_Lydian);
            F_escalas.Add(F_Mixolydian);
            F_escalas.Add(F_Locrian);
            Gescalas.Add(GMajor);
            Gescalas.Add(GMinor);
            Gescalas.Add(GDorian);
            Gescalas.Add(GPhrygian);
            Gescalas.Add(GLydian);
            Gescalas.Add(GMixolydian);
            Gescalas.Add(GLocrian);
            G_escalas.Add(G_Major);
            G_escalas.Add(G_Minor);
            G_escalas.Add(G_Dorian);
            G_escalas.Add(G_Phrygian);
            G_escalas.Add(G_Lydian);
            G_escalas.Add(G_Mixolydian);
            G_escalas.Add(G_Locrian);
            Aescalas.Add(AMajor);
            Aescalas.Add(AMinor);
            Aescalas.Add(ADorian);
            Aescalas.Add(APhrygian);
            Aescalas.Add(ALydian);
            Aescalas.Add(AMixolydian);
            Aescalas.Add(ALocrian);
            A_escalas.Add(A_Major);
            A_escalas.Add(A_Minor);
            A_escalas.Add(A_Dorian);
            A_escalas.Add(A_Phrygian);
            A_escalas.Add(A_Lydian);
            A_escalas.Add(A_Mixolydian);
            A_escalas.Add(A_Locrian);
            Bescalas.Add(BMajor);
            Bescalas.Add(BMinor);
            Bescalas.Add(BDorian);
            Bescalas.Add(BPhrygian);
            Bescalas.Add(BLydian);
            Bescalas.Add(BMixolydian);
            Bescalas.Add(BLocrian);
        }

        public string[] getEscalaMusical(string tonica, string modo)
        {
            switch (tonica)
            {
                case "C":
                    switch (modo)
                    {
                        case "Major":
                            return CMajor;
                        case "Minor":
                            return CMinor;
                        case "Dorian":
                            return CDorian;
                        case "Phrygian":
                            return CPhrygian;
                        case "Lydian":
                            return CLydian;
                        case "Mixolydian":
                            return CMixolydian;
                        case "Locrian":
                            return CLocrian;
                    }
                    break;
                case "C#":
                    switch (modo)
                    {
                        case "Major":
                            return C_Major;
                        case "Minor":
                            return C_Minor;
                        case "Dorian":
                            return C_Dorian;
                        case "Phrygian":
                            return C_Phrygian;
                        case "Lydian":
                            return C_Lydian;
                        case "Mixolydian":
                            return C_Mixolydian;
                        case "Locrian":
                            return C_Locrian;
                    }
                    break;
                case "D":
                    switch (modo)
                    {
                        case "Major":
                            return DMajor;
                        case "Minor":
                            return DMinor;
                        case "Dorian":
                            return DDorian;
                        case "Phrygian":
                            return DPhrygian;
                        case "Lydian":
                            return DLydian;
                        case "Mixolydian":
                            return DMixolydian;
                        case "Locrian":
                            return DLocrian;
                    }
                    break;
                case "D#":
                    switch (modo)
                    {
                        case "Major":
                            return D_Major;
                        case "Minor":
                            return D_Minor;
                        case "Dorian":
                            return D_Dorian;
                        case "Phrygian":
                            return D_Phrygian;
                        case "Lydian":
                            return D_Lydian;
                        case "Mixolydian":
                            return D_Mixolydian;
                        case "Locrian":
                            return D_Locrian;
                    }
                    break;
                case "E":
                    switch (modo)
                    {
                        case "Major":
                            return EMajor;
                        case "Minor":
                            return EMinor;
                        case "Dorian":
                            return EDorian;
                        case "Phrygian":
                            return EPhrygian;
                        case "Lydian":
                            return ELydian;
                        case "Mixolydian":
                            return EMixolydian;
                        case "Locrian":
                            return ELocrian;
                    }
                    break;
                case "F":
                    switch (modo)
                    {
                        case "Major":
                            return FMajor;
                        case "Minor":
                            return FMinor;
                        case "Dorian":
                            return FDorian;
                        case "Phrygian":
                            return FPhrygian;
                        case "Lydian":
                            return FLydian;
                        case "Mixolydian":
                            return FMixolydian;
                        case "Locrian":
                            return FLocrian;
                    }
                    break;
                case "F#":
                    switch (modo)
                    {
                        case "Major":
                            return F_Major;
                        case "Minor":
                            return F_Minor;
                        case "Dorian":
                            return F_Dorian;
                        case "Phrygian":
                            return F_Phrygian;
                        case "Lydian":
                            return F_Lydian;
                        case "Mixolydian":
                            return F_Mixolydian;
                        case "Locrian":
                            return F_Locrian;
                    }
                    break;
                case "G":
                    switch (modo)
                    {
                        case "Major":
                            return GMajor;
                        case "Minor":
                            return GMinor;
                        case "Dorian":
                            return GDorian;
                        case "Phrygian":
                            return GPhrygian;
                        case "Lydian":
                            return GLydian;
                        case "Mixolydian":
                            return GMixolydian;
                        case "Locrian":
                            return GLocrian;
                    }
                    break;
                case "G#":
                    switch (modo)
                    {
                        case "Major":
                            return G_Major;
                        case "Minor":
                            return G_Minor;
                        case "Dorian":
                            return G_Dorian;
                        case "Phrygian":
                            return G_Phrygian;
                        case "Lydian":
                            return G_Lydian;
                        case "Mixolydian":
                            return G_Mixolydian;
                        case "Locrian":
                            return G_Locrian;
                    }
                    break;
                case "A":
                    switch (modo)
                    {
                        case "Major":
                            return AMajor;
                        case "Minor":
                            return AMinor;
                        case "Dorian":
                            return ADorian;
                        case "Phrygian":
                            return APhrygian;
                        case "Lydian":
                            return ALydian;
                        case "Mixolydian":
                            return AMixolydian;
                        case "Locrian":
                            return ALocrian;
                    }
                    break;
                case "A#":
                    switch (modo)
                    {
                        case "Major":
                            return A_Major;
                        case "Minor":
                            return A_Minor;
                        case "Dorian":
                            return A_Dorian;
                        case "Phrygian":
                            return A_Phrygian;
                        case "Lydian":
                            return A_Lydian;
                        case "Mixolydian":
                            return A_Mixolydian;
                        case "Locrian":
                            return A_Locrian;
                    }
                    break;
                case "B":
                    switch (modo)
                    {
                        case "Major":
                            return BMajor;
                        case "Minor":
                            return BMinor;
                        case "Dorian":
                            return BDorian;
                        case "Phrygian":
                            return BPhrygian;
                        case "Lydian":
                            return BLydian;
                        case "Mixolydian":
                            return BMixolydian;
                        case "Locrian":
                            return BLocrian;
                    }
                    break;
                default:
                    Console.WriteLine("\"" + tonica + " " + modo + "\" no es una escala válida");
                    break;
            }
            return null;
        }

    }
}
