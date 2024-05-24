using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;

namespace KelimeEzberlemeSistemi
{
    public partial class sinavmodulu2 : Form
    {

        public SoruHavuzu soruHavuzu;
        public Soru suankiSoru;
        public int dogruCevapSayısı,dogruCevap,yanlisCevap,soruSayisi;

        public sinavmodulu2()
        {
            InitializeComponent();
            soruHavuzu = new SoruHavuzu();
            dogruCevapSayısı = 0;
            dogruCevap = 0;
            yanlisCevap = 0;
            soruSayisi = 0;
            SuankiSoruyuGuncelle();
        }

        private void lblSoruSayisi_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullaniciArayuz backtoform = new KullaniciArayuz();
            backtoform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Doğru Yüzdesi: " + dogruCevap * 10
                   + " Yanlış Yüzdesi: " + yanlisCevap *10,"Doğru Yanlış Yüzdesi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        Font baslik = new Font("Verdana", 12, FontStyle.Bold);
        Font govde = new Font("Verdana", 12);
        SolidBrush sb = new SolidBrush(Color.Black);

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Soru Sayısı: " + soruSayisi, baslik, sb,70,100);
            e.Graphics.DrawString("Doğru Sayısı: " + dogruCevap, baslik, sb, 70, 150);
            e.Graphics.DrawString("Yanlış Sayısı: " + yanlisCevap, baslik, sb, 70, 200);
            e.Graphics.DrawString("Kelime Öğrenme Oranı: " + dogruCevap*10, baslik, sb, 70, 250);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cevap = textBox1.Text.Trim();

            if (suankiSoru.DogruCevap == cevap)                
            {
                soruSayisi += 1;
                dogruCevapSayısı++;
                dogruCevap += 1;
                lblDogru.Text = dogruCevap.ToString();
                lblSoruSayisi.Text = soruSayisi.ToString();
                MessageBox.Show("Doğru cevap!");
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;

                if (dogruCevapSayısı >= 6)
                {
                   
                    soruHavuzu.BilinenSorularaEkle(suankiSoru);
                    
                    soruHavuzu.SoruKaldır(suankiSoru);
                    
                    SuankiSoruyuGuncelle();
                    
                    dogruCevapSayısı = 0;
                }
                else
                {
                    SuankiSoruyuGuncelle();
                }
            }
            else
            {
                soruSayisi += 1;
                yanlisCevap = +1;
                lblYanlis.Text = yanlisCevap.ToString();
                lblSoruSayisi.Text = soruSayisi.ToString();
                MessageBox.Show("Yanlış cevap! Tekrar deneyin.");
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                
            }
        }
        private void SuankiSoruyuGuncelle()
        {
            suankiSoru = soruHavuzu.SoruGetir();
            label1.Text = suankiSoru.Metin;
            textBox1.Text = "";
        }

        private void sinavmodulu2_Load(object sender, EventArgs e)
        {

        }
    }

    public class Soru
    {
        public string Metin { get; }
        public string DogruCevap { get; }

        public Soru(string metin, string dogruCevap)
        {
            Metin = metin;
            DogruCevap = dogruCevap;
        }
    }
    public class SoruHavuzu
    {
        private List<Soru> soruHavuzu;
        private HashSet<Soru> bilinenSorular;

        public SoruHavuzu()
        {
            soruHavuzu = new List<Soru>
            {
                new Soru("Ancient", "Eski"),
                new Soru("Advice", "Tavsiye"),
                new Soru("Difficult", "Zor"),
                new Soru("Late", "Geç"),
                new Soru("First", "İlk"),
                new Soru("Criminal", "Suçlu"),
                new Soru("Creative", "Yaratıcı"),
                new Soru("Last", "Son"),
                new Soru("Available", "Ulaşılabilir"),
                new Soru("Communication", "İletişim"),
                new Soru("Cheap", "Ucuz"),
                new Soru("Expensive", "Pahalı"),
                new Soru("After", "Sonra"),
                new Soru("Answer", "Cevap"),
                new Soru("Art", "Sanat"),
                new Soru("Abandon", "Bırakmak"),
                new Soru("About", "Hakkında"),
                new Soru("Abroad", "Yurtdışı"),
                new Soru("Accept", "Kabul Etmek"),
                new Soru("Account", "Hesap"),
                



            };

            bilinenSorular = new HashSet<Soru>();
        }

        public Soru SoruGetir()
        {
            Random random = new Random();
            return soruHavuzu[random.Next(soruHavuzu.Count)];
        }

        public void BilinenSorularaEkle(Soru soru)
        {
            bilinenSorular.Add(soru);
        }

        public void SoruKaldır(Soru soru)
        {
            soruHavuzu.Remove(soru);
        }
    }

    

}
