using Datos;
using Model;
using System;
using System.Collections.Generic;
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

        public object SecretariaListar () {
            return datosSecretaria.SecretariaListarDatos ();
        }

        /*------------------------------ Frm_Secretaria_Editar ------------------------------*/



        /*------------------------------ Frm_Secretaria_Registrar ------------------------------*/

        #region Frm_Secretaria_Registrar

        public string Secretaria_RegistrarDatos (string cedula, string nombre1, string nombre2, string apellido1, string apellido2, string correo, string telefono, string sexo, DateTime fechaNacimiento, DateTime fechaContrato, string nombreUsuario, string contrasenia1) {
            string mensaje = "¡";
            usuario = new Usuario (0, correo, nombreUsuario, contrasenia1);
            secretaria = new Secretaria (0, usuario, fechaContrato, "", 0, cedula, nombre1, nombre2, apellido1, apellido2, sexo, fechaNacimiento, telefono);
            mensaje = datosSecretaria.Secretaria_RegistrarDatos (secretaria);
            MessageBox.Show (mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return mensaje;
        }

        #endregion

    }
}
