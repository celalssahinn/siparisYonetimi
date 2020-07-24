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
    public partial class siparisVer : Form
    {
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=db4free.net;Database=celalsahin;Uid=celalssahinn;Pwd='??????k';Encrypt=false;AllowUserVariables=True;UseCompression=True");

        public siparisVer()
        {
            InitializeComponent();
        }


        private void masaHakkindaGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            try
            {


            

             
            mysqlbaglan.Open();


            if (mysqlbaglan.State != ConnectionState.Closed)
            {

                        siparisKadi.Text = Regex.Replace(siparisKadi.Text, "'", "&#39;");
                        siparisParola.Text = Regex.Replace(siparisParola.Text, "'", "&#39;");

                        String loginGirisKontrol = "SELECT * FROM kullanicilar where kullaniciAdi='" + siparisKadi.Text + "'AND sifre='" + siparisParola.Text + "'";


                MySqlCommand giris = new MySqlCommand(loginGirisKontrol, mysqlbaglan);


                MySqlDataReader rdr = giris.ExecuteReader();


                if (rdr.Read())
                {

                    progressBar1.Visible = true;
                    girisButton.Visible = false;

                    bekleniyorLabel.BackColor = Color.WhiteSmoke;


                    progressBar1.Value = 0;//İşleme nerden başlanacığını
                    progressBar1.Step = 1; // ilerlemenin kaçar kaçar olacağı
                    for (int i = 0; i <= 100; i++)
                    {
                        bekleniyorLabel.Text = "%" + i.ToString(); // ilerleme düzeyini labelde gösteriyoruz
                        progressBar1.PerformStep(); //Sonraki adıma geçiyoruz
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(12); // çubuğun bar üzerinde ilerleme hızı yükseltirseniz yavaşlar


                    }

                    SiparisVeriGirisi siparisPersonel =new SiparisVeriGirisi();
                    veriTabaniİliskilendirici.personelAdi = siparisKadi.Text;

                    
                    veriSecim veriSecimGiris = new veriSecim();
                    veriSecimGiris.ShowDialog();


                    rdr.Close();
                    mysqlbaglan.Close();



                    this.Hide();



                }

                else
                {
                    siparisKadi.Clear();
                    siparisParola.Clear();
                    MessageBox.Show("Böyle bir kullanıcı bulunmamaktadır");
                    rdr.Close();
                    mysqlbaglan.Close();
                }
            }
            else
            {
                MessageBox.Show("Veri Tabanı Bağlantı Hatası!!!");

            }
            mysqlbaglan.Close();
            
        }
            catch (Exception ex)
            {

                DialogResult hataMesaji = MessageBox.Show("Hatalı islemde bulundunuz,nedenini görmek istiyor musunuz?", "Hata Mesajı Bildirimi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hataMesaji == DialogResult.Yes)
                {
                    MessageBox.Show("Hatanız : " + ex);
                }
            }

        }

        private void siparisVer_Load(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}