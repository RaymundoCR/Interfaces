using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cuadrado C1 = new Cuadrado();
            //C1.Area();
            //C1.Perimetro();
            //TrianguloIsoceles T1 = new TrianguloIsoceles();
            //T1.Area();
            //T1.Perimetro();
            IFigura[] figuras = new IFigura[2];
            Console.WriteLine("Inserta la medida de cuadrado");
            string nombreC = "Cuadrado";
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Inserte la medida de los lados iguales del triangulo");
            string nombreT = "Triangulo";
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserte la medida de la base del triangulo");
            double b = Convert.ToDouble(Console.ReadLine());
            figuras[0] = new Cuadrado(nombreC,x);
            figuras[1] = new TrianguloIsoceles(nombreT,a, b);
            foreach (var f in figuras)
            {
                Console.WriteLine($"El area del {f.Nombre()} es: {f.Area()}");
                Console.WriteLine($"El perimetro del {f.Nombre()}es: {f.Perimetro()}");
            }
            Console.ReadKey();
        }
    }
}
