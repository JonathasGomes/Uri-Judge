using System;

namespace bee1072
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, X, dentro, fora;

            N = int.Parse(Console.ReadLine());

            dentro = 0;
            fora = 0;

            for(int i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());

                if(X >= 10 && X <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}
