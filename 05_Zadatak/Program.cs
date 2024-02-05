using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Zadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            string izbor = "da";
            while (izbor == "da")
            {
                Console.WriteLine("Unesi cijeli broj:");
                a = Int32.Parse(Console.ReadLine());
                if (a % 3 == 0 && a % 5 == 0)
                    Console.WriteLine("Broj je dobar!.");
                else
                    Console.WriteLine("Broj nije dobar.");
                Console.WriteLine("Zelite li ponovno?");
                izbor = Console.ReadLine().ToLower();
            }
            Console.ReadKey();
        }
    }
}
