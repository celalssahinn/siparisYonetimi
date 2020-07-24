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
    public partial class veriSecim : Form
    {
        public veriSecim()
        {
            InitializeComponent();
        }

        private void masaHakkindaGeri_Click(object sender, EventArgs e)
        {
            
            siparisVer siparisAlim = new siparisVer();
            siparisAlim.ShowDialog();
            this.Close();
        }

        private void siparisGiris_Click(object sender, EventArgs e)
        {
            SiparisVeriGirisi siparisVerPersonel = new SiparisVeriGirisi();
            siparisVerPersonel.ShowDialog();
        }

        private void veriSecim_Load(object sender, EventArgs e)
        {
            personelİsimVeriSecim.Text = veriTabaniİliskilendirici.personelAdi;
        }

        private void siparisListele_Click(object sender, EventArgs e)
        {
            siparisVerListele siparisListe = new siparisVerListele();
            siparisListe.ShowDialog();
            this.Close();
        }
    }
}
