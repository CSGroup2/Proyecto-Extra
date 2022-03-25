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
        Frm_Menu menu;

        public Frm_Cliente_Editar () {
            InitializeComponent ();
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

        private String limpiar()
        {
            admcliente.limpiarCamposGuardarCliente(txtmcedula, cbxhospital, txtmnombre1, txtmnombre2, txtmape1, txtmape2, txtmcorreo, txtmtelf, oprmasculino, oprfemenino, daterfechanac, txtmusur, txtrcontra, txtrcontra, errpvdatoscliente);
            return "limpiado";
        }

        private String cargardatoscliente()
        {
           this.admcliente.BuscarClienteID(idclientemodi.ToString(), 1, lblcodigo, txtmcedula, txtmnombre1, txtmnombre2, txtmape1, txtmape2, txtmcorreo, txtmtelf, txtmusur, cbxestado, cbxhospital, oprmasculino, oprfemenino, daterfechanac);
            return "encontrado"; 
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

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if(this.menu == null)
            {
                this.Close();
            }
            else
            {
                menu.abrirhijoform(new Frm_Cliente_Consultar(menu));
            }
        }

        private void pncontenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
