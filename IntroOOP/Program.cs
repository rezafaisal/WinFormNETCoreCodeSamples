using System;

namespace IntroOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mo = new MathOperation();
            int hasilTambah = mo.Tambah(1, 3);
            int hasilKurang = mo.Kurang(5, 2);

            StringOperation.Tulis("Hasil 1 + 3 = " + hasilTambah);
            StringOperation.Tulis("Hasil 5 + 2 = " + hasilKurang);

            mo.bilangan1 = 4;
            mo.bilangan2 = 4;
            int hasilTambah2 = mo.Tambah();
            StringOperation.Tulis("Hasil 4 + 4 = " + hasilTambah2);
        }
    }

    public static class StringOperation
    {
        public static void Tulis(object value)
        {
            Console.WriteLine(value);
        }
    }
}
