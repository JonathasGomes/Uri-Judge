using System;

namespace Exe_vetores06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, maior;
            string maisvelho;
            string[] nomes, s;
            int[] idades;

            N = int.Parse(Console.ReadLine());

            nomes = new string[N];
            idades = new int[N];

            maior = 0;

            maisvelho = "";

            for(int i = 0; i < N; i++)
            {
                s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);

                if (idades[i] > maior)
                {
                    maior = idades[i];
                    maisvelho = nomes[i];
                }
            }

            Console.WriteLine("Pessoa mais velha: " + maisvelho);
        }
    }
}
