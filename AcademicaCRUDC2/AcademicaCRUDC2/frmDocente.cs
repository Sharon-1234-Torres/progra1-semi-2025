using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicaCRUDC2
{
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }
        Conexion objConexiones = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int Posicion = 0;
        public string Accion = "Nuevo";
        private void actualizarDs()
        {
            objDs.Clear();
            objDs = objConexiones.obtenerDatos();
            objDt = objDs.Tables["Docente"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["IDdocente"] };

            grdDocente.DataSource = objDt.DefaultView;

            mostrarDatos();
        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                lblidDocente.Text = objDt.Rows[Posicion]["IDdocente"].ToString();
                txtcodigoDocente.Text = objDt.Rows[Posicion]["Codigo"].ToString();
                txtnombreDocente.Text = objDt.Rows[Posicion]["Nombre"].ToString();
                txtdireccionDocente.Text = objDt.Rows[Posicion]["Direccion"].ToString();
                txttelefonoDocente.Text = objDt.Rows[Posicion]["Tel"].ToString();

                lblCantReg.Text = (Posicion + 1) + " De " + objDt.Rows.Count;
            }
        }

        private void frmDocente_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void btnprimerDocente_Click(object sender, EventArgs e)
        {
            Posicion = 0;
            mostrarDatos();
        }

        private void btnanteriorDocente_Click(object sender, EventArgs e)
        {
            if (Posicion > 0)
            {
                Posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer registro", "Navegación de registro docente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnsiguienteDocente_Click(object sender, EventArgs e)
        {
            if (Posicion < objDt.Rows.Count - 1)
            {
                Posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("último registro", "Navegación de registro docente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnultimoDocente_Click(object sender, EventArgs e)
        {
            Posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }
        private void estadoControles(Boolean estado)
        {
            grbdatosDocente.Enabled = estado;
            grbnavegacionDocente.Enabled = !estado;
            btnEliminarDocente.Enabled = !estado;
        }
        private void limpiarControles()
        {
            lblidDocente.Text = "";
            txtcodigoDocente.Text = "";
            txtnombreDocente.Text = "";
            txtdireccionDocente.Text = "";
            txttelefonoDocente.Text = "";
        }

        private void btnagregarDocente_Click(object sender, EventArgs e)
        {
            if (btnagregarDocente.Text == "Agregar")
            {
                btnagregarDocente.Text = "Guardar";
                btnmodificarDocente.Text = "Cancelar";
                estadoControles(true);
                Accion = "Nuevo";
                limpiarControles();
            }
            else
            {
                String[] Docentes ={
                    lblidDocente.Text, txtcodigoDocente.Text, txtnombreDocente.Text, txtdireccionDocente.Text, txttelefonoDocente.Text
                };
                String respuesta = objConexiones.administrarDatos(Docentes, Accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar docente. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnagregarDocente.Text = "Agregar";
                    btnmodificarDocente.Text = "Modificar";
                    actualizarDs();

                }
            }
        }

        private void btnmodificarDocente_Click(object sender, EventArgs e)
        {
            if (btnmodificarDocente.Text == "Modificar")
            {
                btnagregarDocente.Text = "Guardar";
                btnmodificarDocente.Text = "Cancelar";
                estadoControles(true);
                Accion = "Modificar";
            }
            else
            {
                mostrarDatos();
                estadoControles(false);
                btnagregarDocente.Text = "Agregar";
                btnmodificarDocente.Text = "Modificar";
            }
        }

        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtnombreDocente.Text,
                    "Eliminando docente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexiones.administrarDatos(new string[] { lblidDocente.Text, "", "", "", "" }, "Eliminar");
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar docente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Posicion = 0;
                    actualizarDs();
                }

            }
        }
        private void txtbuscarDocente_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtbuscarDocente.Text);
        }
        private void filtrarDatos(String valor)
        {
            DataView objDv = objDt.DefaultView;
            objDv.RowFilter = "Codigo like '%" + valor + "%' OR Nombre like '%" + valor + "%'";
            grdDocente.DataSource = objDv;
            selecionDocente();
        }
        private void selecionDocente()
        {
            Posicion = objDt.Rows.IndexOf(objDt.Rows.Find(grdDocente.CurrentRow.Cells["ID"].Value));
            mostrarDatos();
        }
    }
}
