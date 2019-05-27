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
    
    public partial class frmOgrenilen : Form
    {
        public MySqlConnection DbConnect = new MySqlConnection("datasource = localhost ; username = root ; password=; database = wordbank ");
        public frmOgrenilen()
        {
            InitializeComponent();
        }
        MySqlDataReader dr;
        private void FrmOgrenilen_Load(object sender, EventArgs e)
        {
            listOgrenilen.Items.Clear();
            DbConnect.Open();
            MySqlCommand yeni = new MySqlCommand("select * from ogrenilen", DbConnect);
            dr = yeni.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr.GetInt32(0).ToString());
                item.SubItems.Add(dr.GetString(1));
                item.SubItems.Add(dr.GetString(2));  
                listOgrenilen.Items.Add(item);
            }
            DbConnect.Close();
        }

        private void BtnOgrenilenGeri_Click(object sender, EventArgs e)
        {
            frmOgrenilen kapat = new frmOgrenilen();
            kapat.Close();
            frmArayuz ac = new frmArayuz();
            ac.Show();
            this.Hide();
        }

        private void ListOgrenilen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
