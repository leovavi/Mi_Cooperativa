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
    public partial class FormGanancias : Form
    {
        string userLogged, loggedAs;
        Informix ifx;

        private void FormGanancias_Load(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_GANACIAS_READ";
                cmd.Parameters.Add("P_CODIGO_EMPLEADO", IfxType.VarChar).Value = "%";
                cmd.ExecuteNonQuery();

                IfxDataReader dr = cmd.ExecuteReader();

                for (int i = 0; i < dr.FieldCount; i++)
                    cb_Filtro.Items.Add(dr.GetName(i));

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error al Cargar Formulario", MessageBoxButtons.OK);
            }
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrador admin = new Administrador(userLogged, loggedAs);
            admin.Show();
            admin.Closed += (s, args) => this.Close();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error Buscar Ganancias";
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_GANACIAS_READ";
                if(txt_Valor.Text == "")
                    cmd.Parameters.Add("P_" + cb_Filtro.Text, txt_Valor.Text);
                else
                    cmd.Parameters.Add("P_CODIGO_EMPLEADO", IfxType.VarChar).Value = txt_Valor.Text;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        public FormGanancias(string user, string logged)
        {
            InitializeComponent();
            ifx = new Informix();
            userLogged = user;
            loggedAs = logged;
            lbl_User.Text = "Usuario: " + userLogged;
        }
    }
}
