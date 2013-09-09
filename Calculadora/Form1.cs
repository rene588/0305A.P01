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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) 

        {
            if ( gradoscent.Text == "" || num2.Text == "" || num3.Text =="" )
            {
                MessageBox.Show("llenar los tres espacios");
            
            }
            else 
            {
                float cent = float.Parse(this.gradoscent.Text);
                float fahr = (cent * 9 / 5) + 32;
                this.resultado.Text = fahr.ToString();
                float kel = (cent + 273);
                this.resultado2.Text = kel.ToString();

                float fah = float.Parse(this.num2.Text);
                float cen = (5 * (fah - 32)) / 9;
                this.resu1.Text = cen.ToString();
                float kelv = ((5 * (fah - 32)) / 9) + 273;
                this.resu2.Text = kelv.ToString();

                float kelvi = float.Parse(this.num3.Text);
                float centi = kelvi - 273;
                this.res1.Text = centi.ToString();
                float fa = ((9 / (kelvi - 273)) / 5) + 32;
                this.res2.Text = fa.ToString();
             
            }
 
        }

        private void gradoscent_TextChanged(object sender, EventArgs e)
        {

        }
        

    }
}
