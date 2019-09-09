using System.Data;
using Nomina2018.DAO;

namespace Nomina2018.Servicios
{
    public class PuestosSRV
    {
        PuestosDAO puestos = new PuestosDAO();

        public void RegistroPuesto(object obj)
        {
            puestos.InsertarPuesto(obj);
        }

        public void EdicionPuesto(object obj)
        {
            puestos.EditarPuesto(obj);
        }
        
        public DataSet ObtenerPuestos(object obj)
        {
            return puestos.GetPuestos(obj);
        }
    }
}