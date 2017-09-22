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
    public partial class FormCuentas : Form
    {
        Informix ifx;
        string userLogged, loggedAs;

        private void FormCuentas_Load(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error al inicializar Formulario";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_EMPLEADOS_READ";
                cmd.Parameters.Add("P_CODIGO_EMPLEADO", IfxType.VarChar).Value = "%";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                cb_CE.DataSource = dt;
                cb_CE.DisplayMember = "CODIGO_EMPLEADO";
                cb_CE.ValueMember = "CODIGO_EMPLEADO";

                updateCB();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void updateCB()
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error al inicializar ComboBox";

            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_CUENTAS_READ";
                cmd.Parameters.Add("P_NUMERO_CUENTA", IfxType.VarChar).Value = "%";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                cb_NC.DataSource = dt;
                cb_NC.DisplayMember = "NUMERO_CUENTA";
                cb_NC.ValueMember = "NUMERO_CUENTA";

                cb_NC_Eliminar.DataSource = dt;
                cb_NC_Eliminar.DisplayMember = "NUMERO_CUENTA";
                cb_NC_Eliminar.ValueMember = "NUMERO_CUENTA";

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
            string cap = "Error al insertar Cuenta";

            try
            {
                if (txt_Saldo.Text != "" && txt_Tipo.Text != "" && txt_Ahorro.Text != "")
                {
                    IfxCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_CUENTAS_CREATE";
                    cmd.Parameters.Add("P_SALDO_CUENTA", IfxType.Decimal).Value = Decimal.Parse(txt_Saldo.Text);
                    cmd.Parameters.Add("P_TIPO_CUENTA", IfxType.VarChar).Value = txt_Tipo.Text;
                    cmd.Parameters.Add("P_AHORRO_MENSUAL", IfxType.Decimal).Value = Decimal.Parse(txt_Ahorro.Text);
                    cmd.Parameters.Add("P_CODIGO_EMPLEADO", IfxType.VarChar).Value = cb_CE.Text;
                    cmd.Parameters.Add("P_ID_UC", IfxType.VarChar).Value = userLogged;
                    cmd.Parameters.Add("P_FECHA_APERTURA", IfxType.VarChar).Value = dtp_Apertura.Value.ToString("MM-dd-YYYY");
                    cmd.ExecuteNonQuery();

                    string msg = "Cuenta agregada exitosamente";
                    cap = "Insertar Cuenta";
                    MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                    updateCB();
                    con.Close();
                }else
                {
                    string msg = "Faltan Campos por rellenar";
                    MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
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

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error al insertar Cuenta";

            try
            {
                if (txt_Saldo.Text != "" && txt_Tipo.Text != "" && txt_Ahorro.Text != "")
                {
                    IfxCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_CUENTAS_UPDATE";
                    cmd.Parameters.Add("P_NUMERO_CUENTA", IfxType.VarChar).Value = cb_NC.Text;
                    cmd.Parameters.Add("P_SALDO_CUENTA", IfxType.Decimal).Value = Decimal.Parse(txt_Saldo.Text);
                    cmd.Parameters.Add("P_TIPO_CUENTA", IfxType.VarChar).Value = txt_Tipo.Text;
                    cmd.Parameters.Add("P_AHORRO_MENSUAL", IfxType.Decimal).Value = Decimal.Parse(txt_Ahorro.Text);
                    cmd.Parameters.Add("P_CODIGO_EMPLEADO", IfxType.VarChar).Value = cb_CE.Text;
                    cmd.Parameters.Add("P_FECHA_APERTURA", IfxType.VarChar).Value = dtp_Apertura.Value.ToString("MM-dd-YYYY");
                    cmd.ExecuteNonQuery();

                    string msg = "Cuenta actualizada exitosamente";
                    cap = "Actualizar Cuenta";
                    MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                    con.Close();
                }
                else
                {
                    string msg = "Faltan Campos por rellenar";
                    MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error al insertar Cuenta";

            try
            {
                
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_CUENTAS_READ";
                if (txt_Valor.Text == "")
                {
                    cmd.Parameters.Add("P_" + cb_Filtro.Text, IfxType.VarChar).Value = "%";
                }
                else
                {
                    cmd.Parameters.Add("P_" + cb_Filtro.Text, txt_Valor.Text);
                }
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                dgv_Cuentas.DataSource = dt;
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
            string cap = "Error al insertar Cuenta";

            try
            {

                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_CUENTAS_READ";
                cmd.Parameters.Add("P_NUMERO_CUENTA", IfxType.VarChar).Value = cb_NC_Eliminar.Text;
                cmd.ExecuteNonQuery();


                string msg = "Cuenta eliminada exitosamente";
                cap = "Eliminar Cuenta";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

                updateCB();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, cap, MessageBoxButtons.OK);
            }
        }

        public FormCuentas(string user, string logged)
        {
            InitializeComponent();
            ifx = new Informix();
            userLogged = user;
            loggedAs = logged;
            lbl_User.Text = "Usuario: " + userLogged;
        }
    }
}
