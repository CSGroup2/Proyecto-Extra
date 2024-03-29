﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos {
    public class Datos_General {

        public DataTable DisponibilidadLlenarComboDatos () {
            // Extract all "disponibilidad" data from database
            Conexion conexion = null;
            SqlConnection sql_conexion = null;
            SqlCommand sql_comando = null;
            SqlDataAdapter sql_adaptador = null;
            DataRow nuevaFila = null;
            DataTable dataTable_resultado = null;
            string query = null;
            try {
                conexion = new Conexion ();
                sql_conexion = conexion.abrir_conexion ();          // Opens conexion to sql server
                query = "SELECT * FROM DISPONIBILIDAD";             // SQL sentece
                sql_comando = new SqlCommand (query, sql_conexion); // Creatin SqlCommand object
                dataTable_resultado = new DataTable ("DISPONIBILIDAD");
                sql_adaptador = new SqlDataAdapter (sql_comando);
                sql_adaptador.Fill (dataTable_resultado);
                nuevaFila = dataTable_resultado.NewRow ();
                nuevaFila["ID_DISPONIBILIDAD"] = 0;
                nuevaFila["NOMBRE_DISPONIBILIDAD"] = "--Seleccione--";
                dataTable_resultado.Rows.InsertAt (nuevaFila, 0);
            } catch (Exception ex) {
                dataTable_resultado = null;
                Console.WriteLine ("Error al consultar en el tipo de ambulancia " + ex.Message);
            } finally {
                conexion.cerrar_conexion (sql_conexion);
            }
            return dataTable_resultado;
        }

        public DataTable EstadoLlenarComboDatos () {
            // Se definen las variables necesarias para la conexion y ejecucion de comandos. 
            Conexion conexion = null;
            SqlConnection sql_conexion = null;
            SqlCommand sql_comando = null;
            SqlDataAdapter sql_adaptador = null;
            DataRow nuevaFila = null;
            DataTable dataTable_resultado = null;
            string query = null;
            try {
                conexion = new Conexion ();
                sql_conexion = conexion.abrir_conexion ();
                query = "sp_consultar_estados";                         // Se define que procedimiento ejecutar
                sql_comando = new SqlCommand (query, sql_conexion);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure;  // Se especifico que el comando es de tipo procedimiento
                dataTable_resultado = new DataTable ("ESTADO");
                sql_adaptador = new SqlDataAdapter (sql_comando);
                sql_adaptador.Fill (dataTable_resultado);               // empiezo a recoger los datos
                nuevaFila = dataTable_resultado.NewRow ();
                nuevaFila["ID_ESTADO"] = 0;
                nuevaFila["NOMBRE_ESTADO"] = "--Seleccione--";
                dataTable_resultado.Rows.InsertAt (nuevaFila, 0);
            } catch (Exception ex) {
                dataTable_resultado = null;
                Console.WriteLine ("Error al consultar los estados " + ex.Message);
            } finally {
                conexion.cerrar_conexion (sql_conexion);
            }
            return dataTable_resultado;
        }

        // Metodo para poder cargar todos los hospitales disponibles de la base de datos

        public DataTable HospitalLlenarComboDatos () {
            // Se definen las variables necesarias para la conexion y ejecucion de comandos. 
            DataTable DtResultado = new DataTable ("HOSPITAL");
            Conexion con = new Conexion ();
            SqlConnection sqlconn = con.abrir_conexion ();
            SqlCommand sql_comando = null;
            try {
                string procedimeinto = "sp_consultar_hospitales"; //Se define que procedimiento ejecutar
                sql_comando = new SqlCommand (procedimeinto, sqlconn);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure; //Se especifico que el comando es de tipo procedimiento
                SqlDataAdapter SqlDat = new SqlDataAdapter (sql_comando);
                SqlDat.Fill (DtResultado);  //empiezo a recoger los datos
            } catch (Exception ex) {
                DtResultado = null;
                Console.WriteLine ("Error al consultar los hospitales " + ex.Message);
            } finally {
                con.cerrar_conexion (sqlconn);
            }
            return DtResultado;
        }

    }
}
