using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

namespace sebesseg
{

    class meres
    {
        public int eltelt;
        public string jelolesek;
        public meres(string line)
        {
            string [] darabok = line.Split(' ');
            this.eltelt = int.Parse(darabok[0]);
            this.jelolesek = darabok[1];
        }

        
        public int micsoda() 
        {
            if (jelolesek.Length >= 4 && jelolesek.Length <= 32)
            {
                while (jelolesek != "]") return 50;
            }
            if (int.Parse(jelolesek) >= 10 && int.Parse(jelolesek) <= 90) return int.Parse(jelolesek);
            else
            {
                return 90;
            }
            

        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<meres> list = new List<meres>();
            StreamReader sr = new StreamReader("ut.txt");


            int utHossza = int.Parse(sr.ReadLine());
            while (!sr.EndOfStream)
            {
                list.Add(new meres(sr.ReadLine()));
            }

            // feladat 2
            Console.WriteLine("2. feladat");
            Console.WriteLine("A települések neve: ");
            foreach (var item in list)
            {
                if (item.jelolesek.Length >= 4 && item.jelolesek.Length <= 32)
                {
                    Console.WriteLine(item.jelolesek);
                }
            }

            // feladat 3 
            Console.WriteLine("Adja meg a szakasz hosszát km-ben: ");
            double szakasz = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"szakasz: {szakasz}");


            // feladat 4 
            int telepulesenBelul = 0;
            bool vegetert = true;
            int vegetER = 0;
            int kezd = 0;
            for (int i = 0; i < list.Count -1; i++)
            {
                if (list[i].jelolesek.Length >= 4 && list[i].jelolesek.Length <= 32)
                {
                    vegetert = false;
                    kezd = list[i].eltelt;
                    kezd = 0;
                }
                if (list[i].jelolesek == "]")
                {
                    vegetert = true;
                    vegetER = list[i].eltelt;
                    vegetER = 0;
                }
                if (vegetert == false) telepulesenBelul += (vegetER - kezd);
                
                
            }
            double szazalek = (Convert.ToDouble(telepulesenBelul) / Convert.ToDouble(utHossza))  * 100;
            
            
            Console.WriteLine($"A mért adatok {szazalek} %-a van telpülésen belül. ({telepulesenBelul} / {utHossza}) * 100");



            Console.ReadKey();
        }
    }
}
