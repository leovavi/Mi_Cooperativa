namespace MiCooperativa
{
    partial class Roles_Privilegios
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
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_Priv = new System.Windows.Forms.Label();
            this.lbl_Roles_Agregar = new System.Windows.Forms.Label();
            this.tab_Actualizar = new System.Windows.Forms.TabPage();
            this.cb_PV_Act = new System.Windows.Forms.ComboBox();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.lbl_RV_Act = new System.Windows.Forms.Label();
            this.lbl_ID_Priv_Viejo = new System.Windows.Forms.Label();
            this.lbl_Actualizar = new System.Windows.Forms.Label();
            this.tab_Buscar = new System.Windows.Forms.TabPage();
            this.dgv_RP = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.cb_Filtro = new System.Windows.Forms.ComboBox();
            this.lbl_Filtro = new System.Windows.Forms.Label();
            this.lbl_Busqueda = new System.Windows.Forms.Label();
            this.tab_Eliminar = new System.Windows.Forms.TabPage();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.lbl_Eliminar = new System.Windows.Forms.Label();
            this.cb_Priv_Eliminar = new System.Windows.Forms.ComboBox();
            this.lbl_Priv_Eliminar = new System.Windows.Forms.Label();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.lbl_User = new System.Windows.Forms.Label();
            this.cb_ID_Priv = new System.Windows.Forms.ComboBox();
            this.cb_ID_Rol = new System.Windows.Forms.ComboBox();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.cb_RV_Act = new System.Windows.Forms.ComboBox();
            this.cb_RN_Act = new System.Windows.Forms.ComboBox();
            this.cb_PN_Act = new System.Windows.Forms.ComboBox();
            this.lbl_RN_Act = new System.Windows.Forms.Label();
            this.lbl_PN_Act = new System.Windows.Forms.Label();
            this.cb_Rol_Eliminar = new System.Windows.Forms.ComboBox();
            this.lbl_Rol_Eliminar = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_Insertar.SuspendLayout();
            this.tab_Actualizar.SuspendLayout();
            this.tab_Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RP)).BeginInit();
            this.tab_Eliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Insertar);
            this.tabControl1.Controls.Add(this.tab_Actualizar);
            this.tabControl1.Controls.Add(this.tab_Buscar);
            this.tabControl1.Controls.Add(this.tab_Eliminar);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 389);
            this.tabControl1.TabIndex = 11;
            // 
            // tab_Insertar
            // 
            this.tab_Insertar.Controls.Add(this.cb_ID_Rol);
            this.tab_Insertar.Controls.Add(this.lbl_Rol);
            this.tab_Insertar.Controls.Add(this.cb_ID_Priv);
            this.tab_Insertar.Controls.Add(this.btn_Agregar);
            this.tab_Insertar.Controls.Add(this.lbl_Priv);
            this.tab_Insertar.Controls.Add(this.lbl_Roles_Agregar);
            this.tab_Insertar.Location = new System.Drawing.Point(4, 30);
            this.tab_Insertar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tab_Insertar.Name = "tab_Insertar";
            this.tab_Insertar.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tab_Insertar.Size = new System.Drawing.Size(609, 355);
            this.tab_Insertar.TabIndex = 0;
            this.tab_Insertar.Text = "Insertar";
            this.tab_Insertar.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(253, 244);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(87, 30);
            this.btn_Agregar.TabIndex = 5;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_Priv
            // 
            this.lbl_Priv.AutoSize = true;
            this.lbl_Priv.Location = new System.Drawing.Point(172, 133);
            this.lbl_Priv.Name = "lbl_Priv";
            this.lbl_Priv.Size = new System.Drawing.Size(75, 21);
            this.lbl_Priv.TabIndex = 3;
            this.lbl_Priv.Text = "ID Privilegio";
            // 
            // lbl_Roles_Agregar
            // 
            this.lbl_Roles_Agregar.AutoSize = true;
            this.lbl_Roles_Agregar.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roles_Agregar.Location = new System.Drawing.Point(221, 55);
            this.lbl_Roles_Agregar.Name = "lbl_Roles_Agregar";
            this.lbl_Roles_Agregar.Size = new System.Drawing.Size(159, 26);
            this.lbl_Roles_Agregar.TabIndex = 0;
            this.lbl_Roles_Agregar.Text = "Agregar Rol-Privilegio";
            // 
            // tab_Actualizar
            // 
            this.tab_Actualizar.Controls.Add(this.cb_RN_Act);
            this.tab_Actualizar.Controls.Add(this.cb_PN_Act);
            this.tab_Actualizar.Controls.Add(this.lbl_RN_Act);
            this.tab_Actualizar.Controls.Add(this.lbl_PN_Act);
            this.tab_Actualizar.Controls.Add(this.cb_RV_Act);
            this.tab_Actualizar.Controls.Add(this.cb_PV_Act);
            this.tab_Actualizar.Controls.Add(this.btn_Actualizar);
            this.tab_Actualizar.Controls.Add(this.lbl_RV_Act);
            this.tab_Actualizar.Controls.Add(this.lbl_ID_Priv_Viejo);
            this.tab_Actualizar.Controls.Add(this.lbl_Actualizar);
            this.tab_Actualizar.Location = new System.Drawing.Point(4, 30);
            this.tab_Actualizar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tab_Actualizar.Name = "tab_Actualizar";
            this.tab_Actualizar.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tab_Actualizar.Size = new System.Drawing.Size(609, 355);
            this.tab_Actualizar.TabIndex = 1;
            this.tab_Actualizar.Text = "Actualizar";
            this.tab_Actualizar.UseVisualStyleBackColor = true;
            // 
            // cb_PV_Act
            // 
            this.cb_PV_Act.FormattingEnabled = true;
            this.cb_PV_Act.Location = new System.Drawing.Point(151, 136);
            this.cb_PV_Act.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cb_PV_Act.Name = "cb_PV_Act";
            this.cb_PV_Act.Size = new System.Drawing.Size(132, 29);
            this.cb_PV_Act.TabIndex = 11;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(258, 255);
            this.btn_Actualizar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(87, 28);
            this.btn_Actualizar.TabIndex = 10;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // lbl_RV_Act
            // 
            this.lbl_RV_Act.AutoSize = true;
            this.lbl_RV_Act.Location = new System.Drawing.Point(74, 189);
            this.lbl_RV_Act.Name = "lbl_RV_Act";
            this.lbl_RV_Act.Size = new System.Drawing.Size(71, 21);
            this.lbl_RV_Act.TabIndex = 8;
            this.lbl_RV_Act.Text = "ID Rol Viejo";
            // 
            // lbl_ID_Priv_Viejo
            // 
            this.lbl_ID_Priv_Viejo.AutoSize = true;
            this.lbl_ID_Priv_Viejo.Location = new System.Drawing.Point(41, 139);
            this.lbl_ID_Priv_Viejo.Name = "lbl_ID_Priv_Viejo";
            this.lbl_ID_Priv_Viejo.Size = new System.Drawing.Size(104, 21);
            this.lbl_ID_Priv_Viejo.TabIndex = 6;
            this.lbl_ID_Priv_Viejo.Text = "ID Privilegio Viejo";
            // 
            // lbl_Actualizar
            // 
            this.lbl_Actualizar.AutoSize = true;
            this.lbl_Actualizar.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Actualizar.Location = new System.Drawing.Point(216, 58);
            this.lbl_Actualizar.Name = "lbl_Actualizar";
            this.lbl_Actualizar.Size = new System.Drawing.Size(171, 26);
            this.lbl_Actualizar.TabIndex = 1;
            this.lbl_Actualizar.Text = "Actualizar Rol-Privilegio";
            // 
            // tab_Buscar
            // 
            this.tab_Buscar.Controls.Add(this.dgv_RP);
            this.tab_Buscar.Controls.Add(this.btn_Buscar);
            this.tab_Buscar.Controls.Add(this.txt_Valor);
            this.tab_Buscar.Controls.Add(this.lbl_Valor);
            this.tab_Buscar.Controls.Add(this.cb_Filtro);
            this.tab_Buscar.Controls.Add(this.lbl_Filtro);
            this.tab_Buscar.Controls.Add(this.lbl_Busqueda);
            this.tab_Buscar.Location = new System.Drawing.Point(4, 30);
            this.tab_Buscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tab_Buscar.Name = "tab_Buscar";
            this.tab_Buscar.Size = new System.Drawing.Size(609, 355);
            this.tab_Buscar.TabIndex = 2;
            this.tab_Buscar.Text = "Buscar";
            this.tab_Buscar.UseVisualStyleBackColor = true;
            // 
            // dgv_RP
            // 
            this.dgv_RP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RP.Location = new System.Drawing.Point(19, 143);
            this.dgv_RP.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgv_RP.Name = "dgv_RP";
            this.dgv_RP.Size = new System.Drawing.Size(568, 207);
            this.dgv_RP.TabIndex = 17;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(248, 104);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(87, 29);
            this.btn_Buscar.TabIndex = 16;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(405, 65);
            this.txt_Valor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(177, 29);
            this.txt_Valor.TabIndex = 15;
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(304, 69);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(95, 21);
            this.lbl_Valor.TabIndex = 14;
            this.lbl_Valor.Text = "Valor Búsqueda";
            // 
            // cb_Filtro
            // 
            this.cb_Filtro.FormattingEnabled = true;
            this.cb_Filtro.Location = new System.Drawing.Point(124, 65);
            this.cb_Filtro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cb_Filtro.Name = "cb_Filtro";
            this.cb_Filtro.Size = new System.Drawing.Size(151, 29);
            this.cb_Filtro.TabIndex = 13;
            // 
            // lbl_Filtro
            // 
            this.lbl_Filtro.AutoSize = true;
            this.lbl_Filtro.Location = new System.Drawing.Point(24, 69);
            this.lbl_Filtro.Name = "lbl_Filtro";
            this.lbl_Filtro.Size = new System.Drawing.Size(94, 21);
            this.lbl_Filtro.TabIndex = 12;
            this.lbl_Filtro.Text = "Filtro Búsqueda";
            // 
            // lbl_Busqueda
            // 
            this.lbl_Busqueda.AutoSize = true;
            this.lbl_Busqueda.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Busqueda.Location = new System.Drawing.Point(232, 18);
            this.lbl_Busqueda.Name = "lbl_Busqueda";
            this.lbl_Busqueda.Size = new System.Drawing.Size(152, 26);
            this.lbl_Busqueda.TabIndex = 2;
            this.lbl_Busqueda.Text = "Buscar Rol-Privilegio";
            // 
            // tab_Eliminar
            // 
            this.tab_Eliminar.Controls.Add(this.cb_Rol_Eliminar);
            this.tab_Eliminar.Controls.Add(this.lbl_Rol_Eliminar);
            this.tab_Eliminar.Controls.Add(this.btn_Eliminar);
            this.tab_Eliminar.Controls.Add(this.lbl_Eliminar);
            this.tab_Eliminar.Controls.Add(this.cb_Priv_Eliminar);
            this.tab_Eliminar.Controls.Add(this.lbl_Priv_Eliminar);
            this.tab_Eliminar.Location = new System.Drawing.Point(4, 30);
            this.tab_Eliminar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tab_Eliminar.Name = "tab_Eliminar";
            this.tab_Eliminar.Size = new System.Drawing.Size(609, 355);
            this.tab_Eliminar.TabIndex = 3;
            this.tab_Eliminar.Text = "Eliminar";
            this.tab_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(256, 251);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(87, 28);
            this.btn_Eliminar.TabIndex = 17;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // lbl_Eliminar
            // 
            this.lbl_Eliminar.AutoSize = true;
            this.lbl_Eliminar.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Eliminar.Location = new System.Drawing.Point(229, 68);
            this.lbl_Eliminar.Name = "lbl_Eliminar";
            this.lbl_Eliminar.Size = new System.Drawing.Size(160, 26);
            this.lbl_Eliminar.TabIndex = 16;
            this.lbl_Eliminar.Text = "Eliminar Rol-Privilegio";
            // 
            // cb_Priv_Eliminar
            // 
            this.cb_Priv_Eliminar.FormattingEnabled = true;
            this.cb_Priv_Eliminar.Location = new System.Drawing.Point(256, 132);
            this.cb_Priv_Eliminar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cb_Priv_Eliminar.Name = "cb_Priv_Eliminar";
            this.cb_Priv_Eliminar.Size = new System.Drawing.Size(151, 29);
            this.cb_Priv_Eliminar.TabIndex = 15;
            // 
            // lbl_Priv_Eliminar
            // 
            this.lbl_Priv_Eliminar.AutoSize = true;
            this.lbl_Priv_Eliminar.Location = new System.Drawing.Point(175, 135);
            this.lbl_Priv_Eliminar.Name = "lbl_Priv_Eliminar";
            this.lbl_Priv_Eliminar.Size = new System.Drawing.Size(75, 21);
            this.lbl_Priv_Eliminar.TabIndex = 14;
            this.lbl_Priv_Eliminar.Text = "ID Privilegio";
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(523, 400);
            this.btn_Atras.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(87, 26);
            this.btn_Atras.TabIndex = 10;
            this.btn_Atras.Text = "Atrás";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(12, 405);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(88, 21);
            this.lbl_User.TabIndex = 9;
            this.lbl_User.Text = "lblUserLogged";
            // 
            // cb_ID_Priv
            // 
            this.cb_ID_Priv.FormattingEnabled = true;
            this.cb_ID_Priv.Location = new System.Drawing.Point(253, 130);
            this.cb_ID_Priv.Name = "cb_ID_Priv";
            this.cb_ID_Priv.Size = new System.Drawing.Size(137, 29);
            this.cb_ID_Priv.TabIndex = 6;
            // 
            // cb_ID_Rol
            // 
            this.cb_ID_Rol.FormattingEnabled = true;
            this.cb_ID_Rol.Location = new System.Drawing.Point(253, 184);
            this.cb_ID_Rol.Name = "cb_ID_Rol";
            this.cb_ID_Rol.Size = new System.Drawing.Size(137, 29);
            this.cb_ID_Rol.TabIndex = 8;
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Location = new System.Drawing.Point(205, 187);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(42, 21);
            this.lbl_Rol.TabIndex = 7;
            this.lbl_Rol.Text = "ID Rol";
            // 
            // cb_RV_Act
            // 
            this.cb_RV_Act.FormattingEnabled = true;
            this.cb_RV_Act.Location = new System.Drawing.Point(151, 186);
            this.cb_RV_Act.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cb_RV_Act.Name = "cb_RV_Act";
            this.cb_RV_Act.Size = new System.Drawing.Size(132, 29);
            this.cb_RV_Act.TabIndex = 12;
            // 
            // cb_RN_Act
            // 
            this.cb_RN_Act.FormattingEnabled = true;
            this.cb_RN_Act.Location = new System.Drawing.Point(420, 186);
            this.cb_RN_Act.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cb_RN_Act.Name = "cb_RN_Act";
            this.cb_RN_Act.Size = new System.Drawing.Size(132, 29);
            this.cb_RN_Act.TabIndex = 16;
            // 
            // cb_PN_Act
            // 
            this.cb_PN_Act.FormattingEnabled = true;
            this.cb_PN_Act.Location = new System.Drawing.Point(420, 136);
            this.cb_PN_Act.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cb_PN_Act.Name = "cb_PN_Act";
            this.cb_PN_Act.Size = new System.Drawing.Size(132, 29);
            this.cb_PN_Act.TabIndex = 15;
            // 
            // lbl_RN_Act
            // 
            this.lbl_RN_Act.AutoSize = true;
            this.lbl_RN_Act.Location = new System.Drawing.Point(336, 189);
            this.lbl_RN_Act.Name = "lbl_RN_Act";
            this.lbl_RN_Act.Size = new System.Drawing.Size(78, 21);
            this.lbl_RN_Act.TabIndex = 14;
            this.lbl_RN_Act.Text = "ID Rol Nuevo";
            // 
            // lbl_PN_Act
            // 
            this.lbl_PN_Act.AutoSize = true;
            this.lbl_PN_Act.Location = new System.Drawing.Point(303, 139);
            this.lbl_PN_Act.Name = "lbl_PN_Act";
            this.lbl_PN_Act.Size = new System.Drawing.Size(111, 21);
            this.lbl_PN_Act.TabIndex = 13;
            this.lbl_PN_Act.Text = "ID Privilegio Nuevo";
            // 
            // cb_Rol_Eliminar
            // 
            this.cb_Rol_Eliminar.FormattingEnabled = true;
            this.cb_Rol_Eliminar.Location = new System.Drawing.Point(256, 184);
            this.cb_Rol_Eliminar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cb_Rol_Eliminar.Name = "cb_Rol_Eliminar";
            this.cb_Rol_Eliminar.Size = new System.Drawing.Size(151, 29);
            this.cb_Rol_Eliminar.TabIndex = 19;
            // 
            // lbl_Rol_Eliminar
            // 
            this.lbl_Rol_Eliminar.AutoSize = true;
            this.lbl_Rol_Eliminar.Location = new System.Drawing.Point(208, 187);
            this.lbl_Rol_Eliminar.Name = "lbl_Rol_Eliminar";
            this.lbl_Rol_Eliminar.Size = new System.Drawing.Size(42, 21);
            this.lbl_Rol_Eliminar.TabIndex = 18;
            this.lbl_Rol_Eliminar.Text = "ID Rol";
            // 
            // Roles_Privilegios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 434);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.lbl_User);
            this.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Roles_Privilegios";
            this.Text = "Roles_Privilegios";
            this.Load += new System.EventHandler(this.Roles_Privilegios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Insertar.ResumeLayout(false);
            this.tab_Insertar.PerformLayout();
            this.tab_Actualizar.ResumeLayout(false);
            this.tab_Actualizar.PerformLayout();
            this.tab_Buscar.ResumeLayout(false);
            this.tab_Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RP)).EndInit();
            this.tab_Eliminar.ResumeLayout(false);
            this.tab_Eliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Insertar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_Priv;
        private System.Windows.Forms.Label lbl_Roles_Agregar;
        private System.Windows.Forms.TabPage tab_Actualizar;
        private System.Windows.Forms.ComboBox cb_PV_Act;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Label lbl_RV_Act;
        private System.Windows.Forms.Label lbl_ID_Priv_Viejo;
        private System.Windows.Forms.Label lbl_Actualizar;
        private System.Windows.Forms.TabPage tab_Buscar;
        private System.Windows.Forms.DataGridView dgv_RP;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.ComboBox cb_Filtro;
        private System.Windows.Forms.Label lbl_Filtro;
        private System.Windows.Forms.Label lbl_Busqueda;
        private System.Windows.Forms.TabPage tab_Eliminar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label lbl_Eliminar;
        private System.Windows.Forms.ComboBox cb_Priv_Eliminar;
        private System.Windows.Forms.Label lbl_Priv_Eliminar;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.ComboBox cb_ID_Rol;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.ComboBox cb_ID_Priv;
        private System.Windows.Forms.ComboBox cb_RN_Act;
        private System.Windows.Forms.ComboBox cb_PN_Act;
        private System.Windows.Forms.Label lbl_RN_Act;
        private System.Windows.Forms.Label lbl_PN_Act;
        private System.Windows.Forms.ComboBox cb_RV_Act;
        private System.Windows.Forms.ComboBox cb_Rol_Eliminar;
        private System.Windows.Forms.Label lbl_Rol_Eliminar;
    }
}