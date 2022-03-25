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

        private static Adm_Secretaria AdmSecretaria = null;    // 1.
        Usuario Usuario = null;
        Secretaria Secretaria = null;
        Datos_Secretaria Datos_Secretaria = null;
        Validacion Validacion = null;

        // Constructor: Adm_Login
        private Adm_Secretaria () {                  // 2.
            Usuario = new Usuario ();
            Secretaria = new Secretaria ();
            Datos_Secretaria = new Datos_Secretaria ();
            Validacion = new Validacion ();
        }

        // Getter: GetAdm
        public static Adm_Secretaria GetAdm () {        // 3.1.
            if (AdmSecretaria == null) {               //3.2
                AdmSecretaria = new Adm_Secretaria ();
            }
            return AdmSecretaria;
        }

        /*------------------------------ Frm_Secretaria_Consultar ------------------------------*/



        /*------------------------------ Frm_Secretaria_Editar ------------------------------*/



        /*------------------------------ Frm_Secretaria_Registrar ------------------------------*/

        #region Frm_Secretaria_Registrar

        public string Secretaria_RegistrarDatos (string cedula, string nombre1, string nombre2, string apellido1, string apellido2, string correo, string telefono, string sexo, DateTime fechaNacimiento, DateTime fechaContrato, string nombreUsuario, string contrasenia1) {
            string mensaje = "¡";
            Usuario = new Usuario (0, correo, nombreUsuario, contrasenia1);
            Secretaria = new Secretaria (0, Usuario, fechaContrato, "", 0, cedula, nombre1, nombre2, apellido1, apellido2, sexo, fechaNacimiento, telefono);
            mensaje = Datos_Secretaria.Secretaria_RegistrarDatos (Secretaria);
            MessageBox.Show (mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return mensaje;
        }

        #endregion

    }
}
