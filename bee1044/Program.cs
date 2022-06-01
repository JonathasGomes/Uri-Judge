using System;

namespace bee1044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            string[] vet;


            vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);


            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São multiplos");

            }
            else
            {

                Console.WriteLine("Não são multiplos");
            }


        }
    }
}
