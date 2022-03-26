using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos {
    public class Datos_Secretaria {

        // Variables
        Conexion conexion = null;
        SqlConnection sqlConexion = null;
        SqlCommand sqlComando = null;
        SqlDataReader sqlDatosLector = null;
        SqlDataAdapter sqlDatosAdaptador = null;
        Secretaria secretria = null;
        DataTable dataTable = null;
        
        string query = null;
        string mensaje = null;

        /*------------------------------ Frm_Secretaria_Consultar ------------------------------*/

        public object SecretariaListarDatos () {
            // Extract all "conductor" data from database
            conexion = new Conexion ();
            query = "sp_secretaria_listarDatos";                        // Stored Procedure name
            dataTable = new DataTable ();
            try {
                sqlConexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sqlComando = new SqlCommand (query, sqlConexion);     // Creatin SqlCommand object
                sqlComando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                sqlDatosAdaptador = new SqlDataAdapter (sqlComando);
                using (sqlComando) {
                    sqlDatosAdaptador.Fill (dataTable);
                }
            } catch (Exception ex) {
                dataTable = null;
                Console.WriteLine ("¡ERROR! al listar los datos de los conductores. \n" + ex.Message);
            } finally {
                conexion.cerrar_conexion (sqlConexion);
            }
            return dataTable;
        }

        /*------------------------------ Frm_Secretaria_Editar ------------------------------*/



        /*------------------------------ Frm_Secretaria_Registrar ------------------------------*/
        public string Secretaria_RegistrarDatos (Secretaria secretaria) {
            conexion = new Conexion ();
            query = "sp_insertar_secretaria";                           // Stored Procedure name
            try {
                sqlConexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sqlComando = new SqlCommand (query, sqlConexion);     // Creatin SqlCommand object
                sqlComando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                if (secretaria != null) {
                    // Adding values to paramerters to SqlCommand below
                    sqlComando.Parameters.AddWithValue ("@cedula", secretaria.Cedula);
                    sqlComando.Parameters.AddWithValue ("@nombre_1", secretaria.Nombre_1);
                    sqlComando.Parameters.AddWithValue ("@nombre_2", secretaria.Nombre_2);
                    sqlComando.Parameters.AddWithValue ("@apellido_1", secretaria.Apellido_1);
                    sqlComando.Parameters.AddWithValue ("@apellido_2", secretaria.Apellido_2);
                    sqlComando.Parameters.AddWithValue ("@sexo", secretaria.Sexo);
                    sqlComando.Parameters.AddWithValue ("@fecha_nac", secretaria.Fecha_nac);
                    sqlComando.Parameters.AddWithValue ("@telefono", secretaria.Telefono);
                    sqlComando.Parameters.AddWithValue ("@nombre_usuario", secretaria.Usuario.Nombre_usuario);
                    sqlComando.Parameters.AddWithValue ("@correo", secretaria.Usuario.Correo);
                    sqlComando.Parameters.AddWithValue ("@contrasenia", secretaria.Usuario.Contrasenia);
                    sqlComando.Parameters.AddWithValue ("@fecha_contrato", secretaria.Fecha_contrato);
                    mensaje = Convert.ToString (sqlComando.ExecuteNonQuery ());
                    if (mensaje == "-1") {
                        mensaje = "¡DATOS NO GUARDADOS!";
                    } else {
                        mensaje = "DATOS GUARDADOS CORRECTAMENTE.";
                    }
                }
            } catch (Exception ex) {
                mensaje = "¡ERRORO! al guardars los datos dela secretaria. \n" + ex.Message;
            } finally {
                conexion.cerrar_conexion (sqlConexion);
            }
            return mensaje;
        }

       
    }
}
