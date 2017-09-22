using System;
using IBM.Data.Informix;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCooperativa
{
    class Informix
    {
        string ConnectionStr = "";
        IfxConnection con = null;

    public Informix()
        {
            ConnectionStr = "Host=*Leovavi;Service=coop;Server=cooperativa;Database=micooperativa;User Id=informix;Password=dbInformix;";
            MakeConnection();
        }

        public void MakeConnection()
        {
            try
            {
                con = new IfxConnection(ConnectionStr);
                con.Open();
                Console.WriteLine("Conexión establecida");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problema al intentar conexión: " + ex.Message);
            }
        }

        public void OpenConection()
        {
            con.Open();
        }

        public void CloseConnection()
        {
            con.Close();
        }

        public IfxConnection getConnection()
        {
            if (con.State != System.Data.ConnectionState.Open)
                OpenConection();
            return con;
        }
    }
}
