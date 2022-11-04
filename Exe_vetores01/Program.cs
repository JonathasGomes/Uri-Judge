using System;
using System.Globalization;

namespace Exe_vetores01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] array;
            string[] s;

            N = int.Parse(Console.ReadLine());

            array = new double[N];

            s = Console.ReadLine().Split(' ');

            for(int i = 0; i < N; i++)
            {
                array[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            double maior = 0.0;
            int posicao = 0;

            for (int i = 0; i < N; i++)
            {
                if(array[i] > maior)
                {
                    maior = array[i];
                    posicao = i;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
        }
    }
}
