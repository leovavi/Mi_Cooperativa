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
    public partial class Afiliado : Form
    {
        string userLogged, loggedAs;
        Informix ifx;

        public Afiliado(string user, string logged)
        {
            InitializeComponent();
            ifx = new Informix();
            userLogged = user;
            loggedAs = logged;
            lbl_User.Text = "Usuario: " + userLogged;
        }

        private void btn_Cuentas_Click(object sender, EventArgs e)
        {
            FormCuentas c = new FormCuentas(userLogged, loggedAs);
            this.Hide();
            c.Show();
            c.Closed += (s, args) => this.Close();
        }

        private void btn_Información_Click(object sender, EventArgs e)
        {
            FormEmpleados fe = new FormEmpleados(userLogged, loggedAs);
            this.Hide();
            fe.Show();
            fe.Closed += (s, args) => this.Close();
        }

        private void btn_Prest_Click(object sender, EventArgs e)
        {
            FormPrestamos p = new FormPrestamos(userLogged, loggedAs);
            this.Hide();
            p.Show();
            p.Closed += (s, args) => this.Close();
        }

        private void btn_Cierre_Sesion_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            this.Hide();
            login.Show();
            login.Closed += (s, args) => this.Close();
        }

        private void btn_Abonos_Click(object sender, EventArgs e)
        {
            FormAbonos fa = new FormAbonos(userLogged, loggedAs);
            this.Hide();
            fa.Show();
            fa.Closed += (s, args) => this.Close();
        }
    }
}
