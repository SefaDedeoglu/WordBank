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
    public partial class frmKelimeEkle : Form
    {
        kelime Kel = new kelime();
        public frmKelimeEkle()
        {
            InitializeComponent();
        }

        private void KelimeEkle_Load(object sender, EventArgs e)
        {

        }

        private void BtnK_Geri_Click(object sender, EventArgs e)
        {
            frmKelimeEkle kapat = new frmKelimeEkle();
            kapat.Close();
            frmArayuz ac = new frmArayuz();
            ac.Show();
            this.Hide();
        }

        private void BtnK_Ekle_Click(object sender, EventArgs e)
        {
            int ekle;
            ekle = Kel.KelimeEkle(txtTrKelime.Text, txtİngKelime.Text,txtEkleBilgi.Text);
            if (ekle == 1)
            {
                MessageBox.Show("kayıt başarılı...");

            }
            else
            {
                MessageBox.Show("kayıt başarısız...");
            }
        }
    }
}
