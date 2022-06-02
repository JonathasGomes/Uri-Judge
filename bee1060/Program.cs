using System;
using System.Globalization;

namespace bee1060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, n6, count;

            count = 0;

            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());
            n4 = double.Parse(Console.ReadLine());
            n5 = double.Parse(Console.ReadLine());
            n6 = double.Parse(Console.ReadLine());

            if (n1 > 0)
            {
                count++;
            }

            if(n2 > 0)
            {
                count++;
            }

            if(n3 > 0)
            {
                count++;
            }

            if (n4 > 0)
            {
                count++;
            }

            if (n5 > 0)
            {
                count++;
            }

            if (n6 > 0)
            {
                count++;
            }
            Console.WriteLine(count + " valores positivos");
        }
    }
}
