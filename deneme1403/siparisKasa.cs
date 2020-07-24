using Microsoft.CSharp.RuntimeBinder;
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
using System.Drawing.Printing;

namespace deneme1403
{
    public partial class SiparisKasa : Form
    {
        
     

        public SiparisKasa()
        {
            InitializeComponent();
          /*  masalarVeriTabani masaV = new masalarVeriTabani();
            int tableİd = masaV.TabloNoGet(veriTabaniİliskilendirici.masaButonAdi);

            if (masaV.TabloBelirt(tableİd,2)==true || masaV.TabloBelirt(tableİd, 3) == true)
            {
                hesap Ad = new hesap();
                int Additionİd = Ad.HesapGet(tableİd);

            }*/

            sayi1.Click += new EventHandler(İslem);
            sayi2.Click += new EventHandler(İslem);
            sayi3.Click += new EventHandler(İslem);
            sayi4.Click += new EventHandler(İslem);
            sayi5.Click += new EventHandler(İslem);
            sayi6.Click += new EventHandler(İslem);
            sayi7.Click += new EventHandler(İslem);
            sayi8.Click += new EventHandler(İslem);
            sayi9.Click += new EventHandler(İslem);
            sayi0.Click += new EventHandler(İslem);
            virgul.Click += new EventHandler(İslem);
        }

        private void MasaBilgileri_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        //tus takimi
        void İslem(Object sender, EventArgs e)
        {

            Button sayi = sender as Button;
            switch (sayi.Name)
            {
                case "sayi1":
                    odemeTextBoxGirisler.Text += (1).ToString();
                    break;
                case "sayi2":
                    odemeTextBoxGirisler.Text += (2).ToString();
                    break;
                case "sayi3":
                    odemeTextBoxGirisler.Text += (3).ToString();
                    break;
                case "sayi4":
                    odemeTextBoxGirisler.Text += (4).ToString();
                    break;
                case "sayi5":
                    odemeTextBoxGirisler.Text += (5).ToString();
                    break;
                case "sayi6":
                    odemeTextBoxGirisler.Text += (6).ToString();
                    break;
                case "sayi7":
                    odemeTextBoxGirisler.Text += (7).ToString();
                    break;
                case "sayi8":
                    odemeTextBoxGirisler.Text += (8).ToString();
                    break;
                case "sayi9":
                    odemeTextBoxGirisler.Text += (9).ToString();
                    break;
                case "sayi0":
                    odemeTextBoxGirisler.Text += (0).ToString();
                    break;
                case "virgul":
                    odemeTextBoxGirisler.Text += (",").ToString();
                    break;


                default:
                    MessageBox.Show("Hatalı giris");
                    break;
            }



        }


        private void PanelKasa_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void SayiClear_Click(object sender, EventArgs e)
        {
            odemeTextBoxGirisler.ResetText();

        }

        private void MasaNumarasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MySqlConnection baglanti = new MySqlConnection()
            {
                ConnectionString = "Server=db4free.net;Database=celalsahin;Uid=celalssahinn;Pwd='??????';Encrypt=false;AllowUserVariables=True;UseCompression=True"
            };
            if (masaNumarasi.SelectedIndex >= 0 && masaNumarasi.SelectedIndex <= 11)
            {


                odemeList.Items.Clear();

                
                MySqlCommand listele = new MySqlCommand()
                {
                    CommandText = "SELECT * FROM siparisVeriGirisi,urunler where siparisVeriGirisi.urun=urunler.urunAdi and masaNumarasi='" + masaNumarasi.Text + "';",
                    Connection = baglanti,
                    CommandType = CommandType.Text
                };//ÜRÜN FİYATI ÇEKME
                int[] islem = new int[50];
                int[] adet = new int[50];
                int[] fiyat = new int[50];
                int[] adetFiyat = new int[50];
                MySqlDataReader listeleDR;

                baglanti.Open();
                listeleDR = listele.ExecuteReader();

                int i = 0;
                for (i = 0; listeleDR.Read(); i++)
                {
                    
                    var item = new ListViewItem()
                    {
                        Text = listeleDR["urun"].ToString()
                    };
                    
                    adet[i] = Convert.ToInt16(listeleDR["adet"]);

                   // item.SubItems.Add(listeleDR["urunFiyati"].ToString());
                    fiyat[i] = Convert.ToInt16(listeleDR["urunFiyati"]);

                    adetFiyat[i] += adet[i] * fiyat[i];

                    // islem[i]+= Convert.ToInt16(listeleDR["urunFiyati"]);
                    
                }
                baglanti.Close();

               

                baglanti.Open();
                listeleDR = listele.ExecuteReader();
                int topla=0;
                for(int a = 0; a < adetFiyat.Length; a++)
                {
                    topla += adetFiyat[a];
                }



                int b = 0;
                for (b = 0; listeleDR.Read(); b++)
                {
                    siparisiVerenPersonel.Text = listeleDR["personelAdi"].ToString();
                    var item = new ListViewItem()
                    {
                        Text = listeleDR["urun"].ToString()
                    };
                    item.SubItems.Add(listeleDR["adet"].ToString());
                    

                     item.SubItems.Add(listeleDR["urunFiyati"].ToString());
                    item.SubItems.Add(adetFiyat[b].ToString());
                    odemeList.Items.Add(item);
                }

                urunToplamFiyat.Text=topla.ToString();

                baglanti.Close();

            }

