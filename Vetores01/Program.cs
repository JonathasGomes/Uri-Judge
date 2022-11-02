using System;

namespace Vetores01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] vet;
            string[] s;

            N = int.Parse(Console.ReadLine());
            vet = new int[N];


            s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

            for(int i = 0; i < N; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}
