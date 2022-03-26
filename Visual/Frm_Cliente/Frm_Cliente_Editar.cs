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
    public partial class Frm_Cliente_Editar : Form {
        Btn_Comportamiento cbtn = new Btn_Comportamiento ();
        Adm_General admgeneral = Adm_General.GetAdm();
        Adm_Cliente admcliente = Adm_Cliente.GetAdm();
        int idclientemodi=0;
        string contrasenia="";
        Frm_Menu menu;

        public Frm_Cliente_Editar () {
            InitializeComponent ();
            this.inactivarcampos();
            this.setfocusbusqueda();
        }

        public Frm_Cliente_Editar(int idcliente, Frm_Menu menuconsul)
        {
            InitializeComponent();
            this.idclientemodi = idcliente;
            this.menu = menuconsul;
            this.btnBuscar.Visible = false;
            this.chxactivarbusqueda.Visible = false; 
        }

        private void FrmClienteModifi_Load (object sender, EventArgs e) {
            this.pncontenido.BackColor = Color.FromArgb (200, 255, 255, 255);
            this.cargarestados();
            this.cargarhospitales();
            _ = idclientemodi != 0 ? this.cargardatoscliente() : this.limpiar() ;
        }

        #region metodos de ayuda o cargadores de datos
        private String limpiar()
        {
            admcliente.limpiarCamposGuardarCliente(txtmcedula, cbxhospital, txtmnombre1, txtmnombre2, txtmape1, txtmape2, txtmcorreo, txtmtelf, oprmasculino, oprfemenino, daterfechanac, txtmusur, txtrcontra, txtrcontra, errpvdatoscliente);
            return "limpiado";
        }

        private String cargardatoscliente()
        {
           String mensaje = this.admcliente.BuscarClienteID(idclientemodi.ToString(), 1, lblcodigo, txtmcedula, txtmnombre1, txtmnombre2, txtmape1, txtmape2, txtmcorreo, txtmtelf, txtmusur, cbxestado, cbxhospital, oprmasculino, oprfemenino, daterfechanac, ref contrasenia);
           return mensaje; 
        }

        private void cargarhospitales()
        {
            cbxhospital.Items.Clear();
            cbxhospital.DataSource = admgeneral.HospitalLlenarCombo();
            cbxhospital.ValueMember = "ID_HOSPITAL";
            cbxhospital.DisplayMember = "NOMBRE_HOSPITAL";
        }

        private void cargarestados()
        {
            cbxestado.Items.Clear();
            cbxestado.DataSource = admgeneral.EstadoLlenarCombo();
            cbxestado.ValueMember = "ID_ESTADO";
            cbxestado.DisplayMember = "NOMBRE_ESTADO";
        }

        private void inactivarcampos()
        {
            lblcodigo.Text = "";
            txtmcedula.Enabled = false;
            txtmnombre1.Enabled = false;
            txtmnombre2.Enabled = false;
            txtmape1.Enabled = false;
            txtmape2.Enabled = false; 
            txtmcorreo.Enabled = false; 
            txtmtelf.Enabled = false; 
            txtmusur.Enabled = false; 
            cbxestado.Enabled = false;
            cbxhospital.Enabled = false; 
            oprmasculino.Enabled = false; 
            oprfemenino.Enabled = false; 
            daterfechanac.Enabled = false;
            chxcontra.Enabled = false;
            chxcontra.Checked = false;
            txtrcontra.Enabled = false; 
        }
        private void habilitarcampos()
        {
            txtmcedula.Enabled = true;
            txtmnombre1.Enabled = true;
            txtmnombre2.Enabled = true;
            txtmape1.Enabled = true;
            txtmape2.Enabled = true;
            txtmcorreo.Enabled = true;
            txtmtelf.Enabled = true;
            txtmusur.Enabled = true;
            cbxestado.Enabled = true;
            cbxhospital.Enabled = true;
            oprmasculino.Enabled = true;
            oprfemenino.Enabled = true;
            daterfechanac.Enabled = true;
            chxcontra.Enabled = true; 
        }
        private void setfocusbusqueda()
        {
            txtmcedula.Enabled = true;
            txtmcedula.Focus();
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SGAR LOS RAPIDOS S.A", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SGAR LOS RAPIDOS S.A", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        #endregion

        #region Efecto boton Guardar
        private void btnguardar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activabotonPer (sender, Color.LimeGreen);
        }
        private void btnguardar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        #region Efecto boton Cancelar
        private void btncancelar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activabotonPer (sender, Color.Firebrick);
        }

        private void btncancelar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realmente actualizar los datos de este registro?", "Warning",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idcliente = Int32.Parse(lblcodigo.Text.Trim().ToString());
                string cedula = txtmcedula.Text.Trim(),
                nombre1 = txtmnombre1.Text.Trim(),
                nombre2 = txtmnombre2.Text.Trim(),
                apellido1 = txtmape1.Text.Trim(),
                apellido2 = txtmape2.Text.Trim(),
                correo = txtmcorreo.Text.Trim(),
                telefono = txtmtelf.Text.Trim(),
                sexo = admcliente.esSexo(oprmasculino, oprfemenino),
                usuario = txtmusur.Text.Trim();
                string contra = (txtrcontra.Text.Trim() == "") ? contra = contrasenia : contra = txtrcontra.Text.Trim();
                DateTime fechanac = daterfechanac.Value;
                int Id_hospital = Int16.Parse(cbxhospital.SelectedValue.ToString());
                int id_estado = Int16.Parse(cbxestado.SelectedValue.ToString());
                string mensaje = admcliente.actualizarDatosCliente(idcliente, cedula, Id_hospital, id_estado, nombre1, nombre2, apellido1, apellido2, correo, telefono, sexo, fechanac, usuario, contra);
                if (mensaje.Contains("¡Error "))
                {
                    MensajeError(mensaje);
                }
                else
                {
                    MensajeOk(mensaje);
                    this.limpiar();
                    this.inactivarcampos();
                    this.setfocusbusqueda(); 
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar este formulario?", "Warning",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.menu == null)
                {
                    this.Close();
                }
                else
                {
                    menu.abrirhijoform(new Frm_Cliente_Consultar(menu));
                }
            }
        }

        private void pncontenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtmcedula.Text))
            {
                string mensaje= this.admcliente.BuscarClienteID(txtmcedula.Text.ToString(), 2, lblcodigo, txtmcedula, txtmnombre1, txtmnombre2, txtmape1, txtmape2, txtmcorreo, txtmtelf, txtmusur, cbxestado, cbxhospital, oprmasculino, oprfemenino, daterfechanac, ref contrasenia);
                if(mensaje.Equals("Encontrado"))
                {
                    MessageBox.Show("Datos encontrados","SGAR LOS RAPIDOS S.A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.habilitarcampos();
                    txtmcedula.Enabled = false;
                    chxactivarbusqueda.Checked = false;
                }
                else
                {
                    MessageBox.Show("Datos no encontrados", "SGAR LOS RAPIDOS S.A", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.limpiar(); 
                    this.inactivarcampos();
                    this.setfocusbusqueda();

                }
            }
        }

        private void chxactivarbusqueda_CheckedChanged(object sender, EventArgs e)
        {
            if (chxactivarbusqueda.Checked)
            {
                this.inactivarcampos();
                this.setfocusbusqueda();
            }
            else
            {
                txtmcedula.Enabled = false;
            }
        }

        private void txtmcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            admcliente.validarSoloNumerosKeyPress(sender, e);
        }

        private void txtmtelf_KeyPress(object sender, KeyPressEventArgs e)
        {
            admcliente.validarSoloNumerosKeyPress(sender, e);
        }

        private void txtmcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            admcliente.validarSoloCorreoKeypress(sender, e);
        }

        private void chxcontra_CheckedChanged(object sender, EventArgs e)
        {
            if (chxcontra.Checked)
            {
                txtrcontra.Enabled = true;
            }
            else
            {
                txtrcontra.Enabled = false;
            }
        }
    }
}
