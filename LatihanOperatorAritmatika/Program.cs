using System;

namespace LatihanOperatorAritmatika
{
    class Program
    {
        static void Main(string[] args)
        {
            // unary -- start
            int i = 3;
            Console.WriteLine(i);   // output: 3
            Console.WriteLine(i++); // output: 3
            Console.WriteLine(i);   // output: 4

            double a = 1.5;
            Console.WriteLine(a);   // output: 1.5
            Console.WriteLine(++a); // output: 2.5
            Console.WriteLine(a);   // output: 2.5

            Console.WriteLine(+4);     // output: 4
            Console.WriteLine(-4);     // output: -4
            Console.WriteLine(-(-4));  // output: 4
            // unary -- end

            //binary -- start
            Console.WriteLine(13 / 5.0);       // output: 2.6

            int x = 13;
            int y = 5;
            Console.WriteLine((double)x / y);  // output: 2.6

            Console.WriteLine(5 % 4);   // output: 1
            Console.WriteLine(5 % -4);  // output: 1
            Console.WriteLine(-5 % 4);  // output: -1
            Console.WriteLine(-5 % -4); // output: -1
            //binary -- end
        }
    }
}
