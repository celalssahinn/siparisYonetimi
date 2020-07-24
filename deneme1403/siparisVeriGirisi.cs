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

namespace deneme1403
{
    public partial class SiparisVeriGirisi : Form
    {
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=db4free.net;Database=celalsahin;Uid=celalssahinn;Pwd='??????';Encrypt=false;AllowUserVariables=True;UseCompression=True");

        public SiparisVeriGirisi()
        {
            InitializeComponent();
        }

        private void SiparisVeriGirisi_Load(object sender, EventArgs e)
        {
            siparisPersonel.Text = veriTabaniİliskilendirici.personelAdi;

            MySqlConnection baglanti = new MySqlConnection()
            {
                ConnectionString = "Server=db4free.net;Database=celalsahin;Uid=celalssahinn;Pwd='??????';Encrypt=false;AllowUserVariables=True;UseCompression=True"
            };
            MySqlCommand masalar = new MySqlCommand()
            {
                CommandText = "SELECT * FROM masalar",
                Connection = baglanti,
                CommandType = CommandType.Text
            };
            MySqlDataReader masalarDR;
            



            
                baglanti.Open();

                masalarDR = masalar.ExecuteReader();


                while (masalarDR.Read())
                {
                    masaNumarasi.Items.Add(masalarDR["masaNumarasi"]);
                }
                baglanti.Close();

           

            
        }

        private void SiparisPersonel_Click(object sender, EventArgs e)
        {
            
        }

        private void MasaHakkindaGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

           
}

        private void KategoriCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection()
            {
                ConnectionString = "Server=db4free.net;Database=celalsahin;Uid=celalssahinn;Pwd='??????';Encrypt=false;AllowUserVariables=True;UseCompression=True"
            };
            MySqlCommand corbaCombo = new MySqlCommand()
            {
                CommandText = "SELECT * FROM urunler where kategoriİd=1",
                Connection = baglanti,
                CommandType = CommandType.Text
            };
            MySqlCommand kebaplarCombo = new MySqlCommand()
            {
                CommandText = "SELECT * FROM urunler where kategoriİd=2",
                Connection = baglanti,
                CommandType = CommandType.Text
            };
            MySqlCommand salatalarCombo = new MySqlCommand()
            {
                CommandText = "SELECT * FROM urunler where kategoriİd=3",
                Connection = baglanti,
                CommandType = CommandType.Text
            };
            MySqlCommand iceceklerCombo = new MySqlCommand()
            {
                CommandText = "SELECT * FROM urunler where kategoriİd=4",
                Connection = baglanti,
                CommandType = CommandType.Text
            };
            MySqlDataReader corbaComboDR;
            MySqlDataReader kebaplarComboDR;
            MySqlDataReader salatalarComboDR;
            MySqlDataReader iceceklerComboDR;


            if (kategoriCombo.SelectedIndex==0)
            {
                urunlerCombo.Items.Clear();
                urunlerCombo.DropDownHeight = 106;
                
                baglanti.Open();
                corbaComboDR = corbaCombo.ExecuteReader();
                while (corbaComboDR.Read())
                {
                    urunlerCombo.Items.Add(corbaComboDR["urunAdi"]);
                }
                adetText.Clear();
                adetText.Text = "1";
                aciklamaYazisi.Clear();
                aciklamaLabel.Visible = true;
                aciklamaYazisi.Visible = true;

                baglanti.Close();
            }

           else if (kategoriCombo.SelectedIndex == 1)
            {
                urunlerCombo.Items.Clear();
                urunlerCombo.DropDownHeight = 106;
                baglanti.Open();
                kebaplarComboDR = kebaplarCombo.ExecuteReader();
                while (kebaplarComboDR.Read())
                {
                    urunlerCombo.Items.Add(kebaplarComboDR["urunAdi"]);
                }
                aciklamaYazisi.Clear();
                adetText.Clear();
                adetText.Text = "1";
                aciklamaLabel.Visible = true;
                aciklamaYazisi.Visible = true;
                baglanti.Close();
            }

            else if (kategoriCombo.SelectedIndex == 2)
            {
                urunlerCombo.Items.Clear();
                urunlerCombo.DropDownHeight = 106;
                baglanti.Open();
                salatalarComboDR = salatalarCombo.ExecuteReader();
                while (salatalarComboDR.Read())
                {
                    urunlerCombo.Items.Add(salatalarComboDR["urunAdi"]);
                }
                aciklamaYazisi.Clear();
                adetText.Clear();
                adetText.Text = "1";
                aciklamaLabel.Visible = true;
                aciklamaYazisi.Visible = true;
                baglanti.Close();
            }

