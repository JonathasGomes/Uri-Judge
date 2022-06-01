using System;

namespace bee1049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipo1, tipo2, tipo3;

            tipo1 = Console.ReadLine();

            if(tipo1 == "vertebrado")
            {
                tipo2 = Console.ReadLine();

                if (tipo2 == "ave")
                {
                    tipo3 = Console.ReadLine();

                    if (tipo3 == "carnivoro")
                    {
                        Console.WriteLine("Aguia");
                    }
                    else if (tipo3 == "onivoro")
                    {
                        Console.WriteLine("Pomba");
                    }

                }
                else if(tipo2 == "mamifero")
                {
                    tipo3 = Console.ReadLine();

                    if (tipo3 == "onivoro")
                    {
                        Console.WriteLine("Homem");
                    }
                    else if(tipo3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }

                }

            }
            else if(tipo1 == "invertebrado")
            {
                tipo2 = Console.ReadLine();

                if (tipo2 == "inseto")
                {
                    tipo3 = Console.ReadLine();

                    if (tipo3 == "hematofago")
                    {
                        Console.WriteLine("Pulga");
                    }
                    else if (tipo3 == "herbivoro")
                    {
                        Console.WriteLine("Lagarta");
                    }
                }
                else if (tipo2 == "anelideo")
                {
                    tipo3 = Console.ReadLine();

                    if (tipo3 == "hematofago")
                    {
                        Console.WriteLine("Sanguessuga");
                    }
                    else if (tipo3 == "onivoro")
                    {
                        Console.WriteLine("Minhoca");
                    }
                }
            }


        }
    }
}
