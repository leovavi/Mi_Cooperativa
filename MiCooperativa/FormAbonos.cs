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
    public partial class FormAbonos : Form
    {
        string userLogged, loggedAs;
        Informix ifx;

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (loggedAs == "Administrador")
            {
                Administrador admin = new Administrador(userLogged, loggedAs);
                admin.Show();
                admin.Closed += (s, args) => this.Close();
            }
            else
            {
                Afiliado afiliado = new Afiliado(userLogged, loggedAs);
                afiliado.Show();
                afiliado.Closed += (s, args) => this.Close();
            }
        }

        private void FormAbonos_Load(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_ABONOS_READ";
                cmd.Parameters.Add("P_CODIGO_ABONO", IfxType.VarChar).Value = "%";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                cb_Abonos.DataSource = dt;
                cb_Abonos.DisplayMember = "CODIGO_ABONO";
                cb_Abonos.ValueMember = "CODIGO_ABONO";

                IfxDataReader dr = cmd.ExecuteReader();

                for (int i = 0; i < dr.FieldCount; i++)
                    cb_Filtro.Items.Add(dr.GetName(i));

                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error al Cargar Formulario", MessageBoxButtons.OK);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error al eliminar Abono";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ABONOS_DELETE";
                cmd.Parameters.Add("P_CODIGO_ABONO", IfxType.VarChar).Value = cb_Abonos.Text;

                cmd.ExecuteNonQuery();

                cap = "Eliminar Abono";
                string msg = "Abono eliminado exitosamente";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error al Buscar Abono";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();

                if (loggedAs == "Administrador")
                {
                    cmd.CommandText = "FN_ABONOS_READ";
                    if (txt_Valor.Text == "")
                    {
                        cmd.Parameters.Add("P_CODIGO_ABONO", IfxType.VarChar).Value = "%";
                    }
                    else
                    {
                        cmd.Parameters.Add("P_" + cb_Filtro.Text, IfxType.VarChar).Value = txt_Valor.Text;
                    }

                    cmd.ExecuteNonQuery();
                    IfxDataAdapter da = new IfxDataAdapter(cmd);
                    da.Fill(dt);
                }
                else
                {
                    cmd.CommandText = "FN_ABONOS_READ_AFILIADO";
                    cmd.Parameters.Add("P_USER", IfxType.VarChar).Value = userLogged;
                    cmd.ExecuteNonQuery();

                    IfxDataAdapter da = new IfxDataAdapter(cmd);
                    da.Fill(dt);
                }

                dgv_Abono.DataSource = dt;
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        public FormAbonos(string user, string logged)
        {
            InitializeComponent();
            userLogged = user;
            loggedAs = logged;
            lbl_User.Text = "Usuario: " + userLogged;
            ifx = new Informix();

            if(loggedAs == "Afiliado")
            {
                tabControl1.TabPages.Remove(tab_Eliminar);
            }
        }
    }
}
