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
    public partial class Roles_Privilegios : Form
    {
        string userLogged, loggedAs;
        Informix ifx;

        private void Roles_Privilegios_Load(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error al Cargar";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_ROLES_READ";
                cmd.Parameters.Add("P_ID_ROL", IfxType.VarChar).Value = "%";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                cb_ID_Rol.DataSource = dt;
                cb_ID_Rol.DisplayMember = "ID_ROL";
                cb_ID_Rol.ValueMember = "ID_ROL";

                cb_RV_Act.DataSource = dt;
                cb_RV_Act.DisplayMember = "ID_ROL";
                cb_RV_Act.ValueMember = "ID_ROL";

                cb_RN_Act.DataSource = dt;
                cb_RN_Act.DisplayMember = "ID_ROL";
                cb_RN_Act.ValueMember = "ID_ROL";

                cb_Rol_Eliminar.DataSource = dt;
                cb_Rol_Eliminar.DisplayMember = "ID_ROL";
                cb_Rol_Eliminar.ValueMember = "ID_ROL";

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_PRIVILEGIOS_READ";
                cmd.Parameters.Add("P_ID_PRIVILEGIO", IfxType.VarChar).Value = "%";
                cmd.ExecuteNonQuery();

                dt = new DataTable();
                da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                cb_ID_Priv.DataSource = dt;
                cb_ID_Priv.DisplayMember = "ID_PRIVILEGIO";
                cb_ID_Priv.ValueMember = "ID_PRIVILEGIO";

                cb_PV_Act.DataSource = dt;
                cb_PV_Act.DisplayMember = "ID_PRIVILEGIO";
                cb_PV_Act.ValueMember = "ID_PRIVILEGIO";

                cb_PN_Act.DataSource = dt;
                cb_PN_Act.DisplayMember = "ID_PRIVILEGIO";
                cb_PN_Act.ValueMember = "ID_PRIVILEGIO";

                cb_Priv_Eliminar.DataSource = dt;
                cb_Priv_Eliminar.DisplayMember = "ID_PRIVILEGIO";
                cb_Priv_Eliminar.ValueMember = "ID_PRIVILEGIO";

                IfxDataReader dr = cmd.ExecuteReader();
                for (int i = 0; i < dr.FieldCount; i++)
                    cb_Filtro.Items.Add(dr.GetName(i));

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error Insertar Rol-Privilegio";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ROLES_PRIVILEGIOS_CREATE";
                cmd.Parameters.Add("P_ID_ROL", IfxType.VarChar).Value = cb_ID_Rol.Text;
                cmd.Parameters.Add("P_ID_PRIVILEGIO", IfxType.VarChar).Value = cb_ID_Priv.Text;
                cmd.ExecuteNonQuery();

                string msg = "Rol-Privilegio insertado exitosamente";
                cap = "Insertar Rol-Privilegio";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error Actualizar Rol-Privilegio";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ROLES_PRIVILEGIOS_UPDATE";
                cmd.Parameters.Add("P_ID_ROL", IfxType.VarChar).Value = cb_RV_Act.Text;
                cmd.Parameters.Add("P_ID_PRIVILEGIO", IfxType.VarChar).Value = cb_PV_Act.Text;
                cmd.Parameters.Add("NEW_ROL", IfxType.VarChar).Value = cb_RN_Act.Text;
                cmd.Parameters.Add("NEW_PRIVILEGIO", IfxType.VarChar).Value = cb_PN_Act.Text;
                cmd.ExecuteNonQuery();

                string msg = "Rol-Privilegio actualizado exitosamente";
                cap = "Actualizar Rol-Privilegio";
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
            string cap = "Error Buscar Rol-Privilegio";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_ROLES_PRIVILEGIOS_READ";
                cmd.Parameters.Add("P_ID_ROL", IfxType.VarChar).Value = "%";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                dgv_RP.DataSource = dt;

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
            string cap = "Error Eliminar Rol-Privilegio";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ROLES_PRIVILEGIOS_DELETE";
                cmd.Parameters.Add("P_ID_ROL", IfxType.VarChar).Value = cb_Rol_Eliminar.Text;
                cmd.Parameters.Add("P_ID_PRIVILEGIO", IfxType.VarChar).Value = cb_Priv_Eliminar.Text;
                cmd.ExecuteNonQuery();

                string msg = "Rol-Privilegio eliminado exitosamente";
                cap = "Eliminar Rol-Privilegio";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

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

        public Roles_Privilegios(string user, string logged)
        {
            InitializeComponent();
            ifx = new Informix();
            userLogged = user;
            loggedAs = logged;
            lbl_User.Text = "Usuario: " + userLogged;
        }
    }
}
