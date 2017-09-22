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
    public partial class FormRoles : Form
    {
        string userLogged, loggedAs;
        Informix ifx;

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
                cmd.CommandText = "FN_ROLES_READ";
                cmd.Parameters.Add("P_ID_ROL", IfxType.VarChar).Value = "%";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                cb_Rol_Act.DataSource = dt;
                cb_Rol_Act.DisplayMember = "ID_ROL";
                cb_Rol_Act.ValueMember = "ID_ROL";

                cb_Rol_Eliminar.DataSource = dt;
                cb_Rol_Eliminar.DisplayMember = "ID_ROL";
                cb_Rol_Eliminar.ValueMember = "ID_ROL";

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

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error Eliminar Rol";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ROLES_DELETE";
                cmd.Parameters.Add("P_ID_ROL", IfxType.VarChar).Value = cb_Rol_Eliminar.Text;
                cmd.ExecuteNonQuery();

                string msg = "Rol eliminado exitosamente";
                cap = "Eliminar Rol";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                con.Close();
                updateCB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void FormRoles_Load(object sender, EventArgs e)
        {
            updateCB();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error Buscar Rol";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_ROLES_READ";
                if (txt_Valor.Text == "")
                    cmd.Parameters.Add("P_ID_ROL", IfxType.VarChar).Value = "%";
                else
                    cmd.Parameters.Add("P_" + cb_Rol_Act.Text, IfxType.VarChar).Value = txt_Valor.Text;
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                dgv_Rol.DataSource = dt;

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
            string cap = "Error Actualizar Rol";
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ROLES_UPDATE";
                cmd.Parameters.Add("P_ID_ROL", IfxType.VarChar).Value = cb_Rol_Act.Text;
                cmd.Parameters.Add("P_DESCRIPCION_ROL", IfxType.VarChar).Value = txt_Desc_Act.Text;
                cmd.ExecuteNonQuery();

                string msg = "Rol creado exitosamente";
                cap = "Agregar Rol";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error Agregar Rol";
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ROLES_CREATE";
                cmd.Parameters.Add("P_DESCRIPCION_ROL", IfxType.VarChar).Value = txt_Desc.Text;
                cmd.ExecuteNonQuery();

                string msg = "Rol creado exitosamente";
                cap = "Agregar Rol";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                con.Close();
                updateCB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        public FormRoles(string user, string logged)
        {
            InitializeComponent();
            ifx = new Informix();
            userLogged = user;
            loggedAs = logged;
            lbl_User.Text = "Usuario: " + userLogged;
        }
    }
}
