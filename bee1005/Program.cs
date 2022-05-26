using System;
using System.Globalization;

namespace bee1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Media;
            float A, B;
            A = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Media = (A + B) / 2;

            Console.WriteLine("MEDIA = " + Media.ToString("F5"), CultureInfo.InvariantCulture);
        }
    }
}
