using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajtok
{   
    class nyitasok
    {
        public int hour;
        public int minute;
        public int id;
        public bool be;
        public nyitasok(string line)
        {
            this.hour = Convert.ToInt32(line.Split(' ')[0]);
            this.minute = Convert.ToInt32(line.Split(' ')[1]);
            this.id = Convert.ToInt32(line.Split(' ')[2]);
            this.be = line.Split(' ')[3] == "be";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<nyitasok> tarsaslgoAjto = new List<nyitasok>();
            StreamReader sr = new StreamReader("ajto.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {       
                tarsaslgoAjto.Add(new nyitasok(sr.ReadLine()));
            }
            sr.Close();




            //3. feladat
            StreamWriter sw = new StreamWriter("athaladas.txt", false, Encoding.UTF8);
            SortedSet<int> ids = new SortedSet<int>();  //rendezett halmaz
            foreach (var item in tarsaslgoAjto) ids.Add(item.id);
            foreach (var item in ids)
            {
                int db = 0;
                foreach(var item1 in tarsaslgoAjto) if (item1.id == item) db++;
                sw.WriteLine($"{item} {db}");
            }

            sw.Close();











            Console.ReadKey();
        }
    }
}
