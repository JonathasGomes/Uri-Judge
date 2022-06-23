using System;

namespace bee1131
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int novogrenal, golgremio, golinter, grenais, vitoriainter, vitoriagremio, empate;
            string[] vet; string venceumais;

            novogrenal = 1;
            grenais = 0;
            vitoriainter = 0;
            vitoriagremio = 0;
            empate = 0;

            while (novogrenal == 1)
            {

                grenais = grenais + 1;

                vet = Console.ReadLine().Split(' ');

                golinter = int.Parse(vet[0]);
                golgremio = int.Parse(vet[1]);

                if(golinter > golgremio)
                {
                    vitoriainter = vitoriainter + 1;
                }
                else if (golgremio > golinter)
                {
                    vitoriagremio = vitoriagremio + 1;
                }
                else
                {
                    empate = empate + 1;
                }

                Console.WriteLine("Novo grenal (1-Sim 2-Nao)");
                novogrenal = int.Parse(Console.ReadLine());
            }

            if(vitoriainter > vitoriagremio)
            {
                venceumais = "Inter";
            }
            else if(vitoriagremio > vitoriainter)
            {
                venceumais = "Gremio";
            }
            else
            {
                venceumais = "Não houve vencedor";
            }

            Console.WriteLine(grenais + " grenais");
            Console.WriteLine("Inter:" + vitoriainter);
            Console.WriteLine("Gremio:" + vitoriagremio);
            Console.WriteLine("Empates:" + empate);
            Console.WriteLine(venceumais + " Venceu mais");
        }
    }
}
