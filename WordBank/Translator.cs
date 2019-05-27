using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBank
{
    class Translator
    {
        MySqlConnection DbConnect = new MySqlConnection("datasource = localhost ; username = root ; password=; database = wordbank ");
        public string ingilizce_cevir(string Turkce)
        {
            string İngilizce = null;
            
            DbConnect.Open();
            MySqlCommand cmd = DbConnect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kelimeler where Turkce=('" + Turkce + "')";
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                İngilizce = reader.GetString("Ingilizce");
                
            }
            DbConnect.Close();
            return İngilizce;

            
        }
        public string turkce_cevir(string İngilizce)
        {
            string Turkce = null;
            
            DbConnect.Open();
            MySqlCommand cmd = DbConnect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kelimeler where Ingilizce=('" + İngilizce + "')";
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Turkce = reader.GetString("Turkce");
                
            }
            DbConnect.Close();
            return Turkce;
        }
        
    }
}
