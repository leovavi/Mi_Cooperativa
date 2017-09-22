namespace MiCooperativa
{
    partial class FormPagos
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
            this.lbl_Pagos = new System.Windows.Forms.Label();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.lbl_User = new System.Windows.Forms.Label();
            this.cb_Filtro = new System.Windows.Forms.ComboBox();
            this.lbl_Filtro = new System.Windows.Forms.Label();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Pagos
            // 
            this.lbl_Pagos.AutoSize = true;
            this.lbl_Pagos.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pagos.Location = new System.Drawing.Point(305, 22);
            this.lbl_Pagos.Name = "lbl_Pagos";
            this.lbl_Pagos.Size = new System.Drawing.Size(52, 26);
            this.lbl_Pagos.TabIndex = 0;
            this.lbl_Pagos.Text = "Pagos";
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(563, 362);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(75, 30);
            this.btn_Atras.TabIndex = 1;
            this.btn_Atras.Text = "Atrás";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(12, 371);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(88, 21);
            this.lbl_User.TabIndex = 2;
            this.lbl_User.Text = "lblUserLogged";
            // 
            // cb_Filtro
            // 
            this.cb_Filtro.FormattingEnabled = true;
            this.cb_Filtro.Location = new System.Drawing.Point(124, 91);
            this.cb_Filtro.Name = "cb_Filtro";
            this.cb_Filtro.Size = new System.Drawing.Size(195, 29);
            this.cb_Filtro.TabIndex = 3;
            // 
            // lbl_Filtro
            // 
            this.lbl_Filtro.AutoSize = true;
            this.lbl_Filtro.Location = new System.Drawing.Point(24, 94);
            this.lbl_Filtro.Name = "lbl_Filtro";
            this.lbl_Filtro.Size = new System.Drawing.Size(94, 21);
            this.lbl_Filtro.TabIndex = 4;
            this.lbl_Filtro.Text = "Filtro Búsqueda";
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(334, 94);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(95, 21);
            this.lbl_Valor.TabIndex = 5;
            this.lbl_Valor.Text = "Valor Búsqueda";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(435, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 29);
            this.textBox1.TabIndex = 6;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(295, 140);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 30);
            this.btn_Buscar.TabIndex = 7;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 177);
            this.dataGridView1.TabIndex = 8;
            // 
            // FormPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 401);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.lbl_Filtro);
            this.Controls.Add(this.cb_Filtro);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.lbl_Pagos);
            this.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormPagos";
            this.Text = "FormPagos";
            this.Load += new System.EventHandler(this.FormPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Pagos;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.ComboBox cb_Filtro;
        private System.Windows.Forms.Label lbl_Filtro;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}