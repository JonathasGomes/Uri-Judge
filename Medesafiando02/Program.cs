using System;
using System.Globalization;

namespace Medesafiando02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, total;

            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            total = n1 + n2 + n3;

            if(total <= 10.00)
            {
                Console.WriteLine("Total é menor q 10.00");
            }
            else if(total >= 10.01 && total <= 20.00)
            {
                Console.WriteLine("Total é maior ou igual a 10.01 e menor ou igual a 20.00");
            }
            else if(total >= 20.01 && total <= 30.00)
            {
                Console.WriteLine("Total é maior ou igual a 20.01 e menor ou igual a 30.00");
            }
            else
            {
                Console.WriteLine("Total é maior que 30.00");
            }

            Console.WriteLine("O Total é = " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
