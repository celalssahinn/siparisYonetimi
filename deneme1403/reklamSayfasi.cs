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
    public partial class reklamSayfasi : Form
    {
        public reklamSayfasi()
        {
            InitializeComponent();

        }

     
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {


            if (pictureBox3.Visible == true)
            {

                pictureBox3.Visible = false;
                pictureBox2.Visible = true;

            }
            if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;

            }

        }
    
        private void reklamSayfasi_Load(object sender, EventArgs e)
        {

        }
    }
}
