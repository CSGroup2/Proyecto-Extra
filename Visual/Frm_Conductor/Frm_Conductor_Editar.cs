using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual {
    public partial class Frm_Conductor_Editar : Form {
        Btn_Comportamiento Btn_Comportamiento = new Btn_Comportamiento ();
        Adm_Conductor admConductor = Adm_Conductor.GetAdm ();
        Adm_General admGeneral = Adm_General.GetAdm ();
        Validacion validacion = new Validacion ();

        public Frm_Conductor_Editar () {
            InitializeComponent ();
            listarEstados ();
            listarDisponibilidad ();
            rdb_Masculino.Checked = false;
        }

        public Frm_Conductor_Editar (int idConductor) {
            // Constructor overcharge
            InitializeComponent ();
            listarEstados ();
            listarDisponibilidad ();
            llenarCamposEditar (idConductor);
        }

        private void Frm_Conductor_Editar_Load (object sender, EventArgs e) {
            this.pnl_Contenido.BackColor = Color.FromArgb (200, 255, 255, 255);
            listarEstados ();
            listarDisponibilidad ();
            rdb_Masculino.Checked = false;
        }

        #region ------------------------------ Frm load at begining

        public void listarDisponibilidad () {
            cmb_Disponibilidad.DataSource = admGeneral.DisponibilidadLlenarCombo ();
            cmb_Disponibilidad.ValueMember = "ID_DISPONIBILIDAD";
            cmb_Disponibilidad.DisplayMember = "NOMBRE_DISPONIBILIDAD";
        }

        private void listarEstados () {
            cmb_Estado.Items.Clear ();
            cmb_Estado.DataSource = admGeneral.EstadoLlenarCombo ();
            cmb_Estado.ValueMember = "ID_ESTADO";
            cmb_Estado.DisplayMember = "NOMBRE_ESTADO";
        }

        private void llenarCamposEditar (int idConductor) {
            admConductor.ConductorBuscarPorId (idConductor, lbl_IdConductor, txt_Cedula, cmb_Estado, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, cmb_Disponibilidad, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNacimiento, dtp_FechaContrato);
        }

        #endregion

        #region ------------------------------ Frm behavior

        #region Efcto Botones

        #region Efecto boton Cancelar
        private void btn_Cancelar_MouseMove (object sender, MouseEventArgs e) {
            Btn_Comportamiento.activabotonPer (sender, Color.Firebrick);
        }

        private void btn_Cancelar_MouseLeave (object sender, EventArgs e) {
            Btn_Comportamiento.desactivaboton (sender);
        }
        #endregion

        #region Efecto boton guardar
        private void btn_Guardar_MouseMove (object sender, MouseEventArgs e) {
            Btn_Comportamiento.activabotonPer (sender, Color.LimeGreen);
        }

        private void btn_Guardar_MouseLeave (object sender, EventArgs e) {
            Btn_Comportamiento.desactivaboton (sender);
        }
        #endregion

        #endregion

        private void txt_Cedula_KeyPress (object sender, KeyPressEventArgs e) {
            // Only allows numbers on press
            validacion.validarSoloNumerosKeyPress (sender, e);
        }

        private void txt_Nombre1_KeyPress (object sender, KeyPressEventArgs e) {
            // Only allows alphabetic characters
            validacion.validarSoloLettrasKeyPress (sender, e);
        }

        #endregion

        private void btn_Guardar_Click (object sender, EventArgs e) {
            err_Alerta.Clear ();
            if (validacion.esCorrecto_EditarDatosConductor (txt_Cedula, cmb_Estado, txt_Nombre1, txt_Apellido1, txt_Apellido2, cmb_Disponibilidad, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNacimiento, dtp_FechaContrato, err_Alerta)) {
                int id = Convert.ToInt32 (lbl_IdConductor.Text);
                string
                   cedula = txt_Cedula.Text.Trim (),
                   estado = cmb_Estado.Text,
                   nombre1 = txt_Nombre1.Text.Trim (),
                   nombre2 = txt_Nombre2.Text.Trim (),
                   apellido1 = txt_Apellido1.Text.Trim (),
                   apellido2 = txt_Apellido2.Text.Trim (),
                   disponibilidad = cmb_Disponibilidad.Text,
                   telefono = txt_Telefono.Text.Trim (),
                   sexo = validacion.LeerSexo (rdb_Masculino, rdb_Femenino);
                DateTime
                    fecha_nacimiento = dtp_FechaNacimiento.Value.Date,
                    fecha_contrato = dtp_FechaContrato.Value.Date;
                string mensaje = admConductor.ConductorEditar (id, cedula, estado, nombre1, nombre2, apellido1, apellido2, disponibilidad, telefono, sexo, fecha_nacimiento, fecha_contrato);
                if (mensaje[0] != '¡') {
                    limpiarCampos ();
                }
            }
        }

        private void btn_Cancelar_Click (object sender, EventArgs e) {
            this.Close ();
        }

        private void limpiarCampos () {
            lbl_IdConductor.Text = "";
            txt_Cedula.Clear ();
            cmb_Estado.SelectedIndex = 0;
            txt_Nombre1.Clear ();
            txt_Nombre2.Clear ();
            txt_Apellido1.Clear ();
            txt_Apellido2.Clear ();
            cmb_Disponibilidad.SelectedIndex = 0;
            txt_Telefono.Clear ();
            rdb_Masculino.Checked = false;
            rdb_Femenino.Checked = false;
            dtp_FechaNacimiento.Value = DateTime.Today;
            dtp_FechaContrato.Value = DateTime.Today;
            err_Alerta.Clear ();
        }

    }
}
