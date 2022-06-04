using System;

namespace bee1037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double intervalo;
            string resultado;

            intervalo = double.Parse(Console.ReadLine());

            if(intervalo >= 0 && intervalo <= 25.00)
            {
                resultado = "[0,25]";
            }
            else if(intervalo >= 25.01 && intervalo <= 50.00)
            {
                resultado = "(25,50]";
            }
            else if (intervalo >= 50.01 && intervalo <= 75.00)
            {
                resultado = "(50,75]";
            }
            else if(intervalo >= 75.01 && intervalo <= 100.00)
            {
                resultado = "(75,100]";
            }
            else
            {
                resultado = "Fora de intervalo";
            }

            Console.WriteLine("Intervalo: " + resultado);
        }
    }
}
