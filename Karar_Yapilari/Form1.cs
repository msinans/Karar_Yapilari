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
            // Klavyeden girilen isim do�ruysa
            if (textBox1.Text == "ali")
            {
                label1.Text = "do�ru";
            }
            else
            {
                label1.Text = "yanl��";
            }
            // Klavyeden girilen say� do�ruysa


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox2.Text);

            if (sayi == 5)
            {
                label2.Text = "do�ru say� girildi";
            }
            else
            {
                label2.Text = "yanl�� say� girildi";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox3.Text);
            if (sayi % 2 == 0)
            {
                label3.Text = "say� �ift";
            }
            else
            {
                label3.Text = "say� tek";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox4.Text);
            if (sayi >= 10 & sayi % 2 == 0)
            {
                label4.Text = "10'dan b�y�k ve �ift";
            }
            else
            {
                label4.Text = "10'dan b�y�k de�il veya �ift de�il";
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
                label5.Text = "10'dan b�y�k veya �ift";
            }
            else
            {
                label5.Text = "10'dan b�y�k de�il veya �ift de�il"; 
            }
        }
    }
}