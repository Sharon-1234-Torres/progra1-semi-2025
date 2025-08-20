using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorMoneda2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn1Convertir_Click(object sender, EventArgs e)
        {
            Double ConvertirVol = 1, ConvertidoVol = 1, ResultadoVol = 0, CantidadVol = 0;
            Double L = 1.0, mL = 0.001, galImp = 4.54609, qtoImp = 1.13652,
                ptaImp = 0.568261, tzaImp = 0.284131, flozImp = 0.0284131,
                cdaImp = 0.0177582, cditaImp = 0.00591939, ftcubico = 28.3168;

            if (!Double.TryParse(txt1CantidadVol.Text, out CantidadVol))
            {
                MessageBox.Show(" Ingrese solo medidas de volumen. ");
                return;
            }

            switch (cbo1ConvertirVol.SelectedIndex)

            {
                case 0: ConvertirVol = L; break;

                case 1: ConvertirVol = mL; break;

                case 2: ConvertirVol = galImp; break;

                case 3: ConvertirVol = qtoImp; break;

                case 4: ConvertirVol = ptaImp; break;

                case 5: ConvertirVol = tzaImp; break;

                case 6: ConvertirVol = flozImp; break;

                case 7: ConvertirVol = cdaImp; break;

                case 8: ConvertirVol = cditaImp; break;

                case 9: ConvertirVol = ftcubico; break;

                default: ConvertirVol = 1; break;
            }

            switch (cbo2ConvertidoVol.SelectedIndex)

            {
                case 0: ConvertidoVol = L; break;

                case 1: ConvertidoVol = mL; break;

                case 2: ConvertidoVol = galImp; break;

                case 3: ConvertidoVol = qtoImp; break;

                case 4: ConvertidoVol = ptaImp; break;

                case 5: ConvertidoVol = tzaImp; break;

                case 6: ConvertidoVol = flozImp; break;

                case 7: ConvertidoVol = cdaImp; break;

                case 8: ConvertidoVol = cditaImp; break;

                case 9: ConvertidoVol = ftcubico; break;

                default: ConvertidoVol = 1; break;
            }

            ResultadoVol = CantidadVol * (ConvertidoVol / ConvertirVol);

            txt2ResultadoVol.Text = ResultadoVol.ToString("F4");
        }

        private void btn2Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
