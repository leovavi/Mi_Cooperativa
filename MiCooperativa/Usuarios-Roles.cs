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
    public partial class Usuarios_Roles : Form
    {
        string userLogged, loggedAs;
        Informix ifx;

        public Usuarios_Roles(string user, string logged)
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
            string cap = "Error Insertar Usuario-Rol";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_USUARIOS_ROLES_CREATE";
                cmd.Parameters.Add("P_ID_ROL", IfxType.VarChar).Value = cb_ID_Rol.Text;
                cmd.Parameters.Add("P_ID_USUARIO", IfxType.VarChar).Value = cb_ID_User.Text;
                cmd.ExecuteNonQuery();

                string msg = "Usuario-Rol insertado exitosamente";
                cap = "Insertar Usuario-Rol";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void Usuarios_Roles_Load(object sender, EventArgs e)
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
                cmd.CommandText = "FN_USUARIOS_READ";
                cmd.Parameters.Add("P_ID_USUARIO", IfxType.VarChar).Value = "%";
                cmd.ExecuteNonQuery();

                dt = new DataTable();
                da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                cb_ID_User.DataSource = dt;
                cb_ID_User.DisplayMember = "ID_USUARIO";
                cb_ID_User.ValueMember = "ID_USUARIO";

                cb_UV_Act.DataSource = dt;
                cb_UV_Act.DisplayMember = "ID_USUARIO";
                cb_UV_Act.ValueMember = "ID_USUARIO";

                cb_UN_Act.DataSource = dt;
                cb_UN_Act.DisplayMember = "ID_USUARIO";
                cb_UN_Act.ValueMember = "ID_USUARIO";

                cb_User_Eliminar.DataSource = dt;
                cb_User_Eliminar.DisplayMember = "ID_USUARIO";
                cb_User_Eliminar.ValueMember = "ID_USUARIO";

                IfxDataReader dr = cmd.ExecuteReader();
                for (int i = 0; i < dr.FieldCount; i++)
                    cb_Filtro.Items.Add(dr.GetName(i));

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
            string cap = "Error Actualizar Usuario-Rol";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_USUARIOS_ROLES_UPDATE";
                cmd.Parameters.Add("P_ID_ROL", IfxType.VarChar).Value = cb_RV_Act.Text;
                cmd.Parameters.Add("P_ID_USUARIO", IfxType.VarChar).Value = cb_UV_Act.Text;
                cmd.Parameters.Add("NEW_ROL", IfxType.VarChar).Value = cb_RN_Act.Text;
                cmd.Parameters.Add("NEW_USUARIO", IfxType.VarChar).Value = cb_UN_Act.Text;
                cmd.ExecuteNonQuery();

                string msg = "Usuario-Rol actualizado exitosamente";
                cap = "Actualizar Usuario-Rol";
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
            string cap = "Error Buscar Usuario-Rol";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_USUARIOS_ROLES_READ";
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
            string cap = "Error Eliminar Usuario-Rol";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_USUARIOS_ROLES_DELETE";
                cmd.Parameters.Add("P_ID_ROL", IfxType.VarChar).Value = cb_Rol_Eliminar.Text;
                cmd.Parameters.Add("P_ID_USUARIO", IfxType.VarChar).Value = cb_User_Eliminar.Text;
                cmd.ExecuteNonQuery();

                string msg = "Usuario-Rol eliminado exitosamente";
                cap = "Eliminar Usuario-Rol";
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
    }
}
