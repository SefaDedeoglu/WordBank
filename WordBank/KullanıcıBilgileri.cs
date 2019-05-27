using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WordBank
{
    class KullanıcıBilgileri
    {
        public MySqlConnection DbConnect = new MySqlConnection("datasource = localhost ; username = root ; password=; database = wordbank ");
        int i;

        public string[] giris(string KullaniciAdi,string Sifre)
        {
            i = 0;int sayac = 0;
            string[] uye = new string[2];
            DbConnect.Open();
            MySqlCommand cmd = DbConnect.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from kullanici where kullaniciAdi='" + KullaniciAdi + " ' and sifre = ' " + Sifre + "'";
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                uye[0] = reader.GetString("kullaniciAdi");
                uye[1] = reader.GetString("sifre");
                sayac++;
            }
            
            DbConnect.Close();
            if (sayac == 0)
            {
                uye = null;
            }
            return uye;
        }

        public int kayit(string kullaniciAdi, string Sifre)
        {
            int ekle = 0;
            try
            {
                
                
                DbConnect.Open();
                MySqlCommand yeni = new MySqlCommand("insert into kullanici(kullaniciAdi,sifre) values ('" + kullaniciAdi + "','" + Sifre + "')", DbConnect);
                object sonuc = null;
                sonuc = yeni.ExecuteNonQuery();

                if (sonuc != null)
                {
                    ekle = 1;

                }
                DbConnect.Close();
            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata:" + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ekle;
        }
    }
}
