using System;

namespace Exe_vetores02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] array;
            string[] s;

            N = int.Parse(Console.ReadLine());

            array = new int[N];

            s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(s[i]);
            }

            int pares = 0;

            for(int i = 0; i < N; i++)
            {
                if (array[i] % 2 == 0)
                {
                    pares++;
                    Console.Write(array[i] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine(pares);
        }
    }
}
