namespace risunki
{
    public partial class Form1 : Form
    {
        Bitmap bitmap = new Bitmap(400, 400);
        public Form1()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += new EventHandler(this.button1_Click);
            radioButton2.CheckedChanged += new EventHandler(this.button3_Click);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int x = 150; x < 200; x++)
            {
                for (int y = 150; y < 200; y++)
                {
                    bitmap.SetPixel(x, y, Color.Black);
                }
            }
            pictureBox1.Image = bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 400; x++)
            {
                for (int y = 0; y < 400; y++)
                {
                    bitmap.SetPixel(x, y, Color.Transparent);
                }
            }
            pictureBox1.Image = bitmap;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 400; x++)
            {
                for (int y = 0; y < 400; y++)
                {
                    bitmap.SetPixel(x, y, Color.Black);
                }
            }

            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                bitmap.SetPixel(rnd.Next(0, 400), rnd.Next(0, 400), Color.Yellow);
            }

            pictureBox1.Image = bitmap;
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}