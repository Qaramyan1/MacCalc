namespace MacCalc
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;
        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {



        }

        private void textBox1_Click(object sender, EventArgs e)
        {


        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void separation_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;

        }

        private void equation_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                res = dn1 + dn2;
            }
            if (D == "-")
            {
                res = dn1 - dn2;
            }
            if (D == "×")
            {
                res = dn1 * dn2;
            }
            if (D == "/")
            {
                res = dn1 / dn2;
            }
           
            D = "=";
            n2 = true;
            textBox1.Text = res.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Button B = (Button)sender;

            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = B.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + B.Text;
            }
            if (B.Text == ",")
            {
               
                if (!textBox1.Text.Contains(","))
                    textBox1.Text = textBox1.Text + ","; }
            

        }
    }
}
