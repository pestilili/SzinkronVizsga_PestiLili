using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas
{

    class data
    {
        string _1;
        string _2;
        public data(string _1, string _2) 
        {
            this._1 = _1;
            this._2 = _2;
        }


        public bool anagrammaEketto()
        {
            if (_1.Length != _2.Length) return false;

            char[] betuk1 = _1.ToCharArray();
            char[] betuk2 = _2.ToCharArray();

            Array.Sort(betuk1);
            Array.Sort(betuk2);

            _1 = " ";
            _2 = " ";



            foreach (var item in betuk1) _1 += item.ToString();
            foreach (var item in betuk2) _2 += item.ToString();
            if (_1 == _2) return true;
            return false;
        }



    }

    internal class Program
    {
        static void anagrammaEJonatan(string _1, string _2)
        {   
            _1 = _1.ToLower();
            _2 = _2.ToLower();

            if (_1.Length != _2.Length)
            {
                Console.WriteLine("A szövegek nem egymás anagrammái.");
                return;
            }

            string abc = "qwertzuiopőúöüóasdfghjkléáűíyxcvbnm";
            int[,] reszek = new int[2, abc.Length];

            for (int i = 0; i < abc.Length; i++)
            {
                for (int j = 0; j < _1.Length; j++) if (_1[j] == abc[i]) reszek[0,i]++;
                for (int j = 0; j < _2.Length; j++) if (_2[j] == abc[i]) reszek[1,i]++;

            }

            for (int i = 0; i < abc.Length; i++)             
            {
                if (reszek[0, i] != reszek[1, i]) 
                {
                    Console.WriteLine("A szövegek nem egymás anagrammái.");
                    return;
                }
                    
            }
            Console.WriteLine("A szövegek egymás anagrammái.");
        }

        static bool anagrammaEketto(string _1, string _2)
        {
            if (_1.Length != _2.Length) return false;

            char[] betuk1 = _1.ToCharArray();
            char[] betuk2 = _2.ToCharArray();

            Array.Sort(betuk1); 
            Array.Sort(betuk2);

            _1 = " ";
            _2 = " ";



           foreach (var item in betuk1) _1 += item.ToString();
           foreach (var item in betuk2) _2 += item.ToString();
           if (_1 == _2) return true;
           return false;
        }


        static void Main(string[] args)
        {

            //anagramma

            Console.WriteLine("Kérem az első szöveget: ");
            string szovegElso = Console.ReadLine();
            Console.WriteLine("Kérem a második szöveget: ");
            string szovegMasodik = Console.ReadLine();

            //eljaras
            anagrammaEJonatan(szovegElso, szovegMasodik);

            //fuggveny
            Console.WriteLine(anagrammaEketto(szovegElso, szovegMasodik));

            //metodus (OOP)
            data tmp = new data(szovegElso, szovegMasodik);
            Console.WriteLine(tmp.anagrammaEketto());










            Console.ReadKey();
        }
    }
}
