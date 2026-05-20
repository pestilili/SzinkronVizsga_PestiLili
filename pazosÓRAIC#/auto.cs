using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace autok
{

    class data
    {
        public string licencePlate;
        public int hour;
        public int minute;
        public int speed;
        public data(string line)
        {
            string[] sz = line.Split('\t');
            this.licencePlate = sz[0];
            this.hour = int.Parse(sz[1]);
            this.minute = int.Parse(sz[2]);
            this.speed = int.Parse(sz[3]);
        }
    }
    internal class Program
    {

        static int lenght;
        static data[] datas;

        static void dataStorage(){
        string[] fileData = File.ReadAllLines("jeladas.txt", Encoding.UTF8);
        lenght = fileData.Length;

        datas = new data[lenght];

            for (int i = 0; i < lenght; i++)
            {
                datas[i] = new data(fileData[i]);

            }
        }

        static void Main(string[] args)
        {
            dataStorage();


            // Írja ki hány db jeladás történt
            Console.WriteLine($"{lenght} db jeladás történt");

            //Hány db gépkocsi ment át a szakaszon ?
            HashSet<string> listOfLicencePlate = new HashSet<string>();
            foreach (var item in datas)
            {
                listOfLicencePlate.Add(item.licencePlate);
            }

            Console.WriteLine($"{ listOfLicencePlate.Count} db gépkocsi ment át a szakaszon.");


           







            Console.ReadKey();
        }
    }
}
