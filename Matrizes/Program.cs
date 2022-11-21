using System;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] A;
            string[] s;

            M = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());
            A = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(' ');
                for(int j=0; j<N; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(A[i, j] + " ");
                    Console.WriteLine();
                }
            }
        }
    }
}
