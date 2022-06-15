using System;

namespace While02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y , i;
            x = 4;
            y = 0;
            i = 0;


            while (i < x)
            {
                i = i + 1;
                y = y + 1;

                Console.Write(i);
                Console.WriteLine(y);
            }
        }
    }
}
