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
    public partial class frmYeniKelime : Form
    {
        MySqlConnection DbConnect = new MySqlConnection("datasource = localhost ; username = root ; password=; database = wordbank ");
        yeniKelime kel = new yeniKelime();
        public frmYeniKelime()
        {
            InitializeComponent();
        }

        private void BtnYeniGeri_Click(object sender, EventArgs e)
        {
            frmYeniKelime kapat = new frmYeniKelime();
            kapat.Close();
            frmArayuz ac = new frmArayuz();
            ac.Show();
            this.Hide();
        }

        private void BtnKelimeAl_Click(object sender, EventArgs e)
        {
            string Turkce = kel.kelime_ogren();
            txtY_Tr.Text = Turkce;

        }
        
        private void BtnKelimeDogrula_Click(object sender, EventArgs e)
        {
            if (txtY_İng.Text != "")
            {
                string ki = "";
                for (int i = 0; i < 100; i++)
                {
                    if (txtY_Tr.Text[i] != '-')
                    {
                        ki += txtY_Tr.Text[i].ToString();
                        continue;
                    }
                    else break;
                }
                MessageBox.Show(ki.ToString());
                MySqlConnection DbConnect = new MySqlConnection("datasource = localhost ; username = root ; password=; database = wordbank ");
                MySqlCommand cmd = DbConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Ingilizce from kelimeler where id=" + Convert.ToInt32(ki);
                DbConnect.Open();

                MySqlDataReader reader = cmd.ExecuteReader();


                string İngilizce = "";
                while (reader.Read())
                {

                    İngilizce = reader.GetValue(0).ToString();
                }
                DbConnect.Close();
                if (İngilizce == txtY_İng.Text)
                {
                    MessageBox.Show("Dogru bildiniz");
                    DbConnect.Open();
                    
                    
                    InsertData();
                   
                }
                
                else
                    MessageBox.Show("Yanlıs bildiniz");

                
            }
            else
            {
                MessageBox.Show("bos olamaz");
            }
        }
        public void InsertData()
        {
            MySqlConnection DbConnect = new MySqlConnection("datasource = localhost ; username = root ; password=; database = wordbank ");
            
            try
            {
                string tarih = DateTime.Now.ToString();
                DbConnect.Open();
                MySqlCommand cmd = DbConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO ogrenilen (kelime,tarih) values ('" + txtY_İng.Text + "', '" + tarih + "')";
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;

                DbConnect.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
