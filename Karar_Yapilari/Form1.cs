namespace Karar_Yapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Klavyeden girilen isim doðruysa
            if (textBox1.Text == "ali")
            {
                label1.Text = "doðru";
            }
            else
            {
                label1.Text = "yanlýþ";
            }
            // Klavyeden girilen sayý doðruysa


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox2.Text);

            if (sayi == 5)
            {
                label2.Text = "doðru sayý girildi";
            }
            else
            {
                label2.Text = "yanlýþ sayý girildi";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox3.Text);
            if (sayi % 2 == 0)
            {
                label3.Text = "sayý çift";
            }
            else
            {
                label3.Text = "sayý tek";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox4.Text);
            if (sayi >= 10 & sayi % 2 == 0)
            {
                label4.Text = "10'dan büyük ve çift";
            }
            else
            {
                label4.Text = "10'dan büyük deðil veya çift deðil";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox5.Text);
            if (sayi >= 10 || sayi%2 ==0)
            {
                label5.Text = "10'dan büyük veya çift";
            }
            else
            {
                label5.Text = "10'dan büyük deðil veya çift deðil"; 
            }
        }
    }
}