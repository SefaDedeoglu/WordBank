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
    public partial class frmKelimeSil : Form
    {
        public MySqlConnection DbConnect = new MySqlConnection("datasource = localhost ; username = root ; password=; database = wordbank ");
        kelime kel = new kelime();
        public frmKelimeSil()
        {
            InitializeComponent();
        }

        private void BtnK_Sil_Click(object sender, EventArgs e)
        {
            int kelimeSil;
            kelimeSil = kel.KelimeSil(txtTrSİl.Text,txtİngSil.Text);
            if (kelimeSil == 1)
            {
                MessageBox.Show("Silme İşlemi Başarılı...");

            }
            else
            {
                MessageBox.Show("Silme İsleminde Bir Hata ile Karşılaşıldı...");
            }
        }

        private void BtnK_sil_cıkıs_Click(object sender, EventArgs e)
        {
            frmKelimeSil kapat = new frmKelimeSil();
            kapat.Close();
            frmArayuz ac = new frmArayuz();
            ac.Show();
            this.Hide();
        }
    }
}
