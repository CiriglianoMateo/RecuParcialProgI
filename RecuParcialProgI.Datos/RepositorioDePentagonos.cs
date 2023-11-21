using RecuParcialProgI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Collections.Generic;
using System.IO;

namespace RecuParcialProgI.Datos
{
    public class RepositorioDePentagonos
    {
        private readonly string _archivo = Path.Combine(Environment.CurrentDirectory, "Pentagonos.txt");
        private List<Pentagono> pentagonos;

        public RepositorioDePentagonos()
        {
            pentagonos = new List<Pentagono>();
            LeerDatosDelArchivo();
        }

        private void LeerDatosDelArchivo()
        {
            if (File.Exists(_archivo))
            {
                using (var lector = new StreamReader(_archivo))
                {
                    while (!lector.EndOfStream)
                    {
                        var lineaLeida = lector.ReadLine();
                        var pentagono = ConstruirFigura(lineaLeida);
                        pentagonos.Add(pentagono);
                    }
                }
            }
        }

        private static Pentagono ConstruirFigura(string lineaLeida)
        {
            var campos = lineaLeida.Split('|');
            if (campos.Length != 5)
            {
              
                throw new ArgumentException("La línea no tiene el formato esperado");
            }

            var ladoPentagono = int.Parse(campos[0]);
            var bordePentagono = (Borde)int.Parse(campos[1]);
            var apotema = int.Parse(campos[2]);
            var perimetro = int.Parse(campos[3]);
            var area = int.Parse(campos[4]);

            return new Pentagono
            {
                //Lado = ladoPentagono,
                //Borde = bordePentagono,
                //Apotema = apotema,
                //Perimetro = perimetro,
                //Area = area
            };
        }
    }
}







