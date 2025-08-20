using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverLongitud1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1Convertir_Click(object sender, EventArgs e)
        {
            Double convertirLong = 1, convertidoLong = 1, resultadoLong = 0, cantidadLong = 0;
            Double km = 1000, m = 1, cm = 100, mm = 1000, micrometro = 1000000, 
                nm = 1000000000, mi = 1609, yd = 1.094, ft = 3.281, pulgada = 39.37;

            if (!Double.TryParse(txt1CantidadLong.Text, out cantidadLong))
            {
                MessageBox.Show(" Ingrese solo valores de Longitud permitidos. ");
                return;
            }

            switch (cbo1ConvertirLong.SelectedIndex)

            {
                case 0: convertirLong = km; break;

                case 1: convertirLong = m; break;

                case 2: convertirLong = cm; break;

                case 3: convertirLong = mm; break;

                case 4: convertidoLong = micrometro; break;

                case 5: convertidoLong = nm; break;

                case 6: convertidoLong = mi; break;

                case 7: convertirLong = yd; break;

                case 8: convertirLong = ft; break;

                case 9: convertidoLong = pulgada; break;

                default: convertidoLong = 1; break;
            }

            switch (cbo2ConvertidoLong.SelectedIndex)

            {
                case 0: convertidoLong = km; break;

                case 1: convertidoLong = m; break;

                case 2: convertidoLong = cm; break;

                case 3: convertidoLong = mm; break;

                case 4: convertidoLong = micrometro; break;

                case 5: convertidoLong = nm; break;

                case 6: convertidoLong = mi; break;

                case 7: convertidoLong = yd; break;

                case 8: convertidoLong = ft; break;

                case 9: convertidoLong = pulgada; break;

                default: convertidoLong = 1; break;
            }

            resultadoLong = cantidadLong * (convertidoLong / convertirLong);

            txt2Resultado.Text = resultadoLong.ToString("F3");
        }

        private void btn2Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
