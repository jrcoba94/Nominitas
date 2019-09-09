using System;
using System.Data.SqlClient;
using Nomina2018.BO;
using System.Data;

namespace Nomina2018.DAO
{
    public class NominasDAO
    {
        string cadena = "Data Source=.; initial catalog = BDNOMINA2018; integrated security=true";
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlTransaction transaction;

        public void InsertarNomina(object obj)
        {
            NominasBO datos = (NominasBO)obj;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("InsertarNominas");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "Insert into nominas (fechapago,empleadoempresaID,diastrabajados,sueldodiario,sueldoquincenal,bonoasistencia,bonopuntualidad,despensa,imss,isr,prestamocrediticio,creditoinfonavit,totalpercepcion,totaldeduccion,totalsueldo)" +
                        " values('" + datos.Fechapago.ToString("dd/MM/yyyy HH:mm") +
                        "','" + datos.EmpleadoempresaID + "','" + datos.Diastrabajados +
                        "','" + datos.Sueldodiario + "','" + datos.Sueldoquincenal +
                        "','" + datos.Bonoasistencia + "','" + datos.Bonopuntualidad +
                        "','" + datos.Despensa + "','" + datos.Imss + "','" + datos.Isr +
                        "','" + datos.Prestamocrediticio + "','" + datos.Creditoinfonavit +
                        "','" + datos.Totalpercepcion + "','" + datos.Totaldeduccion +
                        "','" + datos.Totalsueldo + "')";

                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    try
                    {
                        ex.Message.ToString();
                        transaction.Rollback();
                    }
                    catch (Exception)
                    {
                    }
                }
                connection.Close();
            }
        }

        public void EditarNomina(object obj)
        {
            NominasBO datos = (NominasBO)obj;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("EditarNominas");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "UPDATE nominas SET " +
                        "Fechainicio='" + datos.Fechainicio.ToString("dd/MM/yyyy HH:mm") + "'" +
                        ", fechacierre='" + datos.Fechacierre.ToString("dd/MM/yyyy HH:mm") + "'" +
                        ", fechapago='" + datos.Fechapago.ToString("dd/MM/yyyy HH:mm") + "'" +
                        ", empleadoempresaID='" + datos.EmpleadoempresaID + "'" +
                        ", diastrabajados='" + datos.Diastrabajados + "'" +
                        ", sueldodiario='" + datos.Sueldodiario + "'" +
                        ", sueldoquincenal='" + datos.Sueldoquincenal + "'" +
                        ", bonoasistencia='" + datos.Bonoasistencia + "'" +
                        ", bonopuntualidad='" + datos.Bonopuntualidad + "'" +
                        ", despensa='" + datos.Despensa + "'" +
                        ", imss='" + datos.Imss + "'" +
                        ", isr='" + datos.Isr + "'" +
                        ", prestamocrediticio='" + datos.Prestamocrediticio + "'" +
                        ", reditoinfonavit='" + datos.Creditoinfonavit + "' WHERE nominasID = '" + datos.NominasID + "'";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    try
                    {
                        ex.Message.ToString();
                        transaction.Rollback();
                    }
                    catch (Exception)
                    {
                    }
                }
                connection.Close();
            }
        }

        public void EliminarNomina(object obj)
        {
            NominasBO datos = (NominasBO)obj;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("EliminarNomina");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "DELETE FROM nominas WHERE nominasID = '" + datos.NominasID + "'";
                    command.ExecuteNonQuery();
                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    try
                    {
                        ex.Message.ToString();
                        transaction.Rollback();
                    }
                    catch (Exception)
                    {
                    }
                }
                connection.Close();
            }
        }

        public DataSet SeleccionarNominasEmpleado(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            DataSet nominasDS = new DataSet();
            ModelNominas data = (ModelNominas)obj;
            adapter = new SqlDataAdapter();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("SelectNominas");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    if (data.Nombreempleado != null)
                    {
                        cadenaWhere = cadenaWhere + " nombreempleado like '" + data.Nombreempleado + "%' or";
                        edo = true;
                    }

                    if (data.Apellidomaterno != null)
                    {
                        cadenaWhere = cadenaWhere + " apellidomaterno like '" + data.Apellidomaterno + "%' or";
                        edo = true;
                    }

                    if (data.Apellidopaterno != null)
                    {
                        cadenaWhere = cadenaWhere + " apellidopaterno like '" + data.Apellidopaterno + "%' or";
                        edo = true;
                    }

                    if (data.Nombredepartamento != null)
                    {
                        cadenaWhere = cadenaWhere + " nombredepartamento like '" + data.Nombredepartamento + "%' or";
                        edo = true;
                    }

                    if (edo == true)
                    {
                        cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
                    }

                    command.CommandText = " SELECT * FROM vwNominas " + cadenaWhere;
                    transaction.Commit();

                    adapter.SelectCommand = command;
                    adapter.Fill(nominasDS);
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
                return nominasDS;
            }
        }

        public DataSet GetNominasEmpleado(object obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            DataSet nominasDS = new DataSet();
            NominasBO data = (NominasBO)obj;
            adapter = new SqlDataAdapter();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("SelectNomina");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    if (data.NominasID != 0)
                    {
                        cadenaWhere = cadenaWhere + " nominasID=@NominasID and";
                        command.Parameters.Add("@NominasID", SqlDbType.Int);
                        command.Parameters["@NominasID"].Value = data.NominasID;
                        edo = true;
                    }

                    if (data.EmpleadoempresaID != 0)
                    {
                        cadenaWhere = cadenaWhere + " empleadoempresaID=@EmpleadoEmpresaID and";
                        command.Parameters.Add("@EmpleadoEmpresaID", SqlDbType.Int);
                        command.Parameters["@EmpleadoEmpresaID"].Value = data.NominasID;
                        edo = true;
                    }

                    if (edo == true)
                    {
                        cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
                    }

                    command.CommandText = "SELECT * FROM nominas " + cadenaWhere;
                    transaction.Commit();

                    adapter.SelectCommand = command;
                    adapter.Fill(nominasDS);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    try
                    {
                        ex.Message.ToString();
                        connection.Close();
                        transaction.Rollback();
                    }
                    catch (Exception)
                    {
                    }
                }
                return nominasDS;
            }
        }
    }
}