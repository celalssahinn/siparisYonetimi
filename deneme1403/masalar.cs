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
    public partial class masalar : Form
    {

        MySqlConnection mysqlbaglan = new MySqlConnection("Server=db4free.net;Database=celalsahin;Uid=celalssahinn;Pwd='??????';Encrypt=false;AllowUserVariables=True;UseCompression=True");


        masaHakkinda masa = new masaHakkinda();
        veriTabaniİliskilendirici veri = new veriTabaniİliskilendirici();
        masalarVeriTabani masaV = new masalarVeriTabani();

        public masalar()
        {

            /*
            MySqlCommand cmd = new MySqlCommand("Select masaDurum,masaNumarasi from masalar", mysqlbaglan);
            MySqlDataReader dr = null;



            if (mysqlbaglan.State == ConnectionState.Closed)
            {
                mysqlbaglan.Open();
            }
            

            else{
                MessageBox.Show("Veri Tabanından Veriler Çekilemedi");
                }
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name == "btnMasa" + dr["masaNumarasi"].ToString() && dr["masaDurum"].ToString() == "1")
                        {
                            item.BackColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            item.BackColor = System.Drawing.Color.Red;
                        }
                    }
                }
            }*/

            InitializeComponent();


            /*
                        MySqlCommand dolu = new MySqlCommand("Select masaNumarasi from masalar where masaDurum=0", mysqlbaglan);
                        MySqlDataReader drDolu = dolu.ExecuteReader();

                        if (drDolu.Read())
                         {
                            butonMasa1.BackColor = Color.Red;
                            butonMasa2.BackColor = Color.Red;
                        }

                  */

















            /* if (masaV.TabloBelirt(butonAdi, 1) == true)
              {

              }

             if(mysqlbaglan.State == ConnectionState.Closed)
              {
                  mysqlbaglan.Open();
              }
              dr = cmd.ExecuteReader();

              while (dr.Read())
              {
                  foreach(Control item in this.Controls)
                  {
                      if(item is Button)
                      {
                          if(item.Name=="masaButon" + dr["masaNumarasi"].ToString() && dr["masaDurum"].ToString() == "0")
                          {
                              item.BackColor = Color.Red;
                          }
                         else if (item.Name == "masaButon" + dr["masaNumarasi"].ToString() && dr["masaDurum"].ToString() == "1")
                          {
                              item.BackColor = Color.Red;
                          }
                      }
                  }
              }

     */

        }
        /*
        public void masaDurumlari()
        {
            mysqlbaglan.Open();
            MySqlCommand cmd = new MySqlCommand("Select masaNumarasi,masaDurum from masalar", mysqlbaglan);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["masaNumarasi"].ToString();
                ekle.SubItems.Add(dr["masaDurum"].ToString());
                
            }
        }
        */


        private void PanelMasalar_Paint(object sender, PaintEventArgs e)
        {

        }



        private void BtnMasa1_Click(object sender, EventArgs e)
        {
            masaHakkinda masa = new masaHakkinda();
            veriTabaniİliskilendirici.masaNumarasiButon = 1;


            masa.ShowDialog();
        }

        private void BtnMasa2_Click(object sender, EventArgs e)
        {
            masaHakkinda masa = new masaHakkinda();
            
            veriTabaniİliskilendirici.masaNumarasiButon = 2;


            masa.ShowDialog();


           
        }

        private void BtnMasa3_Click(object sender, EventArgs e)
        {
            masaHakkinda masa = new masaHakkinda();

            veriTabaniİliskilendirici.masaNumarasiButon = 3;


            masa.ShowDialog();
        }

        private void BtnMasa4_Click(object sender, EventArgs e)
        {
            masaHakkinda masa = new masaHakkinda();

            veriTabaniİliskilendirici.masaNumarasiButon = 4;


            masa.ShowDialog();
        }

        private void BtnMasa5_Click(object sender, EventArgs e)
        {
            masaHakkinda masa = new masaHakkinda();

            veriTabaniİliskilendirici.masaNumarasiButon = 5;


            masa.ShowDialog();
        }

        private void BtnMasa6_Click(object sender, EventArgs e)
        {
            masaHakkinda masa = new masaHakkinda();

            veriTabaniİliskilendirici.masaNumarasiButon = 6;


            masa.ShowDialog();
        }

        private void BtnMasa7_Click(object sender, EventArgs e)
        {
            masaHakkinda masa = new masaHakkinda();

            veriTabaniİliskilendirici.masaNumarasiButon = 7;


            masa.ShowDialog();
        }

        private void BtnMasa8_Click(object sender, EventArgs e)
        {
            masaHakkinda masa = new masaHakkinda();

            veriTabaniİliskilendirici.masaNumarasiButon = 8;


            masa.ShowDialog();
        }

        private void BtnMasa9_Click(object sender, EventArgs e)
        {
            masaHakkinda masa = new masaHakkinda();

            veriTabaniİliskilendirici.masaNumarasiButon = 9;


            masa.ShowDialog();
        }

        private void BtnMasa10_Click(object sender, EventArgs e)
        {
            masaHakkinda masa = new masaHakkinda();

            veriTabaniİliskilendirici.masaNumarasiButon = 10;


            masa.ShowDialog();
        }

        private void BtnMasa11_Click(object sender, EventArgs e)
        {
            masaHakkinda masa = new masaHakkinda();

            veriTabaniİliskilendirici.masaNumarasiButon = 11;


            masa.ShowDialog();
        }

        private void BtnMasa12_Click(object sender, EventArgs e)
        {
            masaHakkinda masa = new masaHakkinda();

            veriTabaniİliskilendirici.masaNumarasiButon = 12;


            masa.ShowDialog();
        }

        private void Masalar_Load(object sender, EventArgs e)
        {
            
            Button[] masaisim = { btnMasa1, btnMasa2, btnMasa3, btnMasa4, btnMasa5, btnMasa6, btnMasa7, btnMasa8, btnMasa9, btnMasa10, btnMasa11, btnMasa12 };


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
            MySqlDataReader kategoridDR;

            baglanti.Open();

            Boolean[] masadurumlari=new Boolean[12];
            

            kategoridDR = masalar.ExecuteReader();
            int i = 0;
            for (i=0; kategoridDR.Read(); i++)
            {
                masadurumlari[i] =Convert.ToBoolean(kategoridDR["masaDurum"]);
                 //kategoriCombo.Items.Add(kategoridDR["kategoriAdi"]);
               // masalarGetir.Text = masadurumlari;

               
               if ( masadurumlari[i] == true)
                    masaisim[i].BackColor = Color.Red;
                else
                    masaisim[i].BackColor = Color.Green;
            }


           

            


            baglanti.Close();
        }
        }
    }




