namespace WordBank
{
    partial class frmKelimeEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKelimeEkle));
            this.btnK_Ekle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtTrKelime = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtİngKelime = new Bunifu.Framework.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnK_Geri = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEkleBilgi = new Bunifu.Framework.BunifuCustomTextbox();
            this.SuspendLayout();
            // 
            // btnK_Ekle
            // 
            this.btnK_Ekle.Active = false;
            this.btnK_Ekle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnK_Ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnK_Ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnK_Ekle.BorderRadius = 0;
            this.btnK_Ekle.ButtonText = "Kelime Ekle";
            this.btnK_Ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnK_Ekle.DisabledColor = System.Drawing.Color.Gray;
            this.btnK_Ekle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnK_Ekle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnK_Ekle.Iconimage")));
            this.btnK_Ekle.Iconimage_right = null;
            this.btnK_Ekle.Iconimage_right_Selected = null;
            this.btnK_Ekle.Iconimage_Selected = null;
            this.btnK_Ekle.IconMarginLeft = 0;
            this.btnK_Ekle.IconMarginRight = 0;
            this.btnK_Ekle.IconRightVisible = true;
            this.btnK_Ekle.IconRightZoom = 0D;
            this.btnK_Ekle.IconVisible = true;
            this.btnK_Ekle.IconZoom = 90D;
            this.btnK_Ekle.IsTab = false;
            this.btnK_Ekle.Location = new System.Drawing.Point(208, 183);
            this.btnK_Ekle.Name = "btnK_Ekle";
            this.btnK_Ekle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnK_Ekle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnK_Ekle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnK_Ekle.selected = false;
            this.btnK_Ekle.Size = new System.Drawing.Size(233, 48);
            this.btnK_Ekle.TabIndex = 0;
            this.btnK_Ekle.Text = "Kelime Ekle";
            this.btnK_Ekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnK_Ekle.Textcolor = System.Drawing.Color.White;
            this.btnK_Ekle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK_Ekle.Click += new System.EventHandler(this.BtnK_Ekle_Click);
            // 
            // txtTrKelime
            // 
            this.txtTrKelime.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTrKelime.Location = new System.Drawing.Point(208, 66);
            this.txtTrKelime.Name = "txtTrKelime";
            this.txtTrKelime.Size = new System.Drawing.Size(233, 20);
            this.txtTrKelime.TabIndex = 1;
            // 
            // txtİngKelime
            // 
            this.txtİngKelime.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtİngKelime.Location = new System.Drawing.Point(208, 105);
            this.txtİngKelime.Name = "txtİngKelime";
            this.txtİngKelime.Size = new System.Drawing.Size(233, 20);
            this.txtİngKelime.TabIndex = 2;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(18, 66);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(121, 20);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Türkçe Kelime";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(18, 103);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(142, 20);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "İngilizce Karşılığı";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(30, 18);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(402, 24);
            this.bunifuCustomLabel3.TabIndex = 5;
            this.bunifuCustomLabel3.Text = "Lütfen Eklemek İstediğiniz Kelimeyi Giriniz";
            // 
            // btnK_Geri
            // 
            this.btnK_Geri.Active = false;
            this.btnK_Geri.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnK_Geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnK_Geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnK_Geri.BorderRadius = 0;
            this.btnK_Geri.ButtonText = "Geri Dön";
            this.btnK_Geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnK_Geri.DisabledColor = System.Drawing.Color.Gray;
            this.btnK_Geri.Iconcolor = System.Drawing.Color.Transparent;
            this.btnK_Geri.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnK_Geri.Iconimage")));
            this.btnK_Geri.Iconimage_right = null;
            this.btnK_Geri.Iconimage_right_Selected = null;
            this.btnK_Geri.Iconimage_Selected = null;
            this.btnK_Geri.IconMarginLeft = 0;
            this.btnK_Geri.IconMarginRight = 0;
            this.btnK_Geri.IconRightVisible = true;
            this.btnK_Geri.IconRightZoom = 0D;
            this.btnK_Geri.IconVisible = true;
            this.btnK_Geri.IconZoom = 90D;
            this.btnK_Geri.IsTab = false;
            this.btnK_Geri.Location = new System.Drawing.Point(22, 183);
            this.btnK_Geri.Name = "btnK_Geri";
            this.btnK_Geri.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnK_Geri.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnK_Geri.OnHoverTextColor = System.Drawing.Color.White;
            this.btnK_Geri.selected = false;
            this.btnK_Geri.Size = new System.Drawing.Size(180, 48);
            this.btnK_Geri.TabIndex = 6;
            this.btnK_Geri.Text = "Geri Dön";
            this.btnK_Geri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnK_Geri.Textcolor = System.Drawing.Color.White;
            this.btnK_Geri.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK_Geri.Click += new System.EventHandler(this.BtnK_Geri_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(18, 142);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(43, 20);
            this.bunifuCustomLabel4.TabIndex = 7;
            this.bunifuCustomLabel4.Text = "Bilgi";
            // 
            // txtEkleBilgi
            // 
            this.txtEkleBilgi.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtEkleBilgi.Location = new System.Drawing.Point(208, 142);
            this.txtEkleBilgi.Name = "txtEkleBilgi";
            this.txtEkleBilgi.Size = new System.Drawing.Size(233, 20);
            this.txtEkleBilgi.TabIndex = 8;
            // 
            // frmKelimeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 243);
            this.ControlBox = false;
            this.Controls.Add(this.txtEkleBilgi);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.btnK_Geri);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtİngKelime);
            this.Controls.Add(this.txtTrKelime);
            this.Controls.Add(this.btnK_Ekle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKelimeEkle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.KelimeEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnK_Ekle;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTrKelime;
        private Bunifu.Framework.BunifuCustomTextbox txtİngKelime;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnK_Geri;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.BunifuCustomTextbox txtEkleBilgi;
    }
}