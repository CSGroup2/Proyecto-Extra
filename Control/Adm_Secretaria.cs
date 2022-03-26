using Datos;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control {
    public class Adm_Secretaria {

        /*
           Aplicar el patron de diseño Singleton:
           1. Crear 1 atributo estático y privado de la misma clase.
           2. Cambiar el constructor de public a private.
           3.1. Crear un getter del atributo estático del tipo de la clase.
           3.2.Verificar si atributo es null, si es así, crearlo.
       */

        private static Adm_Secretaria s_admSecretaria = null;    // 1.
        Usuario usuario = null;
        Secretaria secretaria = null;
        Datos_Secretaria datosSecretaria = null;
        Validacion validacion = null;

        // Constructor: Adm_Login
        private Adm_Secretaria () {                  // 2.
            usuario = new Usuario ();
            secretaria = new Secretaria ();
            datosSecretaria = new Datos_Secretaria ();
            validacion = new Validacion ();
        }

        // Getter: GetAdm
        public static Adm_Secretaria GetAdm () {        // 3.1.
            if (s_admSecretaria == null) {               //3.2
                s_admSecretaria = new Adm_Secretaria ();
            }
            return s_admSecretaria;
        }

       



        /*------------------------------ Frm_Secretaria_Consultar ------------------------------*/

        public DataTable SecretariaListar () {
            return datosSecretaria.SecretariaListarDatos ();
        }

        public DataTable SecretariaConsultar (string cedula_nombre, string estado) {
            return datosSecretaria.SecretariaConsultarDatos (cedula_nombre, estado);
        }


        /*------------------------------ Frm_Secretaria_Editar ------------------------------*/

        public void SecretariaBuscarPorId (int idSecretaria, Label lbl_IdSecretaria, TextBox txt_Cedula, ComboBox cmb_Estado, TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNacimiento, DateTimePicker dtp_FechaContrato, TextBox txt_NombreUsuario, TextBox txt_Contrasenia) {
            secretaria = new Secretaria ();
            secretaria = datosSecretaria.SecretariaBuscarPorIdDatos (idSecretaria);
            lbl_IdSecretaria.Text = secretaria.Id_secretaria.ToString ();
            txt_Cedula.Text = secretaria.Cedula.ToString ();
            cmb_Estado.Text = secretaria.Estado.ToString ();
            txt_Nombre1.Text = secretaria.Nombre_1.ToString ();
            txt_Nombre2.Text = secretaria.Nombre_2.ToString ();
            txt_Apellido1.Text = secretaria.Apellido_1.ToString ();
            txt_Apellido2.Text = secretaria.Apellido_2.ToString ();
            txt_Correo.Text = secretaria.Usuario.Correo.ToString ();
            txt_Telefono.Text = secretaria.Telefono.ToString ();
            if (secretaria.Sexo.ToString () == "Masculino") {
                rdb_Masculino.Checked = true;
            } else {
                rdb_Femenino.Checked = true;
            }
            dtp_FechaNacimiento.Text = secretaria.Fecha_nac.ToString ();
            dtp_FechaContrato.Text = secretaria.Fecha_contrato.ToString ();
            txt_NombreUsuario.Text = secretaria.Usuario.Nombre_usuario.ToString ();
            txt_Contrasenia.Text = secretaria.Usuario.Contrasenia.ToString ();
        }

        

        public string SecretariaEditar (int id, string cedula, string estado, string nombre1, string nombre2, string apellido1, string apellido2, string correo, string telefono, string sexo, DateTime fechaNacimiento, DateTime fechaContrato, string nombreUsuario, string contrasenia) {
            string mensaje = "¡"; // '¡' in case of incorrec data on fields   
            usuario = new Usuario (0, correo, nombreUsuario, contrasenia);
            secretaria = new Secretaria (0, usuario, fechaContrato, "", 0, cedula, nombre1, nombre2, apellido1, apellido2, sexo, fechaNacimiento, telefono);
            mensaje = datosSecretaria.SecretariaEditarDatos (secretaria);
            MessageBox.Show (mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return mensaje;
        }

        /*------------------------------ Frm_Secretaria_Registrar ------------------------------*/

        #region Frm_Secretaria_Registrar

        public string Secretaria_RegistrarDatos (string cedula, string nombre1, string nombre2, string apellido1, string apellido2, string correo, string telefono, string sexo, DateTime fechaNacimiento, DateTime fechaContrato, string nombreUsuario, string contrasenia) {
            string mensaje = "¡";
            usuario = new Usuario (0, correo, nombreUsuario, contrasenia);
            secretaria = new Secretaria (0, usuario, fechaContrato, "", 0, cedula, nombre1, nombre2, apellido1, apellido2, sexo, fechaNacimiento, telefono);
            mensaje = datosSecretaria.Secretaria_RegistrarDatos (secretaria);
            MessageBox.Show (mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return mensaje;
        }

       

        #endregion

    }
}
