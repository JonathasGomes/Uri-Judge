using System;

namespace ForEach01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            string[] vet;

            N = int.Parse(Console.ReadLine());

            vet = new string[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos:");

            foreach (string nomes in vet)
            {
                Console.WriteLine(nomes);
            }
        }
    }
}
