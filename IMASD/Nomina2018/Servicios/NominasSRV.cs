using Nomina2018.DAO;
using System.Data;

namespace Nomina2018.Servicios
{
    public class NominasSRV
    {
        NominasDAO nominas = new NominasDAO();
                
        public void RegistroNominas(object obj)
        {
            nominas.InsertarNomina(obj);
        }

        public void EdicionNominas(object obj)
        {
            nominas.EditarNomina(obj);
        }

        public void EliminacionNominas(object obj)
        {
            nominas.EliminarNomina(obj);
        }

        public DataSet ObtenerNominasEmpleado(object obj)
        {
            return nominas.SeleccionarNominasEmpleado(obj);
        }

        public DataSet ObtenerNominaEmpleado(object obj)
        {
            return nominas.GetNominasEmpleado(obj);
        }
    }
}