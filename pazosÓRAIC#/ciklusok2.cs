using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            int szam1;
            Console.Write("Kérek egy pozitív egész számot: ");
            szam1 = int.Parse(Console.ReadLine());

            for (int i = 1; i != szam1; i++)
            {
                Console.Write($"{i} ");  
            }
            Console.WriteLine();

            //2. feladat
            int szam2;
            Console.Write("Kérek egy pozitív egész számot: ");
            szam2 = int.Parse(Console.ReadLine());

            for (int i = 1; i != szam2; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            //3. feladat
            int szam3;
            Console.Write("Kérek egy pozitív egész számot: ");
            szam3 = int.Parse(Console.ReadLine());

            for (int i = 1; i != szam3 + 1; i++)
                if (szam3 % i == 0)
                { 
                Console.WriteLine(i);
                }

            //4. feladat
            int szam4;
            Console.Write("Kérek egy pozitív egész számot: ");
            szam4 = int.Parse(Console.ReadLine());

            int s = 0;
            for (int i= 1; i <= szam4; i++)
            {
                if (szam4 % i == 0) s += i;
            }
            Console.WriteLine(s);
            Console.WriteLine();

            //5. feladat
            int szam5;
            Console.Write("Kérek egy pozitív egész számot: ");
            szam5 = int.Parse(Console.ReadLine());

            int osszeg = 0;
            for (int i = 1; i <= szam4; i++)
            {
                if (szam4 % i == 0) osszeg += i;
            }
            if (osszeg == szam5 * 2) 
            {
                Console.WriteLine("Tökéletes szám"); 
            }
            else { Console.WriteLine("nem tökéletes szám"); }
                Console.WriteLine();

            //6. feladat
            int hatvany_alap;
            Console.Write("Kérem egy hátvány alapját: ");
            hatvany_alap = int.Parse(Console.ReadLine());

            int hatvany_kitevo;
            Console.Write("Kérem egy hatvány kitevőjét: ");
            hatvany_kitevo = int.Parse(Console.ReadLine());

            int osszes2 = 1;

            for (int i = 1; i == hatvany_kitevo; i++)
            {
                osszes2 *= hatvany_alap;  
            }

            Console.WriteLine(osszes2);
            Console.WriteLine();

            //7. feladat
            int szam7 = 0;
            do
            {
                Console.Write("Kérek egy pozitív egész számot: ");
                szam7 = int.Parse(Console.ReadLine());  
            }
            while (szam7 < 1);

            //8. feladat
            double osszeg3 = 0;
            double szam8 = 0;
            do {
                Console.Write("Kérek egy számot");
                szam7 = double.Parse(Console.ReadLine();
                osszeg3 += szam7;
            }
            while (szam8 < 10);
            Console.WriteLine(osszeg3);


















            Console.ReadKey();
        }
    }
}
