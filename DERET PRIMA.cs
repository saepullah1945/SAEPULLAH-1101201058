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
            int bilangan;
            Console.Write("input batas bilangan =  ");
            bilangan = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            Console.WriteLine();
            Console.Write("bilangan prima dari 1 sampai {0} yaitu ",bilangan);
            for (int i = 1; i <= bilangan; i++)
            {
                for (int j= 1; j <= i; j++)
                {
                    if (i%j == 0)
                    {
                        temp += 1;
                    }
                }
                if (temp == 2)
                {
                    Console.Write(i + "   ");
                }
                temp = 0;
            }
            Console.ReadLine();
        }
    }
}
