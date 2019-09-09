using System.Data;
using System.Data.SqlClient;
using Nomina2018.BO;

namespace Nomina2018.DAO
{
    public class PuestosDAO
    {
        string cadena = "Data Source=.; initial catalog = BDNOMINA2018; integrated security=true";
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlTransaction transaction;

        public void InsertarPuesto(object obj)
        {
            PuestoBO datos = (PuestoBO)obj;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("InsertarPuesto");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "Insert into puesto (nombrepuesto,nivel,sueldo)" +
                        " values('" + datos.Nombrepuesto + "','" + datos.Nivel + "','" + datos.Sueldo + "')";

                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (System.Exception ex)
                {
                    try
                    {
                        ex.Message.ToString();
                        transaction.Rollback();
                    }
                    catch (System.Exception)
                    {
                    }
                }
                connection.Close();
            }
        }

        public void EditarPuesto(object obj)
        {
            PuestoBO datos = (PuestoBO)obj;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("EditarPuesto");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "UPDATE puesto SET " +
                        "nombrepuesto='" + datos.Nombrepuesto + "'" +
                        ", sueldo='" + datos.Sueldo + "'" +
                        " WHERE puestoID = '" + datos.PuestoID + "'";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (System.Exception ex)
                {
                    try
                    {
                        ex.Message.ToString();
                        transaction.Rollback();
                    }
                    catch (System.Exception)
                    {
                    }
                }
                connection.Close();
            }
        }

        public DataSet GetPuestos(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            adapter = new SqlDataAdapter();
            DataSet puestosDS = new DataSet();
            PuestoBO data = (PuestoBO)obj;

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("SelectPuestos");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    if (data.PuestoID != 0)
                    {
                        cadenaWhere = cadenaWhere + " puestoID=@PuestoID and";
                        command.Parameters.Add("@PuestoID", SqlDbType.Int);
                        command.Parameters["@PuestoID"].Value = data.PuestoID;
                        edo = true;
                    }
                    if (edo == true)
                    {
                        cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
                    }

                    command.CommandText = "SELECT * FROM puesto " + cadenaWhere;
                    transaction.Commit();

                    adapter.SelectCommand = command;
                    adapter.Fill(puestosDS);
                    connection.Close();
                }
                catch (System.Exception ex)
                {
                    try
                    {
                        ex.Message.ToString();
                        connection.Close();
                        transaction.Rollback();
                    }
                    catch (System.Exception)
                    {
                    }
                }
                return puestosDS;
            }
        }
    }
}