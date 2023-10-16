namespace Asansör_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label9.Text = "1";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label9.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label9.Text == "1")
            {
                label4.BackColor = Color.Turquoise;
                label7.BackColor = Color.Turquoise;
                label8.Top -= 5;

                if (label8.Location.Y<=141)
                {
                    timer1.Stop();
                    label5.BackColor = Color.LightGreen; 
                    label6.BackColor=Color.LightGreen;
                }
            }
            if (label9.Text == "0")
            {
                label5.BackColor = Color.Turquoise;
                label6.BackColor = Color.Turquoise;
                label8.Top += 5;

                if (label8.Location.Y >= 390)
                {
                    timer1.Stop();
                    label4.BackColor = Color.LightGreen;
                    label7.BackColor = Color.LightGreen;

                }
            }
        }
    }
}