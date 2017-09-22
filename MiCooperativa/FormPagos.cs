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
    public partial class FormPagos : Form
    {
        string userLogged, loggedAs;
        Informix ifx;
        public FormPagos(string user, string logged)
        {
            InitializeComponent();
            ifx = new Informix();
            userLogged = user;
            loggedAs = logged;
            lbl_User.Text = "Usuario: " + userLogged;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrador admin = new Administrador(userLogged, loggedAs);
            admin.Show();
            admin.Closed += (s, args) => this.Close();
        }

        private void FormPagos_Load(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_PAGOS_READ";
                cmd.Parameters.Add("P_NUMERO_PAGO", IfxType.VarChar).Value = "%";
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
    }
}
