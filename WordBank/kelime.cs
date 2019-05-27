using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WordBank
{
    class kelime
    {
        public MySqlConnection DbConnect = new MySqlConnection("datasource = localhost ; username = root ; password=; database = wordbank ");
        public int KelimeEkle(string turkce, string ingilizce,string bilgi)
        {
            int ekle = 0;
            try
            {


                DbConnect.Open();
                MySqlCommand yeni = new MySqlCommand("insert into kelimeler(Turkce,Ingilizce,bilgi) values ('" + turkce + "','" + ingilizce + "','" +bilgi+"')", DbConnect);
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

        public int KelimeSil(string turkce,string ingilizce)
        {
            int kelimeSil = 0;
            try
            {
                DbConnect.Open();
                MySqlCommand Sil = new MySqlCommand("delete from kelimeler where Turkce =('" + turkce + "') and Ingilizce=('" + ingilizce + "')", DbConnect);
                object sonuc = null;
                sonuc = Sil.ExecuteNonQuery();

                if (sonuc != null)
                {
                    kelimeSil = 1;

                }
                DbConnect.Close();
            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata:" + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return kelimeSil;
        }

        
    }
}
