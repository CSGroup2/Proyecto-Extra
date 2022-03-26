using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos {
    public class Datos_Conductor {

        // Variables
        Conexion conexion = null;
        SqlConnection sqlConexion = null;
        SqlCommand sqlComando = null;
        SqlDataReader sqlDatosLector = null;
        SqlDataAdapter sqlDatosAdaptador = null;
        Conductor conductor = null;
        DataTable dataTable = null;

        string query = null;
        string mensaje = null;
        
        /*------------------------------ Frm_Conductor_Consultar ------------------------------*/

        public DataTable ConductorListarDatos () {
            // Extract all "conductor" data from database
            conexion = new Conexion ();
            query = "sp_conductor_listarDatos";                        // Stored Procedure name
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

        public DataTable ConductorConsultarDatos (string cedula_nombre, string disponibilidad) {
            // Extract all "conductor" data from database
            conexion = new Conexion ();
            query = "sp_conductor_listarDatosPor_Cedula_Nombre_Disponibilidad";                        // Stored Procedure name
            dataTable = new DataTable ();
            try {
                sqlConexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sqlComando = new SqlCommand (query, sqlConexion);     // Creatin SqlCommand object
                sqlComando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                sqlDatosAdaptador = new SqlDataAdapter (sqlComando);
                using (sqlComando) {
                    // Adding values to paramerters for SqlCommand below
                    // Use DBNull.Value make stored procedure parameters have defaults of NULL
                    if (cedula_nombre != null) {
                        sqlComando.Parameters.Add (new SqlParameter ("@cedula_nombre", cedula_nombre));
                    } else {
                        sqlComando.Parameters.Add (new SqlParameter ("@cedula_nombre", DBNull.Value));
                    }
                    if (disponibilidad != null) {
                        sqlComando.Parameters.Add (new SqlParameter ("@disponibilidad", disponibilidad));
                    } else {
                        sqlComando.Parameters.Add (new SqlParameter ("@disponibilidad", DBNull.Value));
                    }
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

        public string ConductorEliminarDatos (int idConductor) {
            // Extract all "conductor" data from database
            conexion = new Conexion ();
            query = "sp_conductor_eliminarDatos";                   // Stored Procedure name
            try {
                sqlConexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sqlComando = new SqlCommand (query, sqlConexion);     // Creatin SqlCommand object
                sqlComando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                using (sqlComando) {
                    // Adding values to paramerters for SqlCommand below
                    sqlComando.Parameters.Add (new SqlParameter ("@id_conductor", idConductor));
                    mensaje = Convert.ToString (sqlComando.ExecuteNonQuery ());
                    if (mensaje == "-1") {
                        mensaje = "¡DATOS ELIMINADOS CORRECTAMENTE.!";
                    } else {
                        mensaje = "DATOS ELIMINADOS CORRECTAMENTE.";
                    }
                }
            } catch (Exception ex) {
                dataTable = null;
                Console.WriteLine ("¡ERROR! al eliminar el conductor. \n" + ex.Message);
            } finally {
                conexion.cerrar_conexion (sqlConexion);
            }
            return mensaje;
        }

        /*------------------------------ Frm_Conductor_Editar ------------------------------*/

        public Conductor ConductorBuscarPorIdDatos (int idConductor) {
            // Extract all "conductor" data from database
            conexion = new Conexion ();
            query = "sp_conductor_buscarDatosPor_Id";               // Stored Procedure name
            conductor = new Conductor ();
            try {
                sqlConexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sqlComando = new SqlCommand (query, sqlConexion);     // Creatin SqlCommand object
                sqlComando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                sqlComando.Parameters.Add (new SqlParameter ("@dato_idConductor", idConductor));
                sqlDatosLector = sqlComando.ExecuteReader ();
                while (sqlDatosLector.Read ()) {
                    conductor.Id_conductor = Convert.ToInt32 (sqlDatosLector["ID"]);
                    conductor.Cedula = sqlDatosLector["CEDULA"].ToString ();
                    conductor.Estado = sqlDatosLector["ESTADO"].ToString ();
                    conductor.Nombre_1 = sqlDatosLector["NOMBRE1"].ToString ();
                    conductor.Nombre_2 = sqlDatosLector["NOMBRE2"].ToString ();
                    conductor.Apellido_1 = sqlDatosLector["APELLIDO1"].ToString ();
                    conductor.Apellido_2 = sqlDatosLector["APELLIDO2"].ToString ();
                    conductor.Diponibilidad = sqlDatosLector["DISPONIBILIDAD"].ToString ();
                    conductor.Telefono = sqlDatosLector["TELEFONO"].ToString ();
                    conductor.Sexo = sqlDatosLector["SEXO"].ToString ();
                    conductor.Fecha_nac = DateTime.Parse (sqlDatosLector["FECHA_NACIMIENTO"].ToString ());
                    conductor.Fecha_contrato = DateTime.Parse (sqlDatosLector["FECHA_CONTRATO"].ToString ());
                }
            } catch (Exception ex) {
                conductor = null;
                Console.WriteLine ("¡ERROR! al buscar datos de conductore por ID. \n" + ex.Message);
            } finally {
                conexion.cerrar_conexion (sqlConexion);
            }
            return conductor;
        }

        public string ConductorEditarDatos (Conductor conductor) {
            // insert new "condutor" data into the database
            conexion = new Conexion ();
            query = "sp_conductor_actualizarDatos";                        // Stored Procedure name
            try {
                sqlConexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sqlComando = new SqlCommand (query, sqlConexion);     // Creatin SqlCommand object
                sqlComando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                if (conductor != null) {
                    // Adding values to paramerters to SqlCommand below
                    sqlComando.Parameters.AddWithValue ("@cedula", conductor.Cedula);
                    sqlComando.Parameters.AddWithValue ("@nombre_1", conductor.Nombre_1);
                    sqlComando.Parameters.AddWithValue ("@nombre_2", conductor.Nombre_2);
                    sqlComando.Parameters.AddWithValue ("@apellido_1", conductor.Apellido_1);
                    sqlComando.Parameters.AddWithValue ("@apellido_2", conductor.Apellido_2);
                    sqlComando.Parameters.AddWithValue ("@sexo", conductor.Sexo);
                    sqlComando.Parameters.AddWithValue ("@fecha_nac", conductor.Fecha_nac);
                    sqlComando.Parameters.AddWithValue ("@telefono", conductor.Telefono);
                    sqlComando.Parameters.AddWithValue ("@fecha_contrato", conductor.Fecha_contrato);
                    sqlComando.Parameters.AddWithValue ("@disponibilidad", conductor.Diponibilidad);
                    sqlComando.Parameters.AddWithValue ("@estado", conductor.Estado);
                    mensaje = Convert.ToString (sqlComando.ExecuteNonQuery ());
                    if (mensaje == "-1") {
                        mensaje = "¡CÉDULA YA EXISTE!";
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

        /*------------------------------ Frm_Conductor_Registrar ------------------------------*/

        public string ConductorRegistrarDatos (Conductor conductor) {
            // insert new "condutor" data into the database
            conexion = new Conexion ();
            query = "sp_conductor_insertarDatos";                       // Stored Procedure name
            try {
                sqlConexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sqlComando = new SqlCommand (query, sqlConexion);     // Creatin SqlCommand object
                sqlComando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                if (conductor != null) {
                    // Adding values to paramerters to SqlCommand below
                    sqlComando.Parameters.AddWithValue ("@cedula", conductor.Cedula);
                    sqlComando.Parameters.AddWithValue ("@nombre_1", conductor.Nombre_1);
                    sqlComando.Parameters.AddWithValue ("@nombre_2", conductor.Nombre_2);
                    sqlComando.Parameters.AddWithValue ("@apellido_1", conductor.Apellido_1);
                    sqlComando.Parameters.AddWithValue ("@apellido_2", conductor.Apellido_2);
                    sqlComando.Parameters.AddWithValue ("@sexo", conductor.Sexo);
                    sqlComando.Parameters.AddWithValue ("@fecha_nac", conductor.Fecha_nac);
                    sqlComando.Parameters.AddWithValue ("@telefono", conductor.Telefono);
                    sqlComando.Parameters.AddWithValue ("@fecha_contrato", conductor.Fecha_contrato);
                    mensaje = Convert.ToString (sqlComando.ExecuteNonQuery ());
                    if (mensaje == "-1") {
                        mensaje = "¡CÉDULA YA EXISTE!";
                    } else {
                        mensaje = "DATOS GUARDADOS CORRECTAMENTE.";
                    }
                }
            } catch (Exception ex) {
                mensaje = "¡ERROR! al guardar datos de conductor. \n" + ex.Message;
            } finally {
                conexion.cerrar_conexion (sqlConexion);
            }
            return mensaje;
        }


        /*------------------------------ Frm_Asignacion ------------------------------*/

        public DataTable ConductorListarDisponiblesDatos () {
            conexion = new Conexion ();
            query = "sp_listar_conductores_disponibles";                // Stored Procedure name
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
                Console.WriteLine ("¡ERROR! al listar los conductores \n" + ex.Message);
            } finally {
                conexion.cerrar_conexion (sqlConexion);
            }
            return dataTable;
        }

    }
}
