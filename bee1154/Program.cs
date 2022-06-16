using System;

namespace bee1154
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media, idade, idadetodos, count; ;

            media = 0;
            count = 0;
            idadetodos = 0;

            idade = int.Parse(Console.ReadLine());

            while(idade > 1)
            {
                count = count + 1;
                idadetodos = idadetodos + idade;

                idade = int.Parse(Console.ReadLine());
            }

            media = idadetodos / count;

            Console.WriteLine(media);
        }
    }
}
