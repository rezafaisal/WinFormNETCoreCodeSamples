using System;

namespace LatihanArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarasi
            int[] a = new int[3];
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;

            Console.WriteLine(a[0]);

            a[0] = 13;
            Console.WriteLine(a[0]);
        }
    }
}
