using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Visual
{
    public partial class Frm_Configuracion_Cuenta : Form
    {
        Adm_Login admLogin = Adm_Login.GetAdm();

        public Frm_Configuracion_Cuenta()
        {
            InitializeComponent();
        }

        private void Frm_Configuracion_Cuenta_Load(object sender, EventArgs e)
        {
            lblnombres.Text = admLogin.NombreUsuario();
            lblapellidos.Text = admLogin.ApellidoUsuario();
            lblcargo.Text = admLogin.TipoUsuario();
            this.GBoxcontrasenia.BackColor = Color.FromArgb(200, 255, 255, 255);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SGAR LOS RAPIDOS S.A", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SGAR LOS RAPIDOS S.A", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea seguir con el cambio de contraseña?", "Warning",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txt_Contrasenia1.Text.Trim() != txt_Contrasenia2.Text.Trim())
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Los Rapidos SGAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(txt_Contrasenia1.Text.Trim() == "" && txt_Contrasenia2.Text.Trim() == "")
                {
                    MessageBox.Show("Las contraseñas no pueden estar vacias.", "Los Rapidos SGAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string mensaje = admLogin.cambiar_contrasenia(admLogin.IdUsuario(), admLogin.TipoUsuario(), txtcontractual.Text, txt_Contrasenia2.Text);
                    if (mensaje.Contains("exito"))
                    {
                        MensajeOk(mensaje);
                        this.txtcontractual.Clear();
                        this.txt_Contrasenia1.Clear();
                        this.txt_Contrasenia2.Clear();
                        this.deshabilitarcontrasenias();
                    }
                    else
                    {
                        MensajeError(mensaje);
                    }
                }
            }
        }

        private void deshabilitarcontrasenias()
        {
            chxcontra.Checked = false;
            txt_Contrasenia1.Enabled = false;
            txt_Contrasenia2.Enabled = false;
        }

        private void chxcontra_CheckedChanged(object sender, EventArgs e)
        {
            if (chxcontra.Checked)
            {
                txt_Contrasenia1.Enabled = true;
                txt_Contrasenia2.Enabled = true;
            }
            else
            {
                this.deshabilitarcontrasenias();
            }
        }
    }
}
