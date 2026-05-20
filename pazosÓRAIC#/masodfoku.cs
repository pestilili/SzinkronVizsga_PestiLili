using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szelekciok
{
    internal class Program
    {   
        static double[] diszk(double a, double b, double c)
        {   double[] vissza = new double[2];
            vissza[0] = Math.Pow(b, 2) - 4 * a * c;
            if (vissza[0] > 0) vissza[1] = 2;
            else if (vissza[0] == 0) vissza[1] = 1;
            else vissza[1] = 0;
            return vissza;
        }

        static void billentyű()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();  
        }    
        static void Main(string[] args)
        {
            //másodfokú egyenlet diszkrimináns számítás
            // d = b^2 - 4 * a * c
            // d > 0 => 2 megoldás
            // d = 0 => 1 megoldás
            // d < 0 => 0 (nincs) megoldás

            Console.WriteLine("Kérem a másodfokú együtthatót: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Kérem az elsőfokú együtthatót: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Kérem a nulladik fokú együtthatót: ");
            double c = double.Parse(Console.ReadLine());

            double[] megoldas = diszk(a, b, c); 

            switch (megoldas[1])
            {
                case 0:
                    Console.WriteLine("A függvénynek nincs megoldása.");
                    break;

                case 1:
                    double x = (-1 * b) / (2 * a);
                    Console.WriteLine($"A függvénynek egy megoldása van {x: 0.##.}");
                    break;
                default:
                    double x1 = ((-1 * b) + Math.Sqrt(megoldas[0])) / (2 * a);
                    double x2 = ((-1 * b) + Math.Sqrt(megoldas[0])) / (2 * a);
                    Console.WriteLine($"A függvénnynek két megoldása van {x1: 0.00}, {x2:0.00}.");
                    break;
            }





            billentyű();  
        }
    }
}
