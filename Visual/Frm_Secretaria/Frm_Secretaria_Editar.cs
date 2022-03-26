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
    public partial class Frm_Secretaria_Editar : Form {
        Adm_Secretaria admSecretaria = Adm_Secretaria.GetAdm ();
        Adm_General admGeneral = Adm_General.GetAdm ();
        Validacion validacion = new Validacion ();

        public Frm_Secretaria_Editar () {
            InitializeComponent ();
            listarEstados ();
            rdb_Masculino.Checked = false;

        }
        public Frm_Secretaria_Editar (int idSecretaria) {
            InitializeComponent ();
            listarEstados ();
            llenarCamposEditar (idSecretaria);

        }

        private void Frm_Secretaria_Editar_Load (object sender, EventArgs e) {

        }

        #region ------------------------------ Frm load at begining

        private void listarEstados () {
            cmb_Estado.DataSource = admGeneral.EstadoLlenarCombo ();
            cmb_Estado.ValueMember = "ID_ESTADO";
            cmb_Estado.DisplayMember = "NOMBRE_ESTADO";
        }

        private void llenarCamposEditar (int idSecretaria) {
            admSecretaria.SecretariaBuscarPorId (idSecretaria, lbl_IdSecretaria, txt_Cedula, cmb_Estado, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, txt_Correo, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNacimiento, dtp_FechaContrato, txt_NombreUsuario, txt_Contrasenia);
        }

        #endregion

        #region ------------------------------ Frm behavior

        private void txt_Cedula_KeyPress (object sender, KeyPressEventArgs e) {
            // Only allows numbers on press
            validacion.validarSoloNumerosKeyPress (sender, e);
        }

        private void txt_Nombre1_KeyPress (object sender, KeyPressEventArgs e) {
            // Only allows alphabetic characters
            validacion.validarSoloLettrasKeyPress (sender, e);
        }

        private void txt_Correo_KeyPress (object sender, KeyPressEventArgs e) {
            validacion.validarSoloCorreoKeypress (sender, e);
        }

        #endregion

        private void btn_Guardar_Click (object sender, EventArgs e) {
            err_Alerta.Clear ();
            if (validacion.esCorrecto_EditarDatosSecretaria (txt_Cedula, cmb_Estado, txt_Nombre1, txt_Apellido1, txt_Apellido2, txt_Correo, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNacimiento, dtp_FechaContrato, txt_NombreUsuario, txt_Contrasenia, err_Alerta)) {
                int id = Convert.ToInt32 (lbl_IdSecretaria.Text);
                string
                   cedula = txt_Cedula.Text.Trim (),
                   estado = cmb_Estado.Text.Trim (),
                   nombre1 = txt_Nombre1.Text.Trim (),
                   nombre2 = txt_Nombre2.Text.Trim (),
                   apellido1 = txt_Apellido1.Text.Trim (),
                   apellido2 = txt_Apellido2.Text.Trim (),
                   correo = txt_Correo.Text.Trim (),
                   telefono = txt_Telefono.Text.Trim (),
                   sexo = validacion.LeerSexo (rdb_Masculino, rdb_Femenino),
                   nombreUsuario = txt_NombreUsuario.Text.Trim (),
                   contrasenia = txt_Contrasenia.Text.Trim ();
                DateTime
                    fechaNacimiento = dtp_FechaNacimiento.Value.Date,
                    fechaContrato = dtp_FechaContrato.Value.Date;
                string mensaje = admSecretaria.SecretariaEditar (id, cedula, estado, nombre1, nombre2, apellido1, apellido2, correo, telefono, sexo, fechaNacimiento, fechaContrato, nombreUsuario, contrasenia);
                if (mensaje[0] != '¡') {
                    limpiarCampos ();
                }
            }
        }

        private void btn_Cancelar_Click (object sender, EventArgs e) {
            this.Close ();
        }

        private void limpiarCampos () {
            lbl_IdSecretaria.Text = "";
            txt_Cedula.Clear ();
            cmb_Estado.SelectedIndex = 0;
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
            txt_Contrasenia.Clear ();
            err_Alerta.Clear ();
        }

        

        
    }
}
