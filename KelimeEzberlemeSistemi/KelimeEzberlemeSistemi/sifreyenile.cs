using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KelimeEzberlemeSistemi
{
    public partial class sifreyenile : Form
    {
        public sifreyenile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 backtoform = new Form1();
            backtoform.Show();
            this.Hide();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into Tbl_KullaniciGiris (kullaniciAdi,kullaniciSifre) Values (@p1,@p2)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox4.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şifreniz Değiştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
