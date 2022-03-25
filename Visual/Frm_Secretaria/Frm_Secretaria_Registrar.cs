using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Visual {
    public partial class Frm_Secretaria_Registrar : Form {
        Adm_Secretaria Adm_Secretaria = Adm_Secretaria.GetAdm ();
        Validacion Validacion = new Validacion ();

        public Frm_Secretaria_Registrar () {
            InitializeComponent ();
        }

        private void txt_Cedula_KeyPress (object sender, KeyPressEventArgs e) {
            Validacion.validarSoloNumerosKeyPress (sender, e);
        }

        private void txt_Nombre1_KeyPress (object sender, KeyPressEventArgs e) {
            Validacion.validarSoloLettrasKeyPress (sender, e);
        }

        private void txt_Correo_KeyPress (object sender, KeyPressEventArgs e) {
            Validacion.validarSoloCorreoKeypress (sender, e);
        }

        private void btn_Guardar_Click (object sender, EventArgs e) {
            err_Alerta.Clear ();
            if (Validacion.esCorrecto_DatosSecretaria (txt_Cedula, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, txt_Correo, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNacimiento, dtp_FechaContrato, txt_NombreUsuario, txt_Contrasenia1, txt_Contrasenia2, err_Alerta)) {
                string
                   cedula = txt_Cedula.Text.Trim (),
                   nombre1 = txt_Nombre1.Text.Trim (),
                   nombre2 = txt_Nombre2.Text.Trim (),
                   apellido1 = txt_Apellido1.Text.Trim (),
                   apellido2 = txt_Apellido2.Text.Trim (),
                   correo = txt_Correo.Text.Trim (),
                   telefono = txt_Telefono.Text.Trim (),
                   sexo = Validacion.LeerSexo (rdb_Masculino, rdb_Femenino),
                   nombreUsuario = txt_NombreUsuario.Text.Trim (),
                   contrasenia1 = txt_Contrasenia1.Text.Trim ();
                DateTime
                    fechaNacimiento = dtp_FechaNacimiento.Value.Date,
                    fechaContrato = dtp_FechaContrato.Value.Date;
                string mensaje = Adm_Secretaria.Secretaria_RegistrarDatos (cedula, nombre1, nombre2, apellido1, apellido2, correo, telefono, sexo, fechaNacimiento, fechaContrato, nombreUsuario, contrasenia1);
                if (mensaje[0] != '¡') {
                    limpiarCampo ();
                }
            }
        }

        private void btn_Cancelar_Click (object sender, EventArgs e) {
            this.Close ();
        }

        private void btn_Limpiar_Click (object sender, EventArgs e) {
            limpiarCampo ();
        }

        private void limpiarCampo () {
            txt_Cedula.Clear ();
            txt_Nombre1.Clear ();
            txt_Nombre2.Clear ();
            txt_Apellido1.Clear ();
            txt_Apellido2.Clear ();
            txt_Correo.Clear ();
            txt_Telefono.Clear ();
            rdb_Masculino.Checked = false;
            rdb_Femenino.Checked = false;
            dtp_FechaNacimiento.Value = DateTime.Today;
            dtp_FechaContrato.Value = DateTime.Today;
            txt_NombreUsuario.Clear ();
            txt_Contrasenia1.Clear ();
            txt_Contrasenia2.Clear ();
            err_Alerta.Clear ();
        }
    }
}
