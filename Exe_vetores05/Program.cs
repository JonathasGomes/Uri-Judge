using System;
using System.Globalization;

namespace Exe_vetores05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            string[] s;
            double[] array;
            double media, soma;
            int count;

            N = int.Parse(Console.ReadLine());

            array = new double[N];

            s = Console.ReadLine().Split(' ');

            soma = 0.0;
            count = 0;

            for(int i = 0; i < N; i++)
            {
                array[i] = double.Parse(s[i]);

                if(array[i] % 2 == 0)
                {
                    soma = soma + array[i];
                    count++;
                }
            }
            media = soma / count;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
