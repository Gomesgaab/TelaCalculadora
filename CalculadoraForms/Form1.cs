using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{
    public partial class Form1 : Form
    {
        ModelCalculadora modelo;


        public Form1()
        {
            InitializeComponent();
            this.modelo = new ModelCalculadora();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.Somar(Convert.ToDouble(maskedTextBox1.Text));

        }// SOMA

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.Subtrair(Convert.ToDouble(maskedTextBox1.Text));

        }// SUBTRAÇÃO

        private void button3_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.Dividir(Convert.ToDouble(maskedTextBox1.Text));  

        }//Divisão

        private void button4_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.Multiplicar(Convert.ToDouble(maskedTextBox1.Text));

        }// Multiplicação

        private void button5_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.Potencia(Convert.ToDouble(maskedTextBox1.Text));

        }// Potenca

        private void button6_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.Raiz(Convert.ToDouble(maskedTextBox1.Text));

        }// Raiz

        private void Form1_Load(object sender, EventArgs e)
        {

        }// tela

        private void button7_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.Limpa(Convert.ToDouble(maskedTextBox1.Text));

        }// limpar
    }
}
