using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //esta es la librería que me permite usar comandos para trabajar con DB
using System.Data.SqlClient; //esta librería me permite trabajar con sqlServer

namespace CreacionDeClaseAtributoect
{
    class Conexion     
    {
        //Definir los mienbros de la clase, atributos, y métodos
        SqlConnection objConexion = new SqlConnection(); //conectrame a la BD
        SqlCommand objComando = new SqlCommand(); // ejecutar sql en la bd. lectura, actualización, eliminación, inserción.
        SqlDataAdapter objAdaptador = new SqlDataAdapter(); // un puento entre la BD y la aplicación.
        DataSet objDs = new DataSet(); // es una representación de la arquitectura de la BD en memoria.

        public Conexion() //Contructor. Inicializador de los atributos.
        {
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); //Abrir la conexión a la BD.  
            
        }

        public DataSet ObtenerDatos()
        {
            objDs.Clear(); //Limpiar el DataSet
            objComando.Connection = objConexion; // establecer la conexión para ejecutar los comandos
            objComando.Connection = objConexion; //establecer el comando de selección
            objComando.CommandText = "SELECT * FROM alumno";
            objAdaptador.Fill(objDs, "alumnos"); // toma los datos de la BD y llena el DataSet

            return objDs;
        }
    }
}
