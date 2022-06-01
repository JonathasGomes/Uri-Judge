using System;
using System.Globalization;

namespace bee1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, reajustesalario, salarionovo;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.000)
            {
                reajustesalario = salario * 15 / 100;
                salarionovo = reajustesalario + salario;

                Console.WriteLine("Novo salario: " + salarionovo.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajustesalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario >= 400.001 && salario <= 800.000)
            {
                reajustesalario = salario * 12 / 100;
                salarionovo = reajustesalario + salario;

                Console.WriteLine("Novo salario: " + salarionovo.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajustesalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario >= 800.001 && salario <= 1200.000)
            {
                reajustesalario = salario * 10 / 100;
                salarionovo = reajustesalario + salario;

                Console.WriteLine("Novo salario: " + salarionovo.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajustesalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario >= 1200.001 && salario <= 2000.000)
            {
                reajustesalario = salario * 7 / 100;
                salarionovo = reajustesalario + salario;

                Console.WriteLine("Novo salario: " + salarionovo.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajustesalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            else
            {
                reajustesalario = salario * 4 / 100;
                salarionovo = reajustesalario + salario;

                Console.WriteLine("Novo salario: " + salarionovo.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajustesalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }


        }
    }
}
