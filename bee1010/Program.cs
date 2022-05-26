using System;
using System.Globalization;

namespace bee1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CodigoPeca, CodigoPeca2, QntPeca, QntPeca2;
            double ValorPeca, ValorPeca2, ValorTotal;

            CodigoPeca = int.Parse(Console.ReadLine());
            QntPeca = int.Parse(Console.ReadLine());
            ValorPeca = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CodigoPeca2 = int.Parse(Console.ReadLine());
            QntPeca2 = int.Parse(Console.ReadLine());
            ValorPeca2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            ValorTotal = (QntPeca * ValorPeca) + (QntPeca2 * ValorPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + ValorTotal.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
