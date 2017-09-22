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
    public partial class FormPrivilegios : Form
    {
        string userLogged, loggedAs;
        Informix ifx;

        public FormPrivilegios(string user, string logged)
        {
            InitializeComponent();
            ifx = new Informix();
            userLogged = user;
            loggedAs = logged;
            lbl_User.Text = "Usuario: " + userLogged;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error Agregar Privilegio";
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PRIVILEGIOS_CREATE";
                cmd.Parameters.Add("P_DESCRIPCION_PRIVILEGIO", IfxType.VarChar).Value = txt_Priv.Text;
                cmd.ExecuteNonQuery();

                string msg = "Privilegio creado exitosamente";
                cap = "Agregar Privilegio";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                con.Close();
                updateCB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void FormPrivilegios_Load(object sender, EventArgs e)
        {
            updateCB();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error Actualizar Privilegio";
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PRIVILEGIOS_UPDATE";
                cmd.Parameters.Add("P_ID_PRIVILEGIO", IfxType.VarChar).Value = cb_Priv_Act.Text;
                cmd.Parameters.Add("P_DESCRIPCION_PRIVILEGIO", IfxType.VarChar).Value = txt_Desc_Act.Text;
                cmd.ExecuteNonQuery();

                string msg = "Privilegio creado exitosamente";
                cap = "Agregar Privilegio";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error Buscar Privilegio";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_PRIVILEGIOS_READ";
                if (txt_Valor.Text == "")
                    cmd.Parameters.Add("P_ID_PRIVILEGIO", IfxType.VarChar).Value = "%";
                else
                    cmd.Parameters.Add("P_" + cb_Priv_Act.Text, IfxType.VarChar).Value = txt_Valor.Text;
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                dgv_Priv.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error Eliminar Privilegio";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PRIVILEGIOS_DELETE";
                cmd.Parameters.Add("P_ID_ROL", IfxType.VarChar).Value = cb_Priv_Eliminar.Text;
                cmd.ExecuteNonQuery();

                string msg = "Privilegio eliminado exitosamente";
                cap = "Eliminar Privilegio";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                con.Close();
                updateCB();
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

        private void updateCB()
        {
            IfxConnection con = ifx.getConnection();
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_PRIVILEGIOS_READ";
                cmd.Parameters.Add("P_ID_PRIVILEGIO", IfxType.VarChar).Value = "%";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                cb_Priv_Act.DataSource = dt;
                cb_Priv_Act.DisplayMember = "ID_PRIVILEGIO";
                cb_Priv_Act.ValueMember = "ID_PRIVILEGIO";

                cb_Priv_Eliminar.DataSource = dt;
                cb_Priv_Eliminar.DisplayMember = "ID_PRIVILEGIO";
                cb_Priv_Eliminar.ValueMember = "ID_PRIVILEGIO";

                IfxDataReader dr = cmd.ExecuteReader();

                cb_Filtro.Items.Clear();
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
