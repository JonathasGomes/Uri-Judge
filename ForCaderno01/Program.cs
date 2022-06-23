using System;

namespace ForCaderno01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = x + 2;

            for (int i = 0; i < x; i++)
            {
                Console.Write(x + " " + y);
                y = y + i;
            }
        }
    }
}
