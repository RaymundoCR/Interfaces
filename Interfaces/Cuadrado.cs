using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Cuadrado : IFigura
    {
        string nombre { get; set; }
        double x { get; set; }

        public Cuadrado (string nombre,double x)
        {
            this.nombre = nombre;
            this.x = x;

        }
        public double Area()
        {
            double area = x * x;
            return area;
        }

        public double Perimetro()
        {
            double perimetro = x * 4;
            return perimetro;
        }

        public string Nombre()
        {
            return nombre;
        }
    }
}
