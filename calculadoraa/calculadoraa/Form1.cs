using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraa
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
            double Num1, Num2, Respuesta;
            Num1 = double.Parse(textBox1.Text);
            Num2 = double.Parse(textBox2.Text);

            Respuesta = Num1 + Num2;

            lbl3Respuesta.Text = "Respuesta: " + Respuesta;
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }
    }
}
