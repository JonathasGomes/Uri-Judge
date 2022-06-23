using System;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x, soma;

            n = int.Parse(Console.ReadLine());

            soma = 0;
            for (int i = 1; i <= n; i = i + 1 )
            {
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }

            Console.WriteLine(soma);
        }
    }
}
