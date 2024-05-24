using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace KelimeEzberlemeSistemi
{
    public partial class KelimeEklemeModülü : Form
    {
        public KelimeEklemeModülü()
        {
            InitializeComponent();
        }


        int sonrakiKelime;
        


        private void button1_Click(object sender, EventArgs e)
        {
            sonrakiKelime++;
            label5.Text = sonrakiKelime.ToString();

            if (sonrakiKelime == 1)
            {
                label2.Text = "Ancient";
                label4.Text = "Eski";
                richTextBox1.Text = "1-Malta is home to some of the world's most ancient temples.\n"
                    + "2-This ancient church was built more than a thousand years ago.\n"
                    + "3-She's a well-known researcher in ancient languages.\n"
                    + "4-The outer walls of the ancient city are massive.\n"
                    + "5-I find ancient history fascinating.\n"
                    + "6-Ancient Greece is the birthplace of the modern world.\n"
                    + "7-Yoga is an ancient spiritual, physical and mental practice.\n"
                    + "8-The ancient caves date back to the Ice Age.\n"
                    + "9-Later, he was influenced by ancient Greek sculpture.\n"
                    + "10-This expression comes from an ancient Greek story.\n";
                pictureBox1.Image = Image.FromFile("C:\\ancient.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                SoundPlayer sp = new SoundPlayer(@"C://ancient.wav");
                sp.Play();
                
                
            }
            if (sonrakiKelime == 2)
            {
                label2.Text = "Communication";
                label4.Text = "İletişim";
                richTextBox1.Text = "1-You need good communication skills if you want to work in sales.\n"
                    + "2-We need to improve communication between different departments in the company..\n"
                    + "3-I'm trying to improve my communication skills.\n"
                    + "4-Good communication is essential to doing business.\n"
                    + "5-If everyone could speak English, it would be so easy to communicate..\n"
                    + "6-I also use Skype to communicate with my family in Canada.\n"
                    + "7-One form of marketing communication is advertising.\n"
                    + "8-In general, anything that requires an explanation inhibits communication.\n"
                    + "9-His father was a famous teacher of speech communication.\n"
                    + "10-A whistled language is a highly-developed method of communication.\n";
                pictureBox1.Image = Image.FromFile("C:\\communication.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                SoundPlayer sp = new SoundPlayer(@"C://communication.wav");
                sp.Play();
            }
            if (sonrakiKelime == 3)
            {
                label2.Text = "Available";
                label4.Text = "Ulaşılabilir";
                richTextBox1.Text = "1-The game will be available for purchase online on February 11.\n"
                    + "2-The VIP lounge is available to all of our first class passengers.\n"
                    + "3-Free Wi-Fi is now available in all of the city's public libraries.\n"
                    + "4-There is technical assistance available either online or by telephone during normal business hours.\n"
                    + "5-Our new cell phone is now available for sale online.\n"
                    + "6-Do you have any single rooms available?\n"
                    + "7-This is all the available information I have at the moment.\n"
                    + "8-The company has a technical support team readily available to answer any questions.\n"
                    + "9-The collar is available in small and large sizes, with five different colors available.\n"
                    + "10-However, it is usually not available.\n";
                pictureBox1.Image = Image.FromFile("C:\\available.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                SoundPlayer sp = new SoundPlayer(@"C://available.wav");
                sp.Play();
            }
            if (sonrakiKelime == 4)
            {
                label2.Text = "Cheap";
                label4.Text = "Ucuz";
                richTextBox1.Text = "1-Domestic flights in Germany are very cheap.\n"
                    + "2-I was shocked at how cheap food was when I went to Thailand.\n"
                    + "3-I'm looking for a cheap hotel.\n"
                    + "4-I found some really cheap clothes on sale.\n"
                    + "5-This restaurant has cheap lunch sets.\n"
                    + "6-I usually eat at cheap restaurants.\n"
                    + "7-Round-trip tickets to New York are really cheap right now.\n"
                    + "8-I got a cheap flight at the last minute.\n"
                    + "9-Food is usually cheaper in supermarkets.\n"
                    + "10-Children and the elderly are entitled to cheap train tickets.\n";
                pictureBox1.Image = Image.FromFile("C:\\cheap.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                SoundPlayer sp = new SoundPlayer(@"C://cheap.wav");
                sp.Play();

            }
            if (sonrakiKelime == 5)
            {
                label2.Text = "Advice";
                label4.Text = "Tavsiye";
                richTextBox1.Text = "1-I need some advice on which computer to buy.\n"
                    + "2-Give someone advice Steven gave me some good advice.\n"
                    + "3-We went to Paris on Sarah's advice.\n"
                    + "4-On the advice of my doctor, I started riding my bicycle more frequently.\n"
                    + "5-I think I’ll take your advice and go home.\n"
                    + "6-She gave me some good advice.\n"
                    + "7-Some of them give really helpful advice about the job market.\n"
                    + "8-Speak to an independent financial adviser for advice on personal pensions.\n"
                    + "9-He offers advice on rights when buying goods or services.\n"
                    + "10-The website offers career advice for executives.\n";
                pictureBox1.Image = Image.FromFile("C:\\advice.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                SoundPlayer sp = new SoundPlayer(@"C://advice.wav");
                sp.Play();
            }
            if (sonrakiKelime == 6)
            {
                label2.Text = "Different";
                label4.Text = "Farklı";
                richTextBox1.Text = "1-She seems to wear something different every day.\n"
                    + "2-He's different now that he's been to college.\n"
                    + "3-We're reading a different book this week.\n"
                    + "4-Emily is very different from her sister.\n"
                    + "5-Emily and her sister are completely different.\n"
                    + "6-There are many different types of bacteria.\n"
                    + "7-The weather down here is a lot different than it is at home.\n"
                    + "8-Emily is entirely different from her sister.\n"
                    + "9-Monet and other Impressionists painted the same scene at different times of day to discover how the colors change in the different light.\n"
                    + "10-The figure of the consumer embodies a different view of the public.\n";
                pictureBox1.Image = Image.FromFile("C:\\different.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                SoundPlayer sp = new SoundPlayer(@"C://different.wav");
                sp.Play();
            }
            if (sonrakiKelime == 7)
            {
                label2.Text = "Creative";
                label4.Text = "Yaratıcı";
                richTextBox1.Text = "1-Indeed, this view is borne out by the way in which companies and markets reward inventors, designers and \"creatives\".\n"
                    + "2-Creative children are often learning and thinking when they appear to be playing around, often in manipulative or exploratory activities.\n"
                    + "3-Inspiring starting points are vital in any creative activity.\n"
                    + "4-The sections on listening and performance in particular reinforce the creative cognitive engagement that occurs during those activities.\n"
                    + "5-What is most important is to keep the creative spark alight.\n"
                    + "6-In this view, eminently creative people employ cognitive processes that are radically different from those used by most individuals in everyday problem solving.\n"
                    + "7-The resulting effects were to be treated as creative material that could be incorporated into one or more variations, and not as ends in themselves.\n"
                    + "8-The creative composing teachers produce far more independent thinking from their students, even students of a generally lower academic ability.\n"
                    + "9-A third, more challenging, prospect would be the creation of a new model of assessment of creative music making.\n"
                    + "10-Such creative productions seem unlikely if inflections were associated only with specific verbs.\n";
                pictureBox1.Image = Image.FromFile("C:\\creative.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                SoundPlayer sp = new SoundPlayer(@"C://creative.wav");
                sp.Play();
            }
            if (sonrakiKelime == 8)
            {
                label2.Text = "Criminal";
                label4.Text = "Suçlu";
                richTextBox1.Text = "1-She may face criminal charges for lying to a grand jury.\n"
                    + "2-He had an extensive criminal record.\n"
                    + "3-The way she blames other people for her own mistakes is criminal.\n"
                    + "4-To this day she remains impenitent about her criminal past.\n"
                    + "5-When the authorities inquired into his background, they found he had a criminal record.\n"
                    + "6-Researchers have just completed the largest-ever survey of criminal behaviour in the UK.\n"
                    + "7-She has strenuously denied any criminal wrongdoing.\n"
                    + "8-The 19-year-old will be appearing in court on Thursday where she will face criminal charges.\n"
                    + "9-The police are conducting a criminal investigation into the company.\n"
                    + "10-I've heard that she has a criminal record.\n";
                pictureBox1.Image = Image.FromFile("C:\\criminal.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                SoundPlayer sp = new SoundPlayer(@"C://criminal.wav");
                sp.Play();
            }
            if (sonrakiKelime == 9)
            {
                label2.Text = "First";
                label4.Text = "İlk";
                richTextBox1.Text = "1-This is his first time to play golf.\n"
                    + "2-He didn't enjoy his first kiss.\n"
                    + "3-First, we need to go shopping.\n"
                    + "4-On top of that, it will be my first time climbing a mountain.\n"
                    + "5-John, we are here at the pool because you have your first swimming lesson today.\n"
                    + "6-You want to buy a new smartphone, but first you want to talk about it with a family member.\n"
                    + "7-First, I’ll teach you how to do sit-ups, and then later on, we will do push-ups.\n"
                    + "8-My immune system wasn’t so good back then, so I used to get sick every year when the first snow fell.\n"
                    + "9-Their first baby is due in January.\n"
                    + "10-I was amazed to hear that Chris had won first prize.\n";
                pictureBox1.Image = Image.FromFile("C:\\first.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                SoundPlayer sp = new SoundPlayer(@"C://first.wav");
                sp.Play();
            }
            if (sonrakiKelime == 10)
            {
                label2.Text = "Expensive";
                label4.Text = "Pahalı";
                richTextBox1.Text = "1-Membership fees at this gym are very expensive.\n"
                    + "2-This TV is more expensive, but it does have a lot more features.\n"
                    + "3-European cars are quite expensive in the United States.\n"
                    + "4-To remove the rust from your car is going to be quite expensive.\n"
                    + "5-Taking a taxi in London is expensive.\n"
                    + "6-Most of their products are too expensive for me.\n"
                    + "7-He is always going on expensive business trips.\n"
                    + "8-This is a very expensive restaurant.\n"
                    + "9-Diamonds are the most expensive gems in the world.\n"
                    + "10-They enjoy going to expensive restaurants.\n";
                pictureBox1.Image = Image.FromFile("C:\\expensive.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                SoundPlayer sp = new SoundPlayer(@"C://expensive.wav");
                sp.Play();
            }
            if (sonrakiKelime == 11)
            {
                label2.Text = "Interesting";
                label4.Text = "İlgi Çekici";
                richTextBox1.Text = "1-She suggested an interesting idea at the meeting.\n"
                    + "2-I'm reading an interesting book.\n"
                    + "3-My teacher is a very interesting person.\n"
                    + "4-We had an interesting conversation.\n"
                    + "5-Taking a taxi in London is expensive.\n"
                    + "6-Sounds interesting.\n"
                    + "7-I read an interesting article in the newspaper today.\n"
                    + "8-Talk about interesting or sad things that have happened to you lately.\n"
                    + "9-Now I’m interested in watching your games!\n"
                    + "10-Well, they’re very interesting.\n";
                pictureBox1.Image = Image.FromFile("C:\\interesting.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                SoundPlayer sp = new SoundPlayer(@"C://interesting.wav");
                sp.Play();
            }
            if (sonrakiKelime == 12)
            {
                label2.Text = "Late";
                label4.Text = "Geç/Son";
                richTextBox1.Text = "1-Jessica is running late for work.\n"
                    + "2-You’d better hurry; you’re already late!\n"
                    + "3-I thought I'd be late for my appointment.\n"
                    + "4-I stayed up late working on this presentation several nights in a row.\n"
                    + "5-You are late for a meeting, and you have forgotten your phone at home.\n"
                    + "6-Jessica, you need to hurry up, or else you’ll be late and your boss will be annoyed!\n"
                    + "7-Talk about interesting or sad things that have happened to you lately.\n"
                    + "8-From the late 19th century, European powers began to gain control of parts of the Ottoman Empire.\n"
                    + "9-House music first appeared in the late 1980s.\n"
                    + "10-Nowadays many women are in their late thirties when they have their first child.\n";
                pictureBox1.Image = Image.FromFile("C:\\late.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                SoundPlayer sp = new SoundPlayer(@"C://late.wav");
                sp.Play();
            }
            if (sonrakiKelime == 13)
            {
                MessageBox.Show("Kelimeleri Tamamladınız.Lütfen Sınav Modülüne Geçiniz!","Tebrikler.!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                KullaniciArayuz backtoform = new KullaniciArayuz();
                backtoform.Show();
                this.Hide();
            }






        }

        private void KelimeEklemeModülü_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciArayuz backtoform = new KullaniciArayuz();
            backtoform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
