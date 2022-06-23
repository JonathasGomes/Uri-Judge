using System;

namespace ForCaderno03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 0;

            for (int i = 0; i < x; i++)
            {
                Console.Write(i);
                Console.WriteLine(x);
                y = y + 10;
            }
        }
    }
}
