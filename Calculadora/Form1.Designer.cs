namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnigual = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btndivi = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblopera1 = new System.Windows.Forms.Label();
            this.lblsimbolo = new System.Windows.Forms.Label();
            this.lblopera2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 131);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(247, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnigual);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.btndivi);
            this.panel2.Controls.Add(this.btnmulti);
            this.panel2.Controls.Add(this.btnresta);
            this.panel2.Controls.Add(this.btnsuma);
            this.panel2.Controls.Add(this.btn9);
            this.panel2.Controls.Add(this.btn8);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.btn6);
            this.panel2.Controls.Add(this.btn7);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.btn0);
            this.panel2.Location = new System.Drawing.Point(0, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 193);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnigual
            // 
            this.btnigual.Location = new System.Drawing.Point(537, 130);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(65, 55);
            this.btnigual.TabIndex = 22;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(453, 130);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(70, 55);
            this.button15.TabIndex = 21;
            this.button15.Text = "borrar";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // btndivi
            // 
            this.btndivi.Location = new System.Drawing.Point(537, 64);
            this.btndivi.Name = "btndivi";
            this.btndivi.Size = new System.Drawing.Size(65, 55);
            this.btndivi.TabIndex = 20;
            this.btndivi.Text = "/";
            this.btndivi.UseVisualStyleBackColor = true;
            this.btndivi.Click += new System.EventHandler(this.btndivi_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.Location = new System.Drawing.Point(453, 64);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(70, 55);
            this.btnmulti.TabIndex = 19;
            this.btnmulti.Text = "x";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(537, 3);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(65, 55);
            this.btnresta.TabIndex = 18;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(453, 3);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(70, 55);
            this.btnsuma.TabIndex = 17;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(363, 0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(84, 187);
            this.btn9.TabIndex = 16;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(273, 64);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(84, 55);
            this.btn8.TabIndex = 15;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(3, 64);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(84, 55);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(93, 64);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(84, 55);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(183, 64);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(84, 55);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(93, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(84, 55);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(183, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(84, 55);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(273, 3);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(84, 55);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(3, 120);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(354, 65);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(548, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 1;
            // 
            // lblopera1
            // 
            this.lblopera1.AutoSize = true;
            this.lblopera1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblopera1.Location = new System.Drawing.Point(49, 172);
            this.lblopera1.Name = "lblopera1";
            this.lblopera1.Size = new System.Drawing.Size(0, 21);
            this.lblopera1.TabIndex = 2;
            // 
            // lblsimbolo
            // 
            this.lblsimbolo.AutoSize = true;
            this.lblsimbolo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblsimbolo.Location = new System.Drawing.Point(166, 172);
            this.lblsimbolo.Name = "lblsimbolo";
            this.lblsimbolo.Size = new System.Drawing.Size(0, 21);
            this.lblsimbolo.TabIndex = 3;
            // 
            // lblopera2
            // 
            this.lblopera2.AutoSize = true;
            this.lblopera2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblopera2.Location = new System.Drawing.Point(319, 172);
            this.lblopera2.Name = "lblopera2";
            this.lblopera2.Size = new System.Drawing.Size(0, 21);
            this.lblopera2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 182);
            this.button2.TabIndex = 23;
            this.button2.Text = "and";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 412);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblopera2);
            this.Controls.Add(this.lblsimbolo);
            this.Controls.Add(this.lblopera1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnigual;
        private Button button15;
        private Button btndivi;
        private Button btnmulti;
        private Button btnresta;
        private Button btnsuma;
        private Button btn9;
        private Button btn8;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn2;
        private Button button1;
        private Button btn3;
        private Button btn4;
        private Button btn0;
        private Label label3;
        private Label lblopera1;
        private Label lblsimbolo;
        private Label lblopera2;
        private Label label2;
        private Button button2;
    }
}