using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace adatbazis
{
    #region kiosztas
    class kiosztas
    {
        public double frekvencia;
        public double teljesitmeny;
        public string csatorna;
        public string adohely;
        public string cim;

        public kiosztas(string line)
        {
            string[] sz = line.Split('\t');
            this.frekvencia = double.Parse(sz[0].Replace('.',','));
            this.teljesitmeny = double.Parse(sz[1].Replace('.', ','));
            this.csatorna = sz[2];
            this.adohely = sz[3];
            this.cim = sz[4];
        }
    }
    #endregion
    #region telepules
    class telepules
    {
        public string nev;
        public string megye;

        public telepules(string line)
        {
            string[] sz = line.Split('\t');
            this.nev = sz[0];
            this.megye = sz[1];
        }
    }
    #endregion
    #region regio
    class regio
    {
        public string nev;
        public string megye;

        public regio(string line)
        {
            string[] sz = line.Split('\t');
            this.nev = sz[0];
            this.megye = sz[1];
        }
    }
    #endregion
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region fajlbeolvasas
            StreamReader sr = new StreamReader("kiosztas.txt", Encoding.UTF8);
            sr.ReadLine();
            List<kiosztas> kiosztasok = new List<kiosztas>();
            while (!sr.EndOfStream)
            {
                kiosztasok.Add(new kiosztas(sr.ReadLine()));
            }

            sr = new StreamReader("telepules.txt", Encoding.UTF8);
            sr.ReadLine();
            List<telepules> telepulesek = new List<telepules>();
            while (!sr.EndOfStream)
            {
                telepulesek.Add(new telepules(sr.ReadLine()));
            }

            sr = new StreamReader("regio.txt", Encoding.UTF8);
            sr.ReadLine();
            List<regio> regiok = new List<regio>();
            while (!sr.EndOfStream)
            {
                regiok.Add(new regio(sr.ReadLine()));
            }
            sr.Close();
            #endregion
            #region tablak
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder()
            {
                Server = "127.0.0.1",
                UserID = "root",
                Password = "mysql"
            };
            MySqlConnection kapcsolat = new MySqlConnection(builder.ConnectionString);
            kapcsolat.Open();

            var parancs = kapcsolat.CreateCommand();
            parancs.CommandText = ("DROP DATABASE IF EXISTS radioadok;\nCreate Database radioadok;\n Use radioadok");
            parancs.ExecuteNonQuery();
            parancs.CommandText = ("Create table kiosztas(\nazon INT Primary Key NOT NULL AUTO_INCREMENT,\nfrekvencia double,\nteljesítmény double,\ncsatorna Varchar(200),\nadohely Varchar(200),\ncim Varchar(200));");
            parancs.ExecuteNonQuery();
            parancs.CommandText = ("Create table telepules(\nnev Varchar(200) Primary Key Not Null,\nmegye Varchar(200))");
            parancs.ExecuteNonQuery();
            parancs.CommandText = ("Create table regio(\nnev Varchar(200),\nmegye Varchar(200) Primary Key Not Null)");
            parancs.ExecuteNonQuery();
            parancs.CommandText = ("ALTER TABLE kiosztas\nADD FOREIGN KEY (adohely) REFERENCES telepules(nev);");
            parancs.ExecuteNonQuery();
            parancs.CommandText = ("Alter Table telepules\nAdd Foreign Key (megye) References regio(megye)");
            parancs.ExecuteNonQuery();
            #endregion
            #region insertek
            foreach (var item in  regiok)
            {
                parancs.CommandText = ($"INSERT INTO regio(nev, megye) Values(\"{item.nev}\", \"{item.megye}\")");
                parancs.ExecuteNonQuery();
            }
            foreach (var item in telepulesek)
            {
                parancs.CommandText = ($"INSERT INTO telepules(nev, megye) Values(\"{item.nev}\", \"{item.megye}\")");
                parancs.ExecuteNonQuery();
            }
            foreach (var item in kiosztasok)
            {
                parancs.CommandText = ($"INSERT INTO kiosztas(frekvencia, teljesítmény, csatorna, adohely , cim) Values({item.frekvencia.ToString().Replace(',','.')}, {item.teljesitmeny.ToString().Replace(',', '.')}, \"{item.csatorna}\",\"{item.adohely}\",\"{item.cim}\")");
                parancs.ExecuteNonQuery();
            }


            kapcsolat.Close();
            Console.ReadKey();
            #endregion
        }
    }
}