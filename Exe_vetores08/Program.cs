using System;
using System.Globalization;

namespace Exe_vetores08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, countM, countF;
            double menor, maior, soma, media;
            double[] alturas;
            string[] s, sexo;

            N = int.Parse(Console.ReadLine());

            alturas = new double[N];
            sexo = new string[N];

            for (int i = 0; i < N; i++)
            {
                s = Console.ReadLine().Split(' ');

                alturas[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sexo[i] = s[1];
            }

            maior = 0;
            menor = 99.99;

            for(int i = 0; i < N; i++)
            {
                if(alturas[i] > maior)
                {
                    maior = alturas[i];
                }

                if(alturas[i] < menor)
                {
                    menor = alturas[i];
                }
            }

            countF = 0;
            countM = 0;
            soma = 0.0;
            media = 0.0;

            for (int i = 0; i < N; i++)
            {
                if(sexo[i] == "M")
                {
                    countM++;
                }

                if(sexo[i] == "F")
                {
                    soma = soma + alturas[i];
                    countF++;
                }
            }

            media = soma / countF;
            Console.WriteLine("Menor altura = " + menor);
            Console.WriteLine("Maior altura = " + maior);
            Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero dos homens = " + countM);
        }

    }
}
