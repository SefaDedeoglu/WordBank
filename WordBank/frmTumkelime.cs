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
    public partial class frmTumKelime : Form
    {
        public MySqlConnection DbConnect = new MySqlConnection("datasource = localhost ; username = root ; password=; database = wordbank ");
        public frmTumKelime()
        {
            InitializeComponent();
        }
        MySqlDataReader dr;
        private void FrmTumKelime_Load(object sender, EventArgs e)
        {
            
            listKelime.Items.Clear();
            DbConnect.Open();
            MySqlCommand yeni = new MySqlCommand("select * from kelimeler", DbConnect);
            dr = yeni.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr.GetInt32(0).ToString());
                item.SubItems.Add(dr.GetString(1));
                item.SubItems.Add(dr.GetString(2));
                item.SubItems.Add(dr.GetString(3));
                listKelime.Items.Add(item);
            }
            DbConnect.Close();
        }

        private void BtnT_K_Geri_Click(object sender, EventArgs e)
        {
            frmTumKelime kapat = new frmTumKelime();
            kapat.Close();
            frmArayuz ac = new frmArayuz();
            ac.Show();
            this.Hide();
        }
    }
}
