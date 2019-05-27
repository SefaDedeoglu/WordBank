namespace WordBank
{
    partial class frmOgrenilen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenilen));
            this.listOgrenilen = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuVTrackbar1 = new Bunifu.Framework.UI.BunifuVTrackbar();
            this.btnOgrenilenGeri = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // listOgrenilen
            // 
            this.listOgrenilen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listOgrenilen.Location = new System.Drawing.Point(1, 1);
            this.listOgrenilen.Name = "listOgrenilen";
            this.listOgrenilen.Size = new System.Drawing.Size(251, 330);
            this.listOgrenilen.TabIndex = 0;
            this.listOgrenilen.UseCompatibleStateImageBehavior = false;
            this.listOgrenilen.View = System.Windows.Forms.View.Details;
            this.listOgrenilen.SelectedIndexChanged += new System.EventHandler(this.ListOgrenilen_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kelime";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tarih";
            this.columnHeader3.Width = 108;
            // 
            // bunifuVTrackbar1
            // 
            this.bunifuVTrackbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuVTrackbar1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuVTrackbar1.BorderRadius = 0;
            this.bunifuVTrackbar1.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuVTrackbar1.Location = new System.Drawing.Point(258, 1);
            this.bunifuVTrackbar1.MaximumValue = 100;
            this.bunifuVTrackbar1.Name = "bunifuVTrackbar1";
            this.bunifuVTrackbar1.Size = new System.Drawing.Size(30, 330);
            this.bunifuVTrackbar1.SliderRadius = 0;
            this.bunifuVTrackbar1.TabIndex = 1;
            this.bunifuVTrackbar1.Value = 0;
            // 
            // btnOgrenilenGeri
            // 
            this.btnOgrenilenGeri.Active = false;
            this.btnOgrenilenGeri.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOgrenilenGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOgrenilenGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgrenilenGeri.BorderRadius = 0;
            this.btnOgrenilenGeri.ButtonText = "Geri Dön";
            this.btnOgrenilenGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOgrenilenGeri.DisabledColor = System.Drawing.Color.Gray;
            this.btnOgrenilenGeri.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOgrenilenGeri.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOgrenilenGeri.Iconimage")));
            this.btnOgrenilenGeri.Iconimage_right = null;
            this.btnOgrenilenGeri.Iconimage_right_Selected = null;
            this.btnOgrenilenGeri.Iconimage_Selected = null;
            this.btnOgrenilenGeri.IconMarginLeft = 0;
            this.btnOgrenilenGeri.IconMarginRight = 0;
            this.btnOgrenilenGeri.IconRightVisible = true;
            this.btnOgrenilenGeri.IconRightZoom = 0D;
            this.btnOgrenilenGeri.IconVisible = true;
            this.btnOgrenilenGeri.IconZoom = 90D;
            this.btnOgrenilenGeri.IsTab = false;
            this.btnOgrenilenGeri.Location = new System.Drawing.Point(1, 337);
            this.btnOgrenilenGeri.Name = "btnOgrenilenGeri";
            this.btnOgrenilenGeri.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOgrenilenGeri.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnOgrenilenGeri.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOgrenilenGeri.selected = false;
            this.btnOgrenilenGeri.Size = new System.Drawing.Size(282, 47);
            this.btnOgrenilenGeri.TabIndex = 2;
            this.btnOgrenilenGeri.Text = "Geri Dön";
            this.btnOgrenilenGeri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOgrenilenGeri.Textcolor = System.Drawing.Color.White;
            this.btnOgrenilenGeri.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrenilenGeri.Click += new System.EventHandler(this.BtnOgrenilenGeri_Click);
            // 
            // frmOgrenilen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 387);
            this.ControlBox = false;
            this.Controls.Add(this.btnOgrenilenGeri);
            this.Controls.Add(this.bunifuVTrackbar1);
            this.Controls.Add(this.listOgrenilen);
            this.Name = "frmOgrenilen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmOgrenilen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listOgrenilen;
        private Bunifu.Framework.UI.BunifuVTrackbar bunifuVTrackbar1;
        private Bunifu.Framework.UI.BunifuFlatButton btnOgrenilenGeri;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}