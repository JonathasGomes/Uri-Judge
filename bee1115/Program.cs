using System;

namespace bee1115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            string resultado;
            string[] vet;

            vet = Console.ReadLine().Split(' ');

            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);


            while(X != 0 || Y != 0)
            {
                if(X > 0 && Y > 0)
                {
                    Console.WriteLine("primeiro");
                    vet = Console.ReadLine().Split(' ');
                }
                else if(X < 0 && Y > 0)
                {
                    Console.WriteLine("segundo");
                    vet = Console.ReadLine().Split(' ');
                }
                else if(X < 0 && Y < 0)
                {
                    Console.WriteLine("terceiro");
                    vet = Console.ReadLine().Split(' ');
                }
                else if(X > 0 && Y < 0)
                {
                    Console.WriteLine("quarto");
                    vet = Console.ReadLine().Split(' ');
                }
            }
        }
    }
}
