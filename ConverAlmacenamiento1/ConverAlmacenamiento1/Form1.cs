using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverAlmacenamiento1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1Convertir_Click(object sender, EventArgs e)
        {
            Double convertirAlma = 1, convertidoAlma = 1, cantidadAlma = 0, resultadoAlma = 0;
            Double B = 1, KB = 1000, MB = 1000000, GB = 1000000000, TB = 1000000000000, 
                PB = 1000000000000000, b = 8, kb = 125, kib = 128, Mb = 125000;

            if (!Double.TryParse(txt1CantidadAlma.Text, out cantidadAlma))
            {
                MessageBox.Show(" Ingrese solo valores de almacenamiento válido. ");
                return;
            }

            switch (cbo1ConvertirAlma.SelectedIndex)

            {
                case 0: convertirAlma = B; break;

                case 1: convertirAlma = KB; break;

                case 2: convertirAlma = MB; break;

                case 3: convertirAlma = GB; break;

                case 4: convertirAlma = TB; break;

                case 5: convertirAlma = PB; break;

                case 6: convertirAlma = b; break;

                case 7: convertirAlma = kb; break;

                case 8: convertirAlma = kib; break;

                case 9: convertirAlma = Mb; break;

                default: convertirAlma = 1; break;
            }

            switch (cbo2ConvertidoAlma.SelectedIndex)

            {
                case 0: convertidoAlma = B; break;

                case 1: convertidoAlma = KB; break;

                case 2: convertidoAlma = MB; break;

                case 3: convertidoAlma = GB; break;

                case 4: convertidoAlma = TB; break;

                case 5: convertidoAlma = PB; break;

                case 6: convertidoAlma = b; break;

                case 7: convertidoAlma = kb; break;

                case 8: convertidoAlma = kib; break;

                case 9: convertidoAlma = Mb; break;

                default: convertidoAlma = 1; break;
            }

            resultadoAlma = cantidadAlma * (convertidoAlma / convertirAlma);

            txt2ResultadoAlma.Text = resultadoAlma.ToString("F4");
        }

        private void btn2Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
