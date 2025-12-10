using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace AcademicaCRUDC2
{
    internal class Conexion
    {
        public SqlConnection objConexion = new SqlConnection();
        public SqlCommand objComando = new SqlCommand();
        public SqlDataAdapter objAdaptador = new SqlDataAdapter();
        DataSet objDatos = new DataSet();

        public Conexion()
        {
            String CadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = CadenaConexion;
            objConexion.Open();
        }
        public DataSet obtenerDatos()
        {
            objDatos.Clear();
            objComando.Connection = objConexion;

            objAdaptador.SelectCommand = objComando;

            objComando.CommandText = "SELECT * FROM Alumnos";
            objAdaptador.Fill(objDatos, "Alumnos");

            objComando.CommandText = "SELECT * FROM Materias";
            objAdaptador.Fill(objDatos, "Materias");

            objComando.CommandText = "SELECT * FROM Docente";
            objAdaptador.Fill(objDatos, "Docente");

            return objDatos;
        }
        public string administrarDatosAlumnos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Alumnos(Codigo,Nombre,Direccion,Telefono) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Alumnos SET codigo='" + datos[1] + "', Nombre='" + datos[2] + "', Direccion='" + datos[3] + "', Telefono='" + datos[4] + "' WHERE IdAlumno='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM Alumnos WHERE IdAlumno='" + datos[0] + "'";
            }
            return ejecutarSQL(sql);
        }
        public string administrarDatosMaterias(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO materias(codigo,nombre,uv) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE materias SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', uv='" + datos[3] + "' WHERE idMateria='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM materias WHERE idMateria='" + datos[0] + "'";
            }
            return ejecutarSQL(sql);
        }
        public string administrarDatos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "Nuevo")
            {
                sql = "INSERT INTO Docente(Nombre, Codigo, Direccion, Tel) VALUES (@Nombre, @Codigo, @Direccion, @Tel)";
            }
            else if (accion == "Modificar")
            {
                sql = "UPDATE Docente SET Nombre=@Nombre, Codigo=@Codigo, Direccion=@Direccion, Tel=@Tel WHERE IDdocente=@IDdocente";
            }
            else if (accion == "Eliminar")
            {
                sql = "DELETE FROM Docente WHERE IDdocente=@IDdocente";
            }
            return ejecutarSQL(sql);
        }
        public String ejecutarSQL(String sql)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;
                return objComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
    
}
