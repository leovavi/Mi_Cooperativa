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
    public partial class Administrador : Form
    {
        string userLogged;
        string loggedAs;
        public Administrador(string user, string logged)
        {
            InitializeComponent();
            userLogged = user;
            loggedAs = logged;
            lblUserLogged.Text = "Usuario: " + userLogged;
        }

        private void btnCierreSesion_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            this.Hide();
            login.Show();
            login.Closed += (s, args) => this.Close();
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            FormEmpleados fe = new FormEmpleados(userLogged, loggedAs);
            this.Hide();
            fe.Show();
            fe.Closed += (s, args) => this.Close();
        }

        private void btn_Abonos_Click(object sender, EventArgs e)
        {
            FormAbonos fa = new FormAbonos(userLogged, loggedAs);
            this.Hide();
            fa.Show();
            fa.Closed += (s, args) => this.Close();
        }

        private void btn_Cuentas_Click(object sender, EventArgs e)
        {
            FormCuentas c = new FormCuentas(userLogged, loggedAs);
            this.Hide();
            c.Show();
            c.Closed += (s, args) => this.Close();
        }

        private void btn_Prestamos_Click(object sender, EventArgs e)
        {
            FormPrestamos p = new FormPrestamos(userLogged, loggedAs);
            this.Hide();
            p.Show();
            p.Closed += (s, args) => this.Close();
        }

        private void btn_Pagos_Click(object sender, EventArgs e)
        {
            FormPagos p = new FormPagos(userLogged, loggedAs);
            this.Hide();
            p.Show();
            p.Closed += (s, args) => this.Close();
        }

        private void btn_Ganancias_Click(object sender, EventArgs e)
        {
            FormGanancias g = new FormGanancias(userLogged, loggedAs);
            this.Hide();
            g.Show();
            g.Closed += (s, args) => this.Close();
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios u = new FormUsuarios(userLogged, loggedAs);
            this.Hide();
            u.Show();
            u.Closed += (s, args) => this.Close();
        }

        private void btn_Roles_Click(object sender, EventArgs e)
        {
            FormRoles r = new FormRoles(userLogged, loggedAs);
            this.Hide();
            r.Show();
            r.Closed += (s, args) => this.Close();
        }

        private void btn_Privilegios_Click(object sender, EventArgs e)
        {
            FormPrivilegios priv = new FormPrivilegios(userLogged, loggedAs);
            this.Hide();
            priv.Show();
            priv.Closed += (s, args) => this.Close();
        }

        private void btnRolesPriv_Click(object sender, EventArgs e)
        {
            Roles_Privilegios rp = new Roles_Privilegios(userLogged, loggedAs);
            this.Hide();
            rp.Show();
            rp.Closed += (s, args) => this.Close();
        }

        private void btnUserRoles_Click(object sender, EventArgs e)
        {
            Usuarios_Roles ur = new Usuarios_Roles(userLogged, loggedAs);
            this.Hide();
            ur.Show();
            ur.Closed += (s, args) => this.Close();
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            FormReportes ur = new FormReportes(userLogged, loggedAs);
            this.Hide();
            ur.Show();
            ur.Closed += (s, args) => this.Close();
        }
    }
}
