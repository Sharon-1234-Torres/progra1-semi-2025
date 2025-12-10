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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Conexion objConexion = new Conexion();
        DataSet objDatos = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void actualizarDs()
        {
            objDatos.Clear(); //Limpiar el DataSet
            objDatos = objConexion.obtenerDatos();
            objDt = objDatos.Tables["Alumnos"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["IdAlumno"] };

            grdAlumnos.DataSource = objDt.DefaultView;
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idAlumno.Text = objDt.Rows[posicion]["IdAlumno"].ToString();
                txtCodigoAlumno.Text = objDt.Rows[posicion]["Codigo"].ToString();
                txtNombreAlumno.Text = objDt.Rows[posicion]["Nombre"].ToString();
                txtDireccionAlumno.Text = objDt.Rows[posicion]["Direccion"].ToString();
                txtTelefonoAlumno.Text = objDt.Rows[posicion]["telefono"].ToString();

                lblnRegistrosAlumno.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void btnUltimoAlumno_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }
        private void estadoControles(Boolean estado)
        {
            grbDatosAlumno.Enabled = estado;
            grbNavegacionAlumno.Enabled = !estado;
            btnEliminarAlumno.Enabled = !estado;
        }
        private void limpiarControles()
        {
            idAlumno.Text = "";
            txtCodigoAlumno.Text = "";
            txtNombreAlumno.Text = "";
            txtDireccionAlumno.Text = "";
            txtTelefonoAlumno.Text = "";
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            if (btnAgregarAlumno.Text == "Nuevo")
            {
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }
            else
            {//Guardar
                String[] alumnos = {
                    idAlumno.Text, txtCodigoAlumno.Text, txtNombreAlumno.Text, txtDireccionAlumno.Text,
                    txtTelefonoAlumno.Text
                };
                String respuesta = objConexion.administrarDatosAlumnos(alumnos, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarAlumno.Text = "Nuevo";
                    btnModificarAlumno.Text = "Modificar";
                    actualizarDs();
                }
            }
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            if (btnModificarAlumno.Text == "Modificar")
            {
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";

            }
            else
            {//Cancelar
                mostrarDatos();
                estadoControles(false);
                btnAgregarAlumno.Text = "Nuevo";
                btnModificarAlumno.Text = "Modificar";
            }
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreAlumno.Text,
               "Eliminando alumnos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion.administrarDatosAlumnos(
                    new String[] { idAlumno.Text, "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void txtBuscarAlumnos_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                filtrarDatos(txtBuscarAlumnos.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void filtrarDatos(String valor)
        {
            try
            {
                DataView objDv = objDt.DefaultView;
                objDv.RowFilter = "Codigo like '%" + valor + "%' OR Nombre like '" + valor + "%'";
                grdAlumnos.DataSource = objDv;
                seleccionarAlumno();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void seleccionarAlumno()
        {
            try
            {
                if (grdAlumnos.CurrentRow == null)
                {
                    MessageBox.Show("No hay filas");
                    return;
                }
                string id = grdAlumnos.CurrentRow.Cells["id"].Value.ToString();
                posicion = objDt.Rows.IndexOf(objDt.Rows.Find(id));
                mostrarDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void grdAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarAlumno();
        }
    }
}