/*for(int i = 0; i <= array.Length; i++)
           {

           //LOAD

                    
            Button[] masaisim = { btnMasa1, btnMasa2, btnMasa3, btnMasa4, btnMasa5, btnMasa6, btnMasa7, btnMasa8, btnMasa9, btnMasa10, btnMasa11, btnMasa12 };
            

            MySqlConnection baglanti = new MySqlConnection();
            baglanti.ConnectionString = "Server=db4free.net;Database=celalsahin;Uid=celalssahinn;Pwd='*.60.*cek';Encrypt=false;AllowUserVariables=True;UseCompression=True";


            MySqlCommand masalar = new MySqlCommand();
            masalar.CommandText = "SELECT * FROM masalar";
            masalar.Connection = baglanti;
            masalar.CommandType = CommandType.Text;

            MySqlDataReader kategoridDR;

            baglanti.Open();

            Boolean[] masadurumlari=new Boolean[12];
            

            kategoridDR = masalar.ExecuteReader();
            int i = 0;
            for (i=0; kategoridDR.Read(); i++)
            {
                masadurumlari[i] =Convert.ToBoolean(kategoridDR["masaDurum"]);
                 //kategoriCombo.Items.Add(kategoridDR["kategoriAdi"]);
               // masalarGetir.Text = masadurumlari;
               if ( masadurumlari[i] == true)
                    masaisim[i].BackColor = Color.Red;
                else
                    masaisim[i].BackColor = Color.Green;
            }


           

            


            baglanti.Close();
        }
        }

           //

           }*/
