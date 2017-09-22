namespace MiCooperativa
{
    partial class LogIn
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
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.lbl_Modo_Sesion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Iniciar_Sesion = new System.Windows.Forms.Button();
            this.txtbx_Usuario = new System.Windows.Forms.TextBox();
            this.txtbx_Contraseña = new System.Windows.Forms.TextBox();
            this.cb_Sesion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(74, 104);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(63, 26);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contraseña.Location = new System.Drawing.Point(74, 165);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(87, 26);
            this.lbl_Contraseña.TabIndex = 1;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // lbl_Modo_Sesion
            // 
            this.lbl_Modo_Sesion.AutoSize = true;
            this.lbl_Modo_Sesion.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Modo_Sesion.Location = new System.Drawing.Point(74, 232);
            this.lbl_Modo_Sesion.Name = "lbl_Modo_Sesion";
            this.lbl_Modo_Sesion.Size = new System.Drawing.Size(96, 26);
            this.lbl_Modo_Sesion.TabIndex = 2;
            this.lbl_Modo_Sesion.Text = "Modo Sesión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mi Cooperativa";
            // 
            // btn_Iniciar_Sesion
            // 
            this.btn_Iniciar_Sesion.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciar_Sesion.Location = new System.Drawing.Point(139, 288);
            this.btn_Iniciar_Sesion.Name = "btn_Iniciar_Sesion";
            this.btn_Iniciar_Sesion.Size = new System.Drawing.Size(134, 34);
            this.btn_Iniciar_Sesion.TabIndex = 4;
            this.btn_Iniciar_Sesion.Text = "Iniciar Sesión";
            this.btn_Iniciar_Sesion.UseVisualStyleBackColor = true;
            this.btn_Iniciar_Sesion.Click += new System.EventHandler(this.btn_Iniciar_Sesion_Click);
            // 
            // txtbx_Usuario
            // 
            this.txtbx_Usuario.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Usuario.Location = new System.Drawing.Point(193, 101);
            this.txtbx_Usuario.MaximumSize = new System.Drawing.Size(160, 40);
            this.txtbx_Usuario.Name = "txtbx_Usuario";
            this.txtbx_Usuario.Size = new System.Drawing.Size(159, 29);
            this.txtbx_Usuario.TabIndex = 5;
            this.txtbx_Usuario.Text = "USER-1";
            // 
            // txtbx_Contraseña
            // 
            this.txtbx_Contraseña.BackColor = System.Drawing.SystemColors.Window;
            this.txtbx_Contraseña.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Contraseña.Location = new System.Drawing.Point(193, 162);
            this.txtbx_Contraseña.Name = "txtbx_Contraseña";
            this.txtbx_Contraseña.PasswordChar = '*';
            this.txtbx_Contraseña.Size = new System.Drawing.Size(159, 29);
            this.txtbx_Contraseña.TabIndex = 6;
            this.txtbx_Contraseña.Text = "54321";
            // 
            // cb_Sesion
            // 
            this.cb_Sesion.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Sesion.FormattingEnabled = true;
            this.cb_Sesion.Location = new System.Drawing.Point(193, 229);
            this.cb_Sesion.Name = "cb_Sesion";
            this.cb_Sesion.Size = new System.Drawing.Size(159, 29);
            this.cb_Sesion.TabIndex = 7;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 355);
            this.Controls.Add(this.cb_Sesion);
            this.Controls.Add(this.txtbx_Contraseña);
            this.Controls.Add(this.txtbx_Usuario);
            this.Controls.Add(this.btn_Iniciar_Sesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Modo_Sesion);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.lbl_Usuario);
            this.Name = "LogIn";
            this.Text = "Empresa ABC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.Label lbl_Modo_Sesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Iniciar_Sesion;
        private System.Windows.Forms.TextBox txtbx_Usuario;
        private System.Windows.Forms.TextBox txtbx_Contraseña;
        private System.Windows.Forms.ComboBox cb_Sesion;
    }
}

