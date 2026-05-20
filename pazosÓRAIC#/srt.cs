using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace txt2srt
{

    class idozites
    {
        public string ido;
        public string felirat;
        public idozites(string sorok) 
        {
            for (int i = 0; i < sorok.Length - 2; i+= 2)
            {
                this.ido = sorok[i].ToString();
                this.felirat = sorok[i+1].ToString();
            }
            
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<idozites> lista1 = new List<idozites>();
       

            StreamReader sr = new StreamReader("feliratok.txt", Encoding.UTF8);

            List<idozites> sorok  = new List<idozites>();
            

            while (!sr.EndOfStream)
            {

                sorok.Add(new idozites(sr.ReadLine()));

            }

            Console.WriteLine($"feliratok száma: {sorok.Count / 2}");
            Console.WriteLine("4. feladat: A legtöbb szóból álló felirat: ");

            foreach (var item in sorok)
            {
                Console.WriteLine(item);
            }

            int legtobb = sorok[0].felirat.Count<char>();
            string leghosszabb = sorok[0].felirat;
            foreach (var item in sorok)
            {
                if (item.felirat.Count<char>() > legtobb)
                {
                    
                    legtobb = item.felirat.Count<char>();
                    leghosszabb = item.felirat;

                }
            }

            Console.WriteLine(leghosszabb);

            Console.ReadKey();
        }
    }
}
