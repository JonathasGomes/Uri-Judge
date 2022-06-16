using System;

namespace bee1134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, alcool, gasolina, diesel;

            num = int.Parse(Console.ReadLine());

            alcool = 0;
            gasolina = 0;
            diesel = 0;

            while (num != 4)
            {

                if (num == 1)
                {
                    alcool = alcool + 1;
                }
                else if (num == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (num == 3)
                {
                    diesel = diesel + 1;
                }

                num = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}
