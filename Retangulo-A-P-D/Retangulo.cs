using System;
using System.Collections.Generic;
using System.Text;

namespace Retangulo_A_P_D
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area() {

            return Largura * Altura;
        }
        public double Perimetro() {
        
            return 2 * (Largura + Altura);
        }
        public double Diagonal() {
       
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }
    }
}
