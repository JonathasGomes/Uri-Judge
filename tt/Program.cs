using System;

namespace tt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n1 = 0, n2 = 1, n3 = 0;

            Console.WriteLine("Digite um número");
            i = int.Parse(Console.ReadLine());

            while(i > n3)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }

            if(i == n3)
            {
                Console.WriteLine("O número " + i + " faz parte da sequência de fibonacci");
            }
            else
            {
                Console.WriteLine("Esse número não faz parte da sequência de fibonacci");
            }
        }
    }
}
