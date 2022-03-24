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
        Adm_Conductor Adm_Conductor = Adm_Conductor.GetAdm ();
        Adm_General Adm_General = Adm_General.GetAdm ();
        Validacion Validacion = new Validacion ();

        public Frm_Conductor_Editar () {
            InitializeComponent ();
            listarEstados ();
            listarDisponibilidad ();
        }

        public Frm_Conductor_Editar (int posicion, int idConductor) {
            // Constructor overcharge
            InitializeComponent ();
            llenarCamposEditar (posicion, idConductor);
            listarEstados ();
            listarDisponibilidad ();
        }

        private void Frm_Conductor_Editar_Load (object sender, EventArgs e) {
            this.pnl_Contenido.BackColor = Color.FromArgb (200, 255, 255, 255);
            listarEstados ();
            listarDisponibilidad ();
        }

        #region Frm load at begining

        public void listarDisponibilidad () {
            cmb_Disponibilidad.DataSource = Adm_General.listarDisponibilidad ();
            cmb_Disponibilidad.ValueMember = "ID_DISPONIBILIDAD";
            cmb_Disponibilidad.DisplayMember = "NOMBRE_DISPONIBILIDAD";
            cmb_Disponibilidad.Enabled = false;
        }

        private void listarEstados () {
            cmb_Estado.Items.Clear ();
            cmb_Estado.DataSource = Adm_General.listerEstados ();
            cmb_Estado.ValueMember = "ID_ESTADO";
            cmb_Estado.DisplayMember = "NOMBRE_ESTADO";
        }

        private void llenarCamposEditar (int posicion, int idConductor) {
            Adm_Conductor.buscarDatosConductorEditar (posicion, idConductor, lbl_IdConductor, txt_Cedula, cmb_Estado, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNacimiento, dtp_FechaContrato);
        }

        #endregion

        #region Frm behavior

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
            Validacion.validarSoloNumerosKeyPress (sender, e);
        }

        private void txt_Nombre1_KeyPress (object sender, KeyPressEventArgs e) {
            // Only allows alphabetic characters
            Validacion.validarSoloLettrasKeyPress (sender, e);
        }

        #endregion

        private void btn_Guardar_Click (object sender, EventArgs e) {
            err_Alerta.Clear ();
            if (Validacion.esCorrecto_EditarDatosConductor (txt_Cedula, cmb_Estado, txt_Nombre1, txt_Apellido1, txt_Apellido2, cmb_Disponibilidad, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNacimiento, dtp_FechaContrato, err_Alerta)) {
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
                   sexo = Validacion.esSexo (rdb_Masculino, rdb_Femenino);
                DateTime
                    fecha_nacimiento = dtp_FechaNacimiento.Value.Date,
                    fecha_contrato = dtp_FechaContrato.Value.Date;
                string mensaje = Adm_Conductor.actualizarDatosConductor (id, cedula, estado, nombre1, nombre2, apellido1, apellido2, telefono, sexo, fecha_nacimiento, fecha_contrato);
                if (mensaje[0] != '¡') {
                    Adm_Conductor.limpiarCamposGuardarConductorEditar (txt_Cedula, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNacimiento, dtp_FechaContrato, err_Alerta);
                }
            }
        }

        private void btn_Cancelar_Click (object sender, EventArgs e) {
            this.Close ();
        }

    }
}
