using System;
using System.Globalization;

namespace bee1040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media, exame, mediaexame;
            string[] vet;

            vet = Console.ReadLine().Split(' ');

            n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            n4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

            media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));


            if (media > 7.0)
            {
                Console.WriteLine("Aprovado");
            }
            else if (media > 5.0 && media < 6.9)
            {
                Console.WriteLine("Aluno em exame.");

                exame = double.Parse(Console.ReadLine());

                Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));

                mediaexame = (media + exame) / 2;

                if(mediaexame > 5.0)
                {
                    Console.WriteLine("Aluno aprovado");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado");
                }
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

        }
    }
}
