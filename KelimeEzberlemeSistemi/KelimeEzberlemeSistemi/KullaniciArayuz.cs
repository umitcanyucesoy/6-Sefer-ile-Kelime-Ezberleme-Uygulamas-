
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeEzberlemeSistemi
{
    public partial class KullaniciArayuz : Form
    {
        public KullaniciArayuz()
        {
            InitializeComponent();
        }

        private void KullaniciArayuz_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KelimeEklemeModülü nextform = new KelimeEklemeModülü();
            nextform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           sinavmodulu2 nextform = new sinavmodulu2();
           nextform.Show();
           this.Hide();
        }
    }
}
