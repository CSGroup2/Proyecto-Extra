
namespace Visual {
    partial class Frm_Conductor_Consultar {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.components = new System.ComponentModel.Container();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pnl_Cuerpo = new System.Windows.Forms.Panel();
            this.pnl_Contenido = new System.Windows.Forms.Panel();
            this.lbl_Datos = new System.Windows.Forms.Label();
            this.txt_CedulaNombre = new System.Windows.Forms.TextBox();
            this.rdb_Cedula = new System.Windows.Forms.RadioButton();
            this.rdb_Nombre = new System.Windows.Forms.RadioButton();
            this.cmb_Disponibilidad = new System.Windows.Forms.ComboBox();
            this.chb_Disponibilidad = new System.Windows.Forms.CheckBox();
            this.btn_Consultar = new FontAwesome.Sharp.IconButton();
            this.btn_MostrarTodos = new FontAwesome.Sharp.IconButton();
            this.dgv_Conductor = new System.Windows.Forms.DataGridView();
            this.btn_Imprimir = new FontAwesome.Sharp.IconButton();
            this.btn_Modificar = new FontAwesome.Sharp.IconButton();
            this.sfd_VentanaGuardado = new System.Windows.Forms.SaveFileDialog();
            this.err_Alerta = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Eliminar = new FontAwesome.Sharp.IconButton();
            this.pnl_Titulo.SuspendLayout();
            this.pnl_Cuerpo.SuspendLayout();
            this.pnl_Contenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Conductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Alerta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnl_Titulo.Controls.Add(this.lbl_Titulo);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(690, 63);
            this.pnl_Titulo.TabIndex = 0;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(102, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(480, 44);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Consulta de Conductores";
            // 
            // pnl_Cuerpo
            // 
            this.pnl_Cuerpo.BackColor = System.Drawing.Color.LightGray;
            this.pnl_Cuerpo.BackgroundImage = global::Visual.Properties.Resources._9;
            this.pnl_Cuerpo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Cuerpo.Controls.Add(this.pnl_Contenido);
            this.pnl_Cuerpo.Controls.Add(this.btn_Imprimir);
            this.pnl_Cuerpo.Controls.Add(this.btn_Modificar);
            this.pnl_Cuerpo.Controls.Add(this.btn_Eliminar);
            this.pnl_Cuerpo.Location = new System.Drawing.Point(0, 63);
            this.pnl_Cuerpo.Name = "pnl_Cuerpo";
            this.pnl_Cuerpo.Size = new System.Drawing.Size(690, 513);
            this.pnl_Cuerpo.TabIndex = 1;
            // 
            // pnl_Contenido
            // 
            this.pnl_Contenido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Contenido.BackColor = System.Drawing.Color.White;
            this.pnl_Contenido.Controls.Add(this.lbl_Datos);
            this.pnl_Contenido.Controls.Add(this.txt_CedulaNombre);
            this.pnl_Contenido.Controls.Add(this.rdb_Cedula);
            this.pnl_Contenido.Controls.Add(this.rdb_Nombre);
            this.pnl_Contenido.Controls.Add(this.cmb_Disponibilidad);
            this.pnl_Contenido.Controls.Add(this.chb_Disponibilidad);
            this.pnl_Contenido.Controls.Add(this.btn_Consultar);
            this.pnl_Contenido.Controls.Add(this.btn_MostrarTodos);
            this.pnl_Contenido.Controls.Add(this.dgv_Conductor);
            this.pnl_Contenido.Location = new System.Drawing.Point(26, 23);
            this.pnl_Contenido.Name = "pnl_Contenido";
            this.pnl_Contenido.Size = new System.Drawing.Size(638, 378);
            this.pnl_Contenido.TabIndex = 0;
            // 
            // lbl_Datos
            // 
            this.lbl_Datos.AutoSize = true;
            this.lbl_Datos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Datos.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Datos.Location = new System.Drawing.Point(36, 19);
            this.lbl_Datos.Name = "lbl_Datos";
            this.lbl_Datos.Size = new System.Drawing.Size(49, 15);
            this.lbl_Datos.TabIndex = 0;
            this.lbl_Datos.Text = "Dato: ";
            // 
            // txt_CedulaNombre
            // 
            this.txt_CedulaNombre.Location = new System.Drawing.Point(88, 17);
            this.txt_CedulaNombre.Name = "txt_CedulaNombre";
            this.txt_CedulaNombre.Size = new System.Drawing.Size(152, 20);
            this.txt_CedulaNombre.TabIndex = 1;
            this.txt_CedulaNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CedulaNombre_KeyPress);
            // 
            // rdb_Cedula
            // 
            this.rdb_Cedula.AutoSize = true;
            this.rdb_Cedula.BackColor = System.Drawing.Color.Transparent;
            this.rdb_Cedula.Checked = true;
            this.rdb_Cedula.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Cedula.Location = new System.Drawing.Point(258, 16);
            this.rdb_Cedula.Name = "rdb_Cedula";
            this.rdb_Cedula.Size = new System.Drawing.Size(67, 19);
            this.rdb_Cedula.TabIndex = 2;
            this.rdb_Cedula.TabStop = true;
            this.rdb_Cedula.Text = "Cédula";
            this.rdb_Cedula.UseVisualStyleBackColor = false;
            this.rdb_Cedula.CheckedChanged += new System.EventHandler(this.rdb_Cedula_CheckedChanged);
            // 
            // rdb_Nombre
            // 
            this.rdb_Nombre.AutoSize = true;
            this.rdb_Nombre.BackColor = System.Drawing.Color.Transparent;
            this.rdb_Nombre.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Nombre.Location = new System.Drawing.Point(337, 16);
            this.rdb_Nombre.Name = "rdb_Nombre";
            this.rdb_Nombre.Size = new System.Drawing.Size(67, 19);
            this.rdb_Nombre.TabIndex = 3;
            this.rdb_Nombre.Text = "Nombre";
            this.rdb_Nombre.UseVisualStyleBackColor = false;
            // 
            // cmb_Disponibilidad
            // 
            this.cmb_Disponibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Disponibilidad.FormattingEnabled = true;
            this.cmb_Disponibilidad.Location = new System.Drawing.Point(88, 48);
            this.cmb_Disponibilidad.Name = "cmb_Disponibilidad";
            this.cmb_Disponibilidad.Size = new System.Drawing.Size(152, 21);
            this.cmb_Disponibilidad.TabIndex = 4;
            // 
            // chb_Disponibilidad
            // 
            this.chb_Disponibilidad.AutoSize = true;
            this.chb_Disponibilidad.BackColor = System.Drawing.Color.Transparent;
            this.chb_Disponibilidad.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Disponibilidad.Location = new System.Drawing.Point(258, 51);
            this.chb_Disponibilidad.Name = "chb_Disponibilidad";
            this.chb_Disponibilidad.Size = new System.Drawing.Size(124, 19);
            this.chb_Disponibilidad.TabIndex = 5;
            this.chb_Disponibilidad.Text = "Disponibilidad";
            this.chb_Disponibilidad.UseVisualStyleBackColor = false;
            this.chb_Disponibilidad.CheckedChanged += new System.EventHandler(this.chb_Disponibilidad_CheckedChanged);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.FlatAppearance.BorderSize = 0;
            this.btn_Consultar.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Consultar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btn_Consultar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Consultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Consultar.IconSize = 35;
            this.btn_Consultar.Location = new System.Drawing.Point(136, 82);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Consultar.Size = new System.Drawing.Size(171, 37);
            this.btn_Consultar.TabIndex = 6;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            this.btn_Consultar.MouseLeave += new System.EventHandler(this.btnconsultar_MouseLeave);
            this.btn_Consultar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnconsultar_MouseMove);
            // 
            // btn_MostrarTodos
            // 
            this.btn_MostrarTodos.FlatAppearance.BorderSize = 0;
            this.btn_MostrarTodos.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MostrarTodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_MostrarTodos.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_MostrarTodos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_MostrarTodos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_MostrarTodos.IconSize = 35;
            this.btn_MostrarTodos.Location = new System.Drawing.Point(332, 82);
            this.btn_MostrarTodos.Name = "btn_MostrarTodos";
            this.btn_MostrarTodos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_MostrarTodos.Size = new System.Drawing.Size(171, 37);
            this.btn_MostrarTodos.TabIndex = 7;
            this.btn_MostrarTodos.Text = "Mostrar Todos";
            this.btn_MostrarTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_MostrarTodos.UseVisualStyleBackColor = true;
            this.btn_MostrarTodos.Click += new System.EventHandler(this.btn_MostrarTodos_Click);
            this.btn_MostrarTodos.MouseLeave += new System.EventHandler(this.btnmostrartodos_MouseLeave);
            this.btn_MostrarTodos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnmostrartodos_MouseMove);
            // 
            // dgv_Conductor
            // 
            this.dgv_Conductor.AllowUserToAddRows = false;
            this.dgv_Conductor.AllowUserToDeleteRows = false;
            this.dgv_Conductor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Conductor.Location = new System.Drawing.Point(27, 129);
            this.dgv_Conductor.Name = "dgv_Conductor";
            this.dgv_Conductor.ReadOnly = true;
            this.dgv_Conductor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Conductor.Size = new System.Drawing.Size(585, 224);
            this.dgv_Conductor.TabIndex = 8;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Imprimir.FlatAppearance.BorderSize = 0;
            this.btn_Imprimir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Imprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Imprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btn_Imprimir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Imprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Imprimir.Location = new System.Drawing.Point(254, 421);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Imprimir.Size = new System.Drawing.Size(183, 52);
            this.btn_Imprimir.TabIndex = 2;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            this.btn_Imprimir.MouseLeave += new System.EventHandler(this.btnimprimir_MouseLeave);
            this.btn_Imprimir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnimprimir_MouseMove);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Modificar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btn_Modificar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Modificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Modificar.Location = new System.Drawing.Point(49, 421);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Modificar.Size = new System.Drawing.Size(183, 52);
            this.btn_Modificar.TabIndex = 1;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            this.btn_Modificar.MouseLeave += new System.EventHandler(this.btnguardar_MouseLeave);
            this.btn_Modificar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnguardar_MouseMove);
            // 
            // err_Alerta
            // 
            this.err_Alerta.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_Alerta.ContainerControl = this;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Eliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_Eliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Eliminar.IconSize = 35;
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(459, 421);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Eliminar.Size = new System.Drawing.Size(183, 52);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // Frm_Conductor_Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 576);
            this.Controls.Add(this.pnl_Titulo);
            this.Controls.Add(this.pnl_Cuerpo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Conductor_Consultar";
            this.Text = "FrmConductorConsul";
            this.Load += new System.EventHandler(this.Frm_Conductor_Consultar_Load);
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.pnl_Cuerpo.ResumeLayout(false);
            this.pnl_Contenido.ResumeLayout(false);
            this.pnl_Contenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Conductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Alerta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Panel pnl_Cuerpo;
        private FontAwesome.Sharp.IconButton btn_Modificar;
        private System.Windows.Forms.Panel pnl_Contenido;
        private System.Windows.Forms.ComboBox cmb_Disponibilidad;
        private System.Windows.Forms.CheckBox chb_Disponibilidad;
        private System.Windows.Forms.RadioButton rdb_Nombre;
        private System.Windows.Forms.RadioButton rdb_Cedula;
        private System.Windows.Forms.TextBox txt_CedulaNombre;
        private System.Windows.Forms.Label lbl_Datos;
        private System.Windows.Forms.DataGridView dgv_Conductor;
        private FontAwesome.Sharp.IconButton btn_Consultar;
        private FontAwesome.Sharp.IconButton btn_MostrarTodos;
        private FontAwesome.Sharp.IconButton btn_Imprimir;
        private System.Windows.Forms.SaveFileDialog sfd_VentanaGuardado;
        private System.Windows.Forms.ErrorProvider err_Alerta;
        private FontAwesome.Sharp.IconButton btn_Eliminar;
    }
}