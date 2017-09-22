namespace MiCooperativa
{
    partial class Administrador
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
            this.lbl_Mi_Cooperativa = new System.Windows.Forms.Label();
            this.btn_Abonos = new System.Windows.Forms.Button();
            this.btn_Cuentas = new System.Windows.Forms.Button();
            this.btn_Empleados = new System.Windows.Forms.Button();
            this.btn_Prestamos = new System.Windows.Forms.Button();
            this.btn_Pagos = new System.Windows.Forms.Button();
            this.btn_Ganancias = new System.Windows.Forms.Button();
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.btn_Roles = new System.Windows.Forms.Button();
            this.btn_Privilegios = new System.Windows.Forms.Button();
            this.lblUserLogged = new System.Windows.Forms.Label();
            this.btnUserRoles = new System.Windows.Forms.Button();
            this.btnRolesPriv = new System.Windows.Forms.Button();
            this.btnCierreMensual = new System.Windows.Forms.Button();
            this.btnCierreSesion = new System.Windows.Forms.Button();
            this.btnLiquidaciones = new System.Windows.Forms.Button();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Mi_Cooperativa
            // 
            this.lbl_Mi_Cooperativa.AutoSize = true;
            this.lbl_Mi_Cooperativa.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mi_Cooperativa.Location = new System.Drawing.Point(147, 28);
            this.lbl_Mi_Cooperativa.Name = "lbl_Mi_Cooperativa";
            this.lbl_Mi_Cooperativa.Size = new System.Drawing.Size(155, 36);
            this.lbl_Mi_Cooperativa.TabIndex = 4;
            this.lbl_Mi_Cooperativa.Text = "Mi Cooperativa";
            // 
            // btn_Abonos
            // 
            this.btn_Abonos.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Abonos.Location = new System.Drawing.Point(58, 107);
            this.btn_Abonos.Name = "btn_Abonos";
            this.btn_Abonos.Size = new System.Drawing.Size(68, 34);
            this.btn_Abonos.TabIndex = 5;
            this.btn_Abonos.Text = "Abonos";
            this.btn_Abonos.UseVisualStyleBackColor = true;
            this.btn_Abonos.Click += new System.EventHandler(this.btn_Abonos_Click);
            // 
            // btn_Cuentas
            // 
            this.btn_Cuentas.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cuentas.Location = new System.Drawing.Point(181, 107);
            this.btn_Cuentas.Name = "btn_Cuentas";
            this.btn_Cuentas.Size = new System.Drawing.Size(76, 34);
            this.btn_Cuentas.TabIndex = 6;
            this.btn_Cuentas.Text = "Cuentas";
            this.btn_Cuentas.UseVisualStyleBackColor = true;
            this.btn_Cuentas.Click += new System.EventHandler(this.btn_Cuentas_Click);
            // 
            // btn_Empleados
            // 
            this.btn_Empleados.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empleados.Location = new System.Drawing.Point(302, 107);
            this.btn_Empleados.Name = "btn_Empleados";
            this.btn_Empleados.Size = new System.Drawing.Size(94, 34);
            this.btn_Empleados.TabIndex = 7;
            this.btn_Empleados.Text = "Empleados";
            this.btn_Empleados.UseVisualStyleBackColor = true;
            this.btn_Empleados.Click += new System.EventHandler(this.btn_Empleados_Click);
            // 
            // btn_Prestamos
            // 
            this.btn_Prestamos.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prestamos.Location = new System.Drawing.Point(47, 186);
            this.btn_Prestamos.Name = "btn_Prestamos";
            this.btn_Prestamos.Size = new System.Drawing.Size(91, 34);
            this.btn_Prestamos.TabIndex = 8;
            this.btn_Prestamos.Text = "Préstamos";
            this.btn_Prestamos.UseVisualStyleBackColor = true;
            this.btn_Prestamos.Click += new System.EventHandler(this.btn_Prestamos_Click);
            // 
            // btn_Pagos
            // 
            this.btn_Pagos.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pagos.Location = new System.Drawing.Point(181, 186);
            this.btn_Pagos.Name = "btn_Pagos";
            this.btn_Pagos.Size = new System.Drawing.Size(76, 34);
            this.btn_Pagos.TabIndex = 9;
            this.btn_Pagos.Text = "Pagos";
            this.btn_Pagos.UseVisualStyleBackColor = true;
            this.btn_Pagos.Click += new System.EventHandler(this.btn_Pagos_Click);
            // 
            // btn_Ganancias
            // 
            this.btn_Ganancias.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ganancias.Location = new System.Drawing.Point(302, 186);
            this.btn_Ganancias.Name = "btn_Ganancias";
            this.btn_Ganancias.Size = new System.Drawing.Size(94, 34);
            this.btn_Ganancias.TabIndex = 10;
            this.btn_Ganancias.Text = "Ganancias";
            this.btn_Ganancias.UseVisualStyleBackColor = true;
            this.btn_Ganancias.Click += new System.EventHandler(this.btn_Ganancias_Click);
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Usuarios.Location = new System.Drawing.Point(47, 264);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(91, 34);
            this.btn_Usuarios.TabIndex = 11;
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.UseVisualStyleBackColor = true;
            this.btn_Usuarios.Click += new System.EventHandler(this.btn_Usuarios_Click);
            // 
            // btn_Roles
            // 
            this.btn_Roles.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Roles.Location = new System.Drawing.Point(181, 264);
            this.btn_Roles.Name = "btn_Roles";
            this.btn_Roles.Size = new System.Drawing.Size(76, 34);
            this.btn_Roles.TabIndex = 12;
            this.btn_Roles.Text = "Roles";
            this.btn_Roles.UseVisualStyleBackColor = true;
            this.btn_Roles.Click += new System.EventHandler(this.btn_Roles_Click);
            // 
            // btn_Privilegios
            // 
            this.btn_Privilegios.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Privilegios.Location = new System.Drawing.Point(302, 264);
            this.btn_Privilegios.Name = "btn_Privilegios";
            this.btn_Privilegios.Size = new System.Drawing.Size(94, 34);
            this.btn_Privilegios.TabIndex = 13;
            this.btn_Privilegios.Text = "Privilegios";
            this.btn_Privilegios.UseVisualStyleBackColor = true;
            this.btn_Privilegios.Click += new System.EventHandler(this.btn_Privilegios_Click);
            // 
            // lblUserLogged
            // 
            this.lblUserLogged.AutoSize = true;
            this.lblUserLogged.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogged.Location = new System.Drawing.Point(11, 481);
            this.lblUserLogged.Name = "lblUserLogged";
            this.lblUserLogged.Size = new System.Drawing.Size(106, 26);
            this.lblUserLogged.TabIndex = 14;
            this.lblUserLogged.Text = "lblUserLogged";
            // 
            // btnUserRoles
            // 
            this.btnUserRoles.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserRoles.Location = new System.Drawing.Point(26, 338);
            this.btnUserRoles.Name = "btnUserRoles";
            this.btnUserRoles.Size = new System.Drawing.Size(121, 34);
            this.btnUserRoles.TabIndex = 15;
            this.btnUserRoles.Text = "Usuarios-Roles";
            this.btnUserRoles.UseVisualStyleBackColor = true;
            this.btnUserRoles.Click += new System.EventHandler(this.btnUserRoles_Click);
            // 
            // btnRolesPriv
            // 
            this.btnRolesPriv.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRolesPriv.Location = new System.Drawing.Point(282, 338);
            this.btnRolesPriv.Name = "btnRolesPriv";
            this.btnRolesPriv.Size = new System.Drawing.Size(133, 34);
            this.btnRolesPriv.TabIndex = 16;
            this.btnRolesPriv.Text = "Roles-Privilegios";
            this.btnRolesPriv.UseVisualStyleBackColor = true;
            this.btnRolesPriv.Click += new System.EventHandler(this.btnRolesPriv_Click);
            // 
            // btnCierreMensual
            // 
            this.btnCierreMensual.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierreMensual.Location = new System.Drawing.Point(153, 338);
            this.btnCierreMensual.Name = "btnCierreMensual";
            this.btnCierreMensual.Size = new System.Drawing.Size(123, 34);
            this.btnCierreMensual.TabIndex = 17;
            this.btnCierreMensual.Text = "Cierre Mensual";
            this.btnCierreMensual.UseVisualStyleBackColor = true;
            // 
            // btnCierreSesion
            // 
            this.btnCierreSesion.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierreSesion.Location = new System.Drawing.Point(292, 473);
            this.btnCierreSesion.Name = "btnCierreSesion";
            this.btnCierreSesion.Size = new System.Drawing.Size(113, 34);
            this.btnCierreSesion.TabIndex = 18;
            this.btnCierreSesion.Text = "Cerrar Sesión";
            this.btnCierreSesion.UseVisualStyleBackColor = true;
            this.btnCierreSesion.Click += new System.EventHandler(this.btnCierreSesion_Click);
            // 
            // btnLiquidaciones
            // 
            this.btnLiquidaciones.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiquidaciones.Location = new System.Drawing.Point(228, 409);
            this.btnLiquidaciones.Name = "btnLiquidaciones";
            this.btnLiquidaciones.Size = new System.Drawing.Size(116, 34);
            this.btnLiquidaciones.TabIndex = 19;
            this.btnLiquidaciones.Text = "Liquidaciones";
            this.btnLiquidaciones.UseVisualStyleBackColor = true;
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reportes.Location = new System.Drawing.Point(96, 410);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(114, 34);
            this.btn_Reportes.TabIndex = 20;
            this.btn_Reportes.Text = "Reportes";
            this.btn_Reportes.UseVisualStyleBackColor = true;
            this.btn_Reportes.Click += new System.EventHandler(this.btn_Reportes_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 528);
            this.Controls.Add(this.btn_Reportes);
            this.Controls.Add(this.btnLiquidaciones);
            this.Controls.Add(this.btnCierreSesion);
            this.Controls.Add(this.btnCierreMensual);
            this.Controls.Add(this.btnRolesPriv);
            this.Controls.Add(this.btnUserRoles);
            this.Controls.Add(this.lblUserLogged);
            this.Controls.Add(this.btn_Privilegios);
            this.Controls.Add(this.btn_Roles);
            this.Controls.Add(this.btn_Usuarios);
            this.Controls.Add(this.btn_Ganancias);
            this.Controls.Add(this.btn_Pagos);
            this.Controls.Add(this.btn_Prestamos);
            this.Controls.Add(this.btn_Empleados);
            this.Controls.Add(this.btn_Cuentas);
            this.Controls.Add(this.btn_Abonos);
            this.Controls.Add(this.lbl_Mi_Cooperativa);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Mi_Cooperativa;
        private System.Windows.Forms.Button btn_Abonos;
        private System.Windows.Forms.Button btn_Cuentas;
        private System.Windows.Forms.Button btn_Empleados;
        private System.Windows.Forms.Button btn_Prestamos;
        private System.Windows.Forms.Button btn_Pagos;
        private System.Windows.Forms.Button btn_Ganancias;
        private System.Windows.Forms.Button btn_Usuarios;
        private System.Windows.Forms.Button btn_Roles;
        private System.Windows.Forms.Button btn_Privilegios;
        private System.Windows.Forms.Label lblUserLogged;
        private System.Windows.Forms.Button btnUserRoles;
        private System.Windows.Forms.Button btnRolesPriv;
        private System.Windows.Forms.Button btnCierreMensual;
        private System.Windows.Forms.Button btnCierreSesion;
        private System.Windows.Forms.Button btnLiquidaciones;
        private System.Windows.Forms.Button btn_Reportes;
    }
}