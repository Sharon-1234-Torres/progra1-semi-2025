using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcularr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, Respuesta;
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);

            Respuesta = num1 + num2;

            label3.Text = "Respuesta: " + Respuesta;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
