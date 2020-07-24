namespace deneme1403
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.parolaTextBox = new System.Windows.Forms.TextBox();
            this.girisButton = new System.Windows.Forms.Button();
            this.bekleniyorLabel = new System.Windows.Forms.Label();
            this.kontrolLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.form1Tasima = new System.Windows.Forms.Panel();
            this.simgeDurumunaGetir = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siparisYonetimSistemi = new System.Windows.Forms.NotifyIcon(this.components);
            this.form1Tasima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simgeDurumunaGetir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Emmett", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Emmett", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(293, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola:";
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kullaniciAdiTextBox.Font = new System.Drawing.Font("Emmett", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(394, 334);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(232, 27);
            this.kullaniciAdiTextBox.TabIndex = 2;
            this.kullaniciAdiTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // parolaTextBox
            // 
            this.parolaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.parolaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.parolaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parolaTextBox.Location = new System.Drawing.Point(394, 368);
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.PasswordChar = '*';
            this.parolaTextBox.Size = new System.Drawing.Size(232, 27);
            this.parolaTextBox.TabIndex = 3;
            this.parolaTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // girisButton
            // 
            this.girisButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.girisButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.girisButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisButton.Location = new System.Drawing.Point(672, 365);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(75, 29);
            this.girisButton.TabIndex = 4;
            this.girisButton.Text = "Giriş";
            this.girisButton.UseVisualStyleBackColor = true;
            this.girisButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // bekleniyorLabel
            // 
            this.bekleniyorLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bekleniyorLabel.AutoSize = true;
            this.bekleniyorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bekleniyorLabel.Font = new System.Drawing.Font("Emmett", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bekleniyorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bekleniyorLabel.Location = new System.Drawing.Point(429, 630);
            this.bekleniyorLabel.MaximumSize = new System.Drawing.Size(250, 100);
            this.bekleniyorLabel.MinimumSize = new System.Drawing.Size(180, 0);
            this.bekleniyorLabel.Name = "bekleniyorLabel";
            this.bekleniyorLabel.Size = new System.Drawing.Size(180, 27);
            this.bekleniyorLabel.TabIndex = 6;
            this.bekleniyorLabel.Text = "Bekleniyor...";
            this.bekleniyorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bekleniyorLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // kontrolLabel
            // 
            this.kontrolLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kontrolLabel.AutoSize = true;
            this.kontrolLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kontrolLabel.Font = new System.Drawing.Font("Alien Encounters", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontrolLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kontrolLabel.Location = new System.Drawing.Point(678, 375);
            this.kontrolLabel.Name = "kontrolLabel";
            this.kontrolLabel.Size = new System.Drawing.Size(166, 13);
            this.kontrolLabel.TabIndex = 8;
            this.kontrolLabel.Text = "Islem Basarili...";
            this.kontrolLabel.Visible = false;
            this.kontrolLabel.Click += new System.EventHandler(this.kontrolLabel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(0, 603);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1001, 82);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.form1Tasima;
            this.bunifuDragControl1.Vertical = true;
            // 
            // form1Tasima
            // 
            this.form1Tasima.BackColor = System.Drawing.Color.White;
            this.form1Tasima.Controls.Add(this.simgeDurumunaGetir);
            this.form1Tasima.Controls.Add(this.pictureBox2);
            this.form1Tasima.Cursor = System.Windows.Forms.Cursors.Default;
            this.form1Tasima.Location = new System.Drawing.Point(10, 3);
            this.form1Tasima.Name = "form1Tasima";
            this.form1Tasima.Size = new System.Drawing.Size(988, 48);
            this.form1Tasima.TabIndex = 10;
            // 
            // simgeDurumunaGetir
            // 
            this.simgeDurumunaGetir.Image = ((System.Drawing.Image)(resources.GetObject("simgeDurumunaGetir.Image")));
            this.simgeDurumunaGetir.Location = new System.Drawing.Point(876, 9);
            this.simgeDurumunaGetir.Name = "simgeDurumunaGetir";
            this.simgeDurumunaGetir.Size = new System.Drawing.Size(43, 30);
            this.simgeDurumunaGetir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.simgeDurumunaGetir.TabIndex = 10;
            this.simgeDurumunaGetir.TabStop = false;
            this.simgeDurumunaGetir.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::deneme1403.Properties.Resources.exit_icon_4599;
            this.pictureBox2.Location = new System.Drawing.Point(925, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 593);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(991, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 593);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1001, 10);
            this.panel4.TabIndex = 13;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 593);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 10);
            this.panel2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DeepPink;
            this.button1.Location = new System.Drawing.Point(16, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Sipariş Alım Ekranı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(324, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(361, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // siparisYonetimSistemi
            // 
            this.siparisYonetimSistemi.Icon = ((System.Drawing.Icon)(resources.GetObject("siparisYonetimSistemi.Icon")));
            this.siparisYonetimSistemi.Text = "Sipariş Yönetim Sistemi";
            this.siparisYonetimSistemi.Visible = true;
            this.siparisYonetimSistemi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.siparisYonetimSistemi_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AcceptButton = this.girisButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1001, 685);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bekleniyorLabel);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.parolaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.kontrolLabel);
            this.Controls.Add(this.form1Tasima);
            this.Controls.Add(this.panel4);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Yönetimi Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.form1Tasima.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.simgeDurumunaGetir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.TextBox parolaTextBox;
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.Label bekleniyorLabel;
        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label kontrolLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel form1Tasima;
        private System.Windows.Forms.PictureBox simgeDurumunaGetir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon siparisYonetimSistemi;
    }
}

