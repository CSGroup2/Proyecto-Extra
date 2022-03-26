
namespace Visual {
    partial class Frm_Cliente_Editar {
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.pncontenido = new System.Windows.Forms.Panel();
            this.chxactivarbusqueda = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxestado = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtmusur = new System.Windows.Forms.TextBox();
            this.chxcontra = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtrcontra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxhospital = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtmcorreo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmtelf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.daterfechanac = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.oprfemenino = new System.Windows.Forms.RadioButton();
            this.oprmasculino = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmape2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmape1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmcedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gboxnombres = new System.Windows.Forms.GroupBox();
            this.txtmnombre2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmnombre1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.errpvdatoscliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.pncontenido.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboxnombres.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpvdatoscliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImage = global::Visual.Properties.Resources._8;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Controls.Add(this.pncontenido);
            this.panel2.Controls.Add(this.btncancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 497);
            this.panel2.TabIndex = 5;
            // 
            // btnguardar
            // 
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnguardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.Location = new System.Drawing.Point(128, 422);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnguardar.Size = new System.Drawing.Size(183, 52);
            this.btnguardar.TabIndex = 30;
            this.btnguardar.Text = "Actualizar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            this.btnguardar.MouseLeave += new System.EventHandler(this.btnguardar_MouseLeave);
            this.btnguardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnguardar_MouseMove);
            // 
            // pncontenido
            // 
            this.pncontenido.BackColor = System.Drawing.Color.White;
            this.pncontenido.Controls.Add(this.chxactivarbusqueda);
            this.pncontenido.Controls.Add(this.btnBuscar);
            this.pncontenido.Controls.Add(this.lblcodigo);
            this.pncontenido.Controls.Add(this.label15);
            this.pncontenido.Controls.Add(this.cbxestado);
            this.pncontenido.Controls.Add(this.label14);
            this.pncontenido.Controls.Add(this.groupBox2);
            this.pncontenido.Controls.Add(this.cbxhospital);
            this.pncontenido.Controls.Add(this.label13);
            this.pncontenido.Controls.Add(this.txtmcorreo);
            this.pncontenido.Controls.Add(this.label10);
            this.pncontenido.Controls.Add(this.txtmtelf);
            this.pncontenido.Controls.Add(this.label9);
            this.pncontenido.Controls.Add(this.daterfechanac);
            this.pncontenido.Controls.Add(this.label8);
            this.pncontenido.Controls.Add(this.oprfemenino);
            this.pncontenido.Controls.Add(this.oprmasculino);
            this.pncontenido.Controls.Add(this.label7);
            this.pncontenido.Controls.Add(this.groupBox1);
            this.pncontenido.Controls.Add(this.txtmcedula);
            this.pncontenido.Controls.Add(this.label5);
            this.pncontenido.Controls.Add(this.gboxnombres);
            this.pncontenido.Location = new System.Drawing.Point(16, 25);
            this.pncontenido.Name = "pncontenido";
            this.pncontenido.Size = new System.Drawing.Size(651, 370);
            this.pncontenido.TabIndex = 14;
            this.pncontenido.Paint += new System.Windows.Forms.PaintEventHandler(this.pncontenido_Paint);
            // 
            // chxactivarbusqueda
            // 
            this.chxactivarbusqueda.AutoSize = true;
            this.chxactivarbusqueda.Checked = true;
            this.chxactivarbusqueda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxactivarbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxactivarbusqueda.Location = new System.Drawing.Point(292, 62);
            this.chxactivarbusqueda.Name = "chxactivarbusqueda";
            this.chxactivarbusqueda.Size = new System.Drawing.Size(15, 14);
            this.chxactivarbusqueda.TabIndex = 37;
            this.chxactivarbusqueda.UseVisualStyleBackColor = true;
            this.chxactivarbusqueda.CheckedChanged += new System.EventHandler(this.chxactivarbusqueda_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscar.Location = new System.Drawing.Point(236, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBuscar.Size = new System.Drawing.Size(44, 28);
            this.btnBuscar.TabIndex = 59;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblcodigo
            // 
            this.lblcodigo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(123, 10);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(74, 26);
            this.lblcodigo.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label15.Location = new System.Drawing.Point(18, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 18);
            this.label15.TabIndex = 31;
            this.label15.Text = "Código:";
            // 
            // cbxestado
            // 
            this.cbxestado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxestado.FormattingEnabled = true;
            this.cbxestado.Location = new System.Drawing.Point(434, 10);
            this.cbxestado.Name = "cbxestado";
            this.cbxestado.Size = new System.Drawing.Size(185, 28);
            this.cbxestado.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label14.Location = new System.Drawing.Point(338, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 18);
            this.label14.TabIndex = 29;
            this.label14.Text = "Estado:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmusur);
            this.groupBox2.Controls.Add(this.chxcontra);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtrcontra);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(329, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 95);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta";
            // 
            // txtmusur
            // 
            this.txtmusur.Enabled = false;
            this.txtmusur.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmusur.Location = new System.Drawing.Point(105, 17);
            this.txtmusur.Name = "txtmusur";
            this.txtmusur.ReadOnly = true;
            this.txtmusur.Size = new System.Drawing.Size(168, 26);
            this.txtmusur.TabIndex = 36;
            // 
            // chxcontra
            // 
            this.chxcontra.AutoSize = true;
            this.chxcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxcontra.Location = new System.Drawing.Point(285, 61);
            this.chxcontra.Name = "chxcontra";
            this.chxcontra.Size = new System.Drawing.Size(15, 14);
            this.chxcontra.TabIndex = 35;
            this.chxcontra.UseVisualStyleBackColor = true;
            this.chxcontra.CheckedChanged += new System.EventHandler(this.chxcontra_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label12.Location = new System.Drawing.Point(4, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 18);
            this.label12.TabIndex = 33;
            this.label12.Text = "Contraseña:";
            // 
            // txtrcontra
            // 
            this.txtrcontra.Enabled = false;
            this.txtrcontra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrcontra.Location = new System.Drawing.Point(105, 55);
            this.txtrcontra.Name = "txtrcontra";
            this.txtrcontra.PasswordChar = '*';
            this.txtrcontra.Size = new System.Drawing.Size(168, 26);
            this.txtrcontra.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 18);
            this.label11.TabIndex = 30;
            this.label11.Text = "Usuario:";
            // 
            // cbxhospital
            // 
            this.cbxhospital.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxhospital.FormattingEnabled = true;
            this.cbxhospital.Location = new System.Drawing.Point(434, 53);
            this.cbxhospital.Name = "cbxhospital";
            this.cbxhospital.Size = new System.Drawing.Size(185, 28);
            this.cbxhospital.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label13.Location = new System.Drawing.Point(338, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 18);
            this.label13.TabIndex = 26;
            this.label13.Text = "Hospital:";
            // 
            // txtmcorreo
            // 
            this.txtmcorreo.BackColor = System.Drawing.SystemColors.Window;
            this.txtmcorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmcorreo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmcorreo.Location = new System.Drawing.Point(98, 274);
            this.txtmcorreo.Name = "txtmcorreo";
            this.txtmcorreo.Size = new System.Drawing.Size(209, 26);
            this.txtmcorreo.TabIndex = 19;
            this.txtmcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmcorreo_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label10.Location = new System.Drawing.Point(18, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Correo:";
            // 
            // txtmtelf
            // 
            this.txtmtelf.BackColor = System.Drawing.SystemColors.Window;
            this.txtmtelf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmtelf.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmtelf.Location = new System.Drawing.Point(98, 311);
            this.txtmtelf.Name = "txtmtelf";
            this.txtmtelf.Size = new System.Drawing.Size(179, 26);
            this.txtmtelf.TabIndex = 17;
            this.txtmtelf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmtelf_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label9.Location = new System.Drawing.Point(17, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Num. Telf:";
            // 
            // daterfechanac
            // 
            this.daterfechanac.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daterfechanac.Location = new System.Drawing.Point(158, 189);
            this.daterfechanac.Name = "daterfechanac";
            this.daterfechanac.Size = new System.Drawing.Size(315, 26);
            this.daterfechanac.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(17, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fech. Nacimiento:";
            // 
            // oprfemenino
            // 
            this.oprfemenino.AutoSize = true;
            this.oprfemenino.BackColor = System.Drawing.Color.Transparent;
            this.oprfemenino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oprfemenino.Location = new System.Drawing.Point(209, 228);
            this.oprfemenino.Name = "oprfemenino";
            this.oprfemenino.Size = new System.Drawing.Size(98, 24);
            this.oprfemenino.TabIndex = 14;
            this.oprfemenino.Text = "Femenino";
            this.oprfemenino.UseVisualStyleBackColor = false;
            // 
            // oprmasculino
            // 
            this.oprmasculino.AutoSize = true;
            this.oprmasculino.BackColor = System.Drawing.Color.Transparent;
            this.oprmasculino.Checked = true;
            this.oprmasculino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oprmasculino.Location = new System.Drawing.Point(81, 228);
            this.oprmasculino.Name = "oprmasculino";
            this.oprmasculino.Size = new System.Drawing.Size(102, 24);
            this.oprmasculino.TabIndex = 13;
            this.oprmasculino.TabStop = true;
            this.oprmasculino.Text = "Masculino";
            this.oprmasculino.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(17, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sexo:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtmape2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtmape1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(335, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apellidos";
            // 
            // txtmape2
            // 
            this.txtmape2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmape2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmape2.Location = new System.Drawing.Point(146, 52);
            this.txtmape2.Name = "txtmape2";
            this.txtmape2.Size = new System.Drawing.Size(137, 26);
            this.txtmape2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(2, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Segundo Apellido:";
            // 
            // txtmape1
            // 
            this.txtmape1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmape1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmape1.Location = new System.Drawing.Point(146, 17);
            this.txtmape1.Name = "txtmape1";
            this.txtmape1.Size = new System.Drawing.Size(137, 26);
            this.txtmape1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(2, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Primer Apellido:";
            // 
            // txtmcedula
            // 
            this.txtmcedula.BackColor = System.Drawing.SystemColors.Window;
            this.txtmcedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmcedula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmcedula.Location = new System.Drawing.Point(123, 55);
            this.txtmcedula.MaxLength = 10;
            this.txtmcedula.Name = "txtmcedula";
            this.txtmcedula.Size = new System.Drawing.Size(106, 26);
            this.txtmcedula.TabIndex = 6;
            this.txtmcedula.Text = "0914201033";
            this.txtmcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmcedula_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(17, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Num. Cédula:";
            // 
            // gboxnombres
            // 
            this.gboxnombres.BackColor = System.Drawing.Color.Transparent;
            this.gboxnombres.Controls.Add(this.txtmnombre2);
            this.gboxnombres.Controls.Add(this.label3);
            this.gboxnombres.Controls.Add(this.txtmnombre1);
            this.gboxnombres.Controls.Add(this.label4);
            this.gboxnombres.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxnombres.Location = new System.Drawing.Point(11, 89);
            this.gboxnombres.Name = "gboxnombres";
            this.gboxnombres.Size = new System.Drawing.Size(318, 90);
            this.gboxnombres.TabIndex = 4;
            this.gboxnombres.TabStop = false;
            this.gboxnombres.Text = "Nombres";
            // 
            // txtmnombre2
            // 
            this.txtmnombre2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmnombre2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmnombre2.Location = new System.Drawing.Point(147, 52);
            this.txtmnombre2.Name = "txtmnombre2";
            this.txtmnombre2.Size = new System.Drawing.Size(149, 26);
            this.txtmnombre2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(4, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Segundo Nombre:";
            // 
            // txtmnombre1
            // 
            this.txtmnombre1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmnombre1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmnombre1.Location = new System.Drawing.Point(147, 15);
            this.txtmnombre1.Name = "txtmnombre1";
            this.txtmnombre1.Size = new System.Drawing.Size(149, 26);
            this.txtmnombre1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Primer Nombre:";
            // 
            // btncancelar
            // 
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btncancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancelar.Location = new System.Drawing.Point(345, 422);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btncancelar.Size = new System.Drawing.Size(183, 52);
            this.btncancelar.TabIndex = 29;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            this.btncancelar.MouseLeave += new System.EventHandler(this.btncancelar_MouseLeave);
            this.btncancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btncancelar_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 57);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(180, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Actualizar Cliente";
            // 
            // errpvdatoscliente
            // 
            this.errpvdatoscliente.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errpvdatoscliente.ContainerControl = this;
            // 
            // Frm_Cliente_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Cliente_Editar";
            this.Text = "FrmClienteModifi";
            this.Load += new System.EventHandler(this.FrmClienteModifi_Load);
            this.panel2.ResumeLayout(false);
            this.pncontenido.ResumeLayout(false);
            this.pncontenido.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboxnombres.ResumeLayout(false);
            this.gboxnombres.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpvdatoscliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pncontenido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtrcontra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxhospital;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtmcorreo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmtelf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker daterfechanac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton oprfemenino;
        private System.Windows.Forms.RadioButton oprmasculino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmape2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmape1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmcedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gboxnombres;
        private System.Windows.Forms.TextBox txtmnombre2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmnombre1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btncancelar;
        private System.Windows.Forms.ComboBox cbxestado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chxcontra;
        private System.Windows.Forms.TextBox txtmusur;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.ErrorProvider errpvdatoscliente;
        private System.Windows.Forms.CheckBox chxactivarbusqueda;
    }
}