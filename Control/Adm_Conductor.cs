using Datos;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control {
    public class Adm_Conductor {

        /*
           Aplicar el patron de diseño Singleton:
           1. Crear 1 atributo estático y privado de la misma clase.
           2. Cambiar el constructor de public a private.
           3.1. Crear un getter del atributo estático del tipo de la clase.
           3.2.Verificar si atributo es null, si es así, crearlo.
       */

        private static Adm_Conductor s_admConductor = null;    // 1.
        Conductor conductor = null;
        Datos_Conductor datosConductor = null;
        Validacion validacion = null;

        //Persona Persona = null;

        //public Usuario_Cache UsuarioCache { get => usuarioCache; set => usuarioCache = value; }

        // Constructor: Adm_Login
        private Adm_Conductor () {                  // 2.
            conductor = new Conductor ();
            datosConductor = new Datos_Conductor ();
            validacion = new Validacion ();
        }

        // Getter: GetAdm
        public static Adm_Conductor GetAdm () {     // 3.1.
            if (s_admConductor == null) {                  //3.2
                s_admConductor = new Adm_Conductor ();
            }
            return s_admConductor;
        }

        /*------------------------------ Frm_Conductor_Consultar ------------------------------*/

        #region ------------------------------ Frm_Conductor_Consultar

        public DataTable ConductorListar () {
            return datosConductor.ConductorListarDatos ();
        }

        public DataTable ConductorConsultar (string cedula_nombre, string disponibilidad) {
           return datosConductor.ConductorConsultarDatos (cedula_nombre, disponibilidad);
        }

        public string ConductorEliminar (int idConductor) {
            return datosConductor.ConductorEliminarDatos (idConductor);
        }

        #endregion

        /*------------------------------ Frm_Conductor_Editar ------------------------------*/

        #region ------------------------------ Frm_Conductor_Editar

        public void ConductorBuscarPorId (int idConductor, Label lbl_IdConductor, TextBox txt_Cedula, ComboBox cmb_Estado, TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, ComboBox cmb_Disponibilidad, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNacimiento, DateTimePicker dtp_FechaContrato) {
            conductor = new Conductor ();
            conductor = datosConductor.ConductorBuscarPorIdDatos (idConductor);
            lbl_IdConductor.Text = conductor.Id_conductor.ToString ();
            txt_Cedula.Text = conductor.Cedula.ToString ();
            cmb_Estado.Text = conductor.Estado.ToString();
            txt_Nombre1.Text = conductor.Nombre_1.ToString ();
            txt_Nombre2.Text = conductor.Nombre_2.ToString ();
            txt_Apellido1.Text = conductor.Apellido_1.ToString ();
            txt_Apellido2.Text = conductor.Apellido_2.ToString ();
            cmb_Disponibilidad.Text = conductor.Diponibilidad.ToString ();
            txt_Telefono.Text = conductor.Telefono.ToString ();
            if (conductor.Sexo.ToString() == "Masculino") {
                rdb_Masculino.Checked = true;
            } else {
                rdb_Femenino.Checked = true;
            }
            dtp_FechaNacimiento.Text = conductor.Fecha_nac.ToString ();
            dtp_FechaContrato.Text = conductor.Fecha_contrato.ToString ();
        }
        
        public string ConductorEditar (int id, string cedula, string estado, string nombre1, string nombre2, string apellido1, string apellido2, string disponibilidad, string telefono, string sexo, DateTime fecha_nac, DateTime fecha_contrato) {
            string mensaje = "¡"; // '¡' in case of incorrec data on fields   
            conductor = new Conductor (id, fecha_contrato, disponibilidad, estado, 0, cedula, nombre1, nombre2, apellido1, apellido2, sexo, fecha_nac, telefono);
            mensaje = datosConductor.ConductorEditarDatos (conductor);
            MessageBox.Show (mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return mensaje;
        }

        #endregion

        /*------------------------------ Frm_Conductor_Registrar ------------------------------*/

        #region ------------------------------ Frm_Conductor_Registrar

        // Methods for Buttons
        public string ConductorRegistrar (string cedula, string nombre1, string nombre2, string apellido1, string apellido2, string telefono, string sexo, DateTime fecha_nac, DateTime fecha_contrato) {
            string mensaje = "¡"; // '¡' in case of incorrec data on fields   
            conductor = new Conductor (0, fecha_contrato, "", "", 0, cedula, nombre1, nombre2, apellido1, apellido2, sexo, fecha_nac, telefono);
            mensaje = datosConductor.ConductorRegistrarDatos (conductor);
            MessageBox.Show (mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return mensaje;
        }

        #endregion

        /*------------------------------ Frm_Asignar ------------------------------*/

        #region ------------------------------

        internal void ConductorListarDisponibles (DataGridView dgvConductores) {
            dgvConductores.Refresh ();
            datosConductor = new Datos_Conductor ();
            dgvConductores.DataSource = datosConductor.ConductorListarDisponiblesDatos ();
        }
        
        #endregion
    }
}
