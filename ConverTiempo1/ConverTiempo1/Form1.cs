using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverTiempo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double convertirTiem = 1, convertidoTiem = 1, ResultadoTiem = 0, CantidadTiem = 0;
            Double minuto = 1, hora = 60, dia = 1440, semana = 100080, mes = 43800, 
                ao = 525600, decada = 5.256000000, siglo = 5.2560000000, segundo = 60, 
                milisegundo = 60000;

            if (!Double.TryParse(txt1CantidadTiem.Text, out CantidadTiem))
            {
                MessageBox.Show("Ingrese solo números.");
                return;
            }


            switch (cbo1ConvertirTiem.SelectedIndex)

            {
                case 0: convertirTiem = minuto; break;

                case 1: convertirTiem = hora; break;

                case 2: convertirTiem = dia; break;

                case 3: convertirTiem = semana; break;

                case 4: convertirTiem = mes; break;

                case 5: convertirTiem = ao; break;

                case 6: convertirTiem = decada; break;

                case 7: convertirTiem = siglo; break;

                case 8: convertirTiem = segundo; break;

                case 9: convertirTiem = milisegundo; break;

                default: convertirTiem = 1; break;
            }

            switch (cbo2ConvertidoTiem.SelectedIndex)

            {
                case 0: convertidoTiem = minuto; break;

                case 1: convertidoTiem = hora; break;

                case 2: convertidoTiem = dia; break;

                case 3: convertidoTiem = semana; break;

                case 4: convertidoTiem = mes; break;

                case 5: convertidoTiem = ao; break;

                case 6: convertidoTiem = decada; break;

                case 7: convertidoTiem = siglo; break;

                case 8: convertidoTiem = segundo; break;

                case 9: convertidoTiem = milisegundo; break;

                default: convertidoTiem = 1; break;
            }

            ResultadoTiem = CantidadTiem * (convertidoTiem / convertirTiem);

            txt2Resultado.Text = ResultadoTiem.ToString("F4");
        }

        private void btn2Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
