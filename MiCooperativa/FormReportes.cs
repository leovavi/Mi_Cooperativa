using IBM.Data.Informix;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCooperativa
{
    public partial class FormReportes : Form
    {
        string userLogged, loggedAs;
        Informix ifx;

        public FormReportes(string user, string logged)
        {
            InitializeComponent();
            ifx = new Informix();
            userLogged = user;
            loggedAs = logged;
            lbl_User.Text = "Usuario: " + userLogged;
        }

        private void btn_Rep_Div_Click(object sender, EventArgs e)
        {
            string cap = "Error al hacer Reporte";
            IfxConnection con = ifx.getConnection();

            try
            {                
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_REPORTE_DIVIDENDOS";
                cmd.Parameters.Add("P_FECHA_INI", IfxType.VarChar).Value = dtp_Ini.Value.ToString("MM-dd-YYYY");
                cmd.Parameters.Add("P_FECHA_FIN", IfxType.VarChar).Value = dtp_Fin.Value.ToString("MM-dd-YYYY");
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                dgv_Rep.DataSource = dt;
                con.Close();   
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrador admin = new Administrador(userLogged, loggedAs);
            admin.Show();
            admin.Closed += (s, args) => this.Close();
        }

        private void btn_Rep_NA_Click(object sender, EventArgs e)
        {
            string cap = "Error al hacer Reporte";
            IfxConnection con = ifx.getConnection();

            try
            {
                if(txt_Rep_NA.Text != "")
                {
                    IfxCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "FN_REPORTE_NUEVAS_AFILIACIONES";
                    cmd.Parameters.Add("P_FECHA", IfxType.Integer).Value = Int32.Parse(txt_Rep_NA.Text);
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    IfxDataAdapter da = new IfxDataAdapter(cmd);
                    da.Fill(dt);

                    dgv_Rep.DataSource = dt;
                    con.Close();
                }else
                {
                    string msg = "Filtro de Año debe ser llenado";
                    MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }         
        }
    }
}
