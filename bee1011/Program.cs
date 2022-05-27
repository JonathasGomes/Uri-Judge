using System;
using System.Globalization;

namespace bee1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R, PI, Volume;
            PI = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Volume = (4.0 / 3) * PI * Math.Pow(R, 3.0);

            Console.WriteLine("VOLUME = " + Volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
