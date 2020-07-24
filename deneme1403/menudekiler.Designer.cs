namespace deneme1403
{
    partial class menudekiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menudekiler));
            this.menudekilerDrag = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.menudekilerMenuAdi = new System.Windows.Forms.Label();
            this.menudekilerList = new System.Windows.Forms.ListView();
            this.urunid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.masaHakkindaGeri = new Bunifu.Framework.UI.BunifuImageButton();
            this.menudekilerDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masaHakkindaGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // menudekilerDrag
            // 
            this.menudekilerDrag.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menudekilerDrag.Controls.Add(this.button2);
            this.menudekilerDrag.Controls.Add(this.menudekilerMenuAdi);
            this.menudekilerDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.menudekilerDrag.Location = new System.Drawing.Point(0, 0);
            this.menudekilerDrag.Name = "menudekilerDrag";
            this.menudekilerDrag.Size = new System.Drawing.Size(1240, 73);
            this.menudekilerDrag.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 49);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menudekilerMenuAdi
            // 
            this.menudekilerMenuAdi.AutoSize = true;
            this.menudekilerMenuAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menudekilerMenuAdi.Location = new System.Drawing.Point(555, 29);
            this.menudekilerMenuAdi.Name = "menudekilerMenuAdi";
            this.menudekilerMenuAdi.Size = new System.Drawing.Size(143, 32);
            this.menudekilerMenuAdi.TabIndex = 0;
            this.menudekilerMenuAdi.Text = "Menu Adı";
            // 
            // menudekilerList
            // 
            this.menudekilerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menudekilerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urunid,
            this.urunKategori,
            this.urunAdi,
            this.urunFiyati});
            this.menudekilerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menudekilerList.Location = new System.Drawing.Point(0, 79);
            this.menudekilerList.Name = "menudekilerList";
            this.menudekilerList.Size = new System.Drawing.Size(1240, 433);
            this.menudekilerList.TabIndex = 5;
            this.menudekilerList.UseCompatibleStateImageBehavior = false;
            this.menudekilerList.View = System.Windows.Forms.View.Details;
            this.menudekilerList.SelectedIndexChanged += new System.EventHandler(this.masaHakkindaList_SelectedIndexChanged);
            // 
            // urunid
            // 
            this.urunid.Text = "Ürün Kod";
            this.urunid.Width = 127;
            // 
            // urunKategori
            // 
            this.urunKategori.Text = "Kategori";
            this.urunKategori.Width = 100;
            // 
            // urunAdi
            // 
            this.urunAdi.Text = "Ürün Adı";
            this.urunAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.urunAdi.Width = 302;
            // 
            // urunFiyati
            // 
            this.urunFiyati.Text = "Ürün Fiyati";
            this.urunFiyati.Width = 142;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.menudekilerDrag;
            this.bunifuDragControl1.Vertical = true;
            // 
            // masaHakkindaGeri
            // 
            this.masaHakkindaGeri.BackColor = System.Drawing.Color.Transparent;
            this.masaHakkindaGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.masaHakkindaGeri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.masaHakkindaGeri.Image = ((System.Drawing.Image)(resources.GetObject("masaHakkindaGeri.Image")));
            this.masaHakkindaGeri.ImageActive = null;
            this.masaHakkindaGeri.Location = new System.Drawing.Point(0, 510);
            this.masaHakkindaGeri.Name = "masaHakkindaGeri";
            this.masaHakkindaGeri.Size = new System.Drawing.Size(1240, 66);
            this.masaHakkindaGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.masaHakkindaGeri.TabIndex = 6;
            this.masaHakkindaGeri.TabStop = false;
            this.masaHakkindaGeri.Zoom = 10;
            this.masaHakkindaGeri.Click += new System.EventHandler(this.masaHakkindaGeri_Click);
            // 
            // menudekiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 576);
            this.Controls.Add(this.masaHakkindaGeri);
            this.Controls.Add(this.menudekilerList);
            this.Controls.Add(this.menudekilerDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menudekiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menudekiler";
            this.Load += new System.EventHandler(this.menudekiler_Load_1);
            this.menudekilerDrag.ResumeLayout(false);
            this.menudekilerDrag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masaHakkindaGeri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menudekilerDrag;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label menudekilerMenuAdi;
        private System.Windows.Forms.ListView menudekilerList;
        private System.Windows.Forms.ColumnHeader urunid;
        private System.Windows.Forms.ColumnHeader urunAdi;
        private System.Windows.Forms.ColumnHeader urunFiyati;
        private Bunifu.Framework.UI.BunifuImageButton masaHakkindaGeri;
        private System.Windows.Forms.ColumnHeader urunKategori;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}