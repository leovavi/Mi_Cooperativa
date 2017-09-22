namespace MiCooperativa
{
    partial class Afiliado
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
            this.lbl_User = new System.Windows.Forms.Label();
            this.btn_Cierre_Sesion = new System.Windows.Forms.Button();
            this.btn_Cuentas = new System.Windows.Forms.Button();
            this.btn_Información = new System.Windows.Forms.Button();
            this.btn_Prest = new System.Windows.Forms.Button();
            this.btn_Abonos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Mi_Cooperativa
            // 
            this.lbl_Mi_Cooperativa.AutoSize = true;
            this.lbl_Mi_Cooperativa.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mi_Cooperativa.Location = new System.Drawing.Point(133, 25);
            this.lbl_Mi_Cooperativa.Name = "lbl_Mi_Cooperativa";
            this.lbl_Mi_Cooperativa.Size = new System.Drawing.Size(155, 36);
            this.lbl_Mi_Cooperativa.TabIndex = 5;
            this.lbl_Mi_Cooperativa.Text = "Mi Cooperativa";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(12, 346);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(106, 26);
            this.lbl_User.TabIndex = 6;
            this.lbl_User.Text = "lblUserLogged";
            // 
            // btn_Cierre_Sesion
            // 
            this.btn_Cierre_Sesion.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cierre_Sesion.Location = new System.Drawing.Point(269, 343);
            this.btn_Cierre_Sesion.Name = "btn_Cierre_Sesion";
            this.btn_Cierre_Sesion.Size = new System.Drawing.Size(132, 33);
            this.btn_Cierre_Sesion.TabIndex = 7;
            this.btn_Cierre_Sesion.Text = "Cerrar Sesión";
            this.btn_Cierre_Sesion.UseVisualStyleBackColor = true;
            this.btn_Cierre_Sesion.Click += new System.EventHandler(this.btn_Cierre_Sesion_Click);
            // 
            // btn_Cuentas
            // 
            this.btn_Cuentas.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cuentas.Location = new System.Drawing.Point(243, 117);
            this.btn_Cuentas.Name = "btn_Cuentas";
            this.btn_Cuentas.Size = new System.Drawing.Size(75, 34);
            this.btn_Cuentas.TabIndex = 8;
            this.btn_Cuentas.Text = "Cuentas";
            this.btn_Cuentas.UseVisualStyleBackColor = true;
            this.btn_Cuentas.Click += new System.EventHandler(this.btn_Cuentas_Click);
            // 
            // btn_Información
            // 
            this.btn_Información.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Información.Location = new System.Drawing.Point(93, 119);
            this.btn_Información.Name = "btn_Información";
            this.btn_Información.Size = new System.Drawing.Size(105, 32);
            this.btn_Información.TabIndex = 9;
            this.btn_Información.Text = "Información";
            this.btn_Información.UseVisualStyleBackColor = true;
            this.btn_Información.Click += new System.EventHandler(this.btn_Información_Click);
            // 
            // btn_Prest
            // 
            this.btn_Prest.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prest.Location = new System.Drawing.Point(93, 199);
            this.btn_Prest.Name = "btn_Prest";
            this.btn_Prest.Size = new System.Drawing.Size(105, 32);
            this.btn_Prest.TabIndex = 11;
            this.btn_Prest.Text = "Préstamos";
            this.btn_Prest.UseVisualStyleBackColor = true;
            this.btn_Prest.Click += new System.EventHandler(this.btn_Prest_Click);
            // 
            // btn_Abonos
            // 
            this.btn_Abonos.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Abonos.Location = new System.Drawing.Point(243, 197);
            this.btn_Abonos.Name = "btn_Abonos";
            this.btn_Abonos.Size = new System.Drawing.Size(75, 34);
            this.btn_Abonos.TabIndex = 10;
            this.btn_Abonos.Text = "Abonos";
            this.btn_Abonos.UseVisualStyleBackColor = true;
            this.btn_Abonos.Click += new System.EventHandler(this.btn_Abonos_Click);
            // 
            // Afiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 388);
            this.Controls.Add(this.btn_Prest);
            this.Controls.Add(this.btn_Abonos);
            this.Controls.Add(this.btn_Información);
            this.Controls.Add(this.btn_Cuentas);
            this.Controls.Add(this.btn_Cierre_Sesion);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_Mi_Cooperativa);
            this.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Afiliado";
            this.Text = "Afiliado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Mi_Cooperativa;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button btn_Cierre_Sesion;
        private System.Windows.Forms.Button btn_Cuentas;
        private System.Windows.Forms.Button btn_Información;
        private System.Windows.Forms.Button btn_Prest;
        private System.Windows.Forms.Button btn_Abonos;
    }
}