using System;
using System.Globalization;

namespace bee1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salariofixo, vendas, total;

            nome = Console.ReadLine();
            salariofixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = salariofixo + (vendas * 15.0 / 100);

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
