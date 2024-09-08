namespace calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int Res = num1 + num2;
            button5.Text = Res.ToString();
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int Res = num1 - num2;
            button5.Text = Res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int Res = num1 * num2;
            button5.Text = Res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1= int.Parse(textBox1.Text);
            int num2= int.Parse(textBox2.Text);
            int Res = num1 / num2;
            button5.Text = Res.ToString();
        }
        
    }
    
}
