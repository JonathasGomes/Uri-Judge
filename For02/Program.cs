using System;

namespace For02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Valor de i decrescente");
            for (int i = 5; i>=0; i--)
            {
                Console.WriteLine("Valor de i " + i);
            }

            Console.WriteLine();

            Console.WriteLine("Valor de z crescente");
            for (int z = 0; z <= 5 ; z++)
            {
                Console.WriteLine("Valor de z " + z);
            }
        }
    }
}
