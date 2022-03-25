using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace Visual {
    public partial class Frm_Conductor_Registrar : Form {

        Btn_Comportamiento Btn_Comportamiento = new Btn_Comportamiento ();
        Adm_Conductor Adm_Conductor = Adm_Conductor.GetAdm ();
        Validacion Validacion = new Validacion ();

        public Frm_Conductor_Registrar () {
            InitializeComponent ();
            
        }

        private void FrmConductorReg_Load (object sender, EventArgs e) {
            this.pnl_Contenido.BackColor = Color.FromArgb (200, 255, 255, 255);
            rdb_Masculino.Checked = false;
        }

        #region Efecto boton limpiar
        private void btnlimpiar_MouseMove (object sender, MouseEventArgs e) {
            Btn_Comportamiento.activaboton (sender);
        }

        private void btnlimpiar_MouseLeave (object sender, EventArgs e) {
            Btn_Comportamiento.desactivaboton (sender);
        }
        #endregion

        #region Efecto boton cancelar
        private void btncancelar_MouseMove (object sender, MouseEventArgs e) {
            Btn_Comportamiento.activaboton (sender);
        }

        private void btncancelar_MouseLeave (object sender, EventArgs e) {
            Btn_Comportamiento.desactivaboton (sender);
        }

        #endregion

        #region Efecto boton guardar
        private void btnguardar_MouseLeave (object sender, EventArgs e) {
            Btn_Comportamiento.desactivaboton (sender);
        }

        private void btnguardar_MouseMove_1 (object sender, MouseEventArgs e) {
            Btn_Comportamiento.activaboton (sender);
        }
        #endregion

        private void txt_Cedula_KeyPress (object sender, KeyPressEventArgs e) {
            // Only allows numbers on press
            Validacion.validarSoloNumerosKeyPress (sender, e);
        }

        private void txt_Nombre1_KeyPress (object sender, KeyPressEventArgs e) {
            // Only allows alphabetic characters
            Validacion.validarSoloLettrasKeyPress (sender, e);
        }
                
        private void btn_Guardar_Click (object sender, EventArgs e) {
            err_Alerta.Clear ();
            if (Validacion.esCorrecto_GuardarDatosConductor (txt_Cedula, txt_Nombre1, txt_Apellido1, txt_Apellido2, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNacimiento, dtp_FechaContrato, err_Alerta)) {
                string
                   cedula = txt_Cedula.Text.Trim (),
                   nombre1 = txt_Nombre1.Text.Trim (),
                   nombre2 = txt_Nombre2.Text.Trim (),
                   apellido1 = txt_Apellido1.Text.Trim (),
                   apellido2 = txt_Apellido2.Text.Trim (),
                   telefono = txt_Telefono.Text.Trim (),
                   sexo = Validacion.LeerSexo (rdb_Masculino, rdb_Femenino);
                DateTime
                    fecha_nac = dtp_FechaNacimiento.Value.Date,
                    fecha_contrato = dtp_FechaContrato.Value.Date;
                string mensaje = Adm_Conductor.ConductorRegistrar (cedula, nombre1, nombre2, apellido1, apellido2, telefono, sexo, fecha_nac, fecha_contrato);
                if (mensaje[0] != '¡') {
                    limpiarCampos ();
                }
            }
        }

        private void btn_Cancelar_Click (object sender, EventArgs e) {
            this.Close ();
        }

        private void btn_Limpiar_Click (object sender, EventArgs e) {
            limpiarCampos ();
        }

        private void limpiarCampos () {
            txt_Cedula.Clear ();
            txt_Nombre1.Clear ();
            txt_Nombre2.Clear ();
            txt_Apellido1.Clear ();
            txt_Apellido2.Clear ();
            txt_Telefono.Clear ();
            rdb_Masculino.Checked = false;
            rdb_Femenino.Checked = false;
            dtp_FechaNacimiento.Value = DateTime.Today;
            dtp_FechaContrato.Value = DateTime.Today;
            err_Alerta.Clear ();
        }

    }
}
