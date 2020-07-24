using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace deneme1403
{
    
    public partial class Form1 : Form
    {

        MySqlConnection mysqlbaglan = new MySqlConnection("Server=db4free.net;Database=celalsahin;Uid=celalssahinn;Pwd='??????';Encrypt=false;AllowUserVariables=True;UseCompression=True");




        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }

        public Form1()
        {
            // login ekranı bar çubuğu ayarı
            InitializeComponent();
            progressBar1.Maximum = 70;
            progressBar1.Minimum = 0;
            kontrolLabel.Visible = false;
           





        }
        


public void textBox1_TextChanged(object sender, EventArgs e)
        {       
            
        }



        public void textBox2_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            mysqlbaglan.Open();


            if (mysqlbaglan.State != ConnectionState.Closed)
            {
                kullaniciAdiTextBox.Text = Regex.Replace(kullaniciAdiTextBox.Text, "'", "&#39;");
                parolaTextBox.Text = Regex.Replace(parolaTextBox.Text, "'", "&#39;");

                String loginGirisKontrol = "SELECT * FROM kullanicilar where kullaniciAdi='" + kullaniciAdiTextBox.Text + "'AND sifre='" + parolaTextBox.Text+"'";
               // String sifreKontrol = "SELECT * FROM kullanicilar where kullaniciAdi='" + kullaniciAdiTextBox.Text;

                MySqlCommand giris = new MySqlCommand(loginGirisKontrol, mysqlbaglan);
              //  MySqlCommand sifreKontolCommand = new MySqlCommand(sifreKontrol, mysqlbaglan);

                MySqlDataReader rdr = giris.ExecuteReader();
              //  MySqlDataReader sifreRead = sifreKontolCommand.ExecuteReader();

                if (rdr.Read())
                {

                    progressBar1.Visible = true;
                    girisButton.Visible = false;
                    kontrolLabel.Visible = true;
                    bekleniyorLabel.BackColor = Color.WhiteSmoke;


                    progressBar1.Value = 0;//İşleme nerden başlanacığını
                    progressBar1.Step = 1; // ilerlemenin kaçar kaçar olacağı
                    for (int i = 0; i <= 100; i++)
                    {
                        bekleniyorLabel.Text = "%" + i.ToString(); // ilerleme düzeyini labelde gösteriyoruz
                        progressBar1.PerformStep(); //Sonraki adıma geçiyoruz
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(10); // çubuğun bar üzerinde ilerleme hızı yükseltirseniz yavaşlar


                    }


                    menu menuGiris = new menu();
                    menuGiris.Show();

                    
                        rdr.Close();
                    mysqlbaglan.Close();
                      //  sifreRead.Close();      
                    

                    this.Hide();



                }

              /*  else if (sifreRead.Read())
                {

                    parolaTextBox.Clear();
                    MessageBox.Show("Şifrenizi kontrol ediniz");
                }*/
                else
                {
                    kullaniciAdiTextBox.Clear();
                    parolaTextBox.Clear();
                    MessageBox.Show("Böyle bir kullanıcı bulunmamaktadır");
                    rdr.Close();
                    mysqlbaglan.Close();
                }
            }
            else
            {
                MessageBox.Show("Veri Tabanı Bağlantı Hatası!!!");
                
            }
        }
            
             




        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void kontrolLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Hide();

            siparisVer siparisAlim = new siparisVer();
            
            siparisAlim.ShowDialog();
            
            
        }

        private void siparisYonetimSistemi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
    }
}
