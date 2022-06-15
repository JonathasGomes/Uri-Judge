using System;

namespace bee1114
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha;

            senha = int.Parse(Console.ReadLine());

            while(senha > 0)
            {
                if (senha == 2002)
                {
                    Console.WriteLine("Acesso permitido");
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }

                senha = int.Parse(Console.ReadLine());
            }


        }
    }
}
