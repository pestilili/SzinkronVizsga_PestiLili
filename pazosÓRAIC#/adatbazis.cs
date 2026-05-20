using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adatbazis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "127.0.0.1",
                Database = "ingatlanok",
                UserID = "root",
                Password = "mysql",
            };

            MySqlConnection kapcsolat = new MySqlConnection(builder.ConnectionString);
            kapcsolat.Open();
            var parancs = kapcsolat.CreateCommand();
            parancs.CommandText = "select id from categories where name = \"lakás\" limit 1;";
            var olvas = parancs.ExecuteReader();
            int keresett_id = 0;
            while (olvas.Read())
            {
                keresett_id = olvas.GetInt32(0);
            }
            olvas.Close();

            parancs.CommandText = $"select * from realestates where categoryId = {keresett_id};";
            olvas = parancs.ExecuteReader();
            while (olvas.Read())
            {
                string adat = olvas.GetString("latlong");
                Console.WriteLine(adat);
            }
            olvas.Close();
            kapcsolat.Close();


            Console.ReadKey();
        }
    }
}