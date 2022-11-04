using System;

namespace Exe_vetores03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] A, B, C;
            string[] SA, SB;
            N = int.Parse(Console.ReadLine());

            A = new int[N];
            B = new int[N];
            C = new int[N];

            SA = Console.ReadLine().Split(' ');
            SB = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(SA[i]);
                B[i] = int.Parse(SB[i]);
            }
            
            for(int i = 0; i < N; i++)
            {
                C[i] = A[i] + B[i];
            }

            for(int i = 0; i < N; i++)
            {
                Console.Write(C[i] + " ");
            }
        }
    }
}
