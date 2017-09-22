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
    public partial class FormEmpleados : Form
    {
        string userLogged;
        string loggedAs;

        Informix ifx;
        public FormEmpleados(string user, string logged)
        {
            InitializeComponent();
            ifx = new Informix();
            userLogged = user;
            loggedAs = logged;
            
            if(loggedAs == "Afiliado")
            {
                tabControl.TabPages.Remove(insertar_Empleados);
                tabControl.TabPages.Remove(eliminar_Empleados);
                tabControl.TabPages.Remove(actualizar_Empleados);
                tabControl.TabPages.Remove(telefonos_Empleados);
            }
            lbl_UserLogged.Text = "Usuario: "+userLogged;
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            IfxCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "FN_ID_USUARIO_READ";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            IfxDataAdapter da = new IfxDataAdapter(cmd);
            da.Fill(dt);

            cb_Users.DataSource = dt;
            cb_Users.DisplayMember = "ID_USUARIO";
            cb_Users.ValueMember = "ID_USUARIO";

            cb_Users_Act.DataSource = dt;
            cb_Users_Act.DisplayMember = "ID_USUARIO";
            cb_Users_Act.ValueMember = "ID_USUARIO";

            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "FN_EMPLEADOS_READ";
            cmd.Parameters.Add("P_CODIGO_EMPLEADO", IfxType.VarChar).Value = "%";
            cmd.ExecuteNonQuery();

            dt = new DataTable();
            da = new IfxDataAdapter(cmd);
            da.Fill(dt);

            cb_CE_Eliminar.DataSource = dt;
            cb_CE_Eliminar.DisplayMember = "CODIGO_EMPLEADO";
            cb_CE_Eliminar.ValueMember = "CODIGO_EMPLEADO";

            cb_CE_Act.DataSource = dt;
            cb_CE_Act.DisplayMember = "CODIGO_EMPLEADO";
            cb_CE_Act.ValueMember = "CODIGO_EMPLEADO";

            IfxDataReader dr = cmd.ExecuteReader();
            for (int i = 0; i < dr.FieldCount; i++)
                cb_Filtro.Items.Add(dr.GetName(i));

            cb_Filtro_Tel.Items.Add("CODIGO_EMPLEADO");
            cb_Filtro_Tel.Items.Add("TELEFONO_EMPLEADO");

            con.Close();
        }

        private void updateCBEmpleados()
        {
            IfxConnection con = ifx.getConnection();
            IfxCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "FN_EMPLEADOS_READ";
            cmd.Parameters.Add("P_CODIGO_EMPLEADO", IfxType.VarChar).Value = "%";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            IfxDataAdapter da = new IfxDataAdapter(cmd);
            da.Fill(dt);

            cb_CE_Eliminar.DataSource = dt;
            cb_CE_Eliminar.DisplayMember = "CODIGO_EMPLEADO";
            cb_CE_Eliminar.ValueMember = "CODIGO_EMPLEADO";

            cb_CE_Act.DataSource = dt;
            cb_CE_Act.DisplayMember = "CODIGO_EMPLEADO";
            cb_CE_Act.ValueMember = "CODIGO_EMPLEADO";

            con.Close();
        }

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

        private void btn_Eliminar_Emp_Click(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EMPLEADOS_DELETE";
                cmd.Parameters.Add("COD_EMP", IfxType.VarChar).Value = cb_CE_Eliminar.Text;
                cmd.ExecuteNonQuery();

                string cap = "Empleado Eliminado";
                string msg = "Empleado eliminado exitosamente";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                con.Close();
                updateCBEmpleados();
            }
            catch(Exception ex)
            {
                string cap = "Error al Eliminar Empleado";
                DialogResult result = MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void btn_Agregar_Empleado_Click(object sender, EventArgs e)
        {
            string cap = "Error al Insertar empleado";
            IfxConnection con = ifx.getConnection();
            if (txt_PN.Text != "" && txt_SN.Text != "" && txt_PA.Text != "" && txt_SA.Text != "" &&
               txt_NC.Text != "" && txt_Avenida.Text != "" && txt_Ciudad.Text != "" && 
               txt_Dept.Text != "" && txt_CorreoP.Text != "")
            {
                try
                {
                    IfxCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_EMPLEADOS_CREATE";

                    cmd.Parameters.Add("PN", IfxType.VarChar).Value = txt_PN.Text;
                    cmd.Parameters.Add("SN", IfxType.VarChar).Value = txt_SN.Text;
                    cmd.Parameters.Add("PA", IfxType.VarChar).Value = txt_PA.Text;
                    cmd.Parameters.Add("SA", IfxType.VarChar).Value = txt_SA.Text;
                    cmd.Parameters.Add("D_CALLE", IfxType.Integer).Value = Int32.Parse(txt_NC.Text);
                    cmd.Parameters.Add("D_AVENIDA", IfxType.VarChar).Value = txt_Avenida.Text;
                    cmd.Parameters.Add("D_CIUDAD", IfxType.VarChar).Value = txt_Ciudad.Text;
                    cmd.Parameters.Add("D_DEP", IfxType.VarChar).Value = txt_Dept.Text;
                    cmd.Parameters.Add("CEP", IfxType.VarChar).Value = txt_CorreoP.Text;
                    cmd.Parameters.Add("F_NAC", IfxType.VarChar).Value = dtp_Nac.Value.ToString("MM-dd-yyyy");
                    cmd.Parameters.Add("F_INICIO_EMP", IfxType.VarChar).Value = dtp_Fecha_IE.Value.ToString("MM-dd-yyyy");
                    cmd.Parameters.Add("ID_USER", IfxType.VarChar).Value = cb_Users.Text;
                    cmd.Parameters.Add("ID_UC", IfxType.VarChar).Value = userLogged;
                    cmd.Parameters.Add("D_NC", IfxType.Integer).Value = Int32.Parse(txt_Casa.Text);
                    cmd.Parameters.Add("CES", IfxType.VarChar).Value = txt_Dept.Text;
                    cmd.Parameters.Add("D_REF", IfxType.VarChar).Value = txt_Ref.Text;

                    cmd.ExecuteNonQuery();

                    cap = "Insertar Empleado";
                    string msg = "Empleado insertado exitosamente";
                    MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                    con.Close();
                    updateCBEmpleados();
                }
                catch(IfxException ex)
                { 
                    MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
                }
            }else
            {
                string msg = "Hay campos vacíos que requieren ser llenados";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);
            }
        }

        private void btn_Agregar_Tel_Click(object sender, EventArgs e)
        {
            string cap = "Error al Agregar Teléfono";
            IfxConnection con = ifx.getConnection();

            if (txt_CE_TA.Text != "" && txt_TE_TA.Text != "")
            {
                try
                {
                    IfxCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_TELEFONOS_EMPLEADOS_CREATE";

                    cmd.Parameters.Add("P_TELEFONO", IfxType.VarChar).Value = txt_TE_TA.Text;
                    cmd.Parameters.Add("P_CODIGO_EMPLEADO", IfxType.VarChar).Value = txt_CE_TA.Text;
                     
                    cmd.ExecuteNonQuery();

                    string msg = "Telefono para Empleado " + txt_CE_TA.Text + " agregado correctamente";
                    cap = "Insertar Teléfono";
                    MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                    con.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
                }
            }
            else
            {
                string msg = "Los campos de Código Empleado y Teléfono Empleado deben llenarse";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);
            }
        }

        private void btn_Eliminar_Tel_Click(object sender, EventArgs e)
        {
            string cap = "Error al Eliminar Teléfono";
            IfxConnection con = ifx.getConnection();

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_TELEFONOS_EMPLEADOS_DELETE";

                cmd.Parameters.Add("P_TELEFONO", IfxType.VarChar).Value = txt_TE_TE.Text;
                cmd.Parameters.Add("P_CODIGO_EMPLEADO", IfxType.VarChar).Value = txt_CE_TE.Text;

                cmd.ExecuteNonQuery();

                string msg = "Telefono " + txt_TE_TE.Text + "eliminado";
                cap = "Eliminar Teléfono";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void btn_Actualizar_Tel_Click(object sender, EventArgs e)
        {
            string cap = "Error al Actualizar Teléfono";
            IfxConnection con = ifx.getConnection();

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_TELEFONOS_EMPLEADOS_UPDATE";

                cmd.Parameters.Add("P_TELEFONO", IfxType.VarChar).Value = txt_TV_TA.Text;
                cmd.Parameters.Add("P_CODIGO_EMPLEADO", IfxType.VarChar).Value = txt_CEV_TA.Text;
                cmd.Parameters.Add("NEW_TELEFONO", IfxType.VarChar).Value = txt_TN_TA.Text;
                cmd.Parameters.Add("NEW_CE", IfxType.VarChar).Value = txt_TN_TA.Text;

                cmd.ExecuteNonQuery();

                string msg = "Telefono actualizado";
                cap = "Actualizar Teléfono";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            string cap = "Error al Insertar empleado";
            IfxConnection con = ifx.getConnection();
            if (txt_PN_Act.Text != "" && txt_SN_Act.Text != "" && txt_PA_Act.Text != "" && txt_SA_Act.Text != "" &&
               txt_Calle_Act.Text != "" && txt_Ave_Act.Text != "" && txt_Ciudad_Act.Text != "" &&
               txt_Dept_Act.Text != "" && txt_CP_Act.Text != "")
            {
                try
                {
                    IfxCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_EMPLEADOS_UPDATE";

                    cmd.Parameters.Add("COD_EMP", IfxType.VarChar).Value = cb_CE_Act.Text;
                    cmd.Parameters.Add("PN", IfxType.VarChar).Value = txt_PN_Act.Text;
                    cmd.Parameters.Add("SN", IfxType.VarChar).Value = txt_SN_Act.Text;
                    cmd.Parameters.Add("PA", IfxType.VarChar).Value = txt_PA_Act.Text;
                    cmd.Parameters.Add("SA", IfxType.VarChar).Value = txt_SA_Act.Text;
                    cmd.Parameters.Add("D_CALLE", IfxType.Integer).Value = txt_Calle_Act.Text;
                    cmd.Parameters.Add("D_AVENIDA", IfxType.VarChar).Value = txt_Ave_Act.Text;
                    cmd.Parameters.Add("D_CIUDAD", IfxType.VarChar).Value = txt_Ciudad_Act.Text;
                    cmd.Parameters.Add("D_DEP", IfxType.VarChar).Value = txt_Dept_Act.Text;
                    cmd.Parameters.Add("CEP", IfxType.VarChar).Value = txt_CP_Act.Text;
                    cmd.Parameters.Add("F_NAC", IfxType.VarChar).Value = dtp_FN_Act.Value.ToString("MM-dd-yyyy");
                    cmd.Parameters.Add("F_INICIO_EMP", IfxType.VarChar).Value = dtp_FIE_Act.Value.ToString("MM-dd-yyyy");
                    cmd.Parameters.Add("ID_USER", IfxType.VarChar).Value = cb_Users_Act.Text;
                    cmd.Parameters.Add("ID_UM", IfxType.VarChar).Value = userLogged;
                    cmd.Parameters.Add("D_NC", IfxType.Integer).Value = txt_Casa_Act.Text;
                    cmd.Parameters.Add("CES", IfxType.VarChar).Value = txt_CS_Act.Text;
                    cmd.Parameters.Add("D_REF", IfxType.VarChar).Value = txt_Ref_Act.Text;

                    cmd.ExecuteNonQuery();

                    cap = "Actualizar Empleado";
                    string msg = "Empleado actualizado exitosamente";
                    MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
                }
            }
            else
            {
                string msg = "Hay campos vacíos que requieren ser llenados";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string cap = "Error al Buscar Empleado";
            IfxConnection con = ifx.getConnection();
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_EMPLEADOS_READ";
                if (txt_Busqueda.Text == "")
                {
                    cmd.Parameters.Add("P_CODIGO_EMPLEADO", IfxType.VarChar).Value = "%";
                }
                else if (cb_Filtro.Text.Equals("direccion_calle"))
                {
                    cmd.Parameters.Add("P_" + cb_Filtro.Text, IfxType.Integer).Value = Int32.Parse(txt_Busqueda.Text);
                    Console.WriteLine("DENTRO");
                }
                else
                {
                    cmd.Parameters.Add("P_" + cb_Filtro.ToString(), IfxType.VarChar).Value = txt_Busqueda.Text;
                }

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                dgv_Emp_Busqueda.DataSource = dt;
            }catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void btn_Buscar_Tel_Click(object sender, EventArgs e)
        {
            string cap = "Error al Buscar Telefono";
            IfxConnection con = ifx.getConnection();
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_TELEFONOS_EMPLEADOS_READ";
                if (txt_Busqueda.Text == "")
                {
                    cmd.Parameters.Add("P_CODIGO_EMPLEADO", IfxType.VarChar).Value = "%";
                }
                else
                {
                    cmd.Parameters.Add("P_" + cb_Filtro_Tel.Text, IfxType.VarChar).Value = txt_Busqueda.Text;
                }

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                dgv_Telefonos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void cb_CE_Act_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cap = "Error al Buscar Telefono";
            IfxConnection con = ifx.getConnection();
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_TELEFONOS_EMPLEADOS_READ";
                if (txt_Busqueda.Text == "")
                {
                    cmd.Parameters.Add("P_CODIGO_EMPLEADO", IfxType.VarChar).Value = "%";
                }
                else
                {
                    cmd.Parameters.Add("P_" + cb_Filtro_Tel.Text, IfxType.VarChar).Value = txt_Busqueda.Text;
                }

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                dgv_Telefonos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }
    }
}
