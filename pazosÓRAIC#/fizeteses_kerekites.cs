using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fizetesek
{
    internal class Program
    {

        static long kerekites(long a)
        {
            long maradek = a % 10;
            if (maradek >= 0 && maradek <= 2)
            {
                return a / 10 * 10;
            }
            else if (maradek >= 3 && maradek <= 7)
            {
                return (a / 10 * 10 + 5);
            }
            else
            {
                return a / 10 * 10 + 10;
            }
        }


        static int[] cimlet(int b, int[] cimletek)
        {
             int[] visszatero = new int[cimletek.Length];
             for (int i = 0; i < cimletek.Length; i++)
                {
                    visszatero[i] = b / cimletek[i];
                    b -= (b / cimletek[i] * cimletek[i]);
                }
                return visszatero;

            


        }
        static void Main(string[] args)
        {
            /*
            Console.WriteLine();
            long szam = Convert.ToInt64(Console.ReadLine());


            Console.WriteLine();
            int szam2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(kerekites(szam));

            int[] cimletek = {20000, 10000, 5000, 2000, 1000, 500, 100, 50, 20, 10, 5};

            Console.WriteLine(cimlet(szam2, cimletek));
            */

            long keszpenz = 0;
            long kartya = 0;
            
            StreamReader sr = new StreamReader("mavszamok.txt");
            while (!sr.EndOfStream)
            { 
                long penz = Convert.ToInt64(sr.ReadLine());
                keszpenz += kerekites(penz);
                kartya += penz;
            }

            Console.WriteLine($"különbség: {kartya - keszpenz} Ft");









            

            Console.ReadKey();
        }
    }
}
