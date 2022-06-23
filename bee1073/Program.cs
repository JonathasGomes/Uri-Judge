using System;

namespace bee1073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double N, resultado;

            N = int.Parse(Console.ReadLine());

            resultado = 0;
            for (int i = 1; i <= N; i++)
            {
                //Encontrar pares
                if(i % 2 == 0)
                {
                    resultado = Math.Pow(i, 2);
                    Console.WriteLine(i + "^" + 2 + " = " + resultado);
                }
            }
        }
    }
}
