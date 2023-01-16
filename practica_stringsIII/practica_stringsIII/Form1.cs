namespace practica_stringsIII
{
    public partial class Form1 : Form
    {
        string palabra = "auto";
        string palabra2 = "";
        int cont = 0;
        int contador_acierto = 0;
        int contador_semiaciertos = 0;
        int contador_desaciertos = 0;
        int contador_palabra1 = 0;
        int contador_palabra2 = 0;
        int contador_palabra3 = 0;
        int contador_palabra4 = 0;
        Dictionary<string, int> diccionario = new Dictionary<string, int>();


        public Form1()
        {
            InitializeComponent();
            esconderop();
            llenar_dictionary();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void llenar_dictionary()
        {

            for (int i = 0; i < palabra.Length; i++)
            {

                if (diccionario.ContainsKey(palabra[i].ToString()))
                {


                    diccionario[palabra[i].ToString()]++;


                }
                else
                {

                    diccionario.Add(palabra[i].ToString(), 1);



                }


            }




        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
        public void esconderop()
        {
            panel6.Visible = false;
            panel5.Visible = false;


        }
        public void mostrar_panel(Panel panel5)
        {

            panel5.Visible = true;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        public void comprobar_semi_aciertos(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4)
        {

            
            if (palabra2.Length == palabra.Length)
            {
                
                for (int i = 0; i < palabra.Length; i++)
                {

                    if (palabra.Contains(palabra2[i]))
                    {
                        if (i == 0)
                        {
                            contador_semiaciertos++;
                            if (string.Equals(palabra2[0], palabra[1]))
                            {
                                int contador = diccionario[palabra[1].ToString()];
                                if (contador_palabra2 < contador)
                                {
                                    textBox1.BackColor = Color.Yellow;
                                    contador_palabra2++;

                                }
                                else
                                {

                                    textBox1.BackColor = Color.Red;

                                }


                            }
                            if (string.Equals(palabra2[0], palabra[2]))
                            {

                                if (contador_palabra3 < diccionario[palabra[2].ToString()])
                                {
                                    textBox1.BackColor = Color.Yellow;
                                    contador_palabra3++;

                                }
                                else
                                {

                                    textBox1.BackColor = Color.Red;

                                }


                            }
                            if (string.Equals(palabra2[0], palabra[3]))
                            {

                                if (contador_palabra4 < diccionario[palabra[3].ToString()])
                                {
                                    textBox1.BackColor = Color.Yellow;
                                    contador_palabra4++;

                                }
                                else
                                {

                                    textBox1.BackColor = Color.Red;

                                }


                            }

                        }
                        if (i == 1)
                        {
                            contador_semiaciertos++;
                            if (string.Equals(palabra2[1], palabra[0]))
                            {

                                if (contador_palabra1 < diccionario[palabra[0].ToString()])
                                {
                                    textBox2.BackColor = Color.Yellow;
                                    contador_palabra1++;

                                }
                                else
                                {

                                    textBox2.BackColor = Color.Red;

                                }


                            }
                            if (string.Equals(palabra2[1], palabra[2]))
                            {

                                if (contador_palabra3 < diccionario[palabra[2].ToString()])
                                {
                                    textBox2.BackColor = Color.Yellow;
                                    contador_palabra3++;

                                }
                                else
                                {

                                    textBox2.BackColor = Color.Red;

                                }


                            }
                            if (string.Equals(palabra2[1], palabra[3]))
                            {

                                if (contador_palabra4 < diccionario[palabra[3].ToString()])
                                {
                                    textBox2.BackColor = Color.Yellow;
                                    contador_palabra4++;
                                }
                                else
                                {

                                    textBox2.BackColor = Color.Red;

                                }


                            }


                        }
                        if (i == 2)
                        {
                            contador_semiaciertos++;
                            if (string.Equals(palabra2[2], palabra[0]))
                            {

                                if (contador_palabra1 < diccionario[palabra[0].ToString()])
                                {
                                    textBox3.BackColor = Color.Yellow;
                                    contador_palabra1++;
                                }
                                else
                                {

                                    textBox3.BackColor = Color.Red;

                                }


                            }
                            if (string.Equals(palabra2[2], palabra[1]))
                            {

                                if (contador_palabra2 < diccionario[palabra[1].ToString()])
                                {
                                    textBox3.BackColor = Color.Yellow;
                                    contador_palabra2++;

                                }
                                else
                                {

                                    textBox3.BackColor = Color.Red;

                                }


                            }
                            if (string.Equals(palabra2[2], palabra[3]))
                            {

                                if (contador_palabra4 < diccionario[palabra[3].ToString()])
                                {
                                    textBox3.BackColor = Color.Yellow;
                                    contador_palabra4++;
                                }
                                else
                                {

                                    textBox3.BackColor = Color.Red;

                                }



                            }


                        }

                        if (i == 3)
                        {
                            contador_semiaciertos++;

                            if (string.Equals(palabra2[3], palabra[0]))
                            {

                                if (contador_palabra1 < diccionario[palabra[0].ToString()])
                                {
                                    textBox4.BackColor = Color.Yellow;
                                    contador_palabra1++;
                                }
                                else
                                {

                                    textBox4.BackColor = Color.Red;

                                }


                            }
                            if (string.Equals(palabra2[3], palabra[1]))
                            {

                                if (contador_palabra2 < diccionario[palabra[1].ToString()])
                                {
                                    textBox4.BackColor = Color.Yellow;
                                    contador_palabra2++;

                                }
                                else
                                {

                                    textBox4.BackColor = Color.Red;

                                }


                            }
                            if (string.Equals(palabra2[3], palabra[2]))
                            {

                                if (contador_palabra3 < diccionario[palabra[3].ToString()])
                                {
                                    textBox4.BackColor = Color.Yellow;
                                    contador_palabra4++;
                                }
                                else
                                {

                                    textBox4.BackColor = Color.Red;

                                }


                            }

                        }
                    }
                }
            }
        }
        public void comprobar_aciertos(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4)
        {
              palabra2 = "";
             this.contador_palabra1 = 0;
             this.contador_palabra2 = 0;
             this.contador_palabra3 = 0;
             this.contador_palabra4 = 0;
            this.contador_acierto = 0;
            palabra2 += textBox1.Text;
            palabra2 += textBox2.Text;
            palabra2 += textBox3.Text;
            palabra2 += textBox4.Text;
            if (palabra2.Length == palabra.Length)
            {
               
                for (int i = 0; i < palabra.Length; i++)
                {


                    if (palabra.Contains(palabra2[i]))
                    {
                        if (string.Equals(palabra[i], palabra2[i]))
                        {

                            if (i == 0)
                            {

                                textBox1.BackColor = Color.Green;
                                contador_acierto++;
                                button2.Text = "A";
                                contador_palabra1++;




                            }
                            else if (i == 1)
                            {

                                textBox2.BackColor = Color.Green;
                                contador_acierto++;

                                button3.Text = "U";
                                contador_palabra2++;
                            }
                            else if (i == 2)
                            {

                                textBox3.BackColor = Color.Green;
                                contador_acierto++;

                                button4.Text = "T";
                                contador_palabra3++;


                            }

                            else if (i == 3)
                            {

                                textBox4.BackColor = Color.Green;
                                contador_acierto++;

                                button5.Text = "O";
                                contador_palabra4++;
                            }







                        }
                    }
                }
            }


           


        }
        public void comprobar_desaciertos(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4) { 
        
            if (palabra2.Length == palabra.Length)
            {
            
                for (int i = 0; i < palabra.Length; i++)
            {
                if (!palabra.Contains(palabra2[i]))
                {
                    if (i == 0)
                    {

                        textBox1.BackColor = Color.Red;
                        contador_desaciertos++;

                    }
                    if (i == 1)
                    {

                        textBox2.BackColor = Color.Red;
                        contador_desaciertos++;

                    }
                    if (i == 2)
                    {

                        textBox3.BackColor = Color.Red;
                        contador_desaciertos++;

                    }

                    if (i == 3)
                    {

                        textBox4.BackColor = Color.Red;
                        contador_desaciertos++;

                    }
                }
            }
        


                }
            
            
            
            }
                    
                    
                    
                    
                    
                    


                
            
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)

        {

            if (cont == 0)
            {
                comprobar_aciertos(textBox1, textBox2, textBox3, textBox4);
                if (palabra2.Length == palabra.Length)
                {
                    comprobar_semi_aciertos(textBox1, textBox2, textBox3, textBox4);
                    comprobar_desaciertos(textBox1, textBox2, textBox3, textBox4);
                    if (contador_acierto < 4)
                    {
                        mostrar_panel(panel5);
                        cont++;
                    }
                    else
                    {

                        MessageBox.Show("has ganadoooo, eres una bestiaaa!!");
                        this.Close();

                    }
                }
                else
                {

                    MessageBox.Show("Debe ingresar 4 caracteres");

                }
            }
            else if (cont == 1)
            {

                comprobar_aciertos(textBox6, textBox5, textBox8, textBox7);
                if (palabra2.Length == palabra.Length)
                {
                    comprobar_semi_aciertos(textBox6, textBox5, textBox8, textBox7);
                    comprobar_desaciertos(textBox6, textBox5, textBox8, textBox7);
                    if (contador_acierto < 4)
                    {
                        mostrar_panel(panel6);
                        cont++;
                    }
                    else
                    {

                        MessageBox.Show("has ganadoooo, eres una bestiaaa!!");
                        this.Close();

                    }
                }
                else
                { MessageBox.Show("Debe ingresar 4 caracteres"); }
            }
            else if (cont == 2)
            {

                comprobar_aciertos(textBox10, textBox9, textBox12, textBox11);
                if (palabra2.Length == palabra.Length)
                {
                    comprobar_semi_aciertos(textBox10, textBox9, textBox12, textBox11);
                    comprobar_desaciertos(textBox10, textBox9, textBox12, textBox11);
                    if (contador_acierto < 4)
                    {

                        MessageBox.Show("has perdido, La palabra era: Auto");
                        this.Close();

                    }
                    else
                    {

                        MessageBox.Show("has ganadoooo, eres una bestiaaa!!");
                        this.Close();

                    }
                }
                else {
                    MessageBox.Show("Debe ingresar 4 caracteres");

                }


            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}