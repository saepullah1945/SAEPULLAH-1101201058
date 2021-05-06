using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM KONVERSI DESIMAL KE BINER");
            Console.Write("MASUKAN DESIMAL  = ");
            int DESIMAL = int.Parse(Console.ReadLine());
            int SISA;
            string HASIL = string.Empty;
            while (DESIMAL > 0)
            {
                SISA = DESIMAL % 2;
                DESIMAL /= 2;
                HASIL = SISA.ToString() + HASIL;
            }
            Console.WriteLine("BINER = {0}", HASIL);
            Console.ReadLine();
        }
    }
}
