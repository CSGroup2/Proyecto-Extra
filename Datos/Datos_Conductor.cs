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
        SqlConnection sql_conexion = null;
        SqlCommand sql_comando = null;
        SqlDataReader sql_lector = null;
        SqlDataAdapter sql_adaptador = null;
        Conductor resultado_Conductor = null;
        DataTable resultado_DataTable = null;

        string query = null;
        string mensaje = null;

        /*------------------------------ Frm_Conductor_Registrar ------------------------------*/

        public string ConductorRegistrarDatos (Conductor conductor) {
            // insert new "condutor" data into the database
            conexion = new Conexion ();
            query = "sp_conductor_insertarDatos";                       // Stored Procedure name
            try {
                sql_conexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sql_comando = new SqlCommand (query, sql_conexion);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                if (conductor != null) {
                    // Adding values to paramerters to SqlCommand below
                    sql_comando.Parameters.AddWithValue ("@cedula", conductor.Cedula);
                    sql_comando.Parameters.AddWithValue ("@nombre_1", conductor.Nombre_1);
                    sql_comando.Parameters.AddWithValue ("@nombre_2", conductor.Nombre_2);
                    sql_comando.Parameters.AddWithValue ("@apellido_1", conductor.Apellido_1);
                    sql_comando.Parameters.AddWithValue ("@apellido_2", conductor.Apellido_2);
                    sql_comando.Parameters.AddWithValue ("@sexo", conductor.Sexo);
                    sql_comando.Parameters.AddWithValue ("@fecha_nac", conductor.Fecha_nac);
                    sql_comando.Parameters.AddWithValue ("@telefono", conductor.Telefono);
                    sql_comando.Parameters.AddWithValue ("@fecha_contrato", conductor.Fecha_contrato);
                    mensaje = Convert.ToString (sql_comando.ExecuteNonQuery ());
                    if (mensaje == "-1") {
                        mensaje = "¡CÉDULA YA EXISTE!";
                    } else {
                        mensaje = "DATOS GUARDADOS CORRECTAMENTE.";
                    }
                }
            } catch (Exception ex) {
                mensaje = "¡ERROR! al guardar datos de conductor. \n" + ex.Message;
            } finally {
                conexion.cerrar_conexion (sql_conexion);
            }
            return mensaje;
        }

        /*------------------------------ Frm_Conductor_Consultar ------------------------------*/

        public DataTable ConductorListarDatos () {
            // Extract all "conductor" data from database
            conexion = new Conexion ();
            query = "sp_conductor_listarDatos";                        // Stored Procedure name
            resultado_DataTable = new DataTable ();
            try {
                sql_conexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sql_comando = new SqlCommand (query, sql_conexion);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                sql_adaptador = new SqlDataAdapter (sql_comando);
                using (sql_comando) {
                    sql_adaptador.Fill (resultado_DataTable);
                }
            } catch (Exception ex) {
                resultado_DataTable = null;
                Console.WriteLine ("¡ERROR! al listar los datos de los conductores. \n" + ex.Message);
            } finally {
                conexion.cerrar_conexion (sql_conexion);
            }
            return resultado_DataTable;
        }

        public DataTable ConductorConsultarDatos (string cedula_nombre, string disponibilidad) {
            // Extract all "conductor" data from database
            conexion = new Conexion ();
            query = "sp_buscar_conductores";                        // Stored Procedure name
            resultado_DataTable = new DataTable ();
            try {
                sql_conexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sql_comando = new SqlCommand (query, sql_conexion);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                sql_adaptador = new SqlDataAdapter (sql_comando);
                using (sql_comando) {
                    // Adding values to paramerters for SqlCommand below
                    // Use DBNull.Value make stored procedure parameters have defaults of NULL
                    if (cedula_nombre != null) {
                        sql_comando.Parameters.Add (new SqlParameter ("@cedula_nombre", cedula_nombre));
                    } else {
                        sql_comando.Parameters.Add (new SqlParameter ("@cedula_nombre", DBNull.Value));
                    }
                    if (disponibilidad != null) {
                        sql_comando.Parameters.Add (new SqlParameter ("@disponibilidad", disponibilidad));
                    } else {
                        sql_comando.Parameters.Add (new SqlParameter ("@disponibilidad", DBNull.Value));
                    }
                    sql_adaptador.Fill (resultado_DataTable);
                }
            } catch (Exception ex) {
                resultado_DataTable = null;
                Console.WriteLine ("¡ERROR! al listar los datos de los conductores. \n" + ex.Message);
            } finally {
                conexion.cerrar_conexion (sql_conexion);
            }
            return resultado_DataTable;
        }

        public string ConductorEliminarDatos (int idConductor) {
            // Extract all "conductor" data from database
            conexion = new Conexion ();
            query = "sp_conductor_eliminarDatos";                   // Stored Procedure name
            try {
                sql_conexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sql_comando = new SqlCommand (query, sql_conexion);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                using (sql_comando) {
                    // Adding values to paramerters for SqlCommand below
                    sql_comando.Parameters.Add (new SqlParameter ("@id_conductor", idConductor));
                    mensaje = Convert.ToString (sql_comando.ExecuteNonQuery ());
                    if (mensaje == "-1") {
                        mensaje = "¡DATOS ELIMINADOS CORRECTAMENTE.!";
                    } else {
                        mensaje = "DATOS ELIMINADOS CORRECTAMENTE.";
                    }
                }
            } catch (Exception ex) {
                resultado_DataTable = null;
                Console.WriteLine ("¡ERROR! al eliminar el conductor. \n" + ex.Message);
            } finally {
                conexion.cerrar_conexion (sql_conexion);
            }
            return mensaje;
        }

        /*------------------------------ Frm_Conductor_Editar ------------------------------*/

        public Conductor ConductorBuscarPorIdDatos (int idConductor) {
            // Extract all "conductor" data from database
            conexion = new Conexion ();
            query = "sp_conductor_buscarDatosPor_Id";               // Stored Procedure name
            resultado_Conductor = new Conductor ();
            try {
                sql_conexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sql_comando = new SqlCommand (query, sql_conexion);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                sql_comando.Parameters.Add (new SqlParameter ("@dato_idConductor", idConductor));
                sql_lector = sql_comando.ExecuteReader ();
                while (sql_lector.Read ()) {
                    resultado_Conductor.Id_conductor = Convert.ToInt32 (sql_lector["ID"]);
                    resultado_Conductor.Cedula = sql_lector["CEDULA"].ToString ();
                    resultado_Conductor.Estado = sql_lector["ESTADO"].ToString ();
                    resultado_Conductor.Nombre_1 = sql_lector["NOMBRE1"].ToString ();
                    resultado_Conductor.Nombre_2 = sql_lector["NOMBRE2"].ToString ();
                    resultado_Conductor.Apellido_1 = sql_lector["APELLIDO1"].ToString ();
                    resultado_Conductor.Apellido_2 = sql_lector["APELLIDO2"].ToString ();
                    resultado_Conductor.Diponibilidad = sql_lector["DISPONIBILIDAD"].ToString ();
                    resultado_Conductor.Telefono = sql_lector["TELEFONO"].ToString ();
                    resultado_Conductor.Sexo = sql_lector["SEXO"].ToString ();
                    resultado_Conductor.Fecha_nac = DateTime.Parse (sql_lector["FECHA_NACIMIENTO"].ToString ());
                    resultado_Conductor.Fecha_contrato = DateTime.Parse (sql_lector["FECHA_CONTRATO"].ToString ());
                }
            } catch (Exception ex) {
                resultado_Conductor = null;
                Console.WriteLine ("¡ERROR! al buscar datos de conductore por ID. \n" + ex.Message);
            } finally {
                conexion.cerrar_conexion (sql_conexion);
            }
            return resultado_Conductor;
        }

        public string ConductorEditarDatos (Conductor conductor) {
            // insert new "condutor" data into the database
            conexion = new Conexion ();
            query = "sp_conductor_actualizarDatos";                        // Stored Procedure name
            try {
                sql_conexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sql_comando = new SqlCommand (query, sql_conexion);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                if (conductor != null) {
                    // Adding values to paramerters to SqlCommand below
                    sql_comando.Parameters.AddWithValue ("@cedula", conductor.Cedula);
                    sql_comando.Parameters.AddWithValue ("@nombre_1", conductor.Nombre_1);
                    sql_comando.Parameters.AddWithValue ("@nombre_2", conductor.Nombre_2);
                    sql_comando.Parameters.AddWithValue ("@apellido_1", conductor.Apellido_1);
                    sql_comando.Parameters.AddWithValue ("@apellido_2", conductor.Apellido_2);
                    sql_comando.Parameters.AddWithValue ("@sexo", conductor.Sexo);
                    sql_comando.Parameters.AddWithValue ("@fecha_nac", conductor.Fecha_nac);
                    sql_comando.Parameters.AddWithValue ("@telefono", conductor.Telefono);
                    sql_comando.Parameters.AddWithValue ("@fecha_contrato", conductor.Fecha_contrato);
                    sql_comando.Parameters.AddWithValue ("@disponibilidad", conductor.Diponibilidad);
                    sql_comando.Parameters.AddWithValue ("@estado", conductor.Estado);
                    mensaje = Convert.ToString (sql_comando.ExecuteNonQuery ());
                    if (mensaje == "-1") {
                        mensaje = "¡CÉDULA YA EXISTE!";
                    } else {
                        mensaje = "DATOS GUARDADOS CORRECTAMENTE.";
                    }
                }
            } catch (Exception ex) {
                mensaje = "OCURRIO UN ERROR. \n" + ex.Message;
            } finally {
                conexion.cerrar_conexion (sql_conexion);
            }
            return mensaje;
        }

        /*------------------------------ Frm_Asignacion ------------------------------*/

        public DataTable ConductorListarDisponiblesDatos () {
            conexion = new Conexion ();
            query = "sp_listar_conductores_disponibles";                // Stored Procedure name
            resultado_DataTable = new DataTable ();
            try {
                sql_conexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sql_comando = new SqlCommand (query, sql_conexion);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                sql_adaptador = new SqlDataAdapter (sql_comando);
                using (sql_comando) {
                    sql_adaptador.Fill (resultado_DataTable);
                }
            } catch (Exception ex) {
                resultado_DataTable = null;
                Console.WriteLine ("¡ERROR! al listar los conductores \n" + ex.Message);
            } finally {
                conexion.cerrar_conexion (sql_conexion);
            }
            return resultado_DataTable;
        }

    }
}
