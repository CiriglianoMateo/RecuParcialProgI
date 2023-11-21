using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RecuParcialProgI.Entidades
{
        public class Pentagono
        {
            public int GetLado { get; set; }
            public Borde Borde { get; set; }
            public double GetAapotema => Math.Sqrt(Math.Pow(GetLado, 2) - Math.Pow(GetLado / 2.0, 2));
            public int Perimetro => 5 * GetLado;
            public double Area => (Perimetro * GetAapotema) / 2;
        }
    }


