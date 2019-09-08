using System.Data;
using System.Data.SqlClient;
using Nomina2018.BO;
using System;

namespace Nomina2018.DAO
{
    public class EmpleadosDAO
    {
        string cadena = "Data Source=.; initial catalog = BDNOMINA2018; integrated security=true";
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlTransaction transaction;

        public void InsertarEmpleado(object obj)
        {
            EmpleadosBO datos = (EmpleadosBO)obj;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("InsertarEmpleado");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "Insert into empleados (nombreempleado,apellidopaterno,apellidomaterno,direccion,correoelectronico,telefono1,telefono2,fechanacimiento,ciudad,estado,curp)" +
                        " values('" + datos.Nombreempleado + "','" + datos.Apellidopaterno + "','" + datos.Apellidomaterno +
                        "','" + datos.Direccion + "','" + datos.Correoelectronico + "','" + datos.Telefono1 + "','" + datos.Telefono2 +
                        "','" + datos.Fechanacimiento.ToString("dd/MM/yyyy HH:mm") + "','" + datos.Ciudad +
                        "','" + datos.Estado + "','" + datos.Curp + "')";

                    command.ExecuteNonQuery();
                    transaction.Commit();
                    datos.EmpleadoID = GetLastRowInserted();
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

        public void EditarEmpleado(object obj)
        {
            EmpleadosBO datos = (EmpleadosBO)obj;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("EditarEmpleado");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "UPDATE empleados SET " +
                        "nombreempleado='" + datos.Nombreempleado + "'" +
                        ", apellidopaterno='" + datos.Apellidopaterno + "'" +
                        ", apellidomaterno='" + datos.Apellidomaterno + "'" +
                        ", direccion='" + datos.Direccion + "'" +
                        ", correoelectronico='" + datos.Correoelectronico + "'" +
                        ", telefono1='" + datos.Telefono1 + "'" +
                        ", fechanacimiento='" + datos.Fechanacimiento.ToString("dd/MM/yyyy HH:mm") + "'" +
                        ", ciudad='" + datos.Ciudad + "'" +
                        ", estado='" + datos.Estado + "'" +
                        ", curp='" + datos.Curp + "' WHERE empleadoID = '" + datos.EmpleadoID + "'";
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

        public void EliminarEmpleado(object obj)
        {
            EmpleadosBO datos = (EmpleadosBO)obj;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("EliminarEmpleado");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "DELETE FROM empleados WHERE empleadoID = '" + datos.EmpleadoID + "'";
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

        public DataSet GetEmpleados(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            DataSet empleadosDS = new DataSet();
            ModelEpleadoEmpresa data = (ModelEpleadoEmpresa)obj;
            adapter = new SqlDataAdapter();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("SelectEmpleados");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    if (data.Nombreempleado != null)
                    {

                        cadenaWhere = cadenaWhere + " nombreempleado=@NombreEmpleado and";
                        command.Parameters.Add("@NombreEmpleado", SqlDbType.VarChar);
                        command.Parameters["@NombreEmpleado"].Value = data.Nombreempleado;
                        edo = true;
                    }

                    if (data.Apellidomaterno != null)
                    {

                        cadenaWhere = cadenaWhere + " apellidomaterno=@ApellidoMaterno and";
                        command.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar);
                        command.Parameters["@ApellidoMaterno"].Value = data.Apellidomaterno;
                        edo = true;
                    }

                    if (data.Apellidopaterno != null)
                    {

                        cadenaWhere = cadenaWhere + " apellidopaterno=@ApellidoPaterno and";
                        command.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar);
                        command.Parameters["@ApellidoPaterno"].Value = data.Apellidopaterno;
                        edo = true;
                    }

                    if (data.Nombredepartamento != null)
                    {

                        cadenaWhere = cadenaWhere + " nombredepartamento=@NombreDepartamento and";
                        command.Parameters.Add("@NombreDepartamento", SqlDbType.VarChar);
                        command.Parameters["@NombreDepartamento"].Value = data.Nombredepartamento;
                        edo = true;
                    }

                    if (edo == true)
                    {
                        cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
                    }

                    command.CommandText = " SELECT * FROM vwEmpleadoEmpresa " + cadenaWhere;
                    transaction.Commit();

                    adapter.SelectCommand = command;
                    adapter.Fill(empleadosDS);
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
                return empleadosDS;
            }
        }

        public DataSet GetEmpleado(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            DataSet empleadosDS = new DataSet();
            EmpleadosBO data = (EmpleadosBO)obj;
            adapter = new SqlDataAdapter();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("SelectEmpleado");
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

                    if (data.Nombreempleado != null)
                    {

                        cadenaWhere = cadenaWhere + " nombreempleado=@NombreEmpleado and";
                        command.Parameters.Add("@NombreEmpleado", SqlDbType.VarChar);
                        command.Parameters["@NombreEmpleado"].Value = data.Nombreempleado;
                        edo = true;
                    }

                    if (data.Apellidomaterno != null)
                    {

                        cadenaWhere = cadenaWhere + " apellidomaterno=@ApellidoMaterno and";
                        command.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar);
                        command.Parameters["@ApellidoMaterno"].Value = data.Apellidomaterno;
                        edo = true;
                    }

                    if (data.Apellidopaterno != null)
                    {

                        cadenaWhere = cadenaWhere + " apellidopaterno=@ApellidoPaterno and";
                        command.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar);
                        command.Parameters["@ApellidoPaterno"].Value = data.Apellidopaterno;
                        edo = true;
                    }
                                        
                    if (edo == true)
                    {
                        cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
                    }

                    command.CommandText = "SELECT * FROM empleados " + cadenaWhere;
                    transaction.Commit();

                    adapter.SelectCommand = command;
                    adapter.Fill(empleadosDS);
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
                return empleadosDS;
            }
        }

        public int GetLastRowInserted()
        {
            int id = 0;
            SqlDataReader empleadoDR;

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("SelectLastEmpleado");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    string query1 = "SELECT * FROM empleados ORDER BY empleadoID DESC";
                    command.CommandText = query1;
                    transaction.Commit();

                    empleadoDR = command.ExecuteReader();
                    if (empleadoDR.Read())
                    {
                        id = int.Parse(empleadoDR.GetValue(0).ToString());
                    }
                    empleadoDR.Close();
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

                return id;
            }
        }
    }
}