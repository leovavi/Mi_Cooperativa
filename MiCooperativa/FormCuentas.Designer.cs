namespace MiCooperativa
{
    partial class FormCuentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Insertar = new System.Windows.Forms.TabPage();
            this.lbl_Ahorro = new System.Windows.Forms.Label();
            this.txt_Tipo = new System.Windows.Forms.TextBox();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.txt_Saldo = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Agregar_Cuenta = new System.Windows.Forms.Label();
            this.lbl_Saldo = new System.Windows.Forms.Label();
            this.tab_Actualizar = new System.Windows.Forms.TabPage();
            this.tab_Buscar = new System.Windows.Forms.TabPage();
            this.tab_Eliminar = new System.Windows.Forms.TabPage();
            this.lbl_User = new System.Windows.Forms.Label();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.txt_Ahorro = new System.Windows.Forms.MaskedTextBox();
            this.lbl_CE = new System.Windows.Forms.Label();
            this.cb_CE = new System.Windows.Forms.ComboBox();
            this.dtp_Apertura = new System.Windows.Forms.DateTimePicker();
            this.lbl_Apertura = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_Actualizar_Cuenta = new System.Windows.Forms.Label();
            this.lbl_Fecha_Act = new System.Windows.Forms.Label();
            this.dtp_Fecha_Act = new System.Windows.Forms.DateTimePicker();
            this.cb_CE_Act = new System.Windows.Forms.ComboBox();
            this.lbl_CE_Act = new System.Windows.Forms.Label();
            this.txt_Ahorro_Act = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Ahorro_Act = new System.Windows.Forms.Label();
            this.txt_Tipo_Act = new System.Windows.Forms.TextBox();
            this.lbl_Tipo_Act = new System.Windows.Forms.Label();
            this.txt_Saldo_Act = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Saldo_Act = new System.Windows.Forms.Label();
            this.cb_NC = new System.Windows.Forms.ComboBox();
            this.lbl_NC = new System.Windows.Forms.Label();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.cb_Filtro = new System.Windows.Forms.ComboBox();
            this.lbl_Filtro = new System.Windows.Forms.Label();
            this.lbl_Buscar_Cuenta = new System.Windows.Forms.Label();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dgv_Cuentas = new System.Windows.Forms.DataGridView();
            this.lbl_Eliminar = new System.Windows.Forms.Label();
            this.cb_NC_Eliminar = new System.Windows.Forms.ComboBox();
            this.lbl_NC_Eliminar = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_Insertar.SuspendLayout();
            this.tab_Actualizar.SuspendLayout();
            this.tab_Buscar.SuspendLayout();
            this.tab_Eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Insertar);
            this.tabControl1.Controls.Add(this.tab_Actualizar);
            this.tabControl1.Controls.Add(this.tab_Buscar);
            this.tabControl1.Controls.Add(this.tab_Eliminar);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_Insertar
            // 
            this.tab_Insertar.Controls.Add(this.btn_Agregar);
            this.tab_Insertar.Controls.Add(this.lbl_Apertura);
            this.tab_Insertar.Controls.Add(this.dtp_Apertura);
            this.tab_Insertar.Controls.Add(this.cb_CE);
            this.tab_Insertar.Controls.Add(this.lbl_CE);
            this.tab_Insertar.Controls.Add(this.txt_Ahorro);
            this.tab_Insertar.Controls.Add(this.lbl_Ahorro);
            this.tab_Insertar.Controls.Add(this.txt_Tipo);
            this.tab_Insertar.Controls.Add(this.lbl_Tipo);
            this.tab_Insertar.Controls.Add(this.txt_Saldo);
            this.tab_Insertar.Controls.Add(this.lbl_Agregar_Cuenta);
            this.tab_Insertar.Controls.Add(this.lbl_Saldo);
            this.tab_Insertar.Location = new System.Drawing.Point(4, 30);
            this.tab_Insertar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tab_Insertar.Name = "tab_Insertar";
            this.tab_Insertar.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tab_Insertar.Size = new System.Drawing.Size(633, 343);
            this.tab_Insertar.TabIndex = 0;
            this.tab_Insertar.Text = "Insertar";
            this.tab_Insertar.UseVisualStyleBackColor = true;
            // 
            // lbl_Ahorro
            // 
            this.lbl_Ahorro.AutoSize = true;
            this.lbl_Ahorro.Location = new System.Drawing.Point(73, 139);
            this.lbl_Ahorro.Name = "lbl_Ahorro";
            this.lbl_Ahorro.Size = new System.Drawing.Size(95, 21);
            this.lbl_Ahorro.TabIndex = 5;
            this.lbl_Ahorro.Text = "Ahorro Mensual";
            // 
            // txt_Tipo
            // 
            this.txt_Tipo.Location = new System.Drawing.Point(399, 73);
            this.txt_Tipo.Name = "txt_Tipo";
            this.txt_Tipo.Size = new System.Drawing.Size(136, 29);
            this.txt_Tipo.TabIndex = 4;
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(320, 76);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(73, 21);
            this.lbl_Tipo.TabIndex = 3;
            this.lbl_Tipo.Text = "Tipo Cuenta";
            // 
            // txt_Saldo
            // 
            this.txt_Saldo.Location = new System.Drawing.Point(174, 73);
            this.txt_Saldo.Mask = "99999999.99";
            this.txt_Saldo.Name = "txt_Saldo";
            this.txt_Saldo.Size = new System.Drawing.Size(100, 29);
            this.txt_Saldo.TabIndex = 2;
            // 
            // lbl_Agregar_Cuenta
            // 
            this.lbl_Agregar_Cuenta.AutoSize = true;
            this.lbl_Agregar_Cuenta.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Agregar_Cuenta.Location = new System.Drawing.Point(247, 19);
            this.lbl_Agregar_Cuenta.Name = "lbl_Agregar_Cuenta";
            this.lbl_Agregar_Cuenta.Size = new System.Drawing.Size(115, 26);
            this.lbl_Agregar_Cuenta.TabIndex = 1;
            this.lbl_Agregar_Cuenta.Text = "Agregar Cuenta";
            // 
            // lbl_Saldo
            // 
            this.lbl_Saldo.AutoSize = true;
            this.lbl_Saldo.Location = new System.Drawing.Point(88, 76);
            this.lbl_Saldo.Name = "lbl_Saldo";
            this.lbl_Saldo.Size = new System.Drawing.Size(80, 21);
            this.lbl_Saldo.TabIndex = 0;
            this.lbl_Saldo.Text = "Saldo Cuenta";
            // 
            // tab_Actualizar
            // 
            this.tab_Actualizar.Controls.Add(this.btn_Actualizar);
            this.tab_Actualizar.Controls.Add(this.cb_NC);
            this.tab_Actualizar.Controls.Add(this.lbl_NC);
            this.tab_Actualizar.Controls.Add(this.lbl_Fecha_Act);
            this.tab_Actualizar.Controls.Add(this.dtp_Fecha_Act);
            this.tab_Actualizar.Controls.Add(this.cb_CE_Act);
            this.tab_Actualizar.Controls.Add(this.lbl_CE_Act);
            this.tab_Actualizar.Controls.Add(this.txt_Ahorro_Act);
            this.tab_Actualizar.Controls.Add(this.lbl_Ahorro_Act);
            this.tab_Actualizar.Controls.Add(this.txt_Tipo_Act);
            this.tab_Actualizar.Controls.Add(this.lbl_Tipo_Act);
            this.tab_Actualizar.Controls.Add(this.txt_Saldo_Act);
            this.tab_Actualizar.Controls.Add(this.lbl_Saldo_Act);
            this.tab_Actualizar.Controls.Add(this.lbl_Actualizar_Cuenta);
            this.tab_Actualizar.Location = new System.Drawing.Point(4, 30);
            this.tab_Actualizar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tab_Actualizar.Name = "tab_Actualizar";
            this.tab_Actualizar.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tab_Actualizar.Size = new System.Drawing.Size(633, 343);
            this.tab_Actualizar.TabIndex = 1;
            this.tab_Actualizar.Text = "Actualizar";
            this.tab_Actualizar.UseVisualStyleBackColor = true;
            // 
            // tab_Buscar
            // 
            this.tab_Buscar.Controls.Add(this.dgv_Cuentas);
            this.tab_Buscar.Controls.Add(this.btn_Buscar);
            this.tab_Buscar.Controls.Add(this.txt_Valor);
            this.tab_Buscar.Controls.Add(this.lbl_Valor);
            this.tab_Buscar.Controls.Add(this.lbl_Buscar_Cuenta);
            this.tab_Buscar.Controls.Add(this.cb_Filtro);
            this.tab_Buscar.Controls.Add(this.lbl_Filtro);
            this.tab_Buscar.Location = new System.Drawing.Point(4, 30);
            this.tab_Buscar.Name = "tab_Buscar";
            this.tab_Buscar.Size = new System.Drawing.Size(633, 343);
            this.tab_Buscar.TabIndex = 2;
            this.tab_Buscar.Text = "Buscar";
            this.tab_Buscar.UseVisualStyleBackColor = true;
            // 
            // tab_Eliminar
            // 
            this.tab_Eliminar.Controls.Add(this.btn_Eliminar);
            this.tab_Eliminar.Controls.Add(this.cb_NC_Eliminar);
            this.tab_Eliminar.Controls.Add(this.lbl_NC_Eliminar);
            this.tab_Eliminar.Controls.Add(this.lbl_Eliminar);
            this.tab_Eliminar.Location = new System.Drawing.Point(4, 30);
            this.tab_Eliminar.Name = "tab_Eliminar";
            this.tab_Eliminar.Size = new System.Drawing.Size(633, 343);
            this.tab_Eliminar.TabIndex = 3;
            this.tab_Eliminar.Text = "Eliminar";
            this.tab_Eliminar.UseVisualStyleBackColor = true;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(13, 401);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(88, 21);
            this.lbl_User.TabIndex = 1;
            this.lbl_User.Text = "lblUserLogged";
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(546, 396);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(75, 30);
            this.btn_Atras.TabIndex = 2;
            this.btn_Atras.Text = "Atrás";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // txt_Ahorro
            // 
            this.txt_Ahorro.Location = new System.Drawing.Point(174, 136);
            this.txt_Ahorro.Mask = "99999999.99";
            this.txt_Ahorro.Name = "txt_Ahorro";
            this.txt_Ahorro.Size = new System.Drawing.Size(100, 29);
            this.txt_Ahorro.TabIndex = 6;
            // 
            // lbl_CE
            // 
            this.lbl_CE.AutoSize = true;
            this.lbl_CE.Location = new System.Drawing.Point(305, 139);
            this.lbl_CE.Name = "lbl_CE";
            this.lbl_CE.Size = new System.Drawing.Size(101, 21);
            this.lbl_CE.TabIndex = 7;
            this.lbl_CE.Text = "Código Empleado";
            // 
            // cb_CE
            // 
            this.cb_CE.FormattingEnabled = true;
            this.cb_CE.Location = new System.Drawing.Point(412, 136);
            this.cb_CE.Name = "cb_CE";
            this.cb_CE.Size = new System.Drawing.Size(123, 29);
            this.cb_CE.TabIndex = 8;
            // 
            // dtp_Apertura
            // 
            this.dtp_Apertura.Location = new System.Drawing.Point(271, 211);
            this.dtp_Apertura.Name = "dtp_Apertura";
            this.dtp_Apertura.Size = new System.Drawing.Size(225, 29);
            this.dtp_Apertura.TabIndex = 9;
            // 
            // lbl_Apertura
            // 
            this.lbl_Apertura.AutoSize = true;
            this.lbl_Apertura.Location = new System.Drawing.Point(173, 217);
            this.lbl_Apertura.Name = "lbl_Apertura";
            this.lbl_Apertura.Size = new System.Drawing.Size(92, 21);
            this.lbl_Apertura.TabIndex = 10;
            this.lbl_Apertura.Text = "Fecha Apertura";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(261, 276);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 30);
            this.btn_Agregar.TabIndex = 11;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_Actualizar_Cuenta
            // 
            this.lbl_Actualizar_Cuenta.AutoSize = true;
            this.lbl_Actualizar_Cuenta.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Actualizar_Cuenta.Location = new System.Drawing.Point(239, 17);
            this.lbl_Actualizar_Cuenta.Name = "lbl_Actualizar_Cuenta";
            this.lbl_Actualizar_Cuenta.Size = new System.Drawing.Size(127, 26);
            this.lbl_Actualizar_Cuenta.TabIndex = 2;
            this.lbl_Actualizar_Cuenta.Text = "Actualizar Cuenta";
            // 
            // lbl_Fecha_Act
            // 
            this.lbl_Fecha_Act.AutoSize = true;
            this.lbl_Fecha_Act.Location = new System.Drawing.Point(183, 261);
            this.lbl_Fecha_Act.Name = "lbl_Fecha_Act";
            this.lbl_Fecha_Act.Size = new System.Drawing.Size(92, 21);
            this.lbl_Fecha_Act.TabIndex = 20;
            this.lbl_Fecha_Act.Text = "Fecha Apertura";
            // 
            // dtp_Fecha_Act
            // 
            this.dtp_Fecha_Act.Location = new System.Drawing.Point(281, 255);
            this.dtp_Fecha_Act.Name = "dtp_Fecha_Act";
            this.dtp_Fecha_Act.Size = new System.Drawing.Size(225, 29);
            this.dtp_Fecha_Act.TabIndex = 19;
            // 
            // cb_CE_Act
            // 
            this.cb_CE_Act.FormattingEnabled = true;
            this.cb_CE_Act.Location = new System.Drawing.Point(422, 180);
            this.cb_CE_Act.Name = "cb_CE_Act";
            this.cb_CE_Act.Size = new System.Drawing.Size(123, 29);
            this.cb_CE_Act.TabIndex = 18;
            // 
            // lbl_CE_Act
            // 
            this.lbl_CE_Act.AutoSize = true;
            this.lbl_CE_Act.Location = new System.Drawing.Point(315, 183);
            this.lbl_CE_Act.Name = "lbl_CE_Act";
            this.lbl_CE_Act.Size = new System.Drawing.Size(101, 21);
            this.lbl_CE_Act.TabIndex = 17;
            this.lbl_CE_Act.Text = "Código Empleado";
            // 
            // txt_Ahorro_Act
            // 
            this.txt_Ahorro_Act.Location = new System.Drawing.Point(184, 180);
            this.txt_Ahorro_Act.Mask = "9999999999";
            this.txt_Ahorro_Act.Name = "txt_Ahorro_Act";
            this.txt_Ahorro_Act.Size = new System.Drawing.Size(100, 29);
            this.txt_Ahorro_Act.TabIndex = 16;
            // 
            // lbl_Ahorro_Act
            // 
            this.lbl_Ahorro_Act.AutoSize = true;
            this.lbl_Ahorro_Act.Location = new System.Drawing.Point(83, 183);
            this.lbl_Ahorro_Act.Name = "lbl_Ahorro_Act";
            this.lbl_Ahorro_Act.Size = new System.Drawing.Size(95, 21);
            this.lbl_Ahorro_Act.TabIndex = 15;
            this.lbl_Ahorro_Act.Text = "Ahorro Mensual";
            // 
            // txt_Tipo_Act
            // 
            this.txt_Tipo_Act.Location = new System.Drawing.Point(409, 117);
            this.txt_Tipo_Act.Name = "txt_Tipo_Act";
            this.txt_Tipo_Act.Size = new System.Drawing.Size(136, 29);
            this.txt_Tipo_Act.TabIndex = 14;
            // 
            // lbl_Tipo_Act
            // 
            this.lbl_Tipo_Act.AutoSize = true;
            this.lbl_Tipo_Act.Location = new System.Drawing.Point(330, 120);
            this.lbl_Tipo_Act.Name = "lbl_Tipo_Act";
            this.lbl_Tipo_Act.Size = new System.Drawing.Size(73, 21);
            this.lbl_Tipo_Act.TabIndex = 13;
            this.lbl_Tipo_Act.Text = "Tipo Cuenta";
            // 
            // txt_Saldo_Act
            // 
            this.txt_Saldo_Act.Location = new System.Drawing.Point(184, 117);
            this.txt_Saldo_Act.Mask = "9999999999";
            this.txt_Saldo_Act.Name = "txt_Saldo_Act";
            this.txt_Saldo_Act.Size = new System.Drawing.Size(100, 29);
            this.txt_Saldo_Act.TabIndex = 12;
            // 
            // lbl_Saldo_Act
            // 
            this.lbl_Saldo_Act.AutoSize = true;
            this.lbl_Saldo_Act.Location = new System.Drawing.Point(98, 120);
            this.lbl_Saldo_Act.Name = "lbl_Saldo_Act";
            this.lbl_Saldo_Act.Size = new System.Drawing.Size(80, 21);
            this.lbl_Saldo_Act.TabIndex = 11;
            this.lbl_Saldo_Act.Text = "Saldo Cuenta";
            // 
            // cb_NC
            // 
            this.cb_NC.FormattingEnabled = true;
            this.cb_NC.Location = new System.Drawing.Point(309, 63);
            this.cb_NC.Name = "cb_NC";
            this.cb_NC.Size = new System.Drawing.Size(123, 29);
            this.cb_NC.TabIndex = 22;
            // 
            // lbl_NC
            // 
            this.lbl_NC.AutoSize = true;
            this.lbl_NC.Location = new System.Drawing.Point(202, 66);
            this.lbl_NC.Name = "lbl_NC";
            this.lbl_NC.Size = new System.Drawing.Size(93, 21);
            this.lbl_NC.TabIndex = 21;
            this.lbl_NC.Text = "Número Cuenta";
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(281, 305);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(75, 30);
            this.btn_Actualizar.TabIndex = 23;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // cb_Filtro
            // 
            this.cb_Filtro.FormattingEnabled = true;
            this.cb_Filtro.Location = new System.Drawing.Point(136, 70);
            this.cb_Filtro.Name = "cb_Filtro";
            this.cb_Filtro.Size = new System.Drawing.Size(164, 29);
            this.cb_Filtro.TabIndex = 24;
            // 
            // lbl_Filtro
            // 
            this.lbl_Filtro.AutoSize = true;
            this.lbl_Filtro.Location = new System.Drawing.Point(29, 73);
            this.lbl_Filtro.Name = "lbl_Filtro";
            this.lbl_Filtro.Size = new System.Drawing.Size(94, 21);
            this.lbl_Filtro.TabIndex = 23;
            this.lbl_Filtro.Text = "Filtro Búsqueda";
            // 
            // lbl_Buscar_Cuenta
            // 
            this.lbl_Buscar_Cuenta.AutoSize = true;
            this.lbl_Buscar_Cuenta.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar_Cuenta.Location = new System.Drawing.Point(257, 21);
            this.lbl_Buscar_Cuenta.Name = "lbl_Buscar_Cuenta";
            this.lbl_Buscar_Cuenta.Size = new System.Drawing.Size(108, 26);
            this.lbl_Buscar_Cuenta.TabIndex = 25;
            this.lbl_Buscar_Cuenta.Text = "Buscar Cuenta";
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(326, 73);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(95, 21);
            this.lbl_Valor.TabIndex = 26;
            this.lbl_Valor.Text = "Valor Búsqueda";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(427, 70);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(174, 29);
            this.txt_Valor.TabIndex = 27;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(275, 114);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 29);
            this.btn_Buscar.TabIndex = 28;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dgv_Cuentas
            // 
            this.dgv_Cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cuentas.Location = new System.Drawing.Point(3, 149);
            this.dgv_Cuentas.Name = "dgv_Cuentas";
            this.dgv_Cuentas.Size = new System.Drawing.Size(627, 191);
            this.dgv_Cuentas.TabIndex = 29;
            // 
            // lbl_Eliminar
            // 
            this.lbl_Eliminar.AutoSize = true;
            this.lbl_Eliminar.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Eliminar.Location = new System.Drawing.Point(251, 69);
            this.lbl_Eliminar.Name = "lbl_Eliminar";
            this.lbl_Eliminar.Size = new System.Drawing.Size(116, 26);
            this.lbl_Eliminar.TabIndex = 26;
            this.lbl_Eliminar.Text = "Eliminar Cuenta";
            // 
            // cb_NC_Eliminar
            // 
            this.cb_NC_Eliminar.FormattingEnabled = true;
            this.cb_NC_Eliminar.Location = new System.Drawing.Point(312, 142);
            this.cb_NC_Eliminar.Name = "cb_NC_Eliminar";
            this.cb_NC_Eliminar.Size = new System.Drawing.Size(123, 29);
            this.cb_NC_Eliminar.TabIndex = 28;
            // 
            // lbl_NC_Eliminar
            // 
            this.lbl_NC_Eliminar.AutoSize = true;
            this.lbl_NC_Eliminar.Location = new System.Drawing.Point(205, 145);
            this.lbl_NC_Eliminar.Name = "lbl_NC_Eliminar";
            this.lbl_NC_Eliminar.Size = new System.Drawing.Size(93, 21);
            this.lbl_NC_Eliminar.TabIndex = 27;
            this.lbl_NC_Eliminar.Text = "Número Cuenta";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(269, 205);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 30);
            this.btn_Eliminar.TabIndex = 29;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // FormCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 435);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormCuentas";
            this.Text = "FormCuentas";
            this.Load += new System.EventHandler(this.FormCuentas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Insertar.ResumeLayout(false);
            this.tab_Insertar.PerformLayout();
            this.tab_Actualizar.ResumeLayout(false);
            this.tab_Actualizar.PerformLayout();
            this.tab_Buscar.ResumeLayout(false);
            this.tab_Buscar.PerformLayout();
            this.tab_Eliminar.ResumeLayout(false);
            this.tab_Eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Insertar;
        private System.Windows.Forms.Label lbl_Ahorro;
        private System.Windows.Forms.TextBox txt_Tipo;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.MaskedTextBox txt_Saldo;
        private System.Windows.Forms.Label lbl_Agregar_Cuenta;
        private System.Windows.Forms.Label lbl_Saldo;
        private System.Windows.Forms.TabPage tab_Actualizar;
        private System.Windows.Forms.TabPage tab_Buscar;
        private System.Windows.Forms.TabPage tab_Eliminar;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_Apertura;
        private System.Windows.Forms.DateTimePicker dtp_Apertura;
        private System.Windows.Forms.ComboBox cb_CE;
        private System.Windows.Forms.Label lbl_CE;
        private System.Windows.Forms.MaskedTextBox txt_Ahorro;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.ComboBox cb_NC;
        private System.Windows.Forms.Label lbl_NC;
        private System.Windows.Forms.Label lbl_Fecha_Act;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Act;
        private System.Windows.Forms.ComboBox cb_CE_Act;
        private System.Windows.Forms.Label lbl_CE_Act;
        private System.Windows.Forms.MaskedTextBox txt_Ahorro_Act;
        private System.Windows.Forms.Label lbl_Ahorro_Act;
        private System.Windows.Forms.TextBox txt_Tipo_Act;
        private System.Windows.Forms.Label lbl_Tipo_Act;
        private System.Windows.Forms.MaskedTextBox txt_Saldo_Act;
        private System.Windows.Forms.Label lbl_Saldo_Act;
        private System.Windows.Forms.Label lbl_Actualizar_Cuenta;
        private System.Windows.Forms.DataGridView dgv_Cuentas;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.Label lbl_Buscar_Cuenta;
        private System.Windows.Forms.ComboBox cb_Filtro;
        private System.Windows.Forms.Label lbl_Filtro;
        private System.Windows.Forms.Label lbl_Eliminar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.ComboBox cb_NC_Eliminar;
        private System.Windows.Forms.Label lbl_NC_Eliminar;
    }
}