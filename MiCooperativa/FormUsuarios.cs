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
    public partial class FormUsuarios : Form
    {
        string userLogged, loggedAs;
        Informix ifx;

        public FormUsuarios(string user, string logged)
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
            string cap = "Error Agregar Usuario";
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_USUARIOS_CREATE";
                cmd.Parameters.Add("P_ID_USUARIO", IfxType.VarChar).Value = txt_User.Text;
                cmd.Parameters.Add("P_CONTRASENA_USUARIO", IfxType.VarChar).Value = txt_Pass.Text;
                cmd.ExecuteNonQuery();

                string msg = "Usuario creado exitosamente";
                cap = "Agregar Usuario";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                con.Close();
                updateCB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error Actualizar Usuario";
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_USUARIOS_UPDATE";
                cmd.Parameters.Add("P_ID_USUARIO", IfxType.VarChar).Value = cb_User_Act.Text;
                cmd.Parameters.Add("P_CONTRASENA_USUARIO", IfxType.VarChar).Value = txt_Pass_Act.Text;
                cmd.ExecuteNonQuery();

                string msg = "Usuario creado exitosamente";
                cap = "Agregar Usuario";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void updateCB()
        {
            IfxConnection con = ifx.getConnection();
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_USUARIOS_READ";
                cmd.Parameters.Add("P_ID_USUARIO", IfxType.VarChar).Value = "%";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                cb_User_Act.DataSource = dt;
                cb_User_Act.DisplayMember = "ID_USUARIO";
                cb_User_Act.ValueMember = "ID_USUARIO";

                cb_User_Eliminar.DataSource = dt;
                cb_User_Eliminar.DisplayMember = "ID_USUARIO";
                cb_User_Eliminar.ValueMember = "ID_USUARIO";

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

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            updateCB();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error Buscar Usuario";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_USUARIOS_READ";
                if(txt_Valor.Text == "")
                    cmd.Parameters.Add("P_ID_USUARIO", IfxType.VarChar).Value = "%";
                else
                    cmd.Parameters.Add("P_"+cb_User_Act.Text, IfxType.VarChar).Value = txt_Valor.Text;
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                dgv_User.DataSource = dt;

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
            string cap = "Error Eliminar Usuario";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_USUARIOS_DELETE";
                cmd.Parameters.Add("P_ID_USUARIO", IfxType.VarChar).Value = cb_User_Eliminar.Text;
                cmd.ExecuteNonQuery();

                string msg = "Usuario eliminado exitosamente";
                cap = "Eliminar Usuario";
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
    }
}
