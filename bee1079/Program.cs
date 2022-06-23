using System;
using System.Globalization;

namespace bee1079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double valor1, valor2, valor3, media;
            string[] vet;

            N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                valor1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                valor2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                valor3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                media = (valor1 * 2.0 + valor2 * 3.0 + valor3 * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
