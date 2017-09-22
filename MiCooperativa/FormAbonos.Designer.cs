namespace MiCooperativa
{
    partial class FormAbonos
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
            this.lbl_User = new System.Windows.Forms.Label();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.tab_Buscar = new System.Windows.Forms.TabPage();
            this.tab_Eliminar = new System.Windows.Forms.TabPage();
            this.lbl_Filtro = new System.Windows.Forms.Label();
            this.cb_Filtro = new System.Windows.Forms.ComboBox();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dgv_Abono = new System.Windows.Forms.DataGridView();
            this.lbl_Buscar_Abonos = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.cb_Abonos = new System.Windows.Forms.ComboBox();
            this.lbl_Eliminar_Abonos = new System.Windows.Forms.Label();
            this.lbl_CA = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_Buscar.SuspendLayout();
            this.tab_Eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Abono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Buscar);
            this.tabControl1.Controls.Add(this.tab_Eliminar);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 379);
            this.tabControl1.TabIndex = 0;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(12, 394);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(88, 21);
            this.lbl_User.TabIndex = 1;
            this.lbl_User.Text = "lblUserLogged";
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(534, 389);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(75, 26);
            this.btn_Atras.TabIndex = 2;
            this.btn_Atras.Text = "Atras";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // tab_Buscar
            // 
            this.tab_Buscar.Controls.Add(this.lbl_Buscar_Abonos);
            this.tab_Buscar.Controls.Add(this.dgv_Abono);
            this.tab_Buscar.Controls.Add(this.btn_Buscar);
            this.tab_Buscar.Controls.Add(this.txt_Valor);
            this.tab_Buscar.Controls.Add(this.lbl_Valor);
            this.tab_Buscar.Controls.Add(this.cb_Filtro);
            this.tab_Buscar.Controls.Add(this.lbl_Filtro);
            this.tab_Buscar.Location = new System.Drawing.Point(4, 30);
            this.tab_Buscar.Name = "tab_Buscar";
            this.tab_Buscar.Size = new System.Drawing.Size(611, 345);
            this.tab_Buscar.TabIndex = 2;
            this.tab_Buscar.Text = "Buscar";
            this.tab_Buscar.UseVisualStyleBackColor = true;
            // 
            // tab_Eliminar
            // 
            this.tab_Eliminar.Controls.Add(this.lbl_CA);
            this.tab_Eliminar.Controls.Add(this.lbl_Eliminar_Abonos);
            this.tab_Eliminar.Controls.Add(this.cb_Abonos);
            this.tab_Eliminar.Controls.Add(this.btn_Eliminar);
            this.tab_Eliminar.Location = new System.Drawing.Point(4, 30);
            this.tab_Eliminar.Name = "tab_Eliminar";
            this.tab_Eliminar.Size = new System.Drawing.Size(611, 345);
            this.tab_Eliminar.TabIndex = 3;
            this.tab_Eliminar.Text = "Eliminar";
            this.tab_Eliminar.UseVisualStyleBackColor = true;
            // 
            // lbl_Filtro
            // 
            this.lbl_Filtro.AutoSize = true;
            this.lbl_Filtro.Location = new System.Drawing.Point(24, 56);
            this.lbl_Filtro.Name = "lbl_Filtro";
            this.lbl_Filtro.Size = new System.Drawing.Size(94, 21);
            this.lbl_Filtro.TabIndex = 0;
            this.lbl_Filtro.Text = "Filtro Búsqueda";
            // 
            // cb_Filtro
            // 
            this.cb_Filtro.FormattingEnabled = true;
            this.cb_Filtro.Location = new System.Drawing.Point(124, 53);
            this.cb_Filtro.Name = "cb_Filtro";
            this.cb_Filtro.Size = new System.Drawing.Size(157, 29);
            this.cb_Filtro.TabIndex = 1;
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(300, 56);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(95, 21);
            this.lbl_Valor.TabIndex = 2;
            this.lbl_Valor.Text = "Valor Búsqueda";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(401, 53);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(181, 29);
            this.txt_Valor.TabIndex = 3;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(257, 100);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 29);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dgv_Abono
            // 
            this.dgv_Abono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Abono.Location = new System.Drawing.Point(3, 143);
            this.dgv_Abono.Name = "dgv_Abono";
            this.dgv_Abono.Size = new System.Drawing.Size(601, 199);
            this.dgv_Abono.TabIndex = 5;
            // 
            // lbl_Buscar_Abonos
            // 
            this.lbl_Buscar_Abonos.AutoSize = true;
            this.lbl_Buscar_Abonos.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar_Abonos.Location = new System.Drawing.Point(240, 9);
            this.lbl_Buscar_Abonos.Name = "lbl_Buscar_Abonos";
            this.lbl_Buscar_Abonos.Size = new System.Drawing.Size(110, 26);
            this.lbl_Buscar_Abonos.TabIndex = 6;
            this.lbl_Buscar_Abonos.Text = "Buscar Abonos";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(262, 198);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 28);
            this.btn_Eliminar.TabIndex = 0;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // cb_Abonos
            // 
            this.cb_Abonos.FormattingEnabled = true;
            this.cb_Abonos.Location = new System.Drawing.Point(196, 142);
            this.cb_Abonos.Name = "cb_Abonos";
            this.cb_Abonos.Size = new System.Drawing.Size(219, 29);
            this.cb_Abonos.TabIndex = 1;
            // 
            // lbl_Eliminar_Abonos
            // 
            this.lbl_Eliminar_Abonos.AutoSize = true;
            this.lbl_Eliminar_Abonos.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Eliminar_Abonos.Location = new System.Drawing.Point(243, 20);
            this.lbl_Eliminar_Abonos.Name = "lbl_Eliminar_Abonos";
            this.lbl_Eliminar_Abonos.Size = new System.Drawing.Size(118, 26);
            this.lbl_Eliminar_Abonos.TabIndex = 2;
            this.lbl_Eliminar_Abonos.Text = "Eliminar Abonos";
            // 
            // lbl_CA
            // 
            this.lbl_CA.AutoSize = true;
            this.lbl_CA.Location = new System.Drawing.Point(258, 100);
            this.lbl_CA.Name = "lbl_CA";
            this.lbl_CA.Size = new System.Drawing.Size(84, 21);
            this.lbl_CA.TabIndex = 3;
            this.lbl_CA.Text = "Código Abono";
            // 
            // FormAbonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 428);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormAbonos";
            this.Text = "FormAbonos";
            this.Load += new System.EventHandler(this.FormAbonos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Buscar.ResumeLayout(false);
            this.tab_Buscar.PerformLayout();
            this.tab_Eliminar.ResumeLayout(false);
            this.tab_Eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Abono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.TabPage tab_Buscar;
        private System.Windows.Forms.Label lbl_Buscar_Abonos;
        private System.Windows.Forms.DataGridView dgv_Abono;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.ComboBox cb_Filtro;
        private System.Windows.Forms.Label lbl_Filtro;
        private System.Windows.Forms.TabPage tab_Eliminar;
        private System.Windows.Forms.Label lbl_CA;
        private System.Windows.Forms.Label lbl_Eliminar_Abonos;
        private System.Windows.Forms.ComboBox cb_Abonos;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}