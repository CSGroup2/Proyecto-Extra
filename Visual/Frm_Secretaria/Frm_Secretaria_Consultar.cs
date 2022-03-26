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
        Adm_Secretaria Adm_Secretaria = Adm_Secretaria.GetAdm ();
        Adm_General Adm_General = Adm_General.GetAdm ();
        Adm_PDF admPDF = Adm_PDF.GetAdm ();
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
            listarDatosSecretaria ();
        }

        public void listarDisponibilidad () {
            cmb_Disponibilidad.DataSource = Adm_General.DisponibilidadLlenarCombo ();
            cmb_Disponibilidad.ValueMember = "ID_DISPONIBILIDAD";
            cmb_Disponibilidad.DisplayMember = "NOMBRE_DISPONIBILIDAD";
            cmb_Disponibilidad.Enabled = false;
        }

        public void listarDatosSecretaria () {
            dgv_Secretaria.Refresh ();
            dgv_Secretaria.DataSource = Adm_Secretaria.SecretariaListar ();
        }

        private void btn_Consultar_Click (object sender, EventArgs e) {

        }

        private void btn_MostrarTodos_Click (object sender, EventArgs e) {
            listarDatosSecretaria ();
        }

        private void btn_Modificar_Click (object sender, EventArgs e) {

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
                    string[] columnas = { "Nº", "id", "disponibilidad", "placa", "modelo", "tipo", "capacidad", "observación" };
                    float[] tamanios = { 2, 2, 3, 4, 4, 3, 2, 5 };

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

        
    }
}
