using Nomina2018.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Nomina2018.Servicios
{
    public class EmpleadoEmpresaSRV
    {
        EmpleadoEmpresaDAO empleados = new EmpleadoEmpresaDAO();
        EmpresasDAO empresas = new EmpresasDAO();
        DepartamentosDAO departamentos = new DepartamentosDAO();
        PuestosDAO puestos = new PuestosDAO();

        public void RegistroEmpleadoEmpresa(object obj)
        {
            empleados.InsertarEmpleadoEmpresa(obj);
        }

        public void EdicionEmpleadoEmpresa(object obj)
        {
            empleados.EditarEmpleadoEmpresa(obj);
        }

        public void EliminacionEmpleadoEmpresa(object obj)
        {
            empleados.EliminarEmpleadoEmpresa(obj);
        }

        public DataSet ObtenerEmpleadosEmpresa(object obj)
        {
            DataSet dataSet = new DataSet();
            dataSet = empleados.GetEmpleadosEmpresa(obj);
            return dataSet;
        }

        public DataSet GEtEmpresa()
        {
            return empresas.GetEmpresas();
        }

        public DataSet GetDepartamento()
        {
            return departamentos.GetDepartamentos();
        }

        public DataSet GetPuesto()
        {
            return puestos.GetPuestos();
        }
    }
}