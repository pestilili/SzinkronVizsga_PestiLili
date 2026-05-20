using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Claims;

namespace epitmenyado
{
    class epitmeny
    {
        public string adoszam;
        public string utca;
        public string hsz;
        public string sav;
        public int terulet;
  
        public epitmeny(string line, int A, int B, int C)
        {
            string[] sz = line.Split(' ');
            this.adoszam = sz[0];
            this.utca = sz[1];
            this.hsz = sz[2];
            this.sav = sz[3];
            this.terulet = int.Parse(sz[4]);
    
        }
        public int ado()
        {
            int tmp = 0;
            switch (sav)
            {
                case "A":
                    tmp = terulet * Program.A;
                    break;

                case "B":
                    tmp = terulet * Program.B;
                    break;

                default:
                    tmp = terulet * Program.C;
                    break;
            }
            if (tmp >= 10000) return tmp;
            return 0;
        }
    }
    internal class Program
    {

        public static int A, B, C;
        static int ado(string sav, int terulet)
        {
            int tmp = 0;
            switch (sav)
            {
                case "A":
                    tmp = terulet * A;
                    break;

                case "B":
                    tmp = terulet * B;
                    break;

                default:
                    tmp = terulet * C;
                    break;
            }
            if (tmp >= 10000) return tmp;
            return 0;
        }
        static void Main(string[] args)
        {
                StreamReader sr = new StreamReader("utca.txt", Encoding.UTF8);

                string[] adok = sr.ReadLine().Split(' ');
                A = int.Parse(adok[0]);
                B = int.Parse(adok[1]);
                C = int.Parse(adok[2]);
    
                List<epitmeny> telkek = new List<epitmeny>();
                while (!sr.EndOfStream)
                {
                    telkek.Add(new epitmeny(sr.ReadLine(), A, B, C));
                }

                sr.Close();

            //2. feladat
            Console.WriteLine($"2. feladat: A mintában {telkek.Count} telek szerepel.");

            //3. feladat
            bool flag = false;
            Console.Write($"3. feladat: Egy tuljadonos adószáma: ");
            string adoszam = Console.ReadLine();
            foreach(var item in telkek)
            {
                if (item.adoszam == adoszam)
                {
                    flag = true;
                    Console.WriteLine($"{item.utca} utca {item.hsz}");
                }
            }
            if (!flag) Console.WriteLine("Nem szerepel az állományban.");

            //4. feladat
            Console.WriteLine(telkek[0].ado()); //method
            Console.WriteLine(ado(telkek[0].sav, telkek[0].terulet)); //függvény

            //5. feladat
            int Adb = 0, Bdb = 0, Cdb = 0;
            int Aosszeg = 0, Bosszeg = 0, Cosszeg=0;
            SortedSet<string> utcak = new SortedSet<string>();
            HashSet<string> adoszamok = new HashSet<string>();
            foreach (var item in telkek)
            {
                utcak.Add(item.utca);
                adoszamok.Add(item.adoszam);
                switch (item.sav)
                {
                    case "A":
                        Adb++;
                        Aosszeg += item.ado();
                        break;

                    case "B":
                        Bdb++;
                        Bosszeg += item.ado();
                        break;

                    default:
                        Cdb++;
                        Cosszeg += item.ado();
                        break;

                }
            }
            Console.WriteLine("5. feladat");
            Console.WriteLine($"A sávba {Adb} telek esik, az adóösszeg {Aosszeg}");
            Console.WriteLine($"A sávba {Bdb} telek esik, az adóösszeg {Bosszeg}");
            Console.WriteLine($"A sávba {Cdb} telek esik, az adóösszeg {Cosszeg}");

            //6. feladat
            Console.WriteLine();
            foreach (var item in utcak)
            {
                string utcaSav = "";
                foreach (var item2 in telkek)
                {
                    if (item == item2.utca && utcaSav == "") utcaSav = item2.sav;
                    if (item == item2.utca && utcaSav != item2.sav)
                    {
                        Console.WriteLine(item2.utca);
                        break;
                    }
                }
            }

            //7. feladat
            StreamWriter sw = new StreamWriter("fizetendo.txt", false, Encoding.UTF8);
            foreach(var item in adoszamok)
            {
                int adoosszeg = 0;
                foreach (var item2 in telkek)
                {
                    if (item == item2.adoszam) adoosszeg += item2.ado();

                    
                    
                    
                   
                }
                sw.WriteLine($"{item} {adoosszeg}");
            }



            sw.Close();





            Console.ReadKey();
        }
    }
}