            else
            {
                baglanti.Close();

            }
        }

        private void SiparisKasa_Load(object sender, EventArgs e)
        {



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

        private void OdemeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sayi7_Click(object sender, EventArgs e)
        {

        }

        private void ödeme_Click(object sender, EventArgs e)
        {

            try
            {

            
            

            DialogResult kontrol = MessageBox.Show("Ödeme işlemini gerçekleştirmek istiyor musunuz?", "Ödeme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kontrol == DialogResult.Yes)
            {
                int urunToplamFiyatInt = Convert.ToInt32(urunToplamFiyat.Text);
                int odemeTextBoxGirislerInt = Convert.ToInt32(odemeTextBoxGirisler.Text);
                int paraUstu;

                if (urunToplamFiyatInt < odemeTextBoxGirislerInt || urunToplamFiyatInt == odemeTextBoxGirislerInt)
                {
                    MySqlConnection baglan = new MySqlConnection()
                    {
                        ConnectionString = "Server=db4free.net;Database=celalsahin;Uid=celalssahinn;Pwd='??????';Encrypt=false;AllowUserVariables=True;UseCompression=True"
                    };
                    String masaDurumGuncelle = "UPDATE masalar set masaDurum=0 where masaNumarasi='" + (masaNumarasi.SelectedIndex + 1) + "'";


                    MySqlCommand masaDurumGiris = new MySqlCommand(masaDurumGuncelle, baglan);
                    baglan.Open();
                    MySqlDataReader masaDurumDR = masaDurumGiris.ExecuteReader();


                    while (masaDurumDR.Read())

                    {
                    }
                    baglan.Close();

                    MySqlConnection baglanti = new MySqlConnection()
                    {
                        ConnectionString = "Server=db4free.net;Database=celalsahin;Uid=celalssahinn;Pwd='??????';Encrypt=false;AllowUserVariables=True;UseCompression=True"
                    };

                    if (urunToplamFiyatInt < odemeTextBoxGirislerInt)
                    {
                        paraUstu = odemeTextBoxGirislerInt - urunToplamFiyatInt;
                        MessageBox.Show("Para üzeri: "+paraUstu);
                    }
                    MessageBox.Show("Ödeme başarı ile gerçekleştirimiştir");

                    String siparisTamamla = "DELETE FROM siparisVeriGirisi where masaNumarasi='" + (masaNumarasi.SelectedIndex + 1) + "'";


                    MySqlCommand siparisTamamlaGiris = new MySqlCommand(siparisTamamla, baglanti);
                    baglanti.Open();
                    MySqlDataReader siparisTamamlaDR = siparisTamamlaGiris.ExecuteReader();


                    while (siparisTamamlaDR.Read())

                    {
                    }
                   

                    siparisiVerenPersonel.Text = "***** *****";
                    odemeTextBoxGirisler.Clear();
                    odemeList.Items.Clear();
                    urunToplamFiyat.Text = "0 TL";
                    siparisTamamlaDR.Close();
                }
                
                
                

                else
                {
                    MessageBox.Show("Ödenen tutarı kontrol ediniz");
                }
            }

            else
            {
                MessageBox.Show("İşleminiz iptal edilmiştir");
            }


        }

            catch (Exception e1)
            {

                odemeTextBoxGirisler.Clear();
                DialogResult hataMesaji = MessageBox.Show("Hatalı Giris, değerlerinizi lütfen kontrol ediniz ,hata nedenini görmek istiyor musunuz?", "Hata Mesajı Bildirimi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hataMesaji == DialogResult.Yes)
                {
                    MessageBox.Show("Hatanız : \n-------\n" + e1);
                }
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void sayiFisYazdir_Click(object sender, EventArgs e)
        {
            ppdDiyalog.ShowDialog();
            
        }

        Font baslik = new Font("Verdana", 12, FontStyle.Bold);
        Font govde = new Font("Verdana", 12);

        SolidBrush sb = new SolidBrush(Color.Black);

        private void pdYazici_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat sFormat = new StringFormat();
            sFormat.Alignment= StringAlignment.Near;
            e.Graphics.DrawString(masaNumarasi.Text+"Hesap Hareketleri",baslik,sb,200,150);
        }
    }
}
