using System;

namespace LatihanProsedur
{
    class Program
    {
        static void Main(string[] args)
        {
            TulisHello();
            Tulis("Hello World");
        }

        static void TulisHello()
        {
            Console.WriteLine("Hello World!");
        }

        static void Tulis(string message)
        {
            Console.WriteLine(message);
        }
    }
}
