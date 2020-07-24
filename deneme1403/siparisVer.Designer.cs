namespace deneme1403
{
    partial class siparisVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siparisVer));
            this.siparisKadi = new System.Windows.Forms.TextBox();
            this.girisButton = new System.Windows.Forms.Button();
            this.siparisParola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bekleniyorLabel = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.hareketDranPanelTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hareketDrag = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hareketDrag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // siparisKadi
            // 
            this.siparisKadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siparisKadi.Font = new System.Drawing.Font("Emmett", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siparisKadi.Location = new System.Drawing.Point(161, 320);
            this.siparisKadi.Name = "siparisKadi";
            this.siparisKadi.Size = new System.Drawing.Size(223, 27);
            this.siparisKadi.TabIndex = 11;
            // 
            // girisButton
            // 
            this.girisButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.girisButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.girisButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.girisButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.girisButton.Location = new System.Drawing.Point(294, 387);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(90, 33);
            this.girisButton.TabIndex = 13;
            this.girisButton.Text = "Giriş";
            this.girisButton.UseVisualStyleBackColor = true;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // siparisParola
            // 
            this.siparisParola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siparisParola.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siparisParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisParola.Location = new System.Drawing.Point(161, 354);
            this.siparisParola.Name = "siparisParola";
            this.siparisParola.PasswordChar = '*';
            this.siparisParola.Size = new System.Drawing.Size(223, 27);
            this.siparisParola.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Emmett", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Emmett", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.hareketDrag;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 540);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(392, 51);
            this.progressBar1.TabIndex = 18;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // bekleniyorLabel
            // 
            this.bekleniyorLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bekleniyorLabel.AutoSize = true;
            this.bekleniyorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bekleniyorLabel.Font = new System.Drawing.Font("Emmett", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bekleniyorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bekleniyorLabel.Location = new System.Drawing.Point(106, 503);
            this.bekleniyorLabel.MaximumSize = new System.Drawing.Size(250, 100);
            this.bekleniyorLabel.MinimumSize = new System.Drawing.Size(180, 0);
            this.bekleniyorLabel.Name = "bekleniyorLabel";
            this.bekleniyorLabel.Size = new System.Drawing.Size(180, 27);
            this.bekleniyorLabel.TabIndex = 19;
            this.bekleniyorLabel.Text = "Bekleniyor...";
            this.bekleniyorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.siparisKadi;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.siparisParola;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 15;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 15;
            this.bunifuElipse4.TargetControl = this.progressBar1;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 15;
            this.bunifuElipse5.TargetControl = this.girisButton;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 15;
            this.bunifuElipse6.TargetControl = this;
            // 
            // hareketDranPanelTop
            // 
            this.hareketDranPanelTop.BackColor = System.Drawing.SystemColors.InfoText;
            this.hareketDranPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.hareketDranPanelTop.Location = new System.Drawing.Point(0, 0);
            this.hareketDranPanelTop.Name = "hareketDranPanelTop";
            this.hareketDranPanelTop.Size = new System.Drawing.Size(412, 10);
            this.hareketDranPanelTop.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 584);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(402, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 584);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 584);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 10);
            this.panel3.TabIndex = 23;
            // 
            // hareketDrag
            // 
            this.hareketDrag.Image = ((System.Drawing.Image)(resources.GetObject("hareketDrag.Image")));
            this.hareketDrag.Location = new System.Drawing.Point(16, 12);
            this.hareketDrag.Name = "hareketDrag";
            this.hareketDrag.Padding = new System.Windows.Forms.Padding(5);
            this.hareketDrag.Size = new System.Drawing.Size(386, 228);
            this.hareketDrag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hareketDrag.TabIndex = 14;
            this.hareketDrag.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::deneme1403.Properties.Resources.exit_icon_4599;
            this.pictureBox2.Location = new System.Drawing.Point(356, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // siparisVer
            // 
            this.AcceptButton = this.girisButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(412, 594);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hareketDranPanelTop);
            this.Controls.Add(this.bekleniyorLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.hareketDrag);
            this.Controls.Add(this.siparisKadi);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.siparisParola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "siparisVer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "siparisVer";
            this.Load += new System.EventHandler(this.siparisVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hareketDrag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox siparisKadi;
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.TextBox siparisParola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.PictureBox hareketDrag;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label bekleniyorLabel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private System.Windows.Forms.Panel hareketDranPanelTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}