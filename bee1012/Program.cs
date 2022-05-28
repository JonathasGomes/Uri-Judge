using System;
using System.Globalization;

namespace bee1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO;
            string[] vet;
            
            vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            TRIANGULO = A * C / 2.0;
            CIRCULO = 3.14159 * Math.Pow(C, 2.0);
            TRAPEZIO = (A + B) * C / 2.0;
            QUADRADO = Math.Pow(B, 2.0);
            RETANGULO = A * B;

            Console.WriteLine("TRIANGULO = " + TRIANGULO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO = " + CIRCULO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO = " + TRAPEZIO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO = " + QUADRADO.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO = " + RETANGULO.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
