using System;
using System.Globalization;

namespace Exe_vetores09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            string[] s, nome;
            double[] preçovenda, preçocompra;
            double lucro, totalvenda, totalcompra, porcentagemLucro;

            N = int.Parse(Console.ReadLine());

            nome = new string[N];
            preçovenda = new double[N];
            preçocompra = new double[N];

            for (int i = 0; i < N; i++)
            {
                s = Console.ReadLine().Split(' ');

                nome[i] = s[0];
                preçovenda[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                preçocompra[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            lucro = 0.0;
            totalcompra = 0.0;
            totalvenda = 0.0;

            for (int i = 0; i < N; i++)
            {
                lucro = lucro + (preçocompra[i] - preçovenda[i]);
                totalcompra = totalcompra + preçocompra[i];
                totalvenda = totalvenda + preçovenda[i];
            }

            int countAbaixode10 = 0;
            int countEntre10a20 = 0;
            int countAcimade20 = 0;

            porcentagemLucro = 0.0;

            for (int i = 0; i < N; i++)
            {
                porcentagemLucro = lucro / preçocompra[i] * 100;

                if (porcentagemLucro < 10.0)
                {
                    countAbaixode10++;
                }
                else if (porcentagemLucro <= 20.0)
                {
                    countEntre10a20++;
                }
                else
                {
                    countAcimade20++;
                }
            }
            Console.WriteLine("Lucro abaixo de 10%: " + countAbaixode10);
            Console.WriteLine("Lucro entre 10% e 20%: " + countEntre10a20);
            Console.WriteLine("Lucro acima de 20%: " + countAcimade20);
            Console.WriteLine("Compra total: " + totalcompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Venda total: " + totalvenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucro.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
