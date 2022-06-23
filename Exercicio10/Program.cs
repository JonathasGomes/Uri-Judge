using System;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, Resultado;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Resultado = N * i;
                Console.WriteLine(i + " x " + N + " = " + Resultado);
            }
        }
    }
}
