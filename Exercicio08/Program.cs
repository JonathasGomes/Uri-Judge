using System;

namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Descobrindo qual o número é menor
            int x, y, z;
            string[] vet;

            vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            if(x < y && x < z)
            {
                Console.WriteLine("MENOR = " + x);
            }
            else
            {
                if(y < z)
                {
                    Console.WriteLine("Menor = " + y);
                }
                else
                {
                    Console.WriteLine("Menor = " + z);
                }
            }
        }
    }
}
