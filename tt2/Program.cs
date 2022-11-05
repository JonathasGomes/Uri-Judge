using System;

namespace tt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 7, count;
            double[] array;
            double menor, maior, media, soma;
            array = new double[7];

            array[0] = 10.458; array[1] = 15.356; array[2] = 13.402;
            array[3] = 20.123; array[4] = 18.965; array[5] = 0; array[6] = 0;

            count = 0;
            maior = 0.0;
            menor = 100.000;
            soma = 0.0;
            media = 0.0;

            for (int i = 0; i < N; i++)
            {
                soma = soma + array[i];

                if (array[i] != 0)
                {
                    count++;
                }
            }

            for (int i = 0; i < N; i++)
            {
                if(array[i] < menor && array[i] > 0)
                {
                    menor = array[i];
                }
                if(array[i] > maior)
                {
                    maior = array[i];
                }
            }

            media = soma / count;
            Console.WriteLine(maior);
            Console.WriteLine(menor);
            Console.WriteLine(soma);
            Console.WriteLine(media);
        }
    }
}
