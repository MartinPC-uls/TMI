using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using TMI_Project.Grabacion;

namespace TMI_Project
{
    public class Armonicos
    {
        /* Fuente: https://miguitarraelectrica.com/frecuencias-sonidos-armonicos/
            1   Fundamental
            2   Octava
            3   Quinta
            4   Octava
            5   Tercera mayor
            6   Quinta
            7   Séptima menor
            8   Octava
            9   Segunda mayor
            10  Tercera mayor
            11  Cuarta aumentada
            12  Quinta justa
            13  Sexta mayor
            14  Séptima menor
            15  Séptima mayor
            16  Octava
         */

        public double FrecuenciaDominante { get; set; }
        public Complex[] Frame { get; set; }
        public int[] Armonico { get; set; }
        public Audio audio { get; set; }
        public double Promedio { get; set; }

        public Armonicos(Complex[] frame, double frecuenciaDominante, Audio audio, double average)
        {
            this.audio = audio;
            Frame = frame;
            FrecuenciaDominante = frecuenciaDominante;
            Promedio = average;
            Armonico = GetArmonicos();
        }

        private int[] GetArmonicos()
        {
            Frecuencias[] frqs = new Frecuencias[Frame.Length / 2];
            for (int i = 0; i < Frame.Length / 2; i++)
            {
                frqs[i] = new Frecuencias { Freqbin = i, Amplitude = Frame[i].Magnitude };
            }
            var _f = frqs.OrderByDescending(amp => amp.Amplitude);
            int j = 0;
            NotasMusicales nm = new NotasMusicales();
            List<int> notas = new List<int>();
            foreach (Frecuencias f in _f)
            {
                if (f.Amplitude >= Promedio && j <= 20) // TODO cambiar este condicional para sacar el número de armónicos
                {
                    double freq = Math.Round((double)f.Freqbin * audio.SampleRate / Frame.Length, 2, MidpointRounding.AwayFromZero);
                    string nota = BuscarPor(FrecuenciaDominante, freq);
                    //Console.WriteLine("Agregando: " + nota);
                    notas.Add(nm.GetNota(nota));
                }

                j++;
            }
            return notas.ToArray();
        }

        private string BuscarPor(double freq, double nextFreq)
        {
            /*
             * 1: C     7:  F#
             * 2: C#    8:  G
             * 3: D     9:  G#
             * 4: D#    10: A
             * 5: E     11: A#
             * 6: F     12: B
             */
            NotasMusicales nm = new NotasMusicales();
            int nota = nm.GetNota(freq);
            int nextNota = nm.GetNota(nextFreq);
            switch (nota)
            {
                case 1: // C
                    if (nextNota == 8) // Quinta = G
                    {
                        //nm.add("G", 2);
                        return "G";
                    } else if (nextNota == 5) // Tercera Mayor = E
                    {
                        //nm.add("E", 2);
                        return "E";
                    } else if (nextNota == 4) // Tercera menor = D#
                    {
                        //nm.add("D#", 2);
                        return "D#";
                    }
                    break;
                case 2: // C#
                    if (nextNota == 9) // Quinta = G#
                    {
                        //nm.add("G#", 2);
                        return "G#";
                    } else if (nextNota == 6) // Tercera Mayor = F
                    {
                        return "F";
                        //nm.add("F", 2);
                    } else if (nextNota == 5) // Tercera menor = E
                    {
                        return "E";
                        //nm.add("E", 2);
                    }
                    break;
                case 3: // D
                    if (nextNota == 10) // Quinta = A
                    {
                        return "A";
                        //nm.add("A", 2);
                    } else if (nextNota == 7) // Tercera Mayor = F#
                    {
                        return "F#";
                        //nm.add("F#", 2);
                    } else if (nextNota == 6) // Tercera menor = F
                    {
                        return "F";
                        //nm.add("F", 2);
                    }
                    break;
                case 4: // D#
                    if (nextNota == 11) // Quinta = A#
                    {
                        return "A#";
                        //nm.add("A#", 2);
                    } else if (nextNota == 8) // Tercera Mayor = G
                    {
                        return "G";
                        //nm.add("G", 2);
                    } else if (nextNota == 7) // Tercera menor = F#
                    {
                        return "F#";
                        //nm.add("F#", 2);
                    }
                    break;
                case 5: // E
                    if (nextNota == 12) // Quinta = B
                    {
                        return "B";
                        //nm.add("B", 2);
                    } else if (nextNota == 9) // Tercera Mayor = G#
                    {
                        return "G#";
                        //nm.add("G#", 2);
                    } else if (nextNota == 8) // Tercera menor = G
                    {
                        return "G";
                        //nm.add("G", 2);
                    }
                    break;
                case 6: // F
                    if (nextNota == 1) // Quinta = C
                    {
                        return "C";
                        //nm.add("C", 2);
                    } else if (nextNota == 10) // Tercera Mayor = A
                    {
                        return "A";
                        //nm.add("A", 2);
                    } else if (nextNota == 9) // Tercera Menor = G#
                    {
                        return "G#";
                        //nm.add("G#", 2);
                    }
                    break;
                case 7: // F#
                    if (nextNota == 2) // Quinta = C#
                    {
                        return "C#";
                        //nm.add("C#", 2);
                    } else if (nextNota == 11) // Tercera Mayor = A#
                    {
                        return "A#";
                        //nm.add("A#", 2);
                    } else if (nextNota == 10) // Tercera menor = A
                    {
                        return "A";
                        //nm.add("A", 2);
                    }
                    break;
                case 8: // G
                    if (nextNota == 3) // Quinta = D
                    {
                        return "D";
                        //nm.add("D", 2);
                    } else if (nextNota == 12) // Tercera Mayor = B
                    {
                        return "B";
                        //nm.add("B", 2);
                    } else if (nextNota == 11) // Tercera menor = A#
                    {
                        return "A#";
                        //nm.add("A#", 2);
                    }
                    break;
                case 9: // G#
                    if (nextNota == 4) // Quinta = D#
                    {
                        return "D#";
                        //nm.add("D#", 2);
                    } else if (nextNota == 1) // Tercera Mayor = C
                    {
                        return "C";
                        //nm.add("C", 2);
                    } else if (nextNota == 12) // Tercera menor = B
                    {
                        return "B";
                        //nm.add("B", 2);
                    }
                    break;
                case 10: // A
                    if (nextNota == 5) // Quinta = E
                    {
                        return "E";
                        //nm.add("E", 2);
                    } else if (nextNota == 2) // Tercera Mayor = C#
                    {
                        return "C#";
                        //nm.add("C#", 2);
                    } else if (nextNota == 1) // Tercera menor = C
                    {
                        return "C";
                        //nm.add("C", 2);
                    }
                    break;
                case 11: // A#
                    if (nextNota == 6) // Quinta = F
                    {
                        return "F";
                        //nm.add("F", 2);
                    } else if (nextNota == 3) // Tercera Mayor = D
                    {
                        return "D";
                        //nm.add("D", 2);
                    } else if (nextNota == 2) // Tercera menor = C#
                    {
                        return "C#";
                        //nm.add("C#", 2);
                    }
                    break;
                case 12: // B
                    if (nextNota == 7) // Quinta = F#
                    {
                        return "F#";
                        //nm.add("F#", 2);
                    } else if (nextNota == 4) // Tercera Mayor = D#
                    {
                        return "D#";
                        //nm.add("D#", 2);
                    } else if (nextNota == 3) // Tercera menor = D
                    {
                        return "D";
                        //nm.add("D", 2);
                    }
                    break;
                default: // Cualquier nota
                    return null;
            }
            return null;
        }
    }
}
