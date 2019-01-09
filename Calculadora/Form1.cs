using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        //Inicializaciones
        double operando1;
        double operando2;
        double resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button buton = sender as Button;
            //Si tiene el 0 inicial, lo quita o si es un símbolo especial, lo añade
            //if (!label1.Text.Contains(",") && buton.Text == ",") 
            //{
            //    Console.Write(buton.Text);
            //    label1.Text += buton.Text;
            //}


            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += buton.Text;

        }

        //Operación pulsada
        private void button3_Click(object sender, EventArgs e)
        {


        }
    }
}
