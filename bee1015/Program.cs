using System;
using System.Globalization;

namespace bee1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, total1, total2;
            string[] p1, p2;

            p1 = Console.ReadLine().Split(' ');
            x1 = double.Parse(p1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(p1[1], CultureInfo.InvariantCulture);

            p2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(p2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(p2[1], CultureInfo.InvariantCulture);


            total1 = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(total1.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
