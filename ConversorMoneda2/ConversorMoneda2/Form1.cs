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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1Convertir_Click(object sender, EventArgs e)
        {
            Double convertir = 1, convertido = 1, Resultado = 0, Cantidad = 0;
            Double Dolar = 1.00, Euro = 0.92, Quetzal = 7.87, LbrEster = 0.78,
            YenJapon = 156.25, ColonSalva = 8.75, Lempira = 24.60,
            PesoMex = 19.20, Cordoba = 36.50, Soles = 3.70;

            if (!Double.TryParse(txt1Cantidad.Text, out Cantidad))
            {
                MessageBox.Show("Ingrese solo números.");
                return;
            }
            
                
              switch (cbo1Convertir.SelectedIndex)

              {
                case 0: convertir = Dolar; break;

                case 1: convertir = Euro; break;

                case 2: convertir = Quetzal; break;

                case 3: convertir = LbrEster; break;

                case 4: convertir = YenJapon; break;

                case 5: convertir = ColonSalva; break;

                case 6: convertir = Lempira; break;

                case 7: convertir = PesoMex; break;

                case 8: convertir = Cordoba; break;

                case 9: convertir = Soles; break;

                default: convertir = 1; break;
              }

            switch (cbo2Convertido.SelectedIndex)

            {
                case 0: convertido = Dolar; break;

                case 1: convertido = Euro; break;

                case 2: convertido = Quetzal; break;

                case 3: convertido = LbrEster; break;

                case 4: convertido = YenJapon; break;

                case 5: convertido = ColonSalva; break;

                case 6: convertido = Lempira; break;

                case 7: convertido = PesoMex; break;

                case 8: convertido = Cordoba; break;

                case 9: convertido = Soles; break;

                default: convertido = 1; break;
            }

            Resultado = Cantidad * (convertido / convertir);

            txt2Resultado.Text = Resultado.ToString("F2");
            
                             

        }

        private void btn2Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
