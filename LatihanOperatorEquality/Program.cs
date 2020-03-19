using System;

namespace LatihanOperatorEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1 + 2 + 3;
            int b = 6;
            Console.WriteLine(a == b);  // output: True

            char c1 = 'a';
            char c2 = 'A';
            Console.WriteLine(c1 == c2);  // output: False
            Console.WriteLine(c1 == char.ToLower(c2));  // output: True

            a = 1 + 1 + 2 + 3;
            b = 6;
            Console.WriteLine(a != b);  // output: True

            string s1 = "Hello";
            string s2 = "Hello";
            Console.WriteLine(s1 != s2);  // output: False

            object o1 = 1;
            object o2 = 1;
            Console.WriteLine(o1 != o2);  // output: True
        }
    }
}
