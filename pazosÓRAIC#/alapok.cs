using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace alapokValtozokMegminden
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Hello");
            Console.WriteLine("Hello");

            // string, int, double, boole, cahr
            string szoveg = "Béla";
            Console.WriteLine($"Hello {szoveg}");

            Console.Write("Kérek egy nevet: ");
            szoveg = Console.ReadLine();
            Console.WriteLine($"Hello {szoveg}");

            int kor = 0;

            do
            {
                Console.Write($"Kérem {szoveg} korát: ");
                try
                {
                    kor = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Hibás adat");
                }


            } while (kor < 1 || kor > 21);

            //int kor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{szoveg} {kor} éves.");

            Console.ReadKey();
        }
    }
}
