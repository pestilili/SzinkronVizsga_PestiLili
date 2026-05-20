using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace radio
{
    public class radio
    {
        int napSorSzam;
        int amatorSorSzam;
        bool farkas = false;
        string uzenet;

        public radio(string adatok)
        {
            string[] sor2 = adatok.Split('\n');
            string[] sor1 = sor2[0].Split(' ');
            this.napSorSzam = int.Parse(sor1[0]);
            this.amatorSorSzam=int.Parse(sor1[1]);
            this.uzenet = sor2[1];
            
            
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("veetel.txt", Encoding.UTF8);
            string adatok = sr.ReadToEnd();
            while (!sr.EndOfStream)
            {
                string[] adat = adatok.Split('$');
            }

            int length = adatok.Length;

            sr.Close();

            foreach (var item in adatok)
            {
                
            }


            //Console.WriteLine($"{}");




            Console.ReadKey();
        }
    }
}
