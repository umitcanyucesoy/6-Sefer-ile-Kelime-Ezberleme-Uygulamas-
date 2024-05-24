using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace KelimeEzberlemeSistemi
{
    public partial class kullanicikayit : Form
    {
        public kullanicikayit()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            
            SqlCommand komut = new SqlCommand("insert into Tbl_KullaniciGiris (kullaniciAdi,kullaniciSifre,kullaniciAd,kullaniciSoyad,kullaniciTC,kullaniciTelefon) Values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox3.Text);
            komut.Parameters.AddWithValue("@p2", textBox4.Text);
            komut.Parameters.AddWithValue("@p3", textBox1.Text);
            komut.Parameters.AddWithValue("@p4", textBox2.Text);
            komut.Parameters.AddWithValue("@p5", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p6", maskedTextBox2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
