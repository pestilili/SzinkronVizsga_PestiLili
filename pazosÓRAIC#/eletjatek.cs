using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eletjatek
{
    internal class Program
    {
        class EletjatekSzimulator
        {
            private int[,] Matrix;
            private int Oszlopokszama;
            private int SorokSzama;

            public EletjatekSzimulator(int matrixSor, int matrixOszlop)
            {
                this.SorokSzama = matrixSor;
                this.Oszlopokszama = matrixOszlop;

                int[] szamok = { 0, 1 };
                int szam = 0;
                Random r = new Random();


                //this.Matrix = new int[12, 12];
                //this.Matrix = new int[,] { { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 1, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 } };
                this.Matrix = new int[,] { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };


                for (int j = 0; j < 12; j++)
                {
                    this.Matrix[0, j] = 0;
                }

                for (int j = 0; j < 12; j++)
                {
                    this.Matrix[11, j] = 0;
                }

                for (int j = 1; j < 11; j++)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        if (i == 0 || i == 11) { this.Matrix[j, i] = 0; }
                        else
                        {
                            szam = r.Next(0, 2);
                            //this.Matrix[j, i] = szamok[szam];
                        }
                    }
                }
            }

                private void megjelenit()
                {
                int[,] tomb = Matrix;
                for (int j = 0; j < 12; j++)
                {
                    Console.Write("X ");
                }
                Console.WriteLine(" ");
                

                for (int j = 1; j < 11; j++)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        if (i == 0 || i == 11) { Console.Write("X "); }
                        else
                        {
                            if (tomb[j, i] == 0) { Console.Write("  "); }
                            else { Console.Write("S "); }
                        }
                    }
                    Console.WriteLine(" ");
                }

                for (int j = 0; j < 12; j++)
                {
                    Console.Write("X ");
                }
            }

            private void KovetkezoAllapot()
            {
                int[,] matrix2 = new int [12,12]; 
                int sejtSzomszedok = 0;
                for (int i = 1; i < 11; i++)
                {
                    for (int j = 1; j < 11; j++)
                    {
                        
                        if (Matrix[i, j] == 1)
                        {
                            sejtSzomszedok = 0;
                            if (Matrix[i + 1, j] == 1) { sejtSzomszedok++; }
                            if (Matrix[i - 1, j] == 1) { sejtSzomszedok++; }
                            if (Matrix[i, j + 1] == 1) { sejtSzomszedok++; }
                            if (Matrix[i, j - 1] == 1) { sejtSzomszedok++; }
                            if (Matrix[i + 1, j + 1] == 1) { sejtSzomszedok++; }
                            if (Matrix[i + 1, j - 1] == 1) { sejtSzomszedok++; }
                            if (Matrix[i - 1, j + 1] == 1) { sejtSzomszedok++; }
                            if (Matrix[i - 1, j - 1] == 1) { sejtSzomszedok++; }
                            if (sejtSzomszedok > 3 || sejtSzomszedok < 2) { matrix2[i, j] = 0; }
                            else { matrix2[i,j] = 1; }
                        }
                        else {
                            sejtSzomszedok = 0;
                            if (Matrix[i + 1, j] == 1) { sejtSzomszedok++; }
                            if (Matrix[i - 1, j] == 1) { sejtSzomszedok++; }
                            if (Matrix[i, j + 1] == 1) { sejtSzomszedok++; }
                            if (Matrix[i, j - 1] == 1) { sejtSzomszedok++; }
                            if (Matrix[i + 1, j + 1] == 1) { sejtSzomszedok++; }
                            if (Matrix[i + 1, j - 1] == 1) { sejtSzomszedok++; }
                            if (Matrix[i - 1, j + 1] == 1) { sejtSzomszedok++; }
                            if (Matrix[i - 1, j - 1] == 1) { sejtSzomszedok++; }
                            if (sejtSzomszedok == 3) { matrix2[i, j] = 1; }
                            else
                            {
                                matrix2[i, j] = 0;
                            }
                        }

                    }
                        
                  
                }
                Matrix = matrix2;

            }

            public void Run()
            {
                megjelenit();
                KovetkezoAllapot();
                Thread.Sleep(500);
            }
        }    
            
            
        

        static void Main(string[] args)
        {

            EletjatekSzimulator data = new EletjatekSzimulator(12, 12);

            for (int i = 0; i < 100; i++)
            {
                data.Run();
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
            
            
            

            Console.ReadKey();
        }
    }
}
