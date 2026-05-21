using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tömbök
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tároljunk el 100 db 1 és 5000 közötti véletlen számot
            Random rnd = new Random();
            int[] szamok = new int[100]; // 100 elemű egészeket tároló tömb
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(1,5001);
            }

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine($"{szamok[i]}, ");
            }

            Console.WriteLine("--------------------------------------------------------------------------");
            // írjuk ki a páros számok átlagát
            int a = 0;
            int b = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 2 == 0)
                {
                    a += szamok[i];
                    b++;
                }
                
            }
            double atlag = (double) a / b;
            Console.WriteLine($"\n {atlag:0.00} a páros számok átlaga");

            Console.WriteLine("--------------------------------------------------------------------------");
            // melyik a legnagyobb szám és hanyadik a sorban

            int max = 0; // szamok
            // int maxi = 0;
            int ssz = 0; // sorszám
            int ssi = 0; // annak a sorszáma


            for (int i = 0; i < szamok.Length; i++)
            {
                ssz++;

                if (szamok[i] > max)
                { 
                    max = szamok[i];
                    ssi = ssz;
                    
                }
            }
            Console.WriteLine($"A legnagyobb szám a {max} és annak sorszáma {ssi}");
            Console.WriteLine("--------------------------------------------------------------------------");


            //szamoljuk meg hogy hány darab 3 -mal osztható szám van

            int db = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 3 == 0)
                {
                    db ++;
                }
            }
            Console.WriteLine($"{db} - db 3-ommal osztható szám");

        }  

    }
}
