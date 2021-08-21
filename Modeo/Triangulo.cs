using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeo
{
    public class Triangulo : Figura
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public int CalcularArea(int base1, int altura)
        {
            return (base1*altura)/2;
        }

        public double CalcularArea(int a, int b, int c)
        {
            int s = (a + b + c) / 2;
            return Math.Sqrt(s*(s - a)*(s - b)*(s - c));
        }




    }
}
