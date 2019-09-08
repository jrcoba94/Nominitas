using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Nomina2018.DAO
{
    public class PuestosDAO
    {
        string cadena = "Data Source=.; initial catalog = BDNOMINA2018; integrated security=true";
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlTransaction transaction;

        public DataSet GetPuestos()
        {
            adapter = new SqlDataAdapter();
            DataSet puestosDS = new DataSet();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                command = connection.CreateCommand();
                transaction = connection.BeginTransaction("SelectPuestos");
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = " SELECT * FROM puesto";
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