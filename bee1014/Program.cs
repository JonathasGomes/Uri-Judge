using System;
using System.Globalization;

namespace bee1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, Gasto;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Gasto = X / Y;

            Console.WriteLine(Gasto.ToString("F3"), CultureInfo.InvariantCulture + "km/l");
        }
    }
}
