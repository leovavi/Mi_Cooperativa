using System;
using IBM.Data.Informix;
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
    public partial class LogIn : Form
    {
        Informix ifx = null;
        public LogIn()
        { 
            InitializeComponent();
            ifx = new Informix();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                IfxConnection con = ifx.getConnection();
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_DESCRIPCION_ROL_READ";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                cb_Sesion.DataSource = dt;
                cb_Sesion.DisplayMember = "DESCIPCION_ROL";
                cb_Sesion.ValueMember = "DESCRIPCION_ROL";

                con.Close();
            }catch(Exception ex)
            {
                DialogResult result = MessageBox.Show(this, ex.Message, "Error Inicio Sesion", MessageBoxButtons.OK);
            }
        }

        private void btn_Iniciar_Sesion_Click(object sender, EventArgs e)
        {
            try
            {
                int cantUsers = 0;

                IfxConnection con = ifx.getConnection();
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "fn_usuarios_read";
                cmd.Parameters.Add("P_ID_USUARIO", IfxType.VarChar).Value = txtbx_Usuario.Text;
                cmd.Parameters.Add("P_CONTRASENA", IfxType.VarChar).Value = txtbx_Contraseña.Text;

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                cantUsers = Convert.ToInt32(dt.Rows.Count.ToString());
                MessageBoxButtons boton = MessageBoxButtons.OK;

                if (cantUsers == 1)
                {
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "fn_usuarios_roles_login_read";
                    cmd.Parameters.Add("P_ID_USUARIO", IfxType.VarChar).Value = txtbx_Usuario.Text;
                    cmd.Parameters.Add("P_DESCRIPCION_ROL", IfxType.VarChar).Value = cb_Sesion.Text;
                    cmd.ExecuteNonQuery();
                    dt = new DataTable();
                    da = new IfxDataAdapter(cmd);
                    da.Fill(dt);

                    cantUsers = Convert.ToInt32(dt.Rows.Count.ToString());
                    Console.WriteLine(cantUsers);

                    if (cantUsers == 1)
                    {
                        if (cb_Sesion.Text.Equals("Administrador"))
                        {
                            Administrador admin = new Administrador(txtbx_Usuario.Text, cb_Sesion.Text);
                            this.Hide();
                            admin.Show();
                            admin.Closed += (s, args) => this.Close();
                        }else
                        {
                            Afiliado afiliado = new Afiliado(txtbx_Usuario.Text, cb_Sesion.Text);
                            this.Hide();
                            afiliado.Show();
                            afiliado.Closed += (s, args) => this.Close();
                        }
                    } else
                    {
                        string msg = "Usuario "+txtbx_Usuario.Text+" no cuenta con rol " + cb_Sesion.Text;
                        string caption = "Error Inicio de Sesión";
                        DialogResult resultado = MessageBox.Show(this, msg, caption, boton);
                    }
                }
                else {
                    string msg = "Usuario o Contraseña incorrectos";
                    string caption = "Error Inicio de Sesión";
                    DialogResult resultado = MessageBox.Show(this, msg, caption, boton);
                }
                con.Close();
            }catch(Exception ex)
            { 
                DialogResult result = MessageBox.Show(this, ex.Message, "Error Inicio Sesion", MessageBoxButtons.OK);
            }
        }
    }
}