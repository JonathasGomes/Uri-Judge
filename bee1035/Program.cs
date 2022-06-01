using System;

namespace bee1035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D,Somacd, Somaab;
            string[] vet;

            vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            D = int.Parse(vet[3]);

            Somaab = A + B;
            Somacd = C + D;

            if(B > C && D > A)
            {
                if(Somacd > Somaab)
                {
                    if(A%2 == 0)
                    {
                        Console.WriteLine("Valores aceito");
                    }
                }
            }
            else
            {
                Console.WriteLine("Valores não aceito");
            }

        }
    }
}
