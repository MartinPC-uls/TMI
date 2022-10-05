using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TMI_Project.Analisis
{
    public class Afinador
    {
        AnalizadorFrecuencias analizadorFrecuencias;
        public Afinador()
        {
            analizadorFrecuencias = new AnalizadorFrecuencias();
        }
        public void ObtenerFrecuencia(double[] vals)
        {
            Complex[] _vals = new Complex[vals.Length];
            for (int i = 0; i < vals.Length; i++)
            {
                _vals[i] = new Complex(vals[i], 0);
            }
            //analizadorFrecuencias.HannWindow(ref _vals);
            Complex[] frecuencias = analizadorFrecuencias.FFT(_vals);
            //double pick = analizadorFrecuencias.GetPick(frecuencias, _vals.Length, 44100);
            //Console.WriteLine(pick);
        }
    }
}
