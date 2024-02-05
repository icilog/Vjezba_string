using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Zadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int godina;
            Console.WriteLine("Unesi godinu za koju želiš provjeru:");
            godina = Int32.Parse(Console.ReadLine());
            if (godina % 4 == 0 && (godina % 100 != 0 || godina % 400 == 0))
                Console.WriteLine($"Godina {godina} je prijestupna godina!");
            else
                Console.WriteLine($"Godina {godina} nije prijestupna godina!");
            Console.ReadKey();


        }
    }
}
