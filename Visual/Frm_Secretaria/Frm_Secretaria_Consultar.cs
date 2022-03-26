using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Visual {
    public partial class Frm_Secretaria_Consultar : Form {
        Adm_Secretaria admSecretaria = Adm_Secretaria.GetAdm ();
        Adm_General admGeneral = Adm_General.GetAdm ();
        Adm_PDF admPDF = Adm_PDF.GetAdm ();
        Validacion validacion = new Validacion ();
        Frm_Menu Frm_Menu;

        public Frm_Secretaria_Consultar () {
            InitializeComponent ();
        }

        public Frm_Secretaria_Consultar (Frm_Menu Menu) {
            // Constructor overcharge
            InitializeComponent ();
            this.Frm_Menu = Menu;
        }

        private void Frm_Secretaria_Consultar_Load (object sender, EventArgs e) {
            listarEstados ();
            listarDatosSecretaria ();
        }

        private void listarEstados () {
            cmb_Estado.Items.Clear ();
            cmb_Estado.DataSource = admGeneral.EstadoLlenarCombo ();
            cmb_Estado.ValueMember = "ID_ESTADO";
            cmb_Estado.DisplayMember = "NOMBRE_ESTADO";
            cmb_Estado.Enabled = false;
        }

        public void listarDatosSecretaria () {
            dgv_Secretaria.Refresh ();
            dgv_Secretaria.DataSource = admSecretaria.SecretariaListar ();
        }

        private void btn_Consultar_Click (object sender, EventArgs e) {
            // Search for "conductor" data
            string cedula_nombre = null;
            string estado = null;
            err_Alerta.Clear ();
            if (txt_CedulaNombre.Text.Trim () == "" && (chk_Estado.Checked == false || cmb_Estado.SelectedIndex == 0)) {
                err_Alerta.SetError (txt_CedulaNombre, "Opcional 1");
                err_Alerta.SetError (chk_Estado, "Opcional 2");
            } else {
                if (!String.IsNullOrWhiteSpace (txt_CedulaNombre.Text)) {
                    cedula_nombre = txt_CedulaNombre.Text.Trim ().Replace (" ", String.Empty);
                }
                if (chk_Estado.Checked) {
                    estado = cmb_Estado.SelectedValue.ToString ();
                }
                dgv_Secretaria.Refresh ();
                dgv_Secretaria.DataSource = admSecretaria.SecretariaConsultar (cedula_nombre, estado);
            }
        }

        private void btn_MostrarTodos_Click (object sender, EventArgs e) {
            listarDatosSecretaria ();
        }

        private void btn_Modificar_Click (object sender, EventArgs e) {
            int
              posicion = 0,
              idConductor = 0;
            posicion = dgv_Secretaria.CurrentRow.Index;
            if (posicion >= 0) {
                idConductor = validacion.AEntero (dgv_Secretaria.Rows[posicion].Cells["ID"].Value.ToString ());
                Frm_Menu.abrirhijoform (new Frm_Secretaria_Editar (idConductor));
            } else {
                MessageBox.Show ("Seleccione una secretaria.");
            }
        }

        private void btnImprimir_Click (object sender, EventArgs e) {
            DataTable dataTable_resultado = new DataTable ();
            // Convert DataGridView to DataTable
            dataTable_resultado = (DataTable)dgv_Secretaria.DataSource;
            // Defines the file extension
            sfd_VentanaGuardado.DefaultExt = "pdf";
            // Defines a filter for the file explorer
            sfd_VentanaGuardado.Filter = "Pdf File |*.pdf";
            // Defines a title to saveFileDialog
            sfd_VentanaGuardado.Title = "SGAR: Conductores - Guardar";
            if (dataTable_resultado.Rows.Count > 0) {
                if (sfd_VentanaGuardado.ShowDialog () == DialogResult.OK) {
                    // Captures file's path
                    string file = sfd_VentanaGuardado.FileName;

                    /*EL SIGUIENTE ARRAY ES PARA DETALLAR LOS NOMBRES DE LAS COLUMNAS EN LA TABLA DEL PDF
                    MODIFICALO EN EL MISMO ORDEN QUE UBICASTE LAS COLUMNAS DE TU DATAGRIDVIEW*/
                    string[] columnas = { "Nº", "ID", "Cédula", "Estado", "Nombre", "Apellidos", "Correo", "Telefono", "Sexo", "Fecha_Nacimiento", "Fecha_Contrato" };
                    float[] tamanios = { 1, float.Parse ("1.5"), 1, 1, 3, 3, 3, 1, 2, 3, 3 };

                    // Creates PDF file
                    admPDF.CrearPdf (dataTable_resultado, file, columnas, tamanios, 2);
                    //
                    if (File.Exists (file)) {
                        // Opens PDF file
                        Process.Start (file);
                    }
                }
            } else {
                MessageBox.Show ("No hay datos para imprimir");
            }
        }

        private void txt_CedulaNombre_KeyPress (object sender, KeyPressEventArgs e) {
            if (rdb_Cedula.Checked) {
                txt_CedulaNombre.MaxLength = 10;
                // Only allows numbers on press
                validacion.validarSoloNumerosKeyPress (sender, e);
            } else {
                txt_CedulaNombre.MaxLength = 300;
                // Only allows alphabetic characters
                validacion.validarSoloLettrasConEspaciosKeyPress (sender, e);
            }
        }

        private void chk_Estado_CheckedChanged (object sender, EventArgs e) {
            if (chk_Estado.Checked) {
                cmb_Estado.Enabled = true;
            } else {
                cmb_Estado.Enabled = false;
            }
        }

        private void rdb_Cedula_CheckedChanged (object sender, EventArgs e) {
            txt_CedulaNombre.Clear ();
        }
    }
}
