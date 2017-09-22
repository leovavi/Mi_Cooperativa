namespace MiCooperativa
{
    partial class FormGanancias
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
            this.dgv_Ganancias = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.lbl_Filtro = new System.Windows.Forms.Label();
            this.cb_Filtro = new System.Windows.Forms.ComboBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.lbl_Ganancias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ganancias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Ganancias
            // 
            this.dgv_Ganancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ganancias.Location = new System.Drawing.Point(12, 164);
            this.dgv_Ganancias.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgv_Ganancias.Name = "dgv_Ganancias";
            this.dgv_Ganancias.Size = new System.Drawing.Size(631, 201);
            this.dgv_Ganancias.TabIndex = 17;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(261, 122);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(87, 30);
            this.btn_Buscar.TabIndex = 16;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(428, 77);
            this.txt_Valor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(196, 29);
            this.txt_Valor.TabIndex = 15;
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(327, 80);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(95, 21);
            this.lbl_Valor.TabIndex = 14;
            this.lbl_Valor.Text = "Valor Búsqueda";
            // 
            // lbl_Filtro
            // 
            this.lbl_Filtro.AutoSize = true;
            this.lbl_Filtro.Location = new System.Drawing.Point(21, 80);
            this.lbl_Filtro.Name = "lbl_Filtro";
            this.lbl_Filtro.Size = new System.Drawing.Size(94, 21);
            this.lbl_Filtro.TabIndex = 13;
            this.lbl_Filtro.Text = "Filtro Búsqueda";
            // 
            // cb_Filtro
            // 
            this.cb_Filtro.FormattingEnabled = true;
            this.cb_Filtro.Location = new System.Drawing.Point(121, 77);
            this.cb_Filtro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cb_Filtro.Name = "cb_Filtro";
            this.cb_Filtro.Size = new System.Drawing.Size(189, 29);
            this.cb_Filtro.TabIndex = 12;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(21, 381);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(88, 21);
            this.lbl_User.TabIndex = 11;
            this.lbl_User.Text = "lblUserLogged";
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(556, 375);
            this.btn_Atras.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(87, 33);
            this.btn_Atras.TabIndex = 10;
            this.btn_Atras.Text = "Atrás";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // lbl_Ganancias
            // 
            this.lbl_Ganancias.AutoSize = true;
            this.lbl_Ganancias.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ganancias.Location = new System.Drawing.Point(265, 24);
            this.lbl_Ganancias.Name = "lbl_Ganancias";
            this.lbl_Ganancias.Size = new System.Drawing.Size(80, 26);
            this.lbl_Ganancias.TabIndex = 9;
            this.lbl_Ganancias.Text = "Ganancias";
            // 
            // FormGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 419);
            this.Controls.Add(this.dgv_Ganancias);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.lbl_Filtro);
            this.Controls.Add(this.cb_Filtro);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.lbl_Ganancias);
            this.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormGanancias";
            this.Text = "FormGanancias";
            this.Load += new System.EventHandler(this.FormGanancias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ganancias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Ganancias;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.Label lbl_Filtro;
        private System.Windows.Forms.ComboBox cb_Filtro;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Label lbl_Ganancias;
    }
}