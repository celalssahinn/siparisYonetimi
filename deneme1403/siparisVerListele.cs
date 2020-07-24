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
    public partial class siparisVerListele : Form
    {
           

        public siparisVerListele()
        {
            InitializeComponent();
        }

        private void siparisVerListele_Load(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection();
            baglanti.ConnectionString = "Server=db4free.net;Database=celalsahin;Uid=celalssahinn;Pwd='??????';Encrypt=false;AllowUserVariables=True;UseCompression=True";


            MySqlCommand masalar = new MySqlCommand();
            masalar.CommandText = "SELECT * FROM masalar";
            masalar.Connection = baglanti;
            masalar.CommandType = CommandType.Text;



            MySqlDataReader masalarDR;





            baglanti.Open();

            masalarDR = masalar.ExecuteReader();


            while (masalarDR.Read())
            {
                masaNo.Items.Add(masalarDR["masaNumarasi"]);
            }
            baglanti.Close();
        }

        private void masaHakkindaGeri_Click(object sender, EventArgs e)
        {
            veriSecim veri = new veriSecim();
            Close();
            veri.ShowDialog();
            
        }

        private void masaNoComboVeriListele_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection();
            baglanti.ConnectionString = "Server=db4free.net;Database=celalsahin;Uid=celalssahinn;Pwd='??????';Encrypt=false;AllowUserVariables=True;UseCompression=True";

            if (masaNo.SelectedIndex >= 0 && masaNo.SelectedIndex <= 11)
            {
                
                
                listeleListView.Items.Clear();


                MySqlCommand listele = new MySqlCommand();
                listele.CommandText = "SELECT * FROM siparisVeriGirisi where masaNumarasi='" + masaNo.Text + "';";
                listele.Connection = baglanti;
                listele.CommandType = CommandType.Text;

                MySqlDataReader listeleDR;

                baglanti.Open();
                listeleDR = listele.ExecuteReader();
                while (listeleDR.Read())
                {
                    var item = new ListViewItem();
                    item.Text = listeleDR["urun"].ToString();
                    item.SubItems.Add(listeleDR["adet"].ToString());
                    listeleListView.Items.Add(item);
                    

                }
                
                    
                baglanti.Close();

            }

            else
            {
                baglanti.Close();
                
            }
        }

        private void listeleListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            //masaNoVeriListele.Text = listeleListView.SelectedItems[0].SubItems[0].Text;
            
            
        }

        private void listSil_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection();
            baglanti.ConnectionString = "Server=db4free.net;Database=celalsahin;Uid=celalssahinn;Pwd='??????';Encrypt=false;AllowUserVariables=True;UseCompression=True";


            try
            {
                String seciliİtem= listeleListView.SelectedItems[0].SubItems[0].Text;
              
                String urunEkle = " DELETE from siparisVeriGirisi where urun= '"+ seciliİtem + "'AND masaNumarasi='" + masaNo.Text + "'";


                MySqlCommand giris = new MySqlCommand(urunEkle, baglanti);
                baglanti.Open();
                MySqlDataReader rdr = giris.ExecuteReader();
                listeleListView.SelectedItems[0].Remove();
                MessageBox.Show("Ürün silindi");

                while (rdr.Read())

                {



                }



               

                baglanti.Close();
            }


            
            catch (Exception)
            {

                MessageBox.Show("Ürün seçilmemiş");
            }
            
        }
    }
}
