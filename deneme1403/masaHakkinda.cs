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
    public partial class masaHakkinda : Form
    {
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=db4free.net;Database=celalsahin;Uid=celalssahinn;Pwd='??????';Encrypt=false;AllowUserVariables=True;UseCompression=True");
       
    
       
            public masaHakkinda()
            {

           
            InitializeComponent();
           
            }

        private void MasaHakkindaAd_Click(object sender, EventArgs e)
        {

        }

        private void MasaHakkindaGeri_Click(object sender, EventArgs e)
        {
            masaHakkinda masa = new masaHakkinda();
            this.Close();
          
        }

        private void MasaHakkindaList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void MasaHakkinda_Load(object sender, EventArgs e)
        {
            mysqlbaglan.Open();

            

                MySqlConnection baglanti = new MySqlConnection()
                {
                    ConnectionString = "Server=db4free.net;Database=celalsahin;Uid=celalssahinn;Pwd='??????';Encrypt=false;AllowUserVariables=True;UseCompression=True"
                };
                masaNo.Text = veriTabaniİliskilendirici.masaNumarasiButon.ToString();


                MySqlCommand listele = new MySqlCommand()
                {
                    CommandText = "SELECT * FROM siparisVeriGirisi,urunler where siparisVeriGirisi.urun=urunler.urunAdi and masaNumarasi='" + veriTabaniİliskilendirici.masaNumarasiButon + "';",
                    Connection = baglanti,
                    CommandType = CommandType.Text
                };//ÜRÜN FİYATI ÇEKME


                MySqlDataReader listeleDR;

                baglanti.Open();
                listeleDR = listele.ExecuteReader();
                while (listeleDR.Read())
                {

                    var item = new ListViewItem()
                    {
                        Text = listeleDR["urun"].ToString()
                    };
                    item.SubItems.Add(listeleDR["urunFiyati"].ToString());
                    item.SubItems.Add(listeleDR["adet"].ToString());
                    item.SubItems.Add(listeleDR["personelAdi"].ToString());
                    masaHakkindaList.Items.Add(item);


                }


                baglanti.Close();


        }
    }
}
