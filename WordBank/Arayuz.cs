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
    public partial class frmArayuz : Form
    {
        public frmArayuz()
        {
            InitializeComponent();
        }

        private void FrmArayuz_Load(object sender, EventArgs e)
        {

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            frmArayuz kapat = new frmArayuz();
            kapat.Close();
            frmAnaMenu ac = new frmAnaMenu();
            ac.Show();
            this.Hide();
        }

        private void BtnKelimeEkle_Click(object sender, EventArgs e)
        {
            frmArayuz gizle = new frmArayuz();
            gizle.Hide();
            frmKelimeEkle ac = new frmKelimeEkle();
            ac.Show();
            this.Hide();
        }

        private void BtnKelimeSil_Click(object sender, EventArgs e)
        {
            frmArayuz gizle = new frmArayuz();
            gizle.Hide();
            frmKelimeSil ac = new frmKelimeSil();
            ac.Show();
            this.Hide();
        }

        private void BtnTumKelimeler_Click(object sender, EventArgs e)
        {
            frmArayuz gizle = new frmArayuz();
            gizle.Hide();
            frmTumKelime ac = new frmTumKelime();
            ac.Show();
            this.Hide();
        }

        private void BtnYeniKelime_Click(object sender, EventArgs e)
        {
            frmArayuz gizle = new frmArayuz();
            gizle.Hide();
            frmYeniKelime ac = new frmYeniKelime();
            ac.Show();
            this.Hide();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frmArayuz kapat = new frmArayuz();
            kapat.Hide();
            frmSozluk ac = new frmSozluk();
            ac.Show();
            this.Hide();
        }

        private void Btnİstatistik_Click(object sender, EventArgs e)
        {
            frmArayuz kapat = new frmArayuz();
            kapat.Hide();
            frmOgrenilen ac = new frmOgrenilen();
            ac.Show();
            this.Hide();
        }
    }
}
