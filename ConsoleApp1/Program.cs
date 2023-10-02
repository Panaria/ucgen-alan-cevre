using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a kenarı 5, b kenarı 6, c kenarı 5 yüksekliği 4 olan bir üçgenin alanını ve çevresini hesaplayınız.

            Console.WriteLine("Alan = " + (6 * 4 / 2));
            Console.WriteLine("Çevre = " + (5 + 5 + 6));

            Console.ReadLine();
        }
    }
}
