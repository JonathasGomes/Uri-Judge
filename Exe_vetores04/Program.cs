using System;
using System.Globalization;

namespace Exe_vetores04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double media, soma;
            double[] array;
            string[] s;

            N = int.Parse(Console.ReadLine());

            array = new double[N];

            s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                array[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            soma = 0.0;

            for (int i = 0; i < N; i++)
            {
                soma = soma + array[i];
            }

            media = 0.0;

            media = soma / N;

            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for(int i = 0; i < N; i++)
            {
                if(array[i] < media)
                {
                    Console.WriteLine(array[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
