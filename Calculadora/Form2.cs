using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form2 : Form
       
    {
        bool detectaoperacion = true;
        string operacion;
        double resultado;
        double numero1;
        double numero2;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            if (detectaoperacion)
            {
                txtpantalla.Text = "";
                txtpantalla.Text = "1";
                detectaoperacion = false;
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "1";
            }
            
           
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            if (detectaoperacion)
            {
                txtpantalla.Text = "";
                txtpantalla.Text = "2";
                detectaoperacion = false;
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "2";
            }
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            if (detectaoperacion)
            {
                txtpantalla.Text = "";
                txtpantalla.Text = "3";
                detectaoperacion = false;
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "3";
            }
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            if (detectaoperacion)
            {
                txtpantalla.Text = "";
                txtpantalla.Text = "4";
                detectaoperacion = false;
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "4";
            }
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            if (detectaoperacion)
            {
                txtpantalla.Text = "";
                txtpantalla.Text = "5";
                detectaoperacion = false;
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "5";
            }
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            if (detectaoperacion)
            {
                txtpantalla.Text = "";
                txtpantalla.Text = "6";
                detectaoperacion = false;
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "6";
            }
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            if (detectaoperacion)
            {
                txtpantalla.Text = "";
                txtpantalla.Text = "7";
                detectaoperacion = false;
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "7";
            }
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            if (detectaoperacion)
            {
                txtpantalla.Text = "";
                txtpantalla.Text = "8";
                detectaoperacion = false;
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "8";
            }
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            if (detectaoperacion)
            {
                txtpantalla.Text = "";
                txtpantalla.Text = "9";
                detectaoperacion = false;
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "9";
            }
        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "0")
            {
                return;
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "0";

            }
          
        }

        // operaciones
        private void cmdmas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            detectaoperacion = true;
            numero1 = double.Parse(txtpantalla.Text);
        }

        private void cmdresta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            detectaoperacion = true;
            numero1 = double.Parse(txtpantalla.Text);

        }

        private void cmdmulti_Click(object sender, EventArgs e)
        {
            operacion = "*";
            detectaoperacion = true;
            numero1 = double.Parse(txtpantalla.Text);

        }

        private void cmddiv_Click(object sender, EventArgs e)
        {
            operacion = "/";
            detectaoperacion = true;
            numero1 = double.Parse(txtpantalla.Text);

        }

        private void cmdigual_Click(object sender, EventArgs e)
        {

            numero2 = double.Parse(txtpantalla.Text);
            detectaoperacion = true;

            switch (operacion)
            {
                case "+":
                    resultado = numero1 + numero2 ;
                    txtpantalla .Text = resultado .ToString();
                    break ;
                case "-":
                    resultado = numero1 - numero2;
                    txtpantalla .Text = resultado.ToString() ;
                    break ;
                case "*":
                    resultado = numero1 * numero2 ;
                    txtpantalla .Text = resultado .ToString();
                    break ;
                case "/":
                    resultado = numero1 / numero2;
                    txtpantalla .Text = resultado.ToString() ;
                    break ;

            }

        }





    }
}
