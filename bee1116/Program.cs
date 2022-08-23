using System;

namespace bee1116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x, y, div;
            string[] vet;


            n = int.Parse(Console.ReadLine());
            div = 0;

            for (int i = 0; i < n; i++)
            {
                vet = Console.ReadLine().Split(' ');

                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
                
                if(x == 0 || y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    div = x / y;
                    Console.WriteLine(div);
                }


            }
        }
    }
}
