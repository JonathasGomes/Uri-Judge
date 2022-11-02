using System;
using System.Globalization;

namespace Vetores02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, SOMA;
            double[] VET;

            N = int.Parse(Console.ReadLine());
            VET = new double[N];

            string[] s = Console.ReadLine().Split(' ');
            for(int i = 0; i < N; i++)
            {
                VET[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for(int i = 0; i < N; i++)
            {
                Console.Write(VET[i] + " ");
            }
            Console.WriteLine();

            double soma = 0.0;
            double media = 0.0;

            for(int i = 0; i < N; i++)
            {
                soma = soma + VET[i];
            }

            for (int i = 0; i < N; i++)
            {
                media = soma / N;
            }

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
