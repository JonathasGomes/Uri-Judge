using System;

namespace ForCaderno02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 10;

            for (int i = 0; i < 4; i++)
            {
                Console.Write(i);
                y = y + i;
                Console.WriteLine(y);
            }
        }
    }
}
