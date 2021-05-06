using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("masukan n = ");
            n = Convert.ToInt32(Console.ReadLine) 
            int[] deret = new int[3] { 0, 1, 1 };
            for (int i = 0; i < n; i++)
            {
                if (i < 1)
                {
                    deret[2] = 0;
                }
                else
                {
                    deret[0] = deret[1];
                    deret[1] = deret[2];
                    deret[2] = deret[0] + deret[1];
                }
                Console.Write(deret[2] + "  ");
            }
            Console.ReadLine();

        }
    }
}