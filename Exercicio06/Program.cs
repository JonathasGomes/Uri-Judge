using System;
using System.Globalization;

namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, notafinal;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            notafinal = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + notafinal.ToString("F1", CultureInfo.InvariantCulture));

            if (notafinal < 60.00)
            {
                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Aprovado");
            }
        }
    }
}
