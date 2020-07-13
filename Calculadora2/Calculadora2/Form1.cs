using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraApp
{
    public partial class Form1 : Form
    {
        
        ClassCalculadora instanciaCalculadora;
        char operacion;
        double resultado;
        public Form1()
        {
            InitializeComponent();
            instanciaCalculadora = new ClassCalculadora();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt0.Text;
        }

        private void btcoma_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + btcoma.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt1.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt3.Text;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt4.Text;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt5.Text;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt6.Text;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt7.Text;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt8.Text;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + bt9.Text;
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            instanciaCalculadora.Numero1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = btSuma.Text;
            tbDisplay.Text = " ";
            operacion = '+';
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            instanciaCalculadora.Numero1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = btResta.Text;
            tbDisplay.Text = " ";
            operacion = '-';
        }

        private void btProducto_Click(object sender, EventArgs e)
        {
            instanciaCalculadora.Numero1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = btProducto.Text;
            tbDisplay.Text = " ";
            operacion = '*';
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            instanciaCalculadora.Numero1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = btDivision.Text;
            tbDisplay.Text = " ";
            operacion = '/';
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            
            instanciaCalculadora.Numero2 = Convert.ToDouble(tbDisplay.Text);
            
            switch (operacion)
            {
                case '+':
                    resultado = instanciaCalculadora.suma(instanciaCalculadora.Numero1, instanciaCalculadora.Numero2);
                    break;
                case '-':
                    resultado = instanciaCalculadora.resta(instanciaCalculadora.Numero1, instanciaCalculadora.Numero2);
                    break;
                case '*':
                    resultado = instanciaCalculadora.producto(instanciaCalculadora.Numero1, instanciaCalculadora.Numero2);
                    break;
                case '/':
                    resultado = instanciaCalculadora.division(instanciaCalculadora.Numero1, instanciaCalculadora.Numero2);
                    break;
            }
            DateTime fecha = DateTime.Now;
            string fila = Convert.ToString(fecha)+ " " + Convert.ToString(instanciaCalculadora.Numero1) + operacion + Convert.ToString(instanciaCalculadora.Numero2) + " = " + resultado; 
            lbListaCalculos.Items.Add(fila);
            fila = "";
            tbDisplay.Text = Convert.ToString(resultado);
            tbDisplay.Text = "";
        }

        private void btC_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = " ";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
