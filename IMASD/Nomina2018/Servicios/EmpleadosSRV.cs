using Nomina2018.DAO;
using System.Data;

namespace Nomina2018.Servicios
{
    public class EmpleadosSRV
    {
        EmpleadosDAO empleados = new EmpleadosDAO();

        public void RegistroEmpleado(object obj)
        {
            empleados.InsertarEmpleado(obj);
        }

        public void EdicionEmpleado(object obj)
        {
            empleados.EditarEmpleado(obj);
        }

        public void EliminaEmpleado(object obj)
        {
            empleados.EliminarEmpleado(obj);
        }

        public DataSet ObtenerEmpleados(object obj)
        {
            DataSet dataSet = new DataSet();
            dataSet = empleados.GetEmpleados(obj);
            return dataSet;
        }

        public DataSet ObtenerEmpleado(object obj)
        {
            DataSet dataSet = new DataSet();
            dataSet = empleados.GetEmpleado(obj);
            return dataSet;
        }
    }
}