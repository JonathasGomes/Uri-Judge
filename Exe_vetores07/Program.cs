using System;

namespace Exe_vetores07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            string[] nomes, s;
            double[] nota1, nota2, media, soma;

            N = int.Parse(Console.ReadLine());

            nomes = new string[N];
            nota1 = new double[N];
            nota2 = new double[N];
            soma = new double[N];
            media = new double[N];

            for (int i = 0; i < N; i++)
            {
                s = Console.ReadLine().Split(' ');

                nomes[i] = s[0];
                nota1[i] = double.Parse(s[1]);
                nota2[i] = double.Parse(s[2]);

                soma[i] = nota1[i] + nota2[i];

                media[i] = soma[i] / 2;
            }

            for (int i = 0; i < N; i++)
            {
                if (media[i] > 6.0)
                {
                    Console.WriteLine("Alunos aprovados:");
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}
