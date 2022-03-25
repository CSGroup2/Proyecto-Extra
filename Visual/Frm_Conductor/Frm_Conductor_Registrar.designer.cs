
namespace Visual {
    partial class Frm_Conductor_Registrar {
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
            this.lbl_Cedula = new System.Windows.Forms.Label();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.grp_Nombres = new System.Windows.Forms.GroupBox();
            this.lbl_Nombre1 = new System.Windows.Forms.Label();
            this.txt_Nombre1 = new System.Windows.Forms.TextBox();
            this.lbl_Nombre2 = new System.Windows.Forms.Label();
            this.txt_Nombre2 = new System.Windows.Forms.TextBox();
            this.grp_Apellidos = new System.Windows.Forms.GroupBox();
            this.lbl_Apellido1 = new System.Windows.Forms.Label();
            this.txt_Apellido1 = new System.Windows.Forms.TextBox();
            this.lbl_Apellido2 = new System.Windows.Forms.Label();
            this.txt_Apellido2 = new System.Windows.Forms.TextBox();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.rdb_Femenino = new System.Windows.Forms.RadioButton();
            this.rdb_Masculino = new System.Windows.Forms.RadioButton();
            this.lbl_FechaNacimiento = new System.Windows.Forms.Label();
            this.dtp_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaContrato = new System.Windows.Forms.Label();
            this.dtp_FechaContrato = new System.Windows.Forms.DateTimePicker();
            this.btn_Guardar = new FontAwesome.Sharp.IconButton();
            this.btn_Cancelar = new FontAwesome.Sharp.IconButton();
            this.btn_Limpiar = new FontAwesome.Sharp.IconButton();
            this.err_Alerta = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_Titulo.SuspendLayout();
            this.pnl_Cuerpo.SuspendLayout();
            this.pnl_Contenido.SuspendLayout();
            this.grp_Nombres.SuspendLayout();
            this.grp_Apellidos.SuspendLayout();
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
            this.pnl_Titulo.Size = new System.Drawing.Size(690, 85);
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
            this.lbl_Titulo.Location = new System.Drawing.Point(119, 22);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(461, 44);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Registro de Conductores";
            // 
            // pnl_Cuerpo
            // 
            this.pnl_Cuerpo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Cuerpo.BackColor = System.Drawing.Color.LightGray;
            this.pnl_Cuerpo.BackgroundImage = global::Visual.Properties.Resources._8;
            this.pnl_Cuerpo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Cuerpo.Controls.Add(this.pnl_Contenido);
            this.pnl_Cuerpo.Controls.Add(this.btn_Guardar);
            this.pnl_Cuerpo.Controls.Add(this.btn_Cancelar);
            this.pnl_Cuerpo.Controls.Add(this.btn_Limpiar);
            this.pnl_Cuerpo.Location = new System.Drawing.Point(0, 85);
            this.pnl_Cuerpo.Name = "pnl_Cuerpo";
            this.pnl_Cuerpo.Size = new System.Drawing.Size(690, 491);
            this.pnl_Cuerpo.TabIndex = 1;
            // 
            // pnl_Contenido
            // 
            this.pnl_Contenido.BackColor = System.Drawing.Color.White;
            this.pnl_Contenido.Controls.Add(this.lbl_Cedula);
            this.pnl_Contenido.Controls.Add(this.txt_Cedula);
            this.pnl_Contenido.Controls.Add(this.grp_Nombres);
            this.pnl_Contenido.Controls.Add(this.grp_Apellidos);
            this.pnl_Contenido.Controls.Add(this.lbl_Telefono);
            this.pnl_Contenido.Controls.Add(this.txt_Telefono);
            this.pnl_Contenido.Controls.Add(this.lbl_Sexo);
            this.pnl_Contenido.Controls.Add(this.rdb_Masculino);
            this.pnl_Contenido.Controls.Add(this.rdb_Femenino);
            this.pnl_Contenido.Controls.Add(this.lbl_FechaNacimiento);
            this.pnl_Contenido.Controls.Add(this.dtp_FechaNacimiento);
            this.pnl_Contenido.Controls.Add(this.lbl_FechaContrato);
            this.pnl_Contenido.Controls.Add(this.dtp_FechaContrato);
            this.pnl_Contenido.Location = new System.Drawing.Point(26, 15);
            this.pnl_Contenido.Name = "pnl_Contenido";
            this.pnl_Contenido.Size = new System.Drawing.Size(639, 310);
            this.pnl_Contenido.TabIndex = 0;
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cedula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_Cedula.Location = new System.Drawing.Point(16, 17);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(109, 18);
            this.lbl_Cedula.TabIndex = 0;
            this.lbl_Cedula.Text = "Num. Cédula:";
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Cedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cedula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cedula.Location = new System.Drawing.Point(157, 14);
            this.txt_Cedula.MaxLength = 10;
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(137, 26);
            this.txt_Cedula.TabIndex = 1;
            this.txt_Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cedula_KeyPress);
            // 
            // grp_Nombres
            // 
            this.grp_Nombres.BackColor = System.Drawing.Color.Transparent;
            this.grp_Nombres.Controls.Add(this.lbl_Nombre1);
            this.grp_Nombres.Controls.Add(this.txt_Nombre1);
            this.grp_Nombres.Controls.Add(this.lbl_Nombre2);
            this.grp_Nombres.Controls.Add(this.txt_Nombre2);
            this.grp_Nombres.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Nombres.Location = new System.Drawing.Point(10, 51);
            this.grp_Nombres.Name = "grp_Nombres";
            this.grp_Nombres.Size = new System.Drawing.Size(302, 85);
            this.grp_Nombres.TabIndex = 2;
            this.grp_Nombres.TabStop = false;
            this.grp_Nombres.Text = "Nombres";
            // 
            // lbl_Nombre1
            // 
            this.lbl_Nombre1.AutoSize = true;
            this.lbl_Nombre1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_Nombre1.Location = new System.Drawing.Point(6, 20);
            this.lbl_Nombre1.Name = "lbl_Nombre1";
            this.lbl_Nombre1.Size = new System.Drawing.Size(128, 18);
            this.lbl_Nombre1.TabIndex = 0;
            this.lbl_Nombre1.Text = "Primer Nombre:";
            // 
            // txt_Nombre1
            // 
            this.txt_Nombre1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nombre1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre1.Location = new System.Drawing.Point(147, 15);
            this.txt_Nombre1.Name = "txt_Nombre1";
            this.txt_Nombre1.Size = new System.Drawing.Size(137, 26);
            this.txt_Nombre1.TabIndex = 1;
            this.txt_Nombre1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre1_KeyPress);
            // 
            // lbl_Nombre2
            // 
            this.lbl_Nombre2.AutoSize = true;
            this.lbl_Nombre2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nombre2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_Nombre2.Location = new System.Drawing.Point(4, 50);
            this.lbl_Nombre2.Name = "lbl_Nombre2";
            this.lbl_Nombre2.Size = new System.Drawing.Size(142, 18);
            this.lbl_Nombre2.TabIndex = 2;
            this.lbl_Nombre2.Text = "Segundo Nombre:";
            // 
            // txt_Nombre2
            // 
            this.txt_Nombre2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nombre2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre2.Location = new System.Drawing.Point(147, 47);
            this.txt_Nombre2.Name = "txt_Nombre2";
            this.txt_Nombre2.Size = new System.Drawing.Size(137, 26);
            this.txt_Nombre2.TabIndex = 3;
            this.txt_Nombre2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre1_KeyPress);
            // 
            // grp_Apellidos
            // 
            this.grp_Apellidos.BackColor = System.Drawing.Color.Transparent;
            this.grp_Apellidos.Controls.Add(this.lbl_Apellido1);
            this.grp_Apellidos.Controls.Add(this.txt_Apellido1);
            this.grp_Apellidos.Controls.Add(this.lbl_Apellido2);
            this.grp_Apellidos.Controls.Add(this.txt_Apellido2);
            this.grp_Apellidos.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Apellidos.Location = new System.Drawing.Point(330, 51);
            this.grp_Apellidos.Name = "grp_Apellidos";
            this.grp_Apellidos.Size = new System.Drawing.Size(302, 85);
            this.grp_Apellidos.TabIndex = 3;
            this.grp_Apellidos.TabStop = false;
            this.grp_Apellidos.Text = "Apellidos";
            // 
            // lbl_Apellido1
            // 
            this.lbl_Apellido1.AutoSize = true;
            this.lbl_Apellido1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Apellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_Apellido1.Location = new System.Drawing.Point(2, 20);
            this.lbl_Apellido1.Name = "lbl_Apellido1";
            this.lbl_Apellido1.Size = new System.Drawing.Size(127, 18);
            this.lbl_Apellido1.TabIndex = 0;
            this.lbl_Apellido1.Text = "Primer Apellido:";
            // 
            // txt_Apellido1
            // 
            this.txt_Apellido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Apellido1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido1.Location = new System.Drawing.Point(147, 15);
            this.txt_Apellido1.Name = "txt_Apellido1";
            this.txt_Apellido1.Size = new System.Drawing.Size(137, 26);
            this.txt_Apellido1.TabIndex = 1;
            this.txt_Apellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre1_KeyPress);
            // 
            // lbl_Apellido2
            // 
            this.lbl_Apellido2.AutoSize = true;
            this.lbl_Apellido2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Apellido2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_Apellido2.Location = new System.Drawing.Point(2, 50);
            this.lbl_Apellido2.Name = "lbl_Apellido2";
            this.lbl_Apellido2.Size = new System.Drawing.Size(145, 18);
            this.lbl_Apellido2.TabIndex = 2;
            this.lbl_Apellido2.Text = "Segundo Apellido:";
            // 
            // txt_Apellido2
            // 
            this.txt_Apellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Apellido2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido2.Location = new System.Drawing.Point(147, 47);
            this.txt_Apellido2.Name = "txt_Apellido2";
            this.txt_Apellido2.Size = new System.Drawing.Size(137, 26);
            this.txt_Apellido2.TabIndex = 3;
            this.txt_Apellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre1_KeyPress);
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Telefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_Telefono.Location = new System.Drawing.Point(335, 145);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(78, 18);
            this.lbl_Telefono.TabIndex = 4;
            this.lbl_Telefono.Text = "Num. Telf:";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Telefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono.Location = new System.Drawing.Point(477, 142);
            this.txt_Telefono.MaxLength = 10;
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(137, 26);
            this.txt_Telefono.TabIndex = 5;
            this.txt_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cedula_KeyPress);
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sexo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_Sexo.Location = new System.Drawing.Point(16, 178);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(48, 18);
            this.lbl_Sexo.TabIndex = 6;
            this.lbl_Sexo.Text = "Sexo:";
            // 
            // rdb_Femenino
            // 
            this.rdb_Femenino.AutoSize = true;
            this.rdb_Femenino.BackColor = System.Drawing.Color.Transparent;
            this.rdb_Femenino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Femenino.Location = new System.Drawing.Point(208, 175);
            this.rdb_Femenino.Name = "rdb_Femenino";
            this.rdb_Femenino.Size = new System.Drawing.Size(98, 24);
            this.rdb_Femenino.TabIndex = 8;
            this.rdb_Femenino.Text = "Femenino";
            this.rdb_Femenino.UseVisualStyleBackColor = false;
            // 
            // rdb_Masculino
            // 
            this.rdb_Masculino.AutoSize = true;
            this.rdb_Masculino.BackColor = System.Drawing.Color.Transparent;
            this.rdb_Masculino.Checked = true;
            this.rdb_Masculino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Masculino.Location = new System.Drawing.Point(84, 175);
            this.rdb_Masculino.Name = "rdb_Masculino";
            this.rdb_Masculino.Size = new System.Drawing.Size(102, 24);
            this.rdb_Masculino.TabIndex = 7;
            this.rdb_Masculino.TabStop = true;
            this.rdb_Masculino.Text = "Masculino";
            this.rdb_Masculino.UseVisualStyleBackColor = false;
            // 
            // lbl_FechaNacimiento
            // 
            this.lbl_FechaNacimiento.AutoSize = true;
            this.lbl_FechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_FechaNacimiento.Location = new System.Drawing.Point(15, 209);
            this.lbl_FechaNacimiento.Name = "lbl_FechaNacimiento";
            this.lbl_FechaNacimiento.Size = new System.Drawing.Size(142, 18);
            this.lbl_FechaNacimiento.TabIndex = 9;
            this.lbl_FechaNacimiento.Text = "Fech. Nacimiento:";
            // 
            // dtp_FechaNacimiento
            // 
            this.dtp_FechaNacimiento.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtp_FechaNacimiento.Location = new System.Drawing.Point(157, 205);
            this.dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            this.dtp_FechaNacimiento.Size = new System.Drawing.Size(242, 26);
            this.dtp_FechaNacimiento.TabIndex = 10;
            // 
            // lbl_FechaContrato
            // 
            this.lbl_FechaContrato.AutoSize = true;
            this.lbl_FechaContrato.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FechaContrato.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaContrato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_FechaContrato.Location = new System.Drawing.Point(15, 241);
            this.lbl_FechaContrato.Name = "lbl_FechaContrato";
            this.lbl_FechaContrato.Size = new System.Drawing.Size(120, 18);
            this.lbl_FechaContrato.TabIndex = 11;
            this.lbl_FechaContrato.Text = "Fech. Contrato:";
            // 
            // dtp_FechaContrato
            // 
            this.dtp_FechaContrato.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaContrato.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtp_FechaContrato.Location = new System.Drawing.Point(157, 237);
            this.dtp_FechaContrato.Name = "dtp_FechaContrato";
            this.dtp_FechaContrato.Size = new System.Drawing.Size(242, 26);
            this.dtp_FechaContrato.TabIndex = 12;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Guardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_Guardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Guardar.Location = new System.Drawing.Point(39, 418);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Guardar.Size = new System.Drawing.Size(183, 52);
            this.btn_Guardar.TabIndex = 1;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            this.btn_Guardar.MouseLeave += new System.EventHandler(this.btnguardar_MouseLeave);
            this.btn_Guardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnguardar_MouseMove_1);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Cancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btn_Cancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Cancelar.Location = new System.Drawing.Point(254, 418);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Cancelar.Size = new System.Drawing.Size(183, 52);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            this.btn_Cancelar.MouseLeave += new System.EventHandler(this.btncancelar_MouseLeave);
            this.btn_Cancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btncancelar_MouseMove);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Limpiar.FlatAppearance.BorderSize = 0;
            this.btn_Limpiar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Limpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btn_Limpiar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Limpiar.Location = new System.Drawing.Point(469, 418);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Limpiar.Size = new System.Drawing.Size(183, 52);
            this.btn_Limpiar.TabIndex = 3;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            this.btn_Limpiar.MouseLeave += new System.EventHandler(this.btnlimpiar_MouseLeave);
            this.btn_Limpiar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnlimpiar_MouseMove);
            // 
            // err_Alerta
            // 
            this.err_Alerta.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_Alerta.ContainerControl = this;
            // 
            // Frm_Conductor_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 576);
            this.Controls.Add(this.pnl_Titulo);
            this.Controls.Add(this.pnl_Cuerpo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Conductor_Registrar";
            this.Text = "FrmConductorReg";
            this.Load += new System.EventHandler(this.FrmConductorReg_Load);
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.pnl_Cuerpo.ResumeLayout(false);
            this.pnl_Contenido.ResumeLayout(false);
            this.pnl_Contenido.PerformLayout();
            this.grp_Nombres.ResumeLayout(false);
            this.grp_Nombres.PerformLayout();
            this.grp_Apellidos.ResumeLayout(false);
            this.grp_Apellidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_Alerta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Panel pnl_Cuerpo;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.GroupBox grp_Nombres;
        private System.Windows.Forms.Label lbl_Nombre1;
        private System.Windows.Forms.TextBox txt_Nombre2;
        private System.Windows.Forms.Label lbl_Nombre2;
        private System.Windows.Forms.TextBox txt_Nombre1;
        private System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.Label lbl_Cedula;
        private FontAwesome.Sharp.IconButton btn_Cancelar;
        private System.Windows.Forms.Panel pnl_Contenido;
        private System.Windows.Forms.GroupBox grp_Apellidos;
        private System.Windows.Forms.TextBox txt_Apellido2;
        private System.Windows.Forms.Label lbl_Apellido2;
        private System.Windows.Forms.TextBox txt_Apellido1;
        private System.Windows.Forms.Label lbl_Apellido1;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.RadioButton rdb_Femenino;
        private System.Windows.Forms.RadioButton rdb_Masculino;
        private System.Windows.Forms.DateTimePicker dtp_FechaNacimiento;
        private System.Windows.Forms.Label lbl_FechaNacimiento;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.DateTimePicker dtp_FechaContrato;
        private System.Windows.Forms.Label lbl_FechaContrato;
        private FontAwesome.Sharp.IconButton btn_Guardar;
        private FontAwesome.Sharp.IconButton btn_Limpiar;
        private System.Windows.Forms.ErrorProvider err_Alerta;
    }
}