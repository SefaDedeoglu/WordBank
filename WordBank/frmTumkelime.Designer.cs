namespace WordBank
{
    partial class frmTumKelime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTumKelime));
            this.bunifuVTrackbar1 = new Bunifu.Framework.UI.BunifuVTrackbar();
            
            this.listKelime = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnT_K_Geri = new Bunifu.Framework.UI.BunifuFlatButton();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            
            this.SuspendLayout();
            // 
            // bunifuVTrackbar1
            // 
            this.bunifuVTrackbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuVTrackbar1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuVTrackbar1.BorderRadius = 0;
            this.bunifuVTrackbar1.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuVTrackbar1.Location = new System.Drawing.Point(302, 12);
            this.bunifuVTrackbar1.MaximumValue = 100;
            this.bunifuVTrackbar1.Name = "bunifuVTrackbar1";
            this.bunifuVTrackbar1.Size = new System.Drawing.Size(30, 390);
            this.bunifuVTrackbar1.SliderRadius = 0;
            this.bunifuVTrackbar1.TabIndex = 0;
            this.bunifuVTrackbar1.Value = 0;
            // 
            // wordbankDataSet
            // 
            
            
            // 
            // listKelime
            // 
            this.listKelime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listKelime.Location = new System.Drawing.Point(12, 12);
            this.listKelime.Name = "listKelime";
            this.listKelime.Size = new System.Drawing.Size(284, 334);
            this.listKelime.TabIndex = 1;
            this.listKelime.UseCompatibleStateImageBehavior = false;
            this.listKelime.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No:";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Türkçe";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İngilizce";
            // 
            // btnT_K_Geri
            // 
            this.btnT_K_Geri.Active = false;
            this.btnT_K_Geri.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnT_K_Geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnT_K_Geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnT_K_Geri.BorderRadius = 0;
            this.btnT_K_Geri.ButtonText = "Geri Dön";
            this.btnT_K_Geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnT_K_Geri.DisabledColor = System.Drawing.Color.Gray;
            this.btnT_K_Geri.Iconcolor = System.Drawing.Color.Transparent;
            this.btnT_K_Geri.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnT_K_Geri.Iconimage")));
            this.btnT_K_Geri.Iconimage_right = null;
            this.btnT_K_Geri.Iconimage_right_Selected = null;
            this.btnT_K_Geri.Iconimage_Selected = null;
            this.btnT_K_Geri.IconMarginLeft = 0;
            this.btnT_K_Geri.IconMarginRight = 0;
            this.btnT_K_Geri.IconRightVisible = true;
            this.btnT_K_Geri.IconRightZoom = 0D;
            this.btnT_K_Geri.IconVisible = true;
            this.btnT_K_Geri.IconZoom = 90D;
            this.btnT_K_Geri.IsTab = false;
            this.btnT_K_Geri.Location = new System.Drawing.Point(12, 354);
            this.btnT_K_Geri.Name = "btnT_K_Geri";
            this.btnT_K_Geri.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnT_K_Geri.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnT_K_Geri.OnHoverTextColor = System.Drawing.Color.White;
            this.btnT_K_Geri.selected = false;
            this.btnT_K_Geri.Size = new System.Drawing.Size(284, 48);
            this.btnT_K_Geri.TabIndex = 2;
            this.btnT_K_Geri.Text = "Geri Dön";
            this.btnT_K_Geri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnT_K_Geri.Textcolor = System.Drawing.Color.White;
            this.btnT_K_Geri.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT_K_Geri.Click += new System.EventHandler(this.BtnT_K_Geri_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bilgi";
            // 
            // frmTumKelime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 412);
            this.ControlBox = false;
            this.Controls.Add(this.btnT_K_Geri);
            this.Controls.Add(this.listKelime);
            this.Controls.Add(this.bunifuVTrackbar1);
            this.Name = "frmTumKelime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmTumKelime_Load);
            
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuVTrackbar bunifuVTrackbar1;
        
        private System.Windows.Forms.ListView listKelime;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Bunifu.Framework.UI.BunifuFlatButton btnT_K_Geri;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}