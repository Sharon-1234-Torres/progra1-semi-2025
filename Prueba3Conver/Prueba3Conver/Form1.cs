using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba3Conver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double Cantidad, Dolar, Euro, Quetzal, PesoMex, LibraEster, YenJap, ColonSalva,
                Cordoba, Lempira;

            Cantidad = Convert.ToDouble(txt1Cantidad.Text);

            if (cbo1Monedas.SelectedIndex == 0)
            {
                Dolar = Cantidad / 24.44;
                lbl4.Visible = true;
                lbl4.Text = " Dólares ";
                txt2Resultado.Text = Convert.ToString(Dolar);
            }
            else
                if (cbo1Monedas.SelectedIndex == 1)
            {
                Euro = Cantidad / 1.17;
                lbl4.Visible = true;
                lbl4.Text = " Euro ";
                txt2Resultado.Text = Convert.ToString(Euro);

            }
            else
            {
                if (cbo1Monedas.SelectedIndex == 2)
                {
                    Quetzal = Cantidad / 0.13;
                    lbl4.Visible = true;
                    lbl4.Text = " Quetzal ";
                    txt2Resultado.Text = Convert.ToString(Quetzal);

                }
                if (cbo1Monedas.SelectedIndex == 3)
                {
                    PesoMex = Cantidad / 0.053;
                    lbl4.Visible = true;
                    lbl4.Text = " Peso Mexicano ";
                    txt2Resultado.Text = Convert.ToString(PesoMex);

                }
            }

            if (cbo1Monedas.SelectedIndex == 4)
            {
                LibraEster = Cantidad / 1.35;
                lbl4.Visible = true;
                lbl4.Text = "Libra esterlina";
                txt2Resultado.Text = Convert.ToString(LibraEster);

                if (cbo1Monedas.SelectedIndex == 5)
                {
                    YenJap = Cantidad / 0.0068;
                    lbl4.Visible = true;
                    lbl4.Text = " Yen Japones ";
                    txt2Resultado.Text = Convert.ToString(YenJap);

                    if (cbo1Monedas.SelectedIndex == 2)
                    {
                        ColonSalva = Cantidad / 0.11;
                        lbl4.Visible = true;
                        lbl4.Text = " Colon Salvadoreño ";
                        txt2Resultado.Text = Convert.ToString(ColonSalva);

                        if (cbo1Monedas.SelectedIndex == 2)
                        {
                            Cordoba = Cantidad / 0.027;
                            lbl4.Visible = true;
                            lbl4.Text = " Cordoba ";
                            txt2Resultado.Text = Convert.ToString(Cordoba);

                            if (cbo1Monedas.SelectedIndex == 2)
                            {
                                Lempira = Cantidad / 0.038;
                                lbl4.Visible = true;
                                lbl4.Text = " Lempira ";
                                txt2Resultado.Text = Convert.ToString(Lempira);



                                private void button2_Click(object sender, EventArgs e)
                {
                    Close();
                }
            }
        }

