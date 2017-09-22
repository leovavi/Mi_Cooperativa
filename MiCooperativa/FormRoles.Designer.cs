namespace MiCooperativa
{
    partial class FormRoles
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
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.lbl_Roles_Agregar = new System.Windows.Forms.Label();
            this.tab_Actualizar = new System.Windows.Forms.TabPage();
            this.cb_Rol_Act = new System.Windows.Forms.ComboBox();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.txt_Desc_Act = new System.Windows.Forms.TextBox();
            this.lbl_Desc_Act = new System.Windows.Forms.Label();
            this.lbl_ID_ROL = new System.Windows.Forms.Label();
            this.lbl_Actualizar = new System.Windows.Forms.Label();
            this.tab_Buscar = new System.Windows.Forms.TabPage();
            this.dgv_Rol = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.cb_Filtro = new System.Windows.Forms.ComboBox();
            this.lbl_Filtro = new System.Windows.Forms.Label();
            this.lbl_Busqueda = new System.Windows.Forms.Label();
            this.tab_Eliminar = new System.Windows.Forms.TabPage();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.lbl_Eliminar = new System.Windows.Forms.Label();
            this.cb_Rol_Eliminar = new System.Windows.Forms.ComboBox();
            this.lbl_Rol_Eliminar = new System.Windows.Forms.Label();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.lbl_User = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_Insertar.SuspendLayout();
            this.tab_Actualizar.SuspendLayout();
            this.tab_Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rol)).BeginInit();
            this.tab_Eliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Insertar);
            this.tabControl1.Controls.Add(this.tab_Actualizar);
            this.tabControl1.Controls.Add(this.tab_Buscar);
            this.tabControl1.Controls.Add(this.tab_Eliminar);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 389);
            this.tabControl1.TabIndex = 5;
            // 
            // tab_Insertar
            // 
            this.tab_Insertar.Controls.Add(this.btn_Agregar);
            this.tab_Insertar.Controls.Add(this.txt_Desc);
            this.tab_Insertar.Controls.Add(this.lbl_Desc);
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
            this.btn_Agregar.Location = new System.Drawing.Point(248, 223);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(87, 30);
            this.btn_Agregar.TabIndex = 5;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_Desc
            // 
            this.txt_Desc.Location = new System.Drawing.Point(248, 155);
            this.txt_Desc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(177, 29);
            this.txt_Desc.TabIndex = 4;
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.AutoSize = true;
            this.lbl_Desc.Location = new System.Drawing.Point(149, 158);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(93, 21);
            this.lbl_Desc.TabIndex = 3;
            this.lbl_Desc.Text = "Descripción Rol";
            // 
            // lbl_Roles_Agregar
            // 
            this.lbl_Roles_Agregar.AutoSize = true;
            this.lbl_Roles_Agregar.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roles_Agregar.Location = new System.Drawing.Point(243, 55);
            this.lbl_Roles_Agregar.Name = "lbl_Roles_Agregar";
            this.lbl_Roles_Agregar.Size = new System.Drawing.Size(91, 26);
            this.lbl_Roles_Agregar.TabIndex = 0;
            this.lbl_Roles_Agregar.Text = "Agregar Rol";
            // 
            // tab_Actualizar
            // 
            this.tab_Actualizar.Controls.Add(this.cb_Rol_Act);
            this.tab_Actualizar.Controls.Add(this.btn_Actualizar);
            this.tab_Actualizar.Controls.Add(this.txt_Desc_Act);
            this.tab_Actualizar.Controls.Add(this.lbl_Desc_Act);
            this.tab_Actualizar.Controls.Add(this.lbl_ID_ROL);
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
            // cb_Rol_Act
            // 
            this.cb_Rol_Act.FormattingEnabled = true;
            this.cb_Rol_Act.Location = new System.Drawing.Point(252, 131);
            this.cb_Rol_Act.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cb_Rol_Act.Name = "cb_Rol_Act";
            this.cb_Rol_Act.Size = new System.Drawing.Size(177, 29);
            this.cb_Rol_Act.TabIndex = 11;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(270, 253);
            this.btn_Actualizar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(87, 28);
            this.btn_Actualizar.TabIndex = 10;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // txt_Desc_Act
            // 
            this.txt_Desc_Act.Location = new System.Drawing.Point(252, 190);
            this.txt_Desc_Act.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_Desc_Act.Name = "txt_Desc_Act";
            this.txt_Desc_Act.Size = new System.Drawing.Size(177, 29);
            this.txt_Desc_Act.TabIndex = 9;
            // 
            // lbl_Desc_Act
            // 
            this.lbl_Desc_Act.AutoSize = true;
            this.lbl_Desc_Act.Location = new System.Drawing.Point(120, 195);
            this.lbl_Desc_Act.Name = "lbl_Desc_Act";
            this.lbl_Desc_Act.Size = new System.Drawing.Size(109, 21);
            this.lbl_Desc_Act.TabIndex = 8;
            this.lbl_Desc_Act.Text = "Nueva Descripción";
            // 
            // lbl_ID_ROL
            // 
            this.lbl_ID_ROL.AutoSize = true;
            this.lbl_ID_ROL.Location = new System.Drawing.Point(184, 136);
            this.lbl_ID_ROL.Name = "lbl_ID_ROL";
            this.lbl_ID_ROL.Size = new System.Drawing.Size(42, 21);
            this.lbl_ID_ROL.TabIndex = 6;
            this.lbl_ID_ROL.Text = "ID Rol";
            // 
            // lbl_Actualizar
            // 
            this.lbl_Actualizar.AutoSize = true;
            this.lbl_Actualizar.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Actualizar.Location = new System.Drawing.Point(254, 61);
            this.lbl_Actualizar.Name = "lbl_Actualizar";
            this.lbl_Actualizar.Size = new System.Drawing.Size(103, 26);
            this.lbl_Actualizar.TabIndex = 1;
            this.lbl_Actualizar.Text = "Actualizar Rol";
            // 
            // tab_Buscar
            // 
            this.tab_Buscar.Controls.Add(this.dgv_Rol);
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
            // dgv_Rol
            // 
            this.dgv_Rol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rol.Location = new System.Drawing.Point(19, 143);
            this.dgv_Rol.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgv_Rol.Name = "dgv_Rol";
            this.dgv_Rol.Size = new System.Drawing.Size(568, 207);
            this.dgv_Rol.TabIndex = 17;
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
            this.lbl_Busqueda.Location = new System.Drawing.Point(251, 18);
            this.lbl_Busqueda.Name = "lbl_Busqueda";
            this.lbl_Busqueda.Size = new System.Drawing.Size(84, 26);
            this.lbl_Busqueda.TabIndex = 2;
            this.lbl_Busqueda.Text = "Buscar Rol";
            // 
            // tab_Eliminar
            // 
            this.tab_Eliminar.Controls.Add(this.btn_Eliminar);
            this.tab_Eliminar.Controls.Add(this.lbl_Eliminar);
            this.tab_Eliminar.Controls.Add(this.cb_Rol_Eliminar);
            this.tab_Eliminar.Controls.Add(this.lbl_Rol_Eliminar);
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
            this.btn_Eliminar.Location = new System.Drawing.Point(256, 226);
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
            this.lbl_Eliminar.Location = new System.Drawing.Point(251, 74);
            this.lbl_Eliminar.Name = "lbl_Eliminar";
            this.lbl_Eliminar.Size = new System.Drawing.Size(92, 26);
            this.lbl_Eliminar.TabIndex = 16;
            this.lbl_Eliminar.Text = "Eliminar Rol";
            // 
            // cb_Rol_Eliminar
            // 
            this.cb_Rol_Eliminar.FormattingEnabled = true;
            this.cb_Rol_Eliminar.Location = new System.Drawing.Point(256, 151);
            this.cb_Rol_Eliminar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cb_Rol_Eliminar.Name = "cb_Rol_Eliminar";
            this.cb_Rol_Eliminar.Size = new System.Drawing.Size(151, 29);
            this.cb_Rol_Eliminar.TabIndex = 15;
            // 
            // lbl_Rol_Eliminar
            // 
            this.lbl_Rol_Eliminar.AutoSize = true;
            this.lbl_Rol_Eliminar.Location = new System.Drawing.Point(208, 154);
            this.lbl_Rol_Eliminar.Name = "lbl_Rol_Eliminar";
            this.lbl_Rol_Eliminar.Size = new System.Drawing.Size(42, 21);
            this.lbl_Rol_Eliminar.TabIndex = 14;
            this.lbl_Rol_Eliminar.Text = "ID Rol";
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(522, 402);
            this.btn_Atras.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(87, 30);
            this.btn_Atras.TabIndex = 4;
            this.btn_Atras.Text = "Atrás";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(12, 407);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(88, 21);
            this.lbl_User.TabIndex = 3;
            this.lbl_User.Text = "lblUserLogged";
            // 
            // FormRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 441);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.lbl_User);
            this.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormRoles";
            this.Text = "FormRoles";
            this.Load += new System.EventHandler(this.FormRoles_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Insertar.ResumeLayout(false);
            this.tab_Insertar.PerformLayout();
            this.tab_Actualizar.ResumeLayout(false);
            this.tab_Actualizar.PerformLayout();
            this.tab_Buscar.ResumeLayout(false);
            this.tab_Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rol)).EndInit();
            this.tab_Eliminar.ResumeLayout(false);
            this.tab_Eliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Insertar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txt_Desc;
        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.Label lbl_Roles_Agregar;
        private System.Windows.Forms.TabPage tab_Actualizar;
        private System.Windows.Forms.ComboBox cb_Rol_Act;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.TextBox txt_Desc_Act;
        private System.Windows.Forms.Label lbl_Desc_Act;
        private System.Windows.Forms.Label lbl_ID_ROL;
        private System.Windows.Forms.Label lbl_Actualizar;
        private System.Windows.Forms.TabPage tab_Buscar;
        private System.Windows.Forms.DataGridView dgv_Rol;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.ComboBox cb_Filtro;
        private System.Windows.Forms.Label lbl_Filtro;
        private System.Windows.Forms.Label lbl_Busqueda;
        private System.Windows.Forms.TabPage tab_Eliminar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label lbl_Eliminar;
        private System.Windows.Forms.ComboBox cb_Rol_Eliminar;
        private System.Windows.Forms.Label lbl_Rol_Eliminar;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Label lbl_User;
    }
}