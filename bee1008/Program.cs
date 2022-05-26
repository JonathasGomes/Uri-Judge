using System;
using System.Globalization;

namespace bee1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int QntHorasTrabalhadas, Number;
            double ValorHora, Salario;

            Number = int.Parse(Console.ReadLine());
            QntHorasTrabalhadas = int.Parse(Console.ReadLine());
            ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Salario = QntHorasTrabalhadas * ValorHora;

            Console.WriteLine("NUMBER = " + Number);
            Console.WriteLine("SALARY = U$ " + Salario.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
