using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 5. В каких двузначных числах удвоенная сумма цифр равна их произведению?
        (Одно из таких чисел 44: 4 * 2 + 4 * 2 = 4 * 4) */

namespace Lab_3_2_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i < 99; i++)            
                if ((i % 10)*2 + (i / 10 % 10)*2 == (i % 10) * (i / 10 % 10))
                    Console.WriteLine(i);            
            Console.ReadKey();
        }
    }
}
