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
    public partial class menudekiler : Form
    {
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=db4free.net;Database=celalsahin;Uid=celalssahinn;Pwd='??????';Encrypt=false;AllowUserVariables=True;UseCompression=True");

        MySqlDataReader dr;
        MySqlCommand cmd;
   
        public menudekiler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }


       




            private void masaHakkindaGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void masaHakkindaList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void menudekiler_Load_1(object sender, EventArgs e)
        {
            menudekilerMenuAdi.Text = veriTabaniİliskilendirici.butonName;
            
            mysqlbaglan.Open();
            cmd = new MySqlCommand("Select * From urunler,kategori where urunler.kategoriİd=kategori.id", mysqlbaglan);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["id"].ToString());
                item.SubItems.Add(dr["kategoriAdi"].ToString());
                item.SubItems.Add(dr["urunAdi"].ToString());
                item.SubItems.Add(dr["urunFiyati"].ToString());
                menudekilerList.Items.Add(item);

            }
            mysqlbaglan.Close();
        }
    }
}
