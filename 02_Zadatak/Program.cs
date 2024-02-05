using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Zadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Unesi prvi cijeli broj:");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi cijeli broj:");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Zbroj brojeva: \n {a} + {b} = {a + b}");
            Console.WriteLine($"Razlika brojeva: \n {a} - {b} = {a - b}");
            Console.ReadKey();
        }
    }
}
