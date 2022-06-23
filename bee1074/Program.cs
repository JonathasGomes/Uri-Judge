using System;

namespace bee1074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, X;

            N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());

                if(i % 2 == 0 && X > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (i % 2 == 0 && X < 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else if (i % 2 != 0 && X > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (i % 2 != 0 && X < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else
                {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}
