using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Zadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int A, B;
            Random rnd = new Random();
            string granicaA, granicaB;
            Console.WriteLine("Unesi broj između 1 i 500:");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi broj između 1 i 500:");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Želiš li da broj {a} bude uključen u provjeru? (da/ne)");
            granicaA = Console.ReadLine();
            Console.WriteLine($"Želiš li da broj {b} bude uključen u provjeru? (da/ne)");
            granicaB = Console.ReadLine();
            if (granicaA.ToLower() == "da") A = a;
            else A = a + 1;
            if (granicaB.ToLower() == "da") B = b + 1;
            else B = b;
            int slucajniBroj = rnd.Next(1, 501);
            if (slucajniBroj <= B && slucajniBroj >= A)
                Console.WriteLine($"Broj {slucajniBroj} je u rasponu!");
            else
                Console.WriteLine($"Broj {slucajniBroj} nije u rasponu!");
           
            Console.ReadKey();




        }
    }
}
