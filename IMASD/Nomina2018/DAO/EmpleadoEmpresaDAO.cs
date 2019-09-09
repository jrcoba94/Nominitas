using Nomina2018.BO;
using System.Data;
using System.Data.SqlClient;

namespace Nomina2018.DAO
{
    public class EmpleadoEmpresaDAO
    {
        DataSet empleadoEmpresaDS = new DataSet();
        string cadena = "Data Source=.; initial catalog = BDNOMINA2018; integrated security=true";
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlTransaction transaction;

        public void InsertarEmpleadoEmpresa(object obj)
        {
            EmpleadoEmpresaBO datos = (EmpleadoEmpresaBO)obj;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("InsertarEmpleadoEmpresa");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "INSERT INTO empleadoempresa (empresaID,empleadoID,departamentoID,puestoID,fechaingreso,antiguedad,nss,rfc,numeroempleado,estatus)" +
                        " values('" + datos.EmpresaID + "','" + datos.EmpleadoID + "','" + datos.DepartamentoID +
                        "','" + datos.PuestoID + "','" + datos.Fechaingreso.ToString("dd/MM/yyyy HH:mm") + "','" + datos.Antiguedad + "','" + datos.Nss + "','" + datos.Rfc + "','" + datos.Numeroempleado +
                        "','" + datos.Estatus + "')";

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

        public void EditarEmpleadoEmpresa(object obj)
        {
            EmpleadoEmpresaBO datos = (EmpleadoEmpresaBO)obj;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("EditarEmpleadoEmpresa");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "UPDATE empleadoempresa SET " +
                        "empresaID='" + datos.EmpresaID + "'" +
                        ", departamentoID='" + datos.DepartamentoID + "'" +
                        ", puestoID='" + datos.PuestoID + "'" +
                        ", antiguedad='" + datos.Antiguedad + "'" +
                        ", nss='" + datos.Nss + "'" +
                        ", rfc='" + datos.Rfc + "'" +
                        ", numeroempleado='" + datos.Numeroempleado + "'" +
                        " WHERE empleadoempresaID = '" + datos.EmpleadoempresaID + "'";
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

        public void EliminarEmpleadoEmpresa(object obj)
        {
            EmpleadoEmpresaBO datos = (EmpleadoEmpresaBO)obj;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("EliminarEmpleadoEmpresa");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "DELETE FROM empleadoempresa WHERE empleadoID = '" + datos.EmpleadoID + "'";
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

        public DataSet GetEmpleadosEmpresa(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            EmpleadoEmpresaBO data = (EmpleadoEmpresaBO)obj;
            adapter = new SqlDataAdapter();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("SelectEmpleadosEmpresa");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    if (data.EmpleadoID != 0)
                    {
                        cadenaWhere = cadenaWhere + " empleadoID=@EmpleadoID and";
                        command.Parameters.Add("@EmpleadoID", SqlDbType.Int);
                        command.Parameters["@EmpleadoID"].Value = data.EmpleadoID;
                        edo = true;
                    }

                    if (edo == true)
                    {
                        cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
                    }

                    command.CommandText = " SELECT * FROM empleadoempresa " + cadenaWhere;
                    transaction.Commit();

                    adapter.SelectCommand = command;
                    adapter.Fill(empleadoEmpresaDS);
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
                return empleadoEmpresaDS;
            }
        }
    }
}