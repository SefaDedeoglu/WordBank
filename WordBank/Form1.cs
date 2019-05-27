using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WordBank
{
    public partial class frmAnaMenu : Form
    {
        public MySqlConnection DbConnect = new MySqlConnection("datasource = localhost ; username = root ; password=; database = wordbank ");
        string[] gelenkullanici;
        KullanıcıBilgileri kul = new KullanıcıBilgileri();
        public frmAnaMenu()
        {
            InitializeComponent();
        }

        
        private void DbConnection()
        {
            string ConnectionString = "datasource = localhost ; username = root ; password=; database = wordbank ";
            MySqlConnection DbConnect = new MySqlConnection(ConnectionString);
            try
            {
                DbConnect.Open();
                MessageBox.Show("Bağlantı Sağlandı");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

      

        private void BtnGiris_Click_1(object sender, EventArgs e)
        {
            gelenkullanici = new string[3];
            gelenkullanici = kul.giris(txtKullaniciAd.Text, txtKullaniciSifre.Text);
            if (gelenkullanici != null)
            {
                
                txtKullaniciAd.Text = gelenkullanici[0];
                txtKullaniciSifre.Text = gelenkullanici[1];
                MessageBox.Show("Giriş Başarılı");
                frmAnaMenu formkapa = new frmAnaMenu();
                formkapa.Close();
                frmArayuz arayuz = new frmArayuz();
                arayuz.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı.");
            }
        }

        private void BtnKullaniciEkle_Click_1(object sender, EventArgs e)
        {
            int ekle;
            ekle = kul.kayit(txtKullaniciAd.Text, txtKullaniciSifre.Text);
            if (ekle == 1)
            {
                MessageBox.Show("kayıt başarılı...");

            }
            else
            {
                MessageBox.Show("kayıt başarısız...");
            }
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
            
        }
    }
}