            else if (kategoriCombo.SelectedIndex == 3)
            {
                urunlerCombo.Items.Clear();
                urunlerCombo.DropDownHeight = 106;
                baglanti.Open();
                iceceklerComboDR = iceceklerCombo.ExecuteReader();
                while (iceceklerComboDR.Read())
                {
                    urunlerCombo.Items.Add(iceceklerComboDR["urunAdi"]);
                }
                aciklamaYazisi.Clear();
                adetText.Clear();
                adetText.Text = "1";
                aciklamaLabel.Visible = true;
                aciklamaYazisi.Visible = true;
                baglanti.Close();
            }

            else
            {
                urunlerCombo.Items.Clear();
                kategoriCombo.Items.Clear();
                aciklamaYazisi.Clear();
                adetText.Clear();
                aciklamaLabel.Visible = false;
                aciklamaYazisi.Visible = false;
                urunlerCombo.DropDownHeight = 30;
                kategoriCombo.DropDownHeight = 30;
            }
        }

        private void MasaNumarasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (masaNumarasi.SelectedIndex >=0 && masaNumarasi.SelectedIndex <=11)
            {
                urunlerCombo.Items.Clear();
                kategoriCombo.Items.Clear();
                aciklamaYazisi.Clear();
               
                adetText.Clear();



                MySqlConnection baglanti = new MySqlConnection()
                {
                    ConnectionString = "Server=db4free.net;Database=celalsahin;Uid=celalssahinn;Pwd='??????';Encrypt=false;AllowUserVariables=True;UseCompression=True"
                };
                MySqlCommand kategoriler = new MySqlCommand()
                {
                    CommandText = "SELECT * FROM kategori",
                    Connection = baglanti,
                    CommandType = CommandType.Text
                };
                MySqlDataReader kategoridDR;

                baglanti.Open();
                kategoriCombo.Items.Clear();
                kategoridDR = kategoriler.ExecuteReader();
                while (kategoridDR.Read())
                {
                    kategoriCombo.Items.Add(kategoridDR["kategoriAdi"]);
                }
                baglanti.Close();

            }

            else
            {
                
                kategoriCombo.Items.Clear();
                urunlerCombo.Items.Clear();
                adetText.Clear();
                aciklamaLabel.Visible = false;
                aciklamaYazisi.Visible = false;
            }
        }

        private void SiparisTamamla_Click(object sender, EventArgs e)
        {
          
        }

        private void SiparisTamamla1_Click(object sender, EventArgs e)
        {
            DialogResult kontrol = MessageBox.Show("Ürünü göndermek istiyor musunuz?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kontrol == DialogResult.Yes)
            {

                String masaDurumGuncelle = "UPDATE masalar set masaDurum=1 where masaNumarasi='" + (masaNumarasi.SelectedIndex+1) + "'";


                MySqlCommand masaDurumGiris = new MySqlCommand(masaDurumGuncelle, mysqlbaglan);
                mysqlbaglan.Open();
                MySqlDataReader masaDurumDR = masaDurumGiris.ExecuteReader();


                while (masaDurumDR.Read())

                {
                }
                mysqlbaglan.Close();

                try

            {

                    


                    

                   

                    String urunEkle = " INSERT INTO siparisVeriGirisi (personelAdi,masaNumarasi,kategori,urun,adet,aciklama) values ('" + this.siparisPersonel.Text + "','" + this.masaNumarasi.Text + "','" + this.kategoriCombo.Text + "','" + this.urunlerCombo.Text + "','" + this.adetText.Text + "','" + this.aciklamaYazisi.Text + "');";


                MySqlCommand giris = new MySqlCommand(urunEkle, mysqlbaglan);
                    mysqlbaglan.Open();
                MySqlDataReader rdr = giris.ExecuteReader();
                MessageBox.Show("Siparişiniz başarı ile gönderilmiştir");

                while (rdr.Read())

                {



                }

                    
                   
                    adetText.Clear();
                    aciklamaYazisi.Clear();

                    mysqlbaglan.Close();
            }
                

            catch (Exception ex)

            {
                    mysqlbaglan.Close();
                   
                    DialogResult hataMesaji = MessageBox.Show("Hatalı islemde bulundunuz,nedenini görmek istiyor musunuz?", "Hata Mesajı Bildirimi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (hataMesaji == DialogResult.Yes)
                    {
                        MessageBox.Show("Hatanız : "+ex);
                    }
                }
            }

            else
            {
                MessageBox.Show("Ürün ekleme işlemini iptal edilmiştir");
            }
        }

        private void AciklamaYazisi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
