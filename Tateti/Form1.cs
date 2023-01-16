namespace Tateti
{
    public partial class Form1 : Form
    {
        List<Button> botones = new List<Button>();
        int turno = 0;
        static int cont = 0;
        Boolean ganador = false;
        Bitmap imagen = new Bitmap(Application.StartupPath + @"\imagenes\bocaEscudo.png");
        Bitmap imagen2 = new Bitmap(Application.StartupPath + @"\imagenes\riverEscudo.png");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            crearbotonea();
            
            actualizarLabel();
        }
        void crearbotonea() {
            int left = 50;
            int top = 50;
            for (int i = 0; i < 9; i++) {
               var button = new Button();
                button.Width = 80;
                button.Height = 80;
                button.Font = new Font(new FontFamily("arial"), 10);
                button.Visible = true;
                button.Left = left;
                button.Top = top;
               button.Click += this.presionrbot;

                left += 150;
                if (i == 2 || i == 5) {

                    top += 150;
                    left = 50;
                
                }
                botones.Add(button);
                this.Controls.Add(button);
                
            }
        }
        void presionrbot(object sender, EventArgs eventArgs) {
            Button button = (Button)sender;
            
            if (button.Image == null && ganador == false)
            {
                if (turno == 0)
                {
                   

                    button.Image =this.imagen;
                    turno = 1;
                    cont++;
                    Verifivarganador();
                    actualizarLabel();
                    
                    
                   
                    //Verifivarganador();

                }
                else
                {


                    button.Image = this.imagen2;
                    turno = 0;
                    cont++;
                    Verifivarganador();
                    actualizarLabel();
                   
                    //Verifivarganador();

                }
                
            }
            if(ganador==true) {
                if (turno == 0)
                {

                    if (MessageBox.Show($"Ganó el jugador {turno + 2}. Desea jugar de nuevo?", "Ganador", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Reiniciarpartida();
                        ganador = false;
                    }
                    else {
                        Application.Exit();
                    }
                    
                }
                else {
                    if (MessageBox.Show($"Ganó el jugador {turno}. Desea jugar de nuevo?", "Ganador", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Reiniciarpartida();
                        ganador = false;
                    }
                    else { Application.Exit(); }
                    
                }

            }
        
        }
        void actualizarLabel() {


            
            lblTurno.Text = "Turno del jugardor n*" + (turno + 1); 
           
                
           
           
            
        }
        void Verifivarganador() {

            if ((botones[0].Image== imagen || botones[0].Image== imagen2) && botones[0].Image == botones[1].Image && botones[1].Image == botones[2].Image ||
               (botones[3].Image == imagen || botones[3].Image == imagen2) && botones[3].Image== botones[4].Image && botones[4].Image == botones[5].Image ||
              (botones[6].Image == imagen || botones[6].Image == imagen2) && botones[6].Image == botones[7].Image && botones[7].Image == botones[8].Image ||
                (botones[0].Image == imagen || botones[0].Image == imagen2) && botones[0].Image == botones[3].Image && botones[3].Image == botones[6].Image ||
              (botones[1].Image == imagen || botones[1].Image == imagen2) && botones[1].Image == botones[4].Image && botones[4].Image == botones[7].Image ||
                (botones[2].Image == imagen || botones[2].Image == imagen2) && botones[2].Image == botones[5].Image && botones[5].Image == botones[8].Image ||
                (botones[0].Image == imagen || botones[0].Image == imagen2) && botones[0].Image== botones[4].Image && botones[4].Image == botones[8].Image ||
               (botones[2].Image == imagen || botones[2].Image == imagen2) && botones[2].Image == botones[4].Image && botones[4].Image == botones[6].Image)
            {
                ganador = true;
            }
           else if (cont>=9 && ganador==false) {
                if (MessageBox.Show($"El juego termino empatado. Desea jugar de nuevo?", "Empate", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Reiniciarpartida();
                    ganador = false;
                    
                }
                else { Application.Exit(); }



            }

        }

        void Reiniciarpartida() {
            turno = 0;
            cont = 0;
            actualizarLabel();
            
            for (int o=0; o<9; o++) {

                botones[o].Image = null;
            
            }
        
        
        
        }
            
        
        
        }
    }

