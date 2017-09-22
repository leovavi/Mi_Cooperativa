namespace MiCooperativa
{
    partial class FormReportes
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
            this.lbl_Reportes = new System.Windows.Forms.Label();
            this.btn_Rep_NA = new System.Windows.Forms.Button();
            this.txt_Rep_NA = new System.Windows.Forms.MaskedTextBox();
            this.dgv_Rep = new System.Windows.Forms.DataGridView();
            this.dtp_Ini = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fin = new System.Windows.Forms.DateTimePicker();
            this.lbl_FI = new System.Windows.Forms.Label();
            this.lbl_FF = new System.Windows.Forms.Label();
            this.btn_Rep_Div = new System.Windows.Forms.Button();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Año = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rep)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Reportes
            // 
            this.lbl_Reportes.AutoSize = true;
            this.lbl_Reportes.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reportes.Location = new System.Drawing.Point(313, 26);
            this.lbl_Reportes.Name = "lbl_Reportes";
            this.lbl_Reportes.Size = new System.Drawing.Size(72, 26);
            this.lbl_Reportes.TabIndex = 0;
            this.lbl_Reportes.Text = "Reportes";
            // 
            // btn_Rep_NA
            // 
            this.btn_Rep_NA.Location = new System.Drawing.Point(296, 74);
            this.btn_Rep_NA.Name = "btn_Rep_NA";
            this.btn_Rep_NA.Size = new System.Drawing.Size(226, 28);
            this.btn_Rep_NA.TabIndex = 1;
            this.btn_Rep_NA.Text = "Generar Reporte Nuevas Afiliaciones";
            this.btn_Rep_NA.UseVisualStyleBackColor = true;
            this.btn_Rep_NA.Click += new System.EventHandler(this.btn_Rep_NA_Click);
            // 
            // txt_Rep_NA
            // 
            this.txt_Rep_NA.Location = new System.Drawing.Point(234, 73);
            this.txt_Rep_NA.Mask = "9999";
            this.txt_Rep_NA.Name = "txt_Rep_NA";
            this.txt_Rep_NA.Size = new System.Drawing.Size(56, 29);
            this.txt_Rep_NA.TabIndex = 2;
            // 
            // dgv_Rep
            // 
            this.dgv_Rep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rep.Location = new System.Drawing.Point(12, 215);
            this.dgv_Rep.Name = "dgv_Rep";
            this.dgv_Rep.Size = new System.Drawing.Size(684, 260);
            this.dgv_Rep.TabIndex = 3;
            // 
            // dtp_Ini
            // 
            this.dtp_Ini.Location = new System.Drawing.Point(215, 120);
            this.dtp_Ini.Name = "dtp_Ini";
            this.dtp_Ini.Size = new System.Drawing.Size(222, 29);
            this.dtp_Ini.TabIndex = 4;
            // 
            // dtp_Fin
            // 
            this.dtp_Fin.Location = new System.Drawing.Point(215, 166);
            this.dtp_Fin.Name = "dtp_Fin";
            this.dtp_Fin.Size = new System.Drawing.Size(222, 29);
            this.dtp_Fin.TabIndex = 5;
            // 
            // lbl_FI
            // 
            this.lbl_FI.AutoSize = true;
            this.lbl_FI.Location = new System.Drawing.Point(136, 126);
            this.lbl_FI.Name = "lbl_FI";
            this.lbl_FI.Size = new System.Drawing.Size(73, 21);
            this.lbl_FI.TabIndex = 6;
            this.lbl_FI.Text = "Fecha Inicio";
            // 
            // lbl_FF
            // 
            this.lbl_FF.AutoSize = true;
            this.lbl_FF.Location = new System.Drawing.Point(136, 172);
            this.lbl_FF.Name = "lbl_FF";
            this.lbl_FF.Size = new System.Drawing.Size(69, 21);
            this.lbl_FF.TabIndex = 7;
            this.lbl_FF.Text = "Fecha Final";
            // 
            // btn_Rep_Div
            // 
            this.btn_Rep_Div.Location = new System.Drawing.Point(455, 142);
            this.btn_Rep_Div.Name = "btn_Rep_Div";
            this.btn_Rep_Div.Size = new System.Drawing.Size(178, 28);
            this.btn_Rep_Div.TabIndex = 8;
            this.btn_Rep_Div.Text = "Generar Reporte Dividendos";
            this.btn_Rep_Div.UseVisualStyleBackColor = true;
            this.btn_Rep_Div.Click += new System.EventHandler(this.btn_Rep_Div_Click);
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(621, 484);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(75, 26);
            this.btn_Atras.TabIndex = 9;
            this.btn_Atras.Text = "Atrás";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(12, 492);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(88, 21);
            this.lbl_User.TabIndex = 10;
            this.lbl_User.Text = "lblUserLogged";
            // 
            // lbl_Año
            // 
            this.lbl_Año.AutoSize = true;
            this.lbl_Año.Location = new System.Drawing.Point(197, 78);
            this.lbl_Año.Name = "lbl_Año";
            this.lbl_Año.Size = new System.Drawing.Size(31, 21);
            this.lbl_Año.TabIndex = 11;
            this.lbl_Año.Text = "Año";
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 522);
            this.Controls.Add(this.lbl_Año);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.btn_Rep_Div);
            this.Controls.Add(this.lbl_FF);
            this.Controls.Add(this.lbl_FI);
            this.Controls.Add(this.dtp_Fin);
            this.Controls.Add(this.dtp_Ini);
            this.Controls.Add(this.dgv_Rep);
            this.Controls.Add(this.txt_Rep_NA);
            this.Controls.Add(this.btn_Rep_NA);
            this.Controls.Add(this.lbl_Reportes);
            this.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Reportes;
        private System.Windows.Forms.Button btn_Rep_NA;
        private System.Windows.Forms.MaskedTextBox txt_Rep_NA;
        private System.Windows.Forms.DataGridView dgv_Rep;
        private System.Windows.Forms.DateTimePicker dtp_Ini;
        private System.Windows.Forms.DateTimePicker dtp_Fin;
        private System.Windows.Forms.Label lbl_FI;
        private System.Windows.Forms.Label lbl_FF;
        private System.Windows.Forms.Button btn_Rep_Div;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Año;
    }
}