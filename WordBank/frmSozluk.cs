using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordBank
{
    public partial class frmSozluk : Form
    {
        Translator szlk = new Translator();
        public frmSozluk()
        {
            InitializeComponent();
        }

        private void BtnSozGeri_Click(object sender, EventArgs e)
        {
            frmSozluk kapat = new frmSozluk();
            kapat.Close();
            frmArayuz ac = new frmArayuz();
            ac.Show();
            this.Hide();
        }

        private void BtnCevir_Click(object sender, EventArgs e)
        {
            string İngilizce = szlk.ingilizce_cevir(txtSozTR.Text);
            
            if (İngilizce   != null)
            {
                txtSozİng.Text = İngilizce;
                
            }
            else
            {
                MessageBox.Show("Aradığınız kelime bulunamadı");
            }
        }

        private void BtnTr_ing_Click(object sender, EventArgs e)
        {
            string Turkce = szlk.turkce_cevir(txtSozİng.Text);
            if (Turkce != null)
            {
                txtSozTR.Text = Turkce;
                
            }
            else
            {
                MessageBox.Show("Aradığınız kelime bulunamadı");
            }
        }
    }
}
