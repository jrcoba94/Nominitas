using System.Data.SqlClient;

namespace Nomina2018.DAO
{
    public class ConexionDB
    {
        public ConexionDB() { }

        SqlConnection con;

        public SqlConnection establecerConexion()
        {
            string cadena = "Data Source=.; initial catalog = BDNOMINA2018; integrated security=true";
            con = new SqlConnection(cadena);
            return con;
        }

        public void AbrirConexion()
        {
            con.Open();
        }

        public void CerrarConexion()
        {
            con.Close();
        }
    }
}