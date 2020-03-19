using System;

namespace LatihanPercabanganIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 13;
            b = 23;

            if (a > b)
            {
                Console.WriteLine("a > b");
            } else if (a < b)
            {
                Console.WriteLine("a < b");
            } else
            {
                Console.WriteLine("a = b");
            }
        }
    }
}
