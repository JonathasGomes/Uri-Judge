using System;

namespace bee1094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, Quantia, Rato, Sapo, Coelho, Total;
            double PorcentagemRato, PorcentagemSapo, PorcentagemCoelho;
            string Tipo;
            string[] vet;

            N = int.Parse(Console.ReadLine());
            Rato = 0;
            Sapo = 0;
            Coelho = 0;

            for(int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                Quantia = int.Parse(vet[0]);
                Tipo = vet[1];

                if (Quantia >= 1 && Quantia <= 15)
                {
                    if(Tipo == "R")
                    {
                        Rato = Rato + Quantia;
                    }
                    if (Tipo == "S")
                    {
                        Sapo = Sapo + Quantia;
                    }
                    if (Tipo == "C")
                    {
                        Coelho = Coelho + Quantia;
                    }
                }
            }

            Total = Rato + Sapo + Coelho;
            PorcentagemRato = Rato / Total * 100.0;
            PorcentagemSapo = Sapo / Total * 100.0;
            PorcentagemCoelho = Coelho / Total * 100.0;

            Console.WriteLine("Total: " + Total + " Cobaias");
            Console.WriteLine("Total de coelhos: " + Coelho);
            Console.WriteLine("Total de ratos: " + Rato);
            Console.WriteLine("Total de sapos: " + Sapo);
            Console.WriteLine("Total de coelhos: " + Coelho);
            Console.WriteLine("Total de ratos: " + Rato);
            Console.WriteLine("Percentual de rato: " + PorcentagemRato + " %");
            Console.WriteLine("Percentual de sapo: " + PorcentagemSapo + " %");
            Console.WriteLine("Percentual de coelho: " + PorcentagemCoelho + " %");
        }
    }
}
