using System;

namespace bee1045
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            string[] vet;

            vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);


            if(A >= B + C)
            {
                Console.WriteLine("Não forma triangulo");
            }
            else if (Math.Pow(A, 2.0) == Math.Pow(B, 2.0) + Math.Pow(C, 2.0))
            {
                Console.WriteLine("Triangulo retangulo");
            }
            else if (Math.Pow(A, 2.0) > Math.Pow(B, 2.0) + Math.Pow(C, 2.0))
            {
                Console.WriteLine("Triangulo obtusangulo");
            }
            else 
            {
                Console.WriteLine("Triangulo acutangulo");
            }

            if(A == B && B == C)
            {
                Console.WriteLine("Triangulo equilatero");
            }
            else if (A == B || B == C || A == C)
            {
                Console.WriteLine("Triangulo retangulo");
            }

        }
    }
}
