using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WordBank
{
    class yeniKelime
    {
        MySqlConnection DbConnect = new MySqlConnection("datasource = localhost ; username = root ; password=; database = wordbank ");
        public string kelime_ogren()
        {
            Random r = new Random();
            int rand = r.Next(1, 50);

            DbConnect.Open();
            MySqlCommand cmd = DbConnect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Turkce,id from kelimeler where id=" + rand;
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();
            string Turkce = "", id = "";
            while (reader.Read())
            {

                Turkce = reader.GetValue(0).ToString();
                id = reader.GetValue(1).ToString();
            }
            DbConnect.Close();

            return id + " - " + Turkce;
        }


    }
}
