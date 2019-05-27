namespace WordBank
{
    partial class frmArayuz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArayuz));
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnİstatistik = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCikis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTumKelimeler = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKelimeSil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKelimeEkle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnYeniKelime = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(152, 13);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(231, 39);
            this.bunifuDatepicker1.TabIndex = 2;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 5, 28, 1, 58, 33, 0);
            // 
            // btnİstatistik
            // 
            this.btnİstatistik.Active = false;
            this.btnİstatistik.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnİstatistik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnİstatistik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnİstatistik.BorderRadius = 0;
            this.btnİstatistik.ButtonText = "Öğrenilenler";
            this.btnİstatistik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnİstatistik.DisabledColor = System.Drawing.Color.Gray;
            this.btnİstatistik.Iconcolor = System.Drawing.Color.Transparent;
            this.btnİstatistik.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnİstatistik.Iconimage")));
            this.btnİstatistik.Iconimage_right = null;
            this.btnİstatistik.Iconimage_right_Selected = null;
            this.btnİstatistik.Iconimage_Selected = null;
            this.btnİstatistik.IconMarginLeft = 0;
            this.btnİstatistik.IconMarginRight = 0;
            this.btnİstatistik.IconRightVisible = true;
            this.btnİstatistik.IconRightZoom = 0D;
            this.btnİstatistik.IconVisible = true;
            this.btnİstatistik.IconZoom = 90D;
            this.btnİstatistik.IsTab = false;
            this.btnİstatistik.Location = new System.Drawing.Point(251, 103);
            this.btnİstatistik.Name = "btnİstatistik";
            this.btnİstatistik.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnİstatistik.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnİstatistik.OnHoverTextColor = System.Drawing.Color.White;
            this.btnİstatistik.selected = false;
            this.btnİstatistik.Size = new System.Drawing.Size(132, 39);
            this.btnİstatistik.TabIndex = 10;
            this.btnİstatistik.Text = "Öğrenilenler";
            this.btnİstatistik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnİstatistik.Textcolor = System.Drawing.Color.White;
            this.btnİstatistik.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnİstatistik.Click += new System.EventHandler(this.Btnİstatistik_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Active = false;
            this.btnCikis.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.BorderRadius = 0;
            this.btnCikis.ButtonText = "Oturumu Kapat";
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
            this.btnCikis.Location = new System.Drawing.Point(15, 283);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCikis.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCikis.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCikis.selected = false;
            this.btnCikis.Size = new System.Drawing.Size(368, 37);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.Text = "Oturumu Kapat";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Textcolor = System.Drawing.Color.White;
            this.btnCikis.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // btnTumKelimeler
            // 
            this.btnTumKelimeler.Active = false;
            this.btnTumKelimeler.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTumKelimeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTumKelimeler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTumKelimeler.BorderRadius = 0;
            this.btnTumKelimeler.ButtonText = "Tüm Kelimeler";
            this.btnTumKelimeler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTumKelimeler.DisabledColor = System.Drawing.Color.Gray;
            this.btnTumKelimeler.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTumKelimeler.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTumKelimeler.Iconimage")));
            this.btnTumKelimeler.Iconimage_right = null;
            this.btnTumKelimeler.Iconimage_right_Selected = null;
            this.btnTumKelimeler.Iconimage_Selected = null;
            this.btnTumKelimeler.IconMarginLeft = 0;
            this.btnTumKelimeler.IconMarginRight = 0;
            this.btnTumKelimeler.IconRightVisible = true;
            this.btnTumKelimeler.IconRightZoom = 0D;
            this.btnTumKelimeler.IconVisible = true;
            this.btnTumKelimeler.IconZoom = 90D;
            this.btnTumKelimeler.IsTab = false;
            this.btnTumKelimeler.Location = new System.Drawing.Point(15, 238);
            this.btnTumKelimeler.Name = "btnTumKelimeler";
            this.btnTumKelimeler.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTumKelimeler.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTumKelimeler.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTumKelimeler.selected = false;
            this.btnTumKelimeler.Size = new System.Drawing.Size(368, 39);
            this.btnTumKelimeler.TabIndex = 8;
            this.btnTumKelimeler.Text = "Tüm Kelimeler";
            this.btnTumKelimeler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTumKelimeler.Textcolor = System.Drawing.Color.White;
            this.btnTumKelimeler.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTumKelimeler.Click += new System.EventHandler(this.BtnTumKelimeler_Click);
            // 
            // btnKelimeSil
            // 
            this.btnKelimeSil.Active = false;
            this.btnKelimeSil.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnKelimeSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnKelimeSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKelimeSil.BorderRadius = 0;
            this.btnKelimeSil.ButtonText = "Kelime Sil";
            this.btnKelimeSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKelimeSil.DisabledColor = System.Drawing.Color.Gray;
            this.btnKelimeSil.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKelimeSil.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnKelimeSil.Iconimage")));
            this.btnKelimeSil.Iconimage_right = null;
            this.btnKelimeSil.Iconimage_right_Selected = null;
            this.btnKelimeSil.Iconimage_Selected = null;
            this.btnKelimeSil.IconMarginLeft = 0;
            this.btnKelimeSil.IconMarginRight = 0;
            this.btnKelimeSil.IconRightVisible = true;
            this.btnKelimeSil.IconRightZoom = 0D;
            this.btnKelimeSil.IconVisible = true;
            this.btnKelimeSil.IconZoom = 90D;
            this.btnKelimeSil.IsTab = false;
            this.btnKelimeSil.Location = new System.Drawing.Point(15, 193);
            this.btnKelimeSil.Name = "btnKelimeSil";
            this.btnKelimeSil.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnKelimeSil.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnKelimeSil.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKelimeSil.selected = false;
            this.btnKelimeSil.Size = new System.Drawing.Size(368, 39);
            this.btnKelimeSil.TabIndex = 7;
            this.btnKelimeSil.Text = "Kelime Sil";
            this.btnKelimeSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKelimeSil.Textcolor = System.Drawing.Color.White;
            this.btnKelimeSil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKelimeSil.Click += new System.EventHandler(this.BtnKelimeSil_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Sözlük";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(152, 103);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(93, 39);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.Text = "Sözlük";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // btnKelimeEkle
            // 
            this.btnKelimeEkle.Active = false;
            this.btnKelimeEkle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnKelimeEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnKelimeEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKelimeEkle.BorderRadius = 0;
            this.btnKelimeEkle.ButtonText = "Kelime Ekle";
            this.btnKelimeEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKelimeEkle.DisabledColor = System.Drawing.Color.Gray;
            this.btnKelimeEkle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKelimeEkle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnKelimeEkle.Iconimage")));
            this.btnKelimeEkle.Iconimage_right = null;
            this.btnKelimeEkle.Iconimage_right_Selected = null;
            this.btnKelimeEkle.Iconimage_Selected = null;
            this.btnKelimeEkle.IconMarginLeft = 0;
            this.btnKelimeEkle.IconMarginRight = 0;
            this.btnKelimeEkle.IconRightVisible = true;
            this.btnKelimeEkle.IconRightZoom = 0D;
            this.btnKelimeEkle.IconVisible = true;
            this.btnKelimeEkle.IconZoom = 90D;
            this.btnKelimeEkle.IsTab = false;
            this.btnKelimeEkle.Location = new System.Drawing.Point(15, 148);
            this.btnKelimeEkle.Name = "btnKelimeEkle";
            this.btnKelimeEkle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnKelimeEkle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnKelimeEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKelimeEkle.selected = false;
            this.btnKelimeEkle.Size = new System.Drawing.Size(368, 39);
            this.btnKelimeEkle.TabIndex = 5;
            this.btnKelimeEkle.Text = "Kelime Ekle";
            this.btnKelimeEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKelimeEkle.Textcolor = System.Drawing.Color.White;
            this.btnKelimeEkle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKelimeEkle.Click += new System.EventHandler(this.BtnKelimeEkle_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Hoşgeldiniz";
            this.bunifuTileButton1.Location = new System.Drawing.Point(15, 13);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton1.TabIndex = 3;
            // 
            // btnYeniKelime
            // 
            this.btnYeniKelime.Active = false;
            this.btnYeniKelime.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnYeniKelime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnYeniKelime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeniKelime.BorderRadius = 0;
            this.btnYeniKelime.ButtonText = "Yeni Kelime Öğren";
            this.btnYeniKelime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeniKelime.DisabledColor = System.Drawing.Color.Gray;
            this.btnYeniKelime.Iconcolor = System.Drawing.Color.Transparent;
            this.btnYeniKelime.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnYeniKelime.Iconimage")));
            this.btnYeniKelime.Iconimage_right = null;
            this.btnYeniKelime.Iconimage_right_Selected = null;
            this.btnYeniKelime.Iconimage_Selected = null;
            this.btnYeniKelime.IconMarginLeft = 0;
            this.btnYeniKelime.IconMarginRight = 0;
            this.btnYeniKelime.IconRightVisible = true;
            this.btnYeniKelime.IconRightZoom = 0D;
            this.btnYeniKelime.IconVisible = true;
            this.btnYeniKelime.IconZoom = 90D;
            this.btnYeniKelime.IsTab = false;
            this.btnYeniKelime.Location = new System.Drawing.Point(152, 58);
            this.btnYeniKelime.Name = "btnYeniKelime";
            this.btnYeniKelime.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnYeniKelime.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnYeniKelime.OnHoverTextColor = System.Drawing.Color.White;
            this.btnYeniKelime.selected = false;
            this.btnYeniKelime.Size = new System.Drawing.Size(231, 39);
            this.btnYeniKelime.TabIndex = 1;
            this.btnYeniKelime.Text = "Yeni Kelime Öğren";
            this.btnYeniKelime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeniKelime.Textcolor = System.Drawing.Color.White;
            this.btnYeniKelime.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeniKelime.Click += new System.EventHandler(this.BtnYeniKelime_Click);
            // 
            // frmArayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 338);
            this.Controls.Add(this.btnİstatistik);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTumKelimeler);
            this.Controls.Add(this.btnKelimeSil);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnKelimeEkle);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.btnYeniKelime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArayuz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arayuz";
            this.Load += new System.EventHandler(this.FrmArayuz_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnYeniKelime;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnKelimeEkle;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnKelimeSil;
        private Bunifu.Framework.UI.BunifuFlatButton btnTumKelimeler;
        private Bunifu.Framework.UI.BunifuFlatButton btnCikis;
        private Bunifu.Framework.UI.BunifuFlatButton btnİstatistik;
    }
}