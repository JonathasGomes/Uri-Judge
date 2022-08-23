using System;

namespace bee1096
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j;

            for (int i = 1; i < 10; i++)
            {
                j = 7;
                Console.Write("I=" + i);
                Console.WriteLine(" J=" + j);
                j--;
                Console.Write("I=" + i);
                Console.WriteLine(" J=" + j);
                j--;
                Console.Write("I=" + i);
                Console.WriteLine(" J=" + j);
            }
        }
    }
}
