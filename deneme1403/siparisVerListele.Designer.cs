namespace deneme1403
{
    partial class siparisVerListele
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siparisVerListele));
            this.hareketDranPanelTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.masaNoVeriListele = new System.Windows.Forms.Label();
            this.masaNo = new System.Windows.Forms.ComboBox();
            this.siparisVerListleleGeri = new Bunifu.Framework.UI.BunifuImageButton();
            this.listeleListView = new System.Windows.Forms.ListView();
            this.urunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunAdet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.listSil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.siparisVerListleleGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // hareketDranPanelTop
            // 
            this.hareketDranPanelTop.BackColor = System.Drawing.SystemColors.InfoText;
            this.hareketDranPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.hareketDranPanelTop.Location = new System.Drawing.Point(0, 0);
            this.hareketDranPanelTop.Name = "hareketDranPanelTop";
            this.hareketDranPanelTop.Size = new System.Drawing.Size(412, 10);
            this.hareketDranPanelTop.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(402, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 584);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 584);
            this.panel1.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 584);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 10);
            this.panel3.TabIndex = 25;
            // 
            // masaNoVeriListele
            // 
            this.masaNoVeriListele.AutoSize = true;
            this.masaNoVeriListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masaNoVeriListele.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.masaNoVeriListele.Location = new System.Drawing.Point(50, 68);
            this.masaNoVeriListele.Name = "masaNoVeriListele";
            this.masaNoVeriListele.Size = new System.Drawing.Size(165, 24);
            this.masaNoVeriListele.TabIndex = 27;
            this.masaNoVeriListele.Text = "Masa Numarası: ";
            // 
            // masaNo
            // 
            this.masaNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.masaNo.FormattingEnabled = true;
            this.masaNo.Location = new System.Drawing.Point(252, 68);
            this.masaNo.Name = "masaNo";
            this.masaNo.Size = new System.Drawing.Size(121, 24);
            this.masaNo.TabIndex = 26;
            this.masaNo.SelectedIndexChanged += new System.EventHandler(this.masaNoComboVeriListele_SelectedIndexChanged);
            // 
            // siparisVerListleleGeri
            // 
            this.siparisVerListleleGeri.BackColor = System.Drawing.SystemColors.WindowText;
            this.siparisVerListleleGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siparisVerListleleGeri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siparisVerListleleGeri.Image = ((System.Drawing.Image)(resources.GetObject("siparisVerListleleGeri.Image")));
            this.siparisVerListleleGeri.ImageActive = null;
            this.siparisVerListleleGeri.Location = new System.Drawing.Point(10, 540);
            this.siparisVerListleleGeri.Name = "siparisVerListleleGeri";
            this.siparisVerListleleGeri.Size = new System.Drawing.Size(392, 44);
            this.siparisVerListleleGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.siparisVerListleleGeri.TabIndex = 28;
            this.siparisVerListleleGeri.TabStop = false;
            this.siparisVerListleleGeri.Zoom = 10;
            this.siparisVerListleleGeri.Click += new System.EventHandler(this.masaHakkindaGeri_Click);
            // 
            // listeleListView
            // 
            this.listeleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urunAdi,
            this.urunAdet});
            this.listeleListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listeleListView.HideSelection = false;
            this.listeleListView.Location = new System.Drawing.Point(16, 144);
            this.listeleListView.Name = "listeleListView";
            this.listeleListView.Size = new System.Drawing.Size(380, 336);
            this.listeleListView.TabIndex = 29;
            this.listeleListView.UseCompatibleStateImageBehavior = false;
            this.listeleListView.View = System.Windows.Forms.View.Details;
            this.listeleListView.SelectedIndexChanged += new System.EventHandler(this.listeleListView_SelectedIndexChanged);
            // 
            // urunAdi
            // 
            this.urunAdi.Text = "Ürün Adı";
            this.urunAdi.Width = 131;
            // 
            // urunAdet
            // 
            this.urunAdet.Text = "Ürün Adet";
            this.urunAdet.Width = 90;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.listeleListView;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this.masaNo;
            // 
            // listSil
            // 
            this.listSil.Activecolor = System.Drawing.Color.Green;
            this.listSil.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.listSil.BackColor = System.Drawing.SystemColors.WindowText;
            this.listSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.listSil.BorderRadius = 0;
            this.listSil.ButtonText = "         Sil";
            this.listSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listSil.DisabledColor = System.Drawing.Color.Gray;
            this.listSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listSil.Iconcolor = System.Drawing.Color.Transparent;
            this.listSil.Iconimage = null;
            this.listSil.Iconimage_right = null;
            this.listSil.Iconimage_right_Selected = null;
            this.listSil.Iconimage_Selected = null;
            this.listSil.IconMarginLeft = 0;
            this.listSil.IconMarginRight = 0;
            this.listSil.IconRightVisible = true;
            this.listSil.IconRightZoom = 0D;
            this.listSil.IconVisible = true;
            this.listSil.IconZoom = 90D;
            this.listSil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listSil.IsTab = false;
            this.listSil.Location = new System.Drawing.Point(292, 493);
            this.listSil.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.listSil.Name = "listSil";
            this.listSil.Normalcolor = System.Drawing.SystemColors.WindowText;
            this.listSil.OnHovercolor = System.Drawing.Color.Red;
            this.listSil.OnHoverTextColor = System.Drawing.Color.White;
            this.listSil.selected = false;
            this.listSil.Size = new System.Drawing.Size(92, 36);
            this.listSil.TabIndex = 36;
            this.listSil.Text = "         Sil";
            this.listSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listSil.Textcolor = System.Drawing.Color.White;
            this.listSil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSil.Click += new System.EventHandler(this.listSil_Click);
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 15;
            this.bunifuElipse4.TargetControl = this.listSil;
            // 
            // siparisVerListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(412, 594);
            this.Controls.Add(this.listSil);
            this.Controls.Add(this.listeleListView);
            this.Controls.Add(this.siparisVerListleleGeri);
            this.Controls.Add(this.masaNoVeriListele);
            this.Controls.Add(this.masaNo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.hareketDranPanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "siparisVerListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "siparisVerListele";
            this.Load += new System.EventHandler(this.siparisVerListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siparisVerListleleGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel hareketDranPanelTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label masaNoVeriListele;
        private System.Windows.Forms.ComboBox masaNo;
        private Bunifu.Framework.UI.BunifuImageButton siparisVerListleleGeri;
        private System.Windows.Forms.ListView listeleListView;
        private System.Windows.Forms.ColumnHeader urunAdi;
        private System.Windows.Forms.ColumnHeader urunAdet;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuFlatButton listSil;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
    }
}