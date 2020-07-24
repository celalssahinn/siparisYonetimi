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
    public partial class yemekler : Form
    {
        menudekiler menu = new menudekiler();
        public yemekler()
        {
            InitializeComponent();
            
            
        }

        private void KebaplarButon_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            veriTabaniİliskilendirici.butonName = tumunuListele.Text;
            menu.ShowDialog();
        }
    }
}
