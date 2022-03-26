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
        Usuario usuario = null;
        Secretaria secretaria = null;
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

        public Secretaria SecretariaBuscarPorIdDatos (int idSecretaria) {
            // Extract all "secretaria" data from database
            conexion = new Conexion ();
            query = "sp_secretaria_buscarDatosPor_Id";               // Stored Procedure name
            usuario = new Usuario ();
            secretaria = new Secretaria ();
            try {
                sqlConexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sqlComando = new SqlCommand (query, sqlConexion);     // Creatin SqlCommand object
                sqlComando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                sqlComando.Parameters.Add (new SqlParameter ("@dato_idSecretaria", idSecretaria));
                sqlDatosLector = sqlComando.ExecuteReader ();
                while (sqlDatosLector.Read ()) {
                    secretaria.Id_secretaria = Convert.ToInt32 (sqlDatosLector["ID"]);
                    secretaria.Cedula = sqlDatosLector["CEDULA"].ToString ();
                    secretaria.Estado = sqlDatosLector["ESTADO"].ToString ();
                    secretaria.Nombre_1 = sqlDatosLector["NOMBRE1"].ToString ();
                    secretaria.Nombre_2 = sqlDatosLector["NOMBRE2"].ToString ();
                    secretaria.Apellido_1 = sqlDatosLector["APELLIDO1"].ToString ();
                    secretaria.Apellido_2 = sqlDatosLector["APELLIDO2"].ToString ();
                    usuario.Correo = sqlDatosLector["CORREO"].ToString ();
                    secretaria.Telefono = sqlDatosLector["TELEFONO"].ToString ();
                    secretaria.Sexo = sqlDatosLector["SEXO"].ToString ();
                    secretaria.Fecha_nac = DateTime.Parse (sqlDatosLector["FECHA_NACIMIENTO"].ToString ());
                    secretaria.Fecha_contrato = DateTime.Parse (sqlDatosLector["FECHA_CONTRATO"].ToString ());
                    usuario.Nombre_usuario = sqlDatosLector["NOMBRE_USUARIO"].ToString ();
                    usuario.Contrasenia = sqlDatosLector["CONTRASENIA"].ToString ();
                    secretaria.Usuario = usuario;
                }
            } catch (Exception ex) {
                secretaria = new Secretaria ();
                Console.WriteLine ("¡ERROR! al buscar datos de secretaria por ID. \n" + ex.Message);
            } finally {
                conexion.cerrar_conexion (sqlConexion);
            }
            return secretaria;
        }

        public string SecretariaEditarDatos (Secretaria secretaria) {
            // insert new "secretaria" data into the database
            conexion = new Conexion ();
            query = "sp_secretaria_actualizarDatos";                        // Stored Procedure name
            try {
                sqlConexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sqlComando = new SqlCommand (query, sqlConexion);     // Creatin SqlCommand object
                sqlComando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                if (secretaria != null) {
                    // Adding values to paramerters to SqlCommand below
                    // persona
                    sqlComando.Parameters.AddWithValue ("@cedula", secretaria.Cedula);
                    sqlComando.Parameters.AddWithValue ("@nombre_1", secretaria.Nombre_1);
                    sqlComando.Parameters.AddWithValue ("@nombre_2", secretaria.Nombre_2);
                    sqlComando.Parameters.AddWithValue ("@apellido_1", secretaria.Apellido_1);
                    sqlComando.Parameters.AddWithValue ("@apellido_2", secretaria.Apellido_2);
                    sqlComando.Parameters.AddWithValue ("@sexo", secretaria.Sexo);
                    sqlComando.Parameters.AddWithValue ("@fecha_nac", secretaria.Fecha_nac);
                    sqlComando.Parameters.AddWithValue ("@telefono", secretaria.Telefono);
                    // usuario
                    sqlComando.Parameters.AddWithValue ("@nombre_usuario", secretaria.Usuario.Nombre_usuario);
                    sqlComando.Parameters.AddWithValue ("@correo", secretaria.Usuario.Correo);
                    sqlComando.Parameters.AddWithValue ("@contrasenia", secretaria.Usuario.Contrasenia);
                    // secretaria
                    sqlComando.Parameters.AddWithValue ("@fecha_contrato", secretaria.Fecha_contrato);
                    sqlComando.Parameters.AddWithValue ("@estado", secretaria.Estado);
                    mensaje = Convert.ToString (sqlComando.ExecuteNonQuery ());
                    if (mensaje == "-1") {
                        mensaje = "¡no se pudo guardar!";
                    } else {
                        mensaje = "DATOS GUARDADOS CORRECTAMENTE.";
                    }
                }
            } catch (Exception ex) {
                mensaje = "OCURRIO UN ERROR. \n" + ex.Message;
            } finally {
                conexion.cerrar_conexion (sqlConexion);
            }
            return mensaje;
        }

        /*------------------------------ Frm_Secretaria_Registrar ------------------------------*/
        public string Secretaria_RegistrarDatos (Secretaria secretaria) {
            int queryResultado = 0;
            conexion = new Conexion ();
            query = "sp_secretaria_insertarDatos";                           // Stored Procedure name
            try {
                sqlConexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sqlComando = new SqlCommand (query, sqlConexion);     // Creatin SqlCommand object
                sqlComando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                if (secretaria != null) {
                    // Adding values to paramerters to SqlCommand below
                    // Persona
                    sqlComando.Parameters.AddWithValue ("@cedula", secretaria.Cedula);
                    sqlComando.Parameters.AddWithValue ("@nombre_1", secretaria.Nombre_1);
                    sqlComando.Parameters.AddWithValue ("@nombre_2", secretaria.Nombre_2);
                    sqlComando.Parameters.AddWithValue ("@apellido_1", secretaria.Apellido_1);
                    sqlComando.Parameters.AddWithValue ("@apellido_2", secretaria.Apellido_2);
                    sqlComando.Parameters.AddWithValue ("@sexo", secretaria.Sexo);
                    sqlComando.Parameters.AddWithValue ("@fecha_nac", secretaria.Fecha_nac);
                    sqlComando.Parameters.AddWithValue ("@telefono", secretaria.Telefono);
                    // Usuario
                    sqlComando.Parameters.AddWithValue ("@nombre_usuario", secretaria.Usuario.Nombre_usuario);
                    sqlComando.Parameters.AddWithValue ("@correo", secretaria.Usuario.Correo);
                    sqlComando.Parameters.AddWithValue ("@contrasenia", secretaria.Usuario.Contrasenia);
                    // Secretaria
                    sqlComando.Parameters.AddWithValue ("@fecha_contrato", secretaria.Fecha_contrato);
                    //mensaje = Convert.ToString (sqlComando.ExecuteNonQuery ());
                    queryResultado = sqlComando.ExecuteNonQuery ();
                    if (queryResultado == 1) {
                        mensaje = "Datos guardados correctamente.";
                    } else {
                        if (queryResultado == -1) {
                            mensaje = "¡DATOS NO GUARDADOS! Ya existe nombre de usuario. " + queryResultado;
                        } else if (queryResultado == -2) {
                            mensaje = "¡DATOS NO GUARDADOS! Ya existe dirección de correo. " + queryResultado;
                        } else if (queryResultado == -3) {
                            mensaje = "¡DATOS NO GUARDADOS! Ya existe número de cédula. " + queryResultado;
                        }
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

