namespace deneme1403
{
    partial class masaHakkinda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masaHakkinda));
            this.masaHakkindaAd = new System.Windows.Forms.Label();
            this.masaHakkindaPanel = new System.Windows.Forms.Panel();
            this.masaHakkindaList = new System.Windows.Forms.ListView();
            this.ürünAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ürünFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunMiktari = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personelAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.masaHakkindaGeri = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.masaHakkindaDrag = new System.Windows.Forms.Panel();
            this.masaNo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.masaHakkindaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masaHakkindaGeri)).BeginInit();
            this.masaHakkindaDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // masaHakkindaAd
            // 
            this.masaHakkindaAd.AutoSize = true;
            this.masaHakkindaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masaHakkindaAd.Location = new System.Drawing.Point(616, 29);
            this.masaHakkindaAd.Name = "masaHakkindaAd";
            this.masaHakkindaAd.Size = new System.Drawing.Size(234, 32);
            this.masaHakkindaAd.TabIndex = 0;
            this.masaHakkindaAd.Text = "Masa Numarası:";
            this.masaHakkindaAd.Click += new System.EventHandler(this.MasaHakkindaAd_Click);
            // 
            // masaHakkindaPanel
            // 
            this.masaHakkindaPanel.Controls.Add(this.masaHakkindaList);
            this.masaHakkindaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masaHakkindaPanel.Location = new System.Drawing.Point(0, 0);
            this.masaHakkindaPanel.Name = "masaHakkindaPanel";
            this.masaHakkindaPanel.Size = new System.Drawing.Size(1519, 748);
            this.masaHakkindaPanel.TabIndex = 1;
            // 
            // masaHakkindaList
            // 
            this.masaHakkindaList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ürünAdi,
            this.ürünFiyati,
            this.urunMiktari,
            this.personelAdi});
            this.masaHakkindaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masaHakkindaList.Location = new System.Drawing.Point(0, 76);
            this.masaHakkindaList.Name = "masaHakkindaList";
            this.masaHakkindaList.Size = new System.Drawing.Size(1516, 669);
            this.masaHakkindaList.TabIndex = 2;
            this.masaHakkindaList.UseCompatibleStateImageBehavior = false;
            this.masaHakkindaList.View = System.Windows.Forms.View.Details;
            this.masaHakkindaList.SelectedIndexChanged += new System.EventHandler(this.MasaHakkindaList_SelectedIndexChanged);
            // 
            // ürünAdi
            // 
            this.ürünAdi.Text = "Ürün Adı";
            this.ürünAdi.Width = 600;
            // 
            // ürünFiyati
            // 
            this.ürünFiyati.Text = "Ürün Birim Fiyatı";
            this.ürünFiyati.Width = 200;
            // 
            // urunMiktari
            // 
            this.urunMiktari.Text = "Miktar";
            this.urunMiktari.Width = 100;
            // 
            // personelAdi
            // 
            this.personelAdi.Text = "Personel Adı";
            this.personelAdi.Width = 200;
            // 
            // masaHakkindaGeri
            // 
            this.masaHakkindaGeri.BackColor = System.Drawing.Color.Transparent;
            this.masaHakkindaGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.masaHakkindaGeri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.masaHakkindaGeri.Image = ((System.Drawing.Image)(resources.GetObject("masaHakkindaGeri.Image")));
            this.masaHakkindaGeri.ImageActive = null;
            this.masaHakkindaGeri.Location = new System.Drawing.Point(0, 748);
            this.masaHakkindaGeri.Name = "masaHakkindaGeri";
            this.masaHakkindaGeri.Size = new System.Drawing.Size(1519, 66);
            this.masaHakkindaGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.masaHakkindaGeri.TabIndex = 2;
            this.masaHakkindaGeri.TabStop = false;
            this.masaHakkindaGeri.Zoom = 10;
            this.masaHakkindaGeri.Click += new System.EventHandler(this.MasaHakkindaGeri_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.masaHakkindaDrag;
            this.bunifuDragControl1.Vertical = true;
            // 
            // masaHakkindaDrag
            // 
            this.masaHakkindaDrag.BackColor = System.Drawing.Color.CornflowerBlue;
            this.masaHakkindaDrag.Controls.Add(this.masaNo);
            this.masaHakkindaDrag.Controls.Add(this.button2);
            this.masaHakkindaDrag.Controls.Add(this.masaHakkindaAd);
            this.masaHakkindaDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.masaHakkindaDrag.Location = new System.Drawing.Point(0, 0);
            this.masaHakkindaDrag.Name = "masaHakkindaDrag";
            this.masaHakkindaDrag.Size = new System.Drawing.Size(1519, 73);
            this.masaHakkindaDrag.TabIndex = 3;
            // 
            // masaNo
            // 
            this.masaNo.AutoSize = true;
            this.masaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masaNo.Location = new System.Drawing.Point(866, 29);
            this.masaNo.Name = "masaNo";
            this.masaNo.Size = new System.Drawing.Size(75, 32);
            this.masaNo.TabIndex = 3;
            this.masaNo.Text = "*****";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 49);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // masaHakkinda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 814);
            this.Controls.Add(this.masaHakkindaDrag);
            this.Controls.Add(this.masaHakkindaPanel);
            this.Controls.Add(this.masaHakkindaGeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(892, 673);
            this.Name = "masaHakkinda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "masaHakkinda";
            this.Load += new System.EventHandler(this.MasaHakkinda_Load);
            this.masaHakkindaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masaHakkindaGeri)).EndInit();
            this.masaHakkindaDrag.ResumeLayout(false);
            this.masaHakkindaDrag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label masaHakkindaAd;
        private System.Windows.Forms.Panel masaHakkindaPanel;
        private Bunifu.Framework.UI.BunifuImageButton masaHakkindaGeri;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel masaHakkindaDrag;
        private System.Windows.Forms.ListView masaHakkindaList;
        private System.Windows.Forms.ColumnHeader ürünAdi;
        private System.Windows.Forms.ColumnHeader ürünFiyati;
        private System.Windows.Forms.ColumnHeader urunMiktari;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label masaNo;
        private System.Windows.Forms.ColumnHeader personelAdi;
    }
}