using System;

namespace LatihanOperatorOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(7.0 < 5.1);   // output: False
            Console.WriteLine(5.1 < 5.1);   // output: False
            Console.WriteLine(0.0 < 5.1);   // output: True

            Console.WriteLine(7.0 > 5.1);   // output: True
            Console.WriteLine(5.1 > 5.1);   // output: False
            Console.WriteLine(0.0 > 5.1);   // output: False

            Console.WriteLine(7.0 <= 5.1);   // output: False
            Console.WriteLine(5.1 <= 5.1);   // output: True
            Console.WriteLine(0.0 <= 5.1);   // output: True

            Console.WriteLine(7.0 >= 5.1);   // output: True
            Console.WriteLine(5.1 >= 5.1);   // output: True
            Console.WriteLine(0.0 >= 5.1);   // output: False
        }
    }
}
