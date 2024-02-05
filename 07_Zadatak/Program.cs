using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _07_Zadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica, prvi, drugi, treci, rijec;
            int trecina, pozicija;
            int duljina = 0;
            recenica = "";
            while (duljina < 3)
            {
                Console.WriteLine("Unesi rečenicu koja sadrži najmanje 3 znaka:");
                recenica = Console.ReadLine();
                recenica = recenica.TrimEnd();
                duljina = recenica.Length;

            }

            trecina = duljina / 3;
            prvi = recenica.Substring(0, trecina).ToUpper();
            drugi = recenica.Substring(trecina, trecina).ToLower();
            treci = recenica.Substring(trecina * 2).ToUpper();
            Console.WriteLine(prvi + drugi + treci);

            Console.WriteLine("Unesi jednu riječ iz svoje rečenice:");
            rijec = Console.ReadLine();
            pozicija = recenica.IndexOf(rijec);
            if (pozicija != -1)
                Console.WriteLine($"Pozicija rijeci {rijec} u vašoj rečenici je {pozicija}");
            else
                Console.WriteLine($"Riječ {rijec} nije u vašoj rečenici!");

            //Zamjena suglasnika sa samoglasincima


            Console.WriteLine("Unesi 5 suglasnika odvojenih razmakom:");
            string[] suglasnici = Console.ReadLine().Split(' ');
            char umjestoA = char.Parse(suglasnici[0].ToLower());
            char umjestoE = char.Parse(suglasnici[1].ToLower());
            char umjestoI = char.Parse(suglasnici[2].ToLower());
            char umjestoO = char.Parse(suglasnici[3].ToLower());
            char umjestoU = char.Parse(suglasnici[4].ToLower());
            char vumjestoA = char.Parse(suglasnici[0].ToUpper());
            char vumjestoE = char.Parse(suglasnici[1].ToUpper());
            char vumjestoI = char.Parse(suglasnici[2].ToUpper());
            char vumjestoO = char.Parse(suglasnici[3].ToUpper());
            char vumjestoU = char.Parse(suglasnici[4].ToUpper());





            while (suglasnici.Length != 5)
            {
                Console.WriteLine("Molim unesite 5 suglasnika odvojenih razmakom: ");
                suglasnici = Console.ReadLine().Split(' ');

            }
            Console.WriteLine($"Ovo je početna rečenica: {recenica}");

            char[] rec = recenica.ToCharArray();
            string novarecenica;
            for (int i = 0; i < recenica.Length; i++)
            {
                switch (recenica[i])
                {
                    case ('a'):
                        rec[i] = umjestoA;
                        break;
                    case ('e'):
                        rec[i] = umjestoE;
                        break;
                    case ('i'):
                        rec[i] = umjestoI;
                        break;
                    case ('o'):
                        rec[i] = umjestoO;
                        break;
                    case ('u'):
                        rec[i] = umjestoU;
                        break;
                    case ('A'):
                        rec[i] = vumjestoA;
                        break;
                    case ('E'):
                        rec[i] = vumjestoE;
                        break;
                    case ('I'):
                        rec[i] = vumjestoI;
                        break;
                    case ('O'):
                        rec[i] = vumjestoO;
                        break;
                    case ('U'):
                        rec[i] = vumjestoU;
                        break;
                }
            }
            novarecenica = new string(rec);
            recenica = novarecenica;
            Console.WriteLine($"Ovo je nova rečenica: {novarecenica}");

            Console.ReadKey();

           
        }
    }
}
