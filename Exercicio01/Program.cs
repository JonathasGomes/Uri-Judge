using System;
using System.Globalization;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Largura, Comprimento, Metro, Area, Preco;

            Console.WriteLine("Insira o valor da largura do terreno: ");
            Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor do comprimento do terreno: ");
            Comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor do metro quadrado do terreno: ");
            Metro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = Largura * Comprimento;
            Preco = Area * Metro;

            Console.WriteLine(Area);
            Console.WriteLine(Preco);
        }
    }
}
