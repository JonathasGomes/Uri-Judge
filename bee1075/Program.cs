using System;

namespace bee1075
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N;

            N = int.Parse(Console.ReadLine());

            for(int i = 0; i < 1000; i++)
            {
                if(i % N == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
