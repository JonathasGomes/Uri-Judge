using System;
using System.Globalization;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math.Sqrt = Raiz quadrada
            //Math.Pow = Elevado

            double Base, Altura, Area, Perimetro, Diagonal;

            Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = Base * Altura;
            Perimetro = 2 * Base + 2 * Altura;
            Diagonal = Math.Sqrt(Math.Pow(Base, 2.0) + Math.Pow(Altura, 2.0));

            Console.WriteLine("Area = " + Area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + Perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + Diagonal.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
