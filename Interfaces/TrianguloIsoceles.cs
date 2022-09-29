using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class TrianguloIsoceles : IFigura
    {
        string nombre { get; set; }
        double a { get; set; }
        double b { get; set; }
        double h { get; set; }

        public TrianguloIsoceles(string nombre,double a, double b)
        {
            this.nombre = nombre;
            this.a = a;
            this.b = b;
        }

        public double Area()
        {
            double hSr = (a * 2f) - ((b * 2f) / 4f);
            h = Math.Sqrt(hSr);
            double area = ((b * h) / 2f);
            return area;
        }

        public double Perimetro()
        {
            double perimetro = (a * 2f) + b;
            return perimetro;
        }
        public string Nombre()
        {
            return nombre;
        }
    }
}
