using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Zadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Unesi prvi realan broj:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi realan broj:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Produkt brojeva: \n {a} * {b} = {a * b}");
            Console.WriteLine($"Kvocijent brojeva:\n {a} / {b} = " + Math.Round(a/b,2));
            Console.ReadKey();
        }
    }
}
