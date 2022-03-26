using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Control {
    public class Validacion {

        public int AEntero (string entrada) {
            int x = 0;
            try {
                x = Convert.ToInt32 (entrada);
            } catch (Exception ex) {
                Console.WriteLine (ex.Message);
                //MessageBox.Show("Error: Se esperaba un número entero");
            }
            return x;
        }

        public string LeerSexo (RadioButton rdb_Masculino, RadioButton rdb_Femenino) {
            string sexo = "";
            if (rdb_Masculino.Checked) {
                sexo = "Masculino";
            } else if (rdb_Femenino.Checked) {
                sexo = "Femenino";
            }
            return sexo;
        }

        public bool EsMayorDeEdad (DateTime fechaNacimiento) {
            bool esMayorDeEdad = true;
            DateTime hoy = DateTime.Now;
            TimeSpan diferenciasDias = hoy.Date.Subtract (fechaNacimiento.Date);
            double diferenciaAños = (Convert.ToDouble (diferenciasDias.Days) / 365);
            if (diferenciaAños < 18) {
                esMayorDeEdad = false;
            }
            return esMayorDeEdad;
        }
        
        /*------------------------------ KeyPress ------------------------------*/

        #region KeyPress for Frm

        public void validarSoloNumerosKeyPress (object sender, KeyPressEventArgs e) {
            char c = e.KeyChar;
            if (!char.IsControl (c) && !char.IsDigit (c)) {
                e.Handled = true;
                return;
            }
        }

        public void validarSoloLettrasKeyPress (object sender, KeyPressEventArgs e) {
            char c = e.KeyChar;
            if (!char.IsLetter (c) && (c != Convert.ToChar (Keys.Back))) {
                e.Handled = true;
                return;
            }
        }

        public void validarSoloLettrasConEspaciosKeyPress (object sender, KeyPressEventArgs e) {
            char c = e.KeyChar;
            if (!char.IsLetter (c) && c != ' ' && (c != Convert.ToChar (Keys.Back))) {
                e.Handled = true;
                return;
            }
        }

        public void validarSoloCorreoKeypress (object sender, KeyPressEventArgs e) {
            char c = e.KeyChar;
            if (!char.IsLetter (c) && !char.IsDigit (e.KeyChar) && (c != '.') && (c != '@') && (c != '-') && (c != '_') && (c != Convert.ToChar (Keys.Back))) {
                e.Handled = true;
                return;
            }
        }

        #endregion

        /*------------------------------ Frm_Conductor ------------------------------*/

        #region Validation: Frm_Conductor_Registrar - errorprovider emtpy fields & incorrect email

        public bool esCorrecto_GuardarDatosConductor (TextBox txt_Cedula, TextBox txt_Nombre1, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNacimiento, DateTimePicker dtp_FechaContrato, ErrorProvider err_Alerta) {
            bool salida = true;
            string mensaje = "Campo obligatorio.";
            if (txt_Cedula.Text.Trim () == "") {
                err_Alerta.SetError (txt_Cedula, mensaje);
                salida = false;
            }
            if (txt_Nombre1.Text.Trim () == "") {
                err_Alerta.SetError (txt_Nombre1, mensaje);
                salida = false;
            }
            if (txt_Apellido1.Text.Trim () == "") {
                err_Alerta.SetError (txt_Apellido1, mensaje);
                salida = false;
            }
            if (txt_Apellido2.Text.Trim () == "") {
                err_Alerta.SetError (txt_Apellido2, mensaje);
                salida = false;
            }
            if (txt_Telefono.Text.Trim () == "") {
                err_Alerta.SetError (txt_Telefono, mensaje);
                salida = false;
            }
            if (rdb_Femenino.Checked == rdb_Masculino.Checked) {
                err_Alerta.SetError (rdb_Femenino, mensaje);
                salida = false;
            }
            if (!EsMayorDeEdad ((DateTime)dtp_FechaNacimiento.Value)) {
                err_Alerta.SetError (dtp_FechaNacimiento, mensaje);
                salida = false;
            }
            if ((DateTime)dtp_FechaContrato.Value.Date > DateTime.Now.Date) {
                err_Alerta.SetError (dtp_FechaContrato, mensaje);
                salida = false;
            }
            return salida;
        }

        public bool esCorrecto_EditarDatosConductor (TextBox txt_Cedula, ComboBox cmb_Estado, TextBox txt_Nombre1, TextBox txt_Apellido1, TextBox txt_Apellido2, ComboBox cmb_Disponibilidad, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNacimiento, DateTimePicker dtp_FechaContrato, ErrorProvider err_Alerta) {
            bool salida = true;
            string mensaje = "Campo obligatorio.";
            if (txt_Cedula.Text.Trim () == "") {
                err_Alerta.SetError (txt_Cedula, mensaje);
                salida = false;
            }
            if (cmb_Estado.SelectedIndex == 0) {
                err_Alerta.SetError (cmb_Estado, mensaje);
                salida = false;
            }
            if (txt_Nombre1.Text.Trim () == "") {
                err_Alerta.SetError (txt_Nombre1, mensaje);
                salida = false;
            }
            if (txt_Apellido1.Text.Trim () == "") {
                err_Alerta.SetError (txt_Apellido1, mensaje);
                salida = false;
            }
            if (txt_Apellido2.Text.Trim () == "") {
                err_Alerta.SetError (txt_Apellido2, mensaje);
                salida = false;
            }
            if (cmb_Disponibilidad.SelectedIndex == 0) {
                err_Alerta.SetError (cmb_Disponibilidad, mensaje);
                salida = false;
            }
            if (txt_Telefono.Text.Trim () == "") {
                err_Alerta.SetError (txt_Telefono, mensaje);
                salida = false;
            }
            if (rdb_Femenino.Checked == rdb_Masculino.Checked) {
                err_Alerta.SetError (rdb_Femenino, mensaje);
                salida = false;
            }
            if (!EsMayorDeEdad ((DateTime)dtp_FechaNacimiento.Value)) {
                err_Alerta.SetError (dtp_FechaNacimiento, mensaje);
                salida = false;
            }
            if ((DateTime)dtp_FechaContrato.Value.Date > DateTime.Now.Date) {
                err_Alerta.SetError (dtp_FechaContrato, mensaje);
                salida = false;
            }
            return salida;
        }

        #endregion

        /*------------------------------ Frm_Secretaria ------------------------------*/

        #region Validation: Frm_Secretaria_Registrar - errorprovider emtpy fields & incorrect email

        public bool esCorrecto_DatosSecretaria (TextBox txt_Cedula, TextBox txt_Nombre1, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNacimiento, DateTimePicker dtp_FechaContrato, TextBox txt_NombreUsuario, TextBox txt_Contrasenia1, TextBox txt_Contrasenia2, ErrorProvider err_Alerta) {
            bool esCorrecto = true;
            string mensaje = "Campo obligatorio.";
            string correo = txt_Correo.Text.Trim ();
            if (txt_Cedula.Text.Trim () == "") {
                err_Alerta.SetError (txt_Cedula, mensaje);
                esCorrecto = false;
            }
            if (txt_Nombre1.Text.Trim () == "") {
                err_Alerta.SetError (txt_Nombre1, mensaje);
                esCorrecto = false;
            }
            if (txt_Apellido1.Text.Trim () == "") {
                err_Alerta.SetError (txt_Apellido1, mensaje);
                esCorrecto = false;
            }
            if (txt_Apellido2.Text.Trim () == "") {
                err_Alerta.SetError (txt_Apellido2, mensaje);
                esCorrecto = false;
            }
            if (correo == "") {
                err_Alerta.SetError (txt_Correo, mensaje);
                esCorrecto = false;
            } else {
                try {
                    var addr = new System.Net.Mail.MailAddress (correo);
                    //return addr.Address == correo;
                } catch {
                    err_Alerta.SetError (txt_Correo, "Correo no valido.");
                    esCorrecto = false;
                }
            }
            if (txt_Telefono.Text.Trim () == "") {
                err_Alerta.SetError (txt_Telefono, mensaje);
                esCorrecto = false;
            }
            if (rdb_Femenino.Checked == rdb_Masculino.Checked) {
                err_Alerta.SetError (rdb_Femenino, mensaje);
                esCorrecto = false;
            }
            if (!EsMayorDeEdad ((DateTime)dtp_FechaNacimiento.Value)) {
                err_Alerta.SetError (dtp_FechaNacimiento, mensaje);
                esCorrecto = false;
            }
            if ((DateTime)dtp_FechaContrato.Value.Date > DateTime.Now.Date) {
                err_Alerta.SetError (dtp_FechaContrato, mensaje);
                esCorrecto = false;
            }
            if (txt_NombreUsuario.Text.Trim () == "") {
                err_Alerta.SetError (txt_NombreUsuario, mensaje);
                esCorrecto = false;
            }
            if (txt_Contrasenia1.Text.Trim () == "") {
                err_Alerta.SetError (txt_Contrasenia1, mensaje);
                esCorrecto = false;
            }
            if (txt_Contrasenia2.Text.Trim () == "") {
                err_Alerta.SetError (txt_Contrasenia2, mensaje);
                esCorrecto = false;
            }
            if (esCorrecto == true && txt_Contrasenia1.Text.Trim () != txt_Contrasenia2.Text.Trim ()) {
                err_Alerta.SetError (txt_Contrasenia2, "Las contraseñas no coinciden.");
                esCorrecto = false;
            }
            return esCorrecto;
        }

        public bool esCorrecto_EditarDatosSecretaria (TextBox txt_Cedula, ComboBox cmb_Estado, TextBox txt_Nombre1, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNacimiento, DateTimePicker dtp_FechaContrato, TextBox txt_NombreUsuario, TextBox txt_Contrasenia, ErrorProvider err_Alerta) {
            bool esCorrecto = true;
            string mensaje = "Campo obligatorio.";
            string correo = txt_Correo.Text.Trim ();
            if (txt_Cedula.Text.Trim () == "") {
                err_Alerta.SetError (txt_Cedula, mensaje);
                esCorrecto = false;
            }
            if (txt_Nombre1.Text.Trim () == "") {
                err_Alerta.SetError (txt_Nombre1, mensaje);
                esCorrecto = false;
            }
           
            if (txt_Apellido1.Text.Trim () == "") {
                err_Alerta.SetError (txt_Apellido1, mensaje);
                esCorrecto = false;
            }
            if (txt_Apellido2.Text.Trim () == "") {
                err_Alerta.SetError (txt_Apellido2, mensaje);
                esCorrecto = false;
            }
            if (correo == "") {
                err_Alerta.SetError (txt_Correo, mensaje);
                esCorrecto = false;
            } else {
                try {
                    var addr = new System.Net.Mail.MailAddress (correo);
                    //return addr.Address == correo;
                } catch {
                    err_Alerta.SetError (txt_Correo, "Correo no valido.");
                    esCorrecto = false;
                }
            }
            if (txt_Telefono.Text.Trim () == "") {
                err_Alerta.SetError (txt_Telefono, mensaje);
                esCorrecto = false;
            }
            if (rdb_Femenino.Checked == rdb_Masculino.Checked) {
                err_Alerta.SetError (rdb_Femenino, mensaje);
                esCorrecto = false;
            }
            if (!EsMayorDeEdad ((DateTime)dtp_FechaNacimiento.Value)) {
                err_Alerta.SetError (dtp_FechaNacimiento, mensaje);
                esCorrecto = false;
            }
            if ((DateTime)dtp_FechaContrato.Value.Date > DateTime.Now.Date) {
                err_Alerta.SetError (dtp_FechaContrato, mensaje);
                esCorrecto = false;
            }
            if (txt_NombreUsuario.Text.Trim () == "") {
                err_Alerta.SetError (txt_NombreUsuario, mensaje);
                esCorrecto = false;
            }
            if (txt_Contrasenia.Text.Trim () == "") {
                err_Alerta.SetError (txt_Contrasenia, mensaje);
                esCorrecto = false;
            }
            return esCorrecto;
        }

        #endregion

        /*------------------------------ Frm_Cliente ------------------------------*/

        #region Validaciones de FrmCliente Registrar

        // Validaciones correspondientes para el formulario de Registrar Cliente

        internal bool esCorrectoDatosCliente(TextBox txt_Cedula, ComboBox cmbhospital, TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNac, TextBox txt_NombreUsuario, TextBox txt_Contrasenia1, TextBox txt_Contrasenia2, ErrorProvider errorProvider1)
        {
            bool salida = true;
            string mensaje = "Campo obligatorio.";
            string correo = txt_Correo.Text.Trim();
            if (txt_Cedula.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Cedula, mensaje);
                salida = false;
            }
            if (txt_Nombre1.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Nombre1, mensaje);
                salida = false;
            }
            if (txt_Nombre2.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Nombre2, mensaje);
                salida = false;
            }
            if (txt_Apellido1.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Apellido1, mensaje);
                salida = false;
            }
            if (txt_Apellido2.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Apellido2, mensaje);
                salida = false;
            }
            if (correo == "")
            {
                errorProvider1.SetError(txt_Correo, mensaje);
                salida = false;
            }
            else
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(correo);
                    //return addr.Address == correo;
                }
                catch
                {
                    errorProvider1.SetError(txt_Correo, "Correo no valido.");
                    salida = false;
                }
            }
            if (txt_Telefono.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Telefono, mensaje);
                salida = false;
            }
            if (cmbhospital.Text == "--Seleccione--")
            {
                errorProvider1.SetError(cmbhospital, "Seleccione un Hospital");
                salida = false;
            }
            if (rdb_Femenino.Checked == rdb_Masculino.Checked)
            {
                errorProvider1.SetError(rdb_Femenino, mensaje);
                salida = false;
            }
            if (dtp_FechaNac.Text == null)
            {
                errorProvider1.SetError(dtp_FechaNac, mensaje);
                salida = false;
            }
            if (txt_NombreUsuario.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_NombreUsuario, mensaje);
                salida = false;
            }
            if (txt_Contrasenia1.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Contrasenia1, mensaje);
                salida = false;
            }
            if (txt_Contrasenia2.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Contrasenia2, mensaje);
                salida = false;
            }
            if (salida == true && txt_Contrasenia1.Text.Trim() != txt_Contrasenia2.Text.Trim())
            {
                errorProvider1.SetError(txt_Contrasenia2, "Las contraseñas no coinciden.");
                salida = false;
            }
            if (!EsMayorDeEdad((DateTime)dtp_FechaNac.Value))
            {
                errorProvider1.SetError(dtp_FechaNac, mensaje);
                salida = false;
            }
            return salida;
        }

        #endregion

        /*------------------------------ Frm_Asignacion ------------------------------*/

        #region Validaciones de FrmAsignacion Consultar
        internal string VerificarCondicion(RadioButton rdbProgreso, RadioButton rdbCumplida)
        {
            string cond = "";
            if (rdbProgreso.Checked)
            {
                cond = "En Progreso";
            }
            else if (rdbCumplida.Checked)
            {
                cond = "Cumplida";
            }
            return cond;
        }
        #endregion
    }
}
