namespace MiCooperativa
{
    partial class FormPrestamos
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
            this.tab_Buscar = new System.Windows.Forms.TabPage();
            this.tab_Eliminar = new System.Windows.Forms.TabPage();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Agregar_Prestamo = new System.Windows.Forms.Label();
            this.lbl_Monto = new System.Windows.Forms.Label();
            this.txt_Monto = new System.Windows.Forms.MaskedTextBox();
            this.txt_Periodos = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Periodos = new System.Windows.Forms.Label();
            this.lbl_CE = new System.Windows.Forms.Label();
            this.cb_CE = new System.Windows.Forms.ComboBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.cb_Filtro = new System.Windows.Forms.ComboBox();
            this.lbl_Filtro = new System.Windows.Forms.Label();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dgv_Prest = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_NP_Eliminar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_Insertar.SuspendLayout();
            this.tab_Buscar.SuspendLayout();
            this.tab_Eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prest)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Insertar);
            this.tabControl1.Controls.Add(this.tab_Buscar);
            this.tabControl1.Controls.Add(this.tab_Eliminar);
            this.tabControl1.Location = new System.Drawing.Point(0, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_Insertar
            // 
            this.tab_Insertar.Controls.Add(this.btn_Agregar);
            this.tab_Insertar.Controls.Add(this.cb_CE);
            this.tab_Insertar.Controls.Add(this.lbl_CE);
            this.tab_Insertar.Controls.Add(this.txt_Periodos);
            this.tab_Insertar.Controls.Add(this.lbl_Periodos);
            this.tab_Insertar.Controls.Add(this.txt_Monto);
            this.tab_Insertar.Controls.Add(this.lbl_Monto);
            this.tab_Insertar.Controls.Add(this.lbl_Agregar_Prestamo);
            this.tab_Insertar.Location = new System.Drawing.Point(4, 30);
            this.tab_Insertar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tab_Insertar.Name = "tab_Insertar";
            this.tab_Insertar.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tab_Insertar.Size = new System.Drawing.Size(670, 332);
            this.tab_Insertar.TabIndex = 0;
            this.tab_Insertar.Text = "Insertar";
            this.tab_Insertar.UseVisualStyleBackColor = true;
            // 
            // tab_Buscar
            // 
            this.tab_Buscar.Controls.Add(this.dgv_Prest);
            this.tab_Buscar.Controls.Add(this.btn_Buscar);
            this.tab_Buscar.Controls.Add(this.txt_Valor);
            this.tab_Buscar.Controls.Add(this.lbl_Valor);
            this.tab_Buscar.Controls.Add(this.cb_Filtro);
            this.tab_Buscar.Controls.Add(this.lbl_Filtro);
            this.tab_Buscar.Controls.Add(this.lbl_Buscar);
            this.tab_Buscar.Location = new System.Drawing.Point(4, 30);
            this.tab_Buscar.Name = "tab_Buscar";
            this.tab_Buscar.Size = new System.Drawing.Size(670, 332);
            this.tab_Buscar.TabIndex = 2;
            this.tab_Buscar.Text = "Buscar";
            this.tab_Buscar.UseVisualStyleBackColor = true;
            // 
            // tab_Eliminar
            // 
            this.tab_Eliminar.Controls.Add(this.btn_Eliminar);
            this.tab_Eliminar.Controls.Add(this.cb_NP_Eliminar);
            this.tab_Eliminar.Controls.Add(this.label2);
            this.tab_Eliminar.Controls.Add(this.label1);
            this.tab_Eliminar.Location = new System.Drawing.Point(4, 30);
            this.tab_Eliminar.Name = "tab_Eliminar";
            this.tab_Eliminar.Size = new System.Drawing.Size(670, 332);
            this.tab_Eliminar.TabIndex = 3;
            this.tab_Eliminar.Text = "Eliminar";
            this.tab_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(591, 388);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(75, 28);
            this.btn_Atras.TabIndex = 1;
            this.btn_Atras.Text = "Atrás";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(12, 392);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(88, 21);
            this.lbl_User.TabIndex = 2;
            this.lbl_User.Text = "lblUserLogged";
            // 
            // lbl_Agregar_Prestamo
            // 
            this.lbl_Agregar_Prestamo.AutoSize = true;
            this.lbl_Agregar_Prestamo.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Agregar_Prestamo.Location = new System.Drawing.Point(266, 28);
            this.lbl_Agregar_Prestamo.Name = "lbl_Agregar_Prestamo";
            this.lbl_Agregar_Prestamo.Size = new System.Drawing.Size(132, 26);
            this.lbl_Agregar_Prestamo.TabIndex = 0;
            this.lbl_Agregar_Prestamo.Text = "Agregar Préstamo";
            // 
            // lbl_Monto
            // 
            this.lbl_Monto.AutoSize = true;
            this.lbl_Monto.Location = new System.Drawing.Point(216, 96);
            this.lbl_Monto.Name = "lbl_Monto";
            this.lbl_Monto.Size = new System.Drawing.Size(97, 21);
            this.lbl_Monto.TabIndex = 1;
            this.lbl_Monto.Text = "Monto Préstamo";
            // 
            // txt_Monto
            // 
            this.txt_Monto.Location = new System.Drawing.Point(319, 93);
            this.txt_Monto.Mask = "99999999.99";
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(132, 29);
            this.txt_Monto.TabIndex = 2;
            // 
            // txt_Periodos
            // 
            this.txt_Periodos.Location = new System.Drawing.Point(370, 148);
            this.txt_Periodos.Mask = "99";
            this.txt_Periodos.Name = "txt_Periodos";
            this.txt_Periodos.Size = new System.Drawing.Size(41, 29);
            this.txt_Periodos.TabIndex = 4;
            // 
            // lbl_Periodos
            // 
            this.lbl_Periodos.AutoSize = true;
            this.lbl_Periodos.Location = new System.Drawing.Point(253, 151);
            this.lbl_Periodos.Name = "lbl_Periodos";
            this.lbl_Periodos.Size = new System.Drawing.Size(111, 21);
            this.lbl_Periodos.TabIndex = 3;
            this.lbl_Periodos.Text = "Periodos Préstamo";
            // 
            // lbl_CE
            // 
            this.lbl_CE.AutoSize = true;
            this.lbl_CE.Location = new System.Drawing.Point(216, 198);
            this.lbl_CE.Name = "lbl_CE";
            this.lbl_CE.Size = new System.Drawing.Size(101, 21);
            this.lbl_CE.TabIndex = 5;
            this.lbl_CE.Text = "Código Empleado";
            // 
            // cb_CE
            // 
            this.cb_CE.FormattingEnabled = true;
            this.cb_CE.Location = new System.Drawing.Point(323, 195);
            this.cb_CE.Name = "cb_CE";
            this.cb_CE.Size = new System.Drawing.Size(128, 29);
            this.cb_CE.TabIndex = 6;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(301, 260);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 30);
            this.btn_Agregar.TabIndex = 7;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.Location = new System.Drawing.Point(262, 16);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(125, 26);
            this.lbl_Buscar.TabIndex = 1;
            this.lbl_Buscar.Text = "Buscar Préstamo";
            // 
            // cb_Filtro
            // 
            this.cb_Filtro.FormattingEnabled = true;
            this.cb_Filtro.Location = new System.Drawing.Point(151, 65);
            this.cb_Filtro.Name = "cb_Filtro";
            this.cb_Filtro.Size = new System.Drawing.Size(154, 29);
            this.cb_Filtro.TabIndex = 8;
            // 
            // lbl_Filtro
            // 
            this.lbl_Filtro.AutoSize = true;
            this.lbl_Filtro.Location = new System.Drawing.Point(44, 68);
            this.lbl_Filtro.Name = "lbl_Filtro";
            this.lbl_Filtro.Size = new System.Drawing.Size(94, 21);
            this.lbl_Filtro.TabIndex = 7;
            this.lbl_Filtro.Text = "Filtro Búsqueda";
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(324, 68);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(95, 21);
            this.lbl_Valor.TabIndex = 9;
            this.lbl_Valor.Text = "Valor Búsqueda";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(425, 65);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(180, 29);
            this.txt_Valor.TabIndex = 10;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(289, 109);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 26);
            this.btn_Buscar.TabIndex = 11;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dgv_Prest
            // 
            this.dgv_Prest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Prest.Location = new System.Drawing.Point(8, 141);
            this.dgv_Prest.Name = "dgv_Prest";
            this.dgv_Prest.Size = new System.Drawing.Size(659, 188);
            this.dgv_Prest.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eliminar Préstamo";
            // 
            // cb_NP_Eliminar
            // 
            this.cb_NP_Eliminar.FormattingEnabled = true;
            this.cb_NP_Eliminar.Location = new System.Drawing.Point(308, 132);
            this.cb_NP_Eliminar.Name = "cb_NP_Eliminar";
            this.cb_NP_Eliminar.Size = new System.Drawing.Size(154, 29);
            this.cb_NP_Eliminar.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Número Préstamo";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(291, 191);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 30);
            this.btn_Eliminar.TabIndex = 11;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // FormPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 428);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormPrestamos";
            this.Text = "FormPrestamos";
            this.Load += new System.EventHandler(this.FormPrestamos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Insertar.ResumeLayout(false);
            this.tab_Insertar.PerformLayout();
            this.tab_Buscar.ResumeLayout(false);
            this.tab_Buscar.PerformLayout();
            this.tab_Eliminar.ResumeLayout(false);
            this.tab_Eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Insertar;
        private System.Windows.Forms.TabPage tab_Buscar;
        private System.Windows.Forms.TabPage tab_Eliminar;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.ComboBox cb_CE;
        private System.Windows.Forms.Label lbl_CE;
        private System.Windows.Forms.MaskedTextBox txt_Periodos;
        private System.Windows.Forms.Label lbl_Periodos;
        private System.Windows.Forms.MaskedTextBox txt_Monto;
        private System.Windows.Forms.Label lbl_Monto;
        private System.Windows.Forms.Label lbl_Agregar_Prestamo;
        private System.Windows.Forms.DataGridView dgv_Prest;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.ComboBox cb_Filtro;
        private System.Windows.Forms.Label lbl_Filtro;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.ComboBox cb_NP_Eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}