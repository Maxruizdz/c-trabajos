namespace Calculadora
{
    public partial class Form1 : Form
    {
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                lblopera1.Text += button1.Text;

            }
            else {

                lblopera2.Text += button1.Text;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                lblopera1.Text += btn2.Text;

            }
            else
            {

                lblopera2.Text += btn2.Text;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                lblopera1.Text += btn3.Text;

            }
            else
            {

                lblopera2.Text += btn3.Text;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                lblopera1.Text += btn4.Text;

            }
            else
            {

                lblopera2.Text += btn4.Text;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                lblopera1.Text += btn5.Text;

            }
            else
            {

                lblopera2.Text += btn5.Text;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                lblopera1.Text += btn6.Text;

            }
            else
            {

                lblopera2.Text += btn6.Text;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                lblopera1.Text += btn7.Text;

            }
            else
            {

                lblopera2.Text += btn7.Text;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                lblopera1.Text += btn8.Text;

            }
            else
            {

                lblopera2.Text += btn8.Text;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                lblopera1.Text += btn9.Text;

            }
            else
            {

                lblopera2.Text += btn9.Text;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                lblopera1.Text += btn0.Text;

            }
            else
            {

                lblopera2.Text += btn0.Text;
            }
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            lblsimbolo.Text = btnsuma.Text;
            cont++;
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            lblsimbolo.Text = btnresta.Text;
            cont++;
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            lblsimbolo.Text = btnmulti.Text;
            cont++;
        }

        private void btndivi_Click(object sender, EventArgs e)
        {
            lblsimbolo.Text = btndivi.Text;
            cont++;
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            float opera1 = float.Parse(lblopera1.Text);
            float opera2 = float.Parse(lblopera2.Text);
            if (string.Compare("+", lblsimbolo.Text, StringComparison.OrdinalIgnoreCase) == 0) {
                label3.Text = (opera1 + opera2).ToString();
            
            }
          else  if (string.Compare("-", lblsimbolo.Text, StringComparison.OrdinalIgnoreCase) == 0)
            {
                label3.Text = (opera1 - opera2).ToString();

            }
           else if (string.Compare("/", lblsimbolo.Text, StringComparison.OrdinalIgnoreCase) == 0)
            {
                label3.Text = (opera1 / opera2).ToString();

            }
            else if (string.Compare("x", lblsimbolo.Text,StringComparison.OrdinalIgnoreCase) == 0)
            {
                label3.Text = (opera1 * opera2).ToString();

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            cont = 0;
            lblopera1.Text = "";
            lblopera2.Text = "";
            lblsimbolo.Text = "";
            label3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            lblopera1.Text = label3.Text;
            lblopera2.Text = "";
            lblsimbolo.Text = "";
            label3.Text = "";

        }
    }
}