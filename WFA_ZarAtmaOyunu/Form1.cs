namespace WFA_ZarAtmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZarAt_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval=100;
        }
        Random rnd=new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblZar1.Text=rnd.Next(1, 7).ToString();
            lblZar2.Text=rnd.Next(1, 7).ToString();
            timer1.Interval+=20;
            if (timer1.Interval>=250)
            {
                timer1.Stop();
            }
        }
    }
}