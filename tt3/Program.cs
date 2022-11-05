using System;
using System.Globalization;

namespace tt3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sp, rj, mg, es, outros, total, persp, perrj,
                permg, peres, peroutros;

            sp = 67.83643; rj = 36.67866; mg = 29.22988; es = 27.16548;
            outros = 19.84953;

            total = sp + rj + mg + es + outros;

            persp = (sp / total) * 100;
            perrj = (rj / total) * 100;
            permg = (mg / total) * 100;
            peres = (es / total) * 100;
            peroutros = (outros / total) * 100;

            Console.WriteLine("Percentual SP: " + persp.ToString("F1", CultureInfo.InvariantCulture) + "%");
            Console.WriteLine("Percentual RJ: " + perrj.ToString("F1", CultureInfo.InvariantCulture) + "%");
            Console.WriteLine("Percentual MG: " + permg.ToString("F1", CultureInfo.InvariantCulture) + "%");
            Console.WriteLine("Percentual ES: " + peres.ToString("F1", CultureInfo.InvariantCulture) + "%");
            Console.WriteLine("Percentual OUTROS: " + peroutros.ToString("F1", CultureInfo.InvariantCulture) + "%");
        }
    }
}
