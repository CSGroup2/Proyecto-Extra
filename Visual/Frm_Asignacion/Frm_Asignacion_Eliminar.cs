using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Visual.Frm_Asignacion
{
    public partial class Frm_Asignacion_Eliminar : Form
    {
        Adm_Asignacion admA = Adm_Asignacion.GetAdm();
        public Frm_Asignacion_Eliminar()
        {
            InitializeComponent();
            admA.LlenarTablaAsignacionesAntiguas(dgvAsignaciones);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string msj = ""; 
            int id = 0;
            int posicion = dgvAsignaciones.CurrentRow.Index;
            if (posicion >= 0)
            {
                id = Convert.ToInt32(dgvAsignaciones.Rows[posicion].Cells["id_asignacion_cabecera"].Value);
                dgvAsignaciones.Rows.RemoveAt(posicion);
                msj = admA.EliminarAsignacion(id);
                MessageBox.Show(msj);
            }
            else
            {
                MessageBox.Show("Seleccione una asignación");
            }
        }
    }
}
