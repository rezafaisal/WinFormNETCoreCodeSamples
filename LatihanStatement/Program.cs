using System;

namespace LatihanStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Declarations();
            ConstantDeclarations();
            Expressions();
            IfStatement();
        }

        static void Declarations()
        {
            Console.WriteLine("Declarations");
            int a;
            int b = 2, c = 3;
            a = 1;
            Console.WriteLine(a + b + c);
        }

        static void ConstantDeclarations()
        {
            Console.WriteLine("ConstantDeclarations");
            const float pi = 3.1415927f;
            const int r = 25;
            Console.WriteLine(pi * r * r);
        }

        static void Expressions()
        {
            Console.WriteLine("Expressions");
            int i;
            i = 123;                // Expression statement
            Console.WriteLine(i);   // Expression statement
            i++;                    // Expression statement
            Console.WriteLine(i);   // Expression statement
        }

        static void IfStatement()
        {
            int number = 1;
            Console.WriteLine("IfStatement");
            if (number == 1)
            {
                Console.WriteLine("Number is 1");
            }
            else
            {
                Console.WriteLine("Number is not 1");
            }
        }

        static void WhileStatement()
        {
            int i = 0;
            int number = 13;
            while (i < number)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
