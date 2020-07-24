using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme1403
{
    public partial class menu : Form
    {
        
        public menu()
        {
            InitializeComponent();

            reklamSayfasi reklam = new reklamSayfasi()
            {
                TopLevel = false
            };
            anaPanelSistem.Controls.Add(reklam);
            reklam.Show();
            reklam.Dock = DockStyle.Fill;
            reklam.BringToFront();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MasalarButon_Click(object sender, EventArgs e)
        {


            masalar masa = new masalar()
            {
                TopLevel = false
            };
            anaPanelSistem.Controls.Add(masa);
            masa.Show();
            masa.Dock = DockStyle.Fill;
            masa.BringToFront();
          

        }
        private void YemekButon_Click(object sender, EventArgs e) //menu sayfası yemekButonu
        {
            yemekler yemek = new yemekler()
            {
                TopLevel = false
            };
            anaPanelSistem.Controls.Add(yemek);
            yemek.Show();
            yemek.Dock = DockStyle.Fill;
            yemek.BringToFront();
        }


        private void BunifuImageButton2_Click(object sender, EventArgs e) //menu sayfası çıkış butonu
        {
            Application.Exit();
        }

        private void MenuAcKapaButon_Click(object sender, EventArgs e) { 
      

            if (menuPanel.Width==50) {
                logoKucuk.Visible = false;
            menuPanel.Visible = true;
            menuPanel.Width = 300;
            menuPanelAnimator.ShowSync(menuPanel);
            logoAnimator.ShowSync(logoBuyuk);
            }

            else
            {
                logoAnimator.HideSync(logoBuyuk);
                logoKucuk.Visible = true;
                menuPanel.Visible = true;
                menuPanel.Width = 50;
                menuPanelAnimator.ShowSync(menuPanel);
            }


        }

  

        private void KasaButon_Click(object sender, EventArgs e)
        {

            SiparisKasa kasa = new SiparisKasa()
            {
                TopLevel = false
            };
            anaPanelSistem.Controls.Add(kasa);
            kasa.Show();
            kasa.Dock = DockStyle.Fill;
            kasa.BringToFront();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Gosterim_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void SiparislerButon_Click(object sender, EventArgs e)
        {

            SiparisGozlem siparisler = new SiparisGozlem()
            {
                TopLevel = false
            };
            anaPanelSistem.Controls.Add(siparisler);
            siparisler.Show();
            siparisler.Dock = DockStyle.Fill;
            siparisler.BringToFront();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Masa1KasaButon_Click(object sender, EventArgs e)
        {

        }

        public void AnaPanelSistem_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
