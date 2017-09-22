namespace MiCooperativa
{
    partial class FormUsuarios
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
            this.lbl_User = new System.Windows.Forms.Label();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Insertar = new System.Windows.Forms.TabPage();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Usuario_Agregar = new System.Windows.Forms.Label();
            this.tab_Actualizar = new System.Windows.Forms.TabPage();
            this.cb_User_Act = new System.Windows.Forms.ComboBox();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.txt_Pass_Act = new System.Windows.Forms.TextBox();
            this.lbl_Pass_Act = new System.Windows.Forms.Label();
            this.lbl_User_Act = new System.Windows.Forms.Label();
            this.lbl_Actualizar = new System.Windows.Forms.Label();
            this.tab_Buscar = new System.Windows.Forms.TabPage();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.cb_Filtro = new System.Windows.Forms.ComboBox();
            this.lbl_Filtro = new System.Windows.Forms.Label();
            this.lbl_Busqueda = new System.Windows.Forms.Label();
            this.tab_Eliminar = new System.Windows.Forms.TabPage();
            this.lbl_Eliminar = new System.Windows.Forms.Label();
            this.cb_User_Eliminar = new System.Windows.Forms.ComboBox();
            this.lbl_Usuario_Eliminar = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.dgv_User = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tab_Insertar.SuspendLayout();
            this.tab_Actualizar.SuspendLayout();
            this.tab_Buscar.SuspendLayout();
            this.tab_Eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(12, 378);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(88, 21);
            this.lbl_User.TabIndex = 0;
            this.lbl_User.Text = "lblUserLogged";
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(453, 375);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(75, 27);
            this.btn_Atras.TabIndex = 1;
            this.btn_Atras.Text = "Atrás";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Insertar);
            this.tabControl1.Controls.Add(this.tab_Actualizar);
            this.tabControl1.Controls.Add(this.tab_Buscar);
            this.tabControl1.Controls.Add(this.tab_Eliminar);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(529, 359);
            this.tabControl1.TabIndex = 2;
            // 
            // tab_Insertar
            // 
            this.tab_Insertar.Controls.Add(this.btn_Agregar);
            this.tab_Insertar.Controls.Add(this.txt_Pass);
            this.tab_Insertar.Controls.Add(this.lbl_Pass);
            this.tab_Insertar.Controls.Add(this.txt_User);
            this.tab_Insertar.Controls.Add(this.lbl_Usuario);
            this.tab_Insertar.Controls.Add(this.lbl_Usuario_Agregar);
            this.tab_Insertar.Location = new System.Drawing.Point(4, 30);
            this.tab_Insertar.Name = "tab_Insertar";
            this.tab_Insertar.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Insertar.Size = new System.Drawing.Size(521, 325);
            this.tab_Insertar.TabIndex = 0;
            this.tab_Insertar.Text = "Insertar";
            this.tab_Insertar.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(228, 243);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 28);
            this.btn_Agregar.TabIndex = 5;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(215, 173);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(152, 29);
            this.txt_Pass.TabIndex = 4;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(138, 176);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(71, 21);
            this.lbl_Pass.TabIndex = 3;
            this.lbl_Pass.Text = "Contraseña";
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(215, 119);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(152, 29);
            this.txt_User.TabIndex = 2;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(157, 122);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(52, 21);
            this.lbl_Usuario.TabIndex = 1;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Usuario_Agregar
            // 
            this.lbl_Usuario_Agregar.AutoSize = true;
            this.lbl_Usuario_Agregar.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario_Agregar.Location = new System.Drawing.Point(198, 50);
            this.lbl_Usuario_Agregar.Name = "lbl_Usuario_Agregar";
            this.lbl_Usuario_Agregar.Size = new System.Drawing.Size(120, 26);
            this.lbl_Usuario_Agregar.TabIndex = 0;
            this.lbl_Usuario_Agregar.Text = "Agregar Usuario";
            // 
            // tab_Actualizar
            // 
            this.tab_Actualizar.Controls.Add(this.cb_User_Act);
            this.tab_Actualizar.Controls.Add(this.btn_Actualizar);
            this.tab_Actualizar.Controls.Add(this.txt_Pass_Act);
            this.tab_Actualizar.Controls.Add(this.lbl_Pass_Act);
            this.tab_Actualizar.Controls.Add(this.lbl_User_Act);
            this.tab_Actualizar.Controls.Add(this.lbl_Actualizar);
            this.tab_Actualizar.Location = new System.Drawing.Point(4, 30);
            this.tab_Actualizar.Name = "tab_Actualizar";
            this.tab_Actualizar.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Actualizar.Size = new System.Drawing.Size(521, 325);
            this.tab_Actualizar.TabIndex = 1;
            this.tab_Actualizar.Text = "Actualizar";
            this.tab_Actualizar.UseVisualStyleBackColor = true;
            // 
            // cb_User_Act
            // 
            this.cb_User_Act.FormattingEnabled = true;
            this.cb_User_Act.Location = new System.Drawing.Point(216, 122);
            this.cb_User_Act.Name = "cb_User_Act";
            this.cb_User_Act.Size = new System.Drawing.Size(152, 29);
            this.cb_User_Act.TabIndex = 11;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(216, 247);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(75, 28);
            this.btn_Actualizar.TabIndex = 10;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // txt_Pass_Act
            // 
            this.txt_Pass_Act.Location = new System.Drawing.Point(216, 176);
            this.txt_Pass_Act.Name = "txt_Pass_Act";
            this.txt_Pass_Act.Size = new System.Drawing.Size(152, 29);
            this.txt_Pass_Act.TabIndex = 9;
            // 
            // lbl_Pass_Act
            // 
            this.lbl_Pass_Act.AutoSize = true;
            this.lbl_Pass_Act.Location = new System.Drawing.Point(103, 179);
            this.lbl_Pass_Act.Name = "lbl_Pass_Act";
            this.lbl_Pass_Act.Size = new System.Drawing.Size(107, 21);
            this.lbl_Pass_Act.TabIndex = 8;
            this.lbl_Pass_Act.Text = "Nueva Contraseña";
            // 
            // lbl_User_Act
            // 
            this.lbl_User_Act.AutoSize = true;
            this.lbl_User_Act.Location = new System.Drawing.Point(158, 125);
            this.lbl_User_Act.Name = "lbl_User_Act";
            this.lbl_User_Act.Size = new System.Drawing.Size(52, 21);
            this.lbl_User_Act.TabIndex = 6;
            this.lbl_User_Act.Text = "Usuario";
            // 
            // lbl_Actualizar
            // 
            this.lbl_Actualizar.AutoSize = true;
            this.lbl_Actualizar.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Actualizar.Location = new System.Drawing.Point(181, 43);
            this.lbl_Actualizar.Name = "lbl_Actualizar";
            this.lbl_Actualizar.Size = new System.Drawing.Size(132, 26);
            this.lbl_Actualizar.TabIndex = 1;
            this.lbl_Actualizar.Text = "Actualizar Usuario";
            // 
            // tab_Buscar
            // 
            this.tab_Buscar.Controls.Add(this.dgv_User);
            this.tab_Buscar.Controls.Add(this.btn_Buscar);
            this.tab_Buscar.Controls.Add(this.txt_Valor);
            this.tab_Buscar.Controls.Add(this.lbl_Valor);
            this.tab_Buscar.Controls.Add(this.cb_Filtro);
            this.tab_Buscar.Controls.Add(this.lbl_Filtro);
            this.tab_Buscar.Controls.Add(this.lbl_Busqueda);
            this.tab_Buscar.Location = new System.Drawing.Point(4, 30);
            this.tab_Buscar.Name = "tab_Buscar";
            this.tab_Buscar.Size = new System.Drawing.Size(521, 325);
            this.tab_Buscar.TabIndex = 2;
            this.tab_Buscar.Text = "Buscar";
            this.tab_Buscar.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(213, 106);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 29);
            this.btn_Buscar.TabIndex = 16;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(360, 61);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(152, 29);
            this.txt_Valor.TabIndex = 15;
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(259, 64);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(95, 21);
            this.lbl_Valor.TabIndex = 14;
            this.lbl_Valor.Text = "Valor Búsqueda";
            // 
            // cb_Filtro
            // 
            this.cb_Filtro.FormattingEnabled = true;
            this.cb_Filtro.Location = new System.Drawing.Point(105, 61);
            this.cb_Filtro.Name = "cb_Filtro";
            this.cb_Filtro.Size = new System.Drawing.Size(130, 29);
            this.cb_Filtro.TabIndex = 13;
            // 
            // lbl_Filtro
            // 
            this.lbl_Filtro.AutoSize = true;
            this.lbl_Filtro.Location = new System.Drawing.Point(5, 64);
            this.lbl_Filtro.Name = "lbl_Filtro";
            this.lbl_Filtro.Size = new System.Drawing.Size(94, 21);
            this.lbl_Filtro.TabIndex = 12;
            this.lbl_Filtro.Text = "Filtro Búsqueda";
            // 
            // lbl_Busqueda
            // 
            this.lbl_Busqueda.AutoSize = true;
            this.lbl_Busqueda.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Busqueda.Location = new System.Drawing.Point(198, 17);
            this.lbl_Busqueda.Name = "lbl_Busqueda";
            this.lbl_Busqueda.Size = new System.Drawing.Size(113, 26);
            this.lbl_Busqueda.TabIndex = 2;
            this.lbl_Busqueda.Text = "Buscar Usuario";
            // 
            // tab_Eliminar
            // 
            this.tab_Eliminar.Controls.Add(this.btn_Eliminar);
            this.tab_Eliminar.Controls.Add(this.lbl_Eliminar);
            this.tab_Eliminar.Controls.Add(this.cb_User_Eliminar);
            this.tab_Eliminar.Controls.Add(this.lbl_Usuario_Eliminar);
            this.tab_Eliminar.Location = new System.Drawing.Point(4, 30);
            this.tab_Eliminar.Name = "tab_Eliminar";
            this.tab_Eliminar.Size = new System.Drawing.Size(521, 325);
            this.tab_Eliminar.TabIndex = 3;
            this.tab_Eliminar.Text = "Eliminar";
            this.tab_Eliminar.UseVisualStyleBackColor = true;
            // 
            // lbl_Eliminar
            // 
            this.lbl_Eliminar.AutoSize = true;
            this.lbl_Eliminar.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Eliminar.Location = new System.Drawing.Point(207, 48);
            this.lbl_Eliminar.Name = "lbl_Eliminar";
            this.lbl_Eliminar.Size = new System.Drawing.Size(121, 26);
            this.lbl_Eliminar.TabIndex = 16;
            this.lbl_Eliminar.Text = "Eliminar Usuario";
            // 
            // cb_User_Eliminar
            // 
            this.cb_User_Eliminar.FormattingEnabled = true;
            this.cb_User_Eliminar.Location = new System.Drawing.Point(233, 132);
            this.cb_User_Eliminar.Name = "cb_User_Eliminar";
            this.cb_User_Eliminar.Size = new System.Drawing.Size(130, 29);
            this.cb_User_Eliminar.TabIndex = 15;
            // 
            // lbl_Usuario_Eliminar
            // 
            this.lbl_Usuario_Eliminar.AutoSize = true;
            this.lbl_Usuario_Eliminar.Location = new System.Drawing.Point(160, 135);
            this.lbl_Usuario_Eliminar.Name = "lbl_Usuario_Eliminar";
            this.lbl_Usuario_Eliminar.Size = new System.Drawing.Size(67, 21);
            this.lbl_Usuario_Eliminar.TabIndex = 14;
            this.lbl_Usuario_Eliminar.Text = "ID Usuario";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(233, 212);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 28);
            this.btn_Eliminar.TabIndex = 17;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // dgv_User
            // 
            this.dgv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_User.Location = new System.Drawing.Point(22, 141);
            this.dgv_User.Name = "dgv_User";
            this.dgv_User.Size = new System.Drawing.Size(478, 166);
            this.dgv_User.TabIndex = 17;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 411);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.lbl_User);
            this.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Insertar.ResumeLayout(false);
            this.tab_Insertar.PerformLayout();
            this.tab_Actualizar.ResumeLayout(false);
            this.tab_Actualizar.PerformLayout();
            this.tab_Buscar.ResumeLayout(false);
            this.tab_Buscar.PerformLayout();
            this.tab_Eliminar.ResumeLayout(false);
            this.tab_Eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Insertar;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Usuario_Agregar;
        private System.Windows.Forms.TabPage tab_Actualizar;
        private System.Windows.Forms.TabPage tab_Buscar;
        private System.Windows.Forms.TabPage tab_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.ComboBox cb_User_Act;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.TextBox txt_Pass_Act;
        private System.Windows.Forms.Label lbl_Pass_Act;
        private System.Windows.Forms.Label lbl_User_Act;
        private System.Windows.Forms.Label lbl_Actualizar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.ComboBox cb_Filtro;
        private System.Windows.Forms.Label lbl_Filtro;
        private System.Windows.Forms.Label lbl_Busqueda;
        private System.Windows.Forms.Label lbl_Eliminar;
        private System.Windows.Forms.ComboBox cb_User_Eliminar;
        private System.Windows.Forms.Label lbl_Usuario_Eliminar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.DataGridView dgv_User;
    }
}