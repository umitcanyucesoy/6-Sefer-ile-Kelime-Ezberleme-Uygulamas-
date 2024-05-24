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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kullanicikayit fr = new kullanicikayit();
            fr.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifreyenile fr = new sifreyenile();
            fr.Show();
            this.Hide();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            

            SqlCommand komut = new SqlCommand("Select * From Tbl_KullaniciGiris Where kullaniciAdi=@p1 and kullaniciSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                KullaniciArayuz fr = new KullaniciArayuz();
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.!");
            }
            bgl.baglanti().Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
