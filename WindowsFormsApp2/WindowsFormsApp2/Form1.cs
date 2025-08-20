using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double Tonelada, Kilogramo, Gramo, Miligramo, Microgramo, ToneladaLarga,
                ToneladaCorta, Stone, Libra, Onza, Resultado;

            

        }

        private void cbo1ConverDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double Tonelada, Kilogramo, Gramo, Miligramo, Microgramo, ToneladaLarga,
                ToneladaCorta, Stone, Libra, Onza, ConverDe, ConverA;

            ConverDe = Convert.ToDouble(cbo1ConverDe.Text);            
            
            if 
                (cbo1ConverDe.SelectedIndex == 0) {
                Tonelada = Convert.ToDouble(txt1Valor.Text);
                Kilogramo = Tonelada * 1000;
                lbl3Resultado.Visible = true;
                lbl3Resultado.Text = " Kilogramos ";
                cbo1ConverDe.Text = Convert.ToString(Kilogramo);
            }
        }
    }
}
