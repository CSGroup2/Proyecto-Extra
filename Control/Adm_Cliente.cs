﻿using Datos;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control
{
    public class Adm_Cliente
    {
        /* conprobar nombre alexander castro mora 
            Aplicar el patron de diseño Singleton:
            1. Crear 1 atributo estático y privado de la misma clase.
            2. Cambiar el constructor de public a private.
            3.1. Crear un getter del atributo estático del tipo de la clase.
            3.2.Verificar si atributo es null, si es así, crearlo.
        */

        private static Adm_Cliente adm_client = null;    // 1.
        Cliente client = null;
        Usuario usuario = null;
        Datos_Cliente Datos_client = null;
        Validacion validacion = null;


        // Constructor: Adm_Cliente
        private Adm_Cliente()  // 2.
        {                 
            client = new Cliente();
            usuario = new Usuario();
            Datos_client = new Datos_Cliente();
            validacion = new Validacion();
        }

        // Getter: GetAdm
        public static Adm_Cliente GetAdm()
        {     // 3.1.
            if (adm_client == null)
            {                  //3.2
                adm_client = new Adm_Cliente();
            }
            return adm_client;
        }

        #region Validaciones
        // Methods for KeyPress
        public void validarSoloNumerosKeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allows numbers on press
            validacion.validarSoloNumerosKeyPress(sender, e);
        }

        public void validarSoloLettrasKeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allows alphabetic characters
            validacion.validarSoloLettrasKeyPress(sender, e);
        }

        public void validarSoloCorreoKeypress(object sender, KeyPressEventArgs e)
        {
            // Only allows eamil characters
            validacion.validarSoloCorreoKeypress(sender, e);
        }
        
        //Valida si realmente un sexo se ha escogido
        public string esSexo(RadioButton rdb_Masculino, RadioButton rdb_Femenino)
        {
            return validacion.LeerSexo(rdb_Masculino, rdb_Femenino);
        }
        //verifica que todos los datos sean correctos, o que se envien datos incompletos
        public  bool validarDatosCliente(TextBox txt_Cedula, ComboBox cmbhospital, TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNac, TextBox txt_NombreUsuario, TextBox txt_Contrasenia1, TextBox txt_Contrasenia2, ErrorProvider errorProvider1)
        {
            bool validaciondatos = validacion.esCorrectoDatosCliente(txt_Cedula, cmbhospital, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, txt_Correo, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNac, txt_NombreUsuario, txt_Contrasenia1, txt_Contrasenia2, errorProvider1);
            if (!validaciondatos)
            {
                MessageBox.Show("¡Error al llenar los campos!", "SGAR LOS RAPIDOS S.A", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return validaciondatos;
        }
        #endregion


        #region Metodos que se comunicaran con la capa datos para la BD

        //Metodo "GuardarDatosCliente" inserta un cliente con sus respectivos datos y su nueva cuenta de usuario.
        public string guardarDatosCliente(string Cedula, int id_hospital , string Nombre1, string Nombre2, string Apellido1, string Apellido2, string Correo, string Telefono, string sexo, DateTime dtp_FechaNac, string NombreUsuario, string Contrasenia1)
        {
            string mensaje = "";
            usuario = new Usuario(0, Correo, NombreUsuario, Contrasenia1);
            client = new Cliente(id_hospital, usuario, 1 , 0, Cedula, Nombre1, Nombre2, Apellido1, Apellido2, sexo, dtp_FechaNac, Telefono, "");
            mensaje = Datos_client.insertarDatosCliente(client);

            return mensaje;
        }

        public DataTable ListarClientes()
        {
            DataTable dtresult = new DataTable();
            dtresult = Datos_client.ListarClientes();
            return dtresult;
        }

        public DataTable ConsultarClientes(string dato, int estado, int hospital, int buscarOb, int buscarOp)
        {
            DataTable dtresult = new DataTable();
            dtresult = Datos_client.ConsultarClientes(dato, estado, hospital, buscarOb, buscarOp);
            return dtresult;
        }

        public string eliminarcliente(int idcliente)
        {
            return Datos_client.eliminarcliente(idcliente); 
        }

        public String BuscarClienteID(string dato, int tipo, Label lblidcliente, TextBox txtcedula, TextBox txtnombre1, TextBox txtnombre2, TextBox txtapellido1, TextBox txtapellido2, TextBox txtcorreo, TextBox txttelefono, TextBox txtusuario, ComboBox cbxestado, ComboBox cbxhospital, RadioButton masculino, RadioButton femenino, DateTimePicker fechanacimiento, ref string contrasenia)
        {
            client = Datos_client.buscarClienteID(dato, tipo);
            string mensaje = "Datos no ecnontrados"; 
            if(client != null) { 
            lblidcliente.Text = client.Id_cliente.ToString();
            txtcedula.Text = client.Cedula.ToString();
            txtnombre1.Text = client.Nombre_1.ToString();
            txtnombre2.Text = client.Nombre_2.ToString();
            txtapellido1.Text = client.Apellido_1.ToString();
            txtapellido2.Text = client.Apellido_2.ToString();
            txtcorreo.Text = client.Usuario.Correo.ToString();
            txttelefono.Text = client.Telefono.ToString();
            txtusuario.Text = client.Usuario.Nombre_usuario.ToString();
            cbxestado.SelectedValue = client.Id_estado;
            cbxhospital.SelectedValue = client.Id_hospital;
            fechanacimiento.Value = DateTime.Parse(client.Fecha_nac.ToString());
            _ = client.Sexo.Equals("Femenino") ? femenino.Checked = true : masculino.Checked = true;
            contrasenia = client.Usuario.Contrasenia; 
            mensaje = "Encontrado";
            }
            return mensaje; 
        }


        public string actualizarDatosCliente(int idcliente, string Cedula, int id_hospital, int id_estado ,string Nombre1, string Nombre2, string Apellido1, string Apellido2, string Correo, string Telefono, string sexo, DateTime dtp_FechaNac, string NombreUsuario, string Contrasenia1)
        {
            string mensaje = "";
            usuario = new Usuario(0, Correo, NombreUsuario, Contrasenia1);
            client = new Cliente(idcliente, id_hospital, usuario, id_estado, 0, Cedula, Nombre1, Nombre2, Apellido1, Apellido2, sexo, dtp_FechaNac, Telefono, "");
            mensaje = Datos_client.actualizarcliente(client);
            return mensaje;
        }


        #endregion


        //Metodo para limpiar los componentes posterior a una insersion.
        public void limpiarCamposGuardarCliente(TextBox txt_Cedula, ComboBox cbxhospital ,TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNac, TextBox txt_NombreUsuario, TextBox txt_Contrasenia1, TextBox txt_Contrasenia2, ErrorProvider errorProvider1)
        {
            errorProvider1.Clear();
            txt_Cedula.Clear();
            cbxhospital.SelectedIndex = 0;
            txt_Nombre1.Clear();
            txt_Nombre2.Clear();
            txt_Apellido1.Clear();
            txt_Apellido2.Clear();
            txt_Correo.Clear();
            txt_Telefono.Clear();
            rdb_Masculino.Checked = false;
            rdb_Femenino.Checked = false;
            dtp_FechaNac.Value = DateTime.Today;
            txt_NombreUsuario.Clear();
            txt_Contrasenia1.Clear();
            txt_Contrasenia2.Clear();
        }

    }
}
