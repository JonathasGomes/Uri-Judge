using System;

namespace Switchcase01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;

            n1 = int.Parse(Console.ReadLine());
            string dia;

           switch (n1)
            {
                case 1: 
                    dia = "Domingo";
                    break;
                case 2: 
                    dia = "Segunda-feira";
                    break;
                case 3:
                    dia = "Terça-feira";
                    break;
                case 4:
                    dia = "Quarta-feira";
                    break;
                case 5:
                    dia ="Quinta-feira";
                    break;
                case 6:
                    dia ="Sexta-feira";
                    break;
                case 7:
                    dia = "Sabado";
                    break;

                default:
                    dia = "Valor invalido";
                    break;
            }

            Console.WriteLine("Dia da semana: " + dia);
        }
    }
}
