using System;

namespace bee1113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            string[] vet;

            vet = Console.ReadLine().Split(' ');

            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);

            while (X != Y)
            {
                if (X < Y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }

                vet = Console.ReadLine().Split(' ');

                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);
            }
        }
    }
}
