using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMI_Project;

namespace PruebasMGE
{
    public class TestGeneradorEscala
    {
        private readonly string C = "C";
        private readonly string C_ = "C#";
        private readonly string D = "D";
        private readonly string D_ = "D#";
        private readonly string E = "E";
        private readonly string F = "F";
        private readonly string F_ = "F#";
        private readonly string G = "G";
        private readonly string G_ = "G#";
        private readonly string A = "A";
        private readonly string A_ = "A#";
        private readonly string B = "B";

        private readonly GeneradorEscala generadorEscala;
        private readonly EscalasMusicales escalasMusicales;
        public TestGeneradorEscala()
        {
            escalasMusicales = new EscalasMusicales();
            generadorEscala = new GeneradorEscala();
        }
        [Fact]

        public void MostrarEscalaMusical()
        {
            string[] escala = { C, D, E, F, G, A, B};
            
            
        }
    }
}
