using System;

namespace Medesafiando03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            string[] vet;
            vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            if(A > B && A > C)
            {
                Console.WriteLine(A + " É o número maior");
            }
            else if(B > C && B > A)
            {
                Console.WriteLine(B + " É o número maior");
            }
            else
            {
                Console.WriteLine(C + " É o número maior");
            }
        }
    }
}
