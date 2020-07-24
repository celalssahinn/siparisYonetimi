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
    public partial class SiparisGozlem : Form
    {
        public SiparisGozlem()
        {
            InitializeComponent();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SiparisGozlem_Load(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection()
            {
                ConnectionString = "Server=db4free.net;Database=celalsahin;Uid=celalssahinn;Pwd='??????';Encrypt=false;AllowUserVariables=True;UseCompression=True"
            };
            siparisGozlemList.Items.Clear();


            MySqlCommand listele = new MySqlCommand()
            {
                CommandText = "SELECT masaNumarasi,urun,adet,aciklama FROM siparisVeriGirisi",
                Connection = baglanti,
                CommandType = CommandType.Text
            };
            MySqlDataReader listeleDR;

                baglanti.Open();
                listeleDR = listele.ExecuteReader();
                while (listeleDR.Read())
                {
                var item = new ListViewItem()
                {
                    Text = listeleDR["masaNumarasi"].ToString()
                };
                item.SubItems.Add(listeleDR["urun"].ToString());
                    item.SubItems.Add(listeleDR["adet"].ToString());
                    item.SubItems.Add(listeleDR["aciklama"].ToString());
                siparisGozlemList.Items.Add(item);


                }


                baglanti.Close();

           
            
        }
    }
}
