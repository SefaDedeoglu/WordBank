namespace WordBank
{
    partial class frmAnaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaMenu));
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCikis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKullaniciEkle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGiris = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(189, 29);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(311, 20);
            this.txtKullaniciAd.TabIndex = 2;
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(189, 78);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.PasswordChar = '*';
            this.txtKullaniciSifre.Size = new System.Drawing.Size(311, 20);
            this.txtKullaniciSifre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "KULLANICI ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ŞİFRE";
            // 
            // btnCikis
            // 
            this.btnCikis.Active = false;
            this.btnCikis.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.BorderRadius = 0;
            this.btnCikis.ButtonText = "ÇIKIŞ";
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.DisabledColor = System.Drawing.Color.Gray;
            this.btnCikis.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCikis.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCikis.Iconimage")));
            this.btnCikis.Iconimage_right = null;
            this.btnCikis.Iconimage_right_Selected = null;
            this.btnCikis.Iconimage_Selected = null;
            this.btnCikis.IconMarginLeft = 0;
            this.btnCikis.IconMarginRight = 0;
            this.btnCikis.IconRightVisible = true;
            this.btnCikis.IconRightZoom = 0D;
            this.btnCikis.IconVisible = true;
            this.btnCikis.IconZoom = 90D;
            this.btnCikis.IsTab = false;
            this.btnCikis.Location = new System.Drawing.Point(12, 228);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCikis.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCikis.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCikis.selected = false;
            this.btnCikis.Size = new System.Drawing.Size(488, 48);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Textcolor = System.Drawing.Color.White;
            this.btnCikis.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Active = false;
            this.btnKullaniciEkle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnKullaniciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnKullaniciEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKullaniciEkle.BorderRadius = 0;
            this.btnKullaniciEkle.ButtonText = "KULLANICI EKLE";
            this.btnKullaniciEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKullaniciEkle.DisabledColor = System.Drawing.Color.Gray;
            this.btnKullaniciEkle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKullaniciEkle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnKullaniciEkle.Iconimage")));
            this.btnKullaniciEkle.Iconimage_right = null;
            this.btnKullaniciEkle.Iconimage_right_Selected = null;
            this.btnKullaniciEkle.Iconimage_Selected = null;
            this.btnKullaniciEkle.IconMarginLeft = 0;
            this.btnKullaniciEkle.IconMarginRight = 0;
            this.btnKullaniciEkle.IconRightVisible = true;
            this.btnKullaniciEkle.IconRightZoom = 0D;
            this.btnKullaniciEkle.IconVisible = true;
            this.btnKullaniciEkle.IconZoom = 90D;
            this.btnKullaniciEkle.IsTab = false;
            this.btnKullaniciEkle.Location = new System.Drawing.Point(12, 174);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnKullaniciEkle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnKullaniciEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKullaniciEkle.selected = false;
            this.btnKullaniciEkle.Size = new System.Drawing.Size(241, 48);
            this.btnKullaniciEkle.TabIndex = 7;
            this.btnKullaniciEkle.Text = "KULLANICI EKLE";
            this.btnKullaniciEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKullaniciEkle.Textcolor = System.Drawing.Color.White;
            this.btnKullaniciEkle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKullaniciEkle.Click += new System.EventHandler(this.BtnKullaniciEkle_Click_1);
            // 
            // btnGiris
            // 
            this.btnGiris.Active = false;
            this.btnGiris.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.BorderRadius = 0;
            this.btnGiris.ButtonText = "GİRİŞ";
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.DisabledColor = System.Drawing.Color.Gray;
            this.btnGiris.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGiris.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGiris.Iconimage")));
            this.btnGiris.Iconimage_right = null;
            this.btnGiris.Iconimage_right_Selected = null;
            this.btnGiris.Iconimage_Selected = null;
            this.btnGiris.IconMarginLeft = 0;
            this.btnGiris.IconMarginRight = 0;
            this.btnGiris.IconRightVisible = true;
            this.btnGiris.IconRightZoom = 0D;
            this.btnGiris.IconVisible = true;
            this.btnGiris.IconZoom = 90D;
            this.btnGiris.IsTab = false;
            this.btnGiris.Location = new System.Drawing.Point(259, 174);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGiris.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGiris.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGiris.selected = false;
            this.btnGiris.Size = new System.Drawing.Size(241, 48);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiris.Textcolor = System.Drawing.Color.White;
            this.btnGiris.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.Click += new System.EventHandler(this.BtnGiris_Click_1);
            // 
            // frmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 286);
            this.ControlBox = false;
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKullaniciEkle);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.txtKullaniciAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "frmAnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnGiris;
        private Bunifu.Framework.UI.BunifuFlatButton btnKullaniciEkle;
        private Bunifu.Framework.UI.BunifuFlatButton btnCikis;
    }
}

