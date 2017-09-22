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
    public partial class FormPrestamos : Form
    {
        string userLogged, loggedAs;
        Informix ifx;
        public FormPrestamos(string user, string logged)
        {
            InitializeComponent();
            userLogged = user;
            loggedAs = logged;
            ifx = new Informix();
            lbl_User.Text = "Usuario: " + userLogged;
        }

        private void FormPrestamos_Load(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_PRESTAMOS_READ";
                cmd.Parameters.Add("P_NUMERO_PRESTAMO", IfxType.VarChar).Value = "%";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                cb_NP_Eliminar.DataSource = dt;
                cb_NP_Eliminar.DisplayMember = "NUMERO_PRESTAMO";
                cb_NP_Eliminar.ValueMember = "NUMERO_PRESTAMO";

                IfxDataReader dr = cmd.ExecuteReader();

                for (int i = 0; i < dr.FieldCount; i++)
                    cb_Filtro.Items.Add(dr.GetName(i));

                updateCB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error al Cargar Formulario", MessageBoxButtons.OK);
            }
        }

        private void updateCB()
        {
            IfxConnection con = ifx.getConnection();
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

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error al Cargar Formulario", MessageBoxButtons.OK);
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            IfxConnection con = ifx.getConnection();
            string cap = "Error Insertar Préstamo";
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PRESTAMOS_CREATE";
                cmd.Parameters.Add("P_MONTO_PRESTAMO", IfxType.VarChar).Value = Decimal.Parse(txt_Monto.Text);
                cmd.Parameters.Add("P_PERIODOS_PRESTAMO", IfxType.Integer).Value = Int32.Parse(txt_Periodos.Text);
                cmd.Parameters.Add("P_CODIGO_EMPLEADO", IfxType.VarChar).Value = cb_CE.Text;
                cmd.Parameters.Add("P_ID_UC", IfxType.VarChar).Value = cb_CE.Text;
                cmd.ExecuteNonQuery();

                string msg = "Préstamo agregado exitosamente";
                cap = "Insertar Préstamo";
                MessageBox.Show(this, msg, cap, MessageBoxButtons.OK);

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
            string cap = "Error Eliminar Préstamo";
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PRESTAMOS_DELETE";
                cmd.Parameters.Add("P_NUMERO_PRESTAMO", IfxType.VarChar).Value = cb_NP_Eliminar.Text;
                cmd.ExecuteNonQuery();

                string msg = "Préstamo eliminado exitosamente";
                cap = "Eliminar Préstamo";
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
            string cap = "Error Buscar Préstamo";
            try
            {
                IfxCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FN_PRESTAMOS_READ";
                if(txt_Valor.Text == "")
                    cmd.Parameters.Add("P_NUMERO_PRESTAMO", IfxType.VarChar).Value = "%";
                else
                    cmd.Parameters.Add("P_"+cb_Filtro.Text, IfxType.VarChar).Value = txt_Valor.Text;
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                IfxDataAdapter da = new IfxDataAdapter(cmd);
                da.Fill(dt);

                dgv_Prest.DataSource = dt;

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
    }
}
