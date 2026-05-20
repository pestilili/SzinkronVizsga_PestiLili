using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileKezeles2
{
    
    class data
    {
        public int ora;
        public int perc;
        public int azonosito;
        public string irany;
        public data(string line)
        {
            string[] sz = line.Split(' ');
            this.ora = int.Parse(sz[0]);
            this.perc = int.Parse(sz[1]);   
            this.azonosito = int.Parse(sz[2]);  
            this.irany = sz[3];
        }


    }
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            List<data> list = new List<data>();
            StreamReader sr = new StreamReader("fuvar.csv", Encoding.UTF8);

            sr.ReadLine();
            while (!sr.EndOfStream)
            { 
            list.Add(new data(sr.ReadLine()));
            }



            sr.Close();

            foreach (var item in list)
            {

            }    




            Console.ReadKey();
        }
    }
}
