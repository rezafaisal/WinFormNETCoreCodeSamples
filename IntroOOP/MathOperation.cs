using System;
using System.Collections.Generic;
using System.Text;

namespace IntroOOP
{
    public class MathOperation
    {
        public int bilangan1 { set; get; }
        public int bilangan2 { set; get; }
        public int Tambah(int bil1, int bil2)
        {
            int hasil = bil1 + bil2;
            return hasil;
        }

        public int Tambah()
        {
            int hasil = bilangan1 + bilangan2;
            return hasil;
        }

        public int Kurang(int bil1, int bil2)
        {
            int hasil = bil1 - bil2;
            return hasil;
        }

        public int Kali(int bil1, int bil2)
        {
            int hasil = bil1 * bil2;
            return hasil;
        }

        public void TulisHasil(object nilai)
        {
            Console.Write(nilai);
        }
    }
}
