using System;
using Nomina2018.Servicios;
using Nomina2018.BO;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace Nomina2018.GUI
{
    public partial class Empleados : System.Web.UI.Page
    {
        EmpleadosSRV empleadoSRV = new EmpleadosSRV();
        EmpleadoEmpresaSRV empleadoempresaSRV = new EmpleadoEmpresaSRV();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBinderEmpleados();
        }       
        
        public void DataBinderEmpleados()
        {
            gvEmpleados.DataSource = ListaEmpleados();
            gvEmpleados.DataBind();
        }

        public DataTable ListaEmpleados()
        {
            DataTable dataTable;
            ModelEpleadoEmpresa mdEmpleado = new ModelEpleadoEmpresa();
            
            dataTable = empleadoSRV.ObtenerEmpleados(mdEmpleado).Tables[0];
            
            return dataTable;
        }

        protected void gvEmpleados_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);
            int id = (int)gvEmpleados.DataKeys[indice].Value;
            EmpleadosBO empleado = new EmpleadosBO();
            EmpleadoEmpresaBO empleadoEmpresa = new EmpleadoEmpresaBO();
            
            if (e.CommandName.Contains("Editar"))
            {
                empleado.EmpleadoID = id;
                empleadoEmpresa.EmpleadoID = id;

                DataTable empleadoDT = empleadoSRV.ObtenerEmpleado(empleado).Tables[0];
                DataTable empleadoempresaDT = empleadoempresaSRV.ObtenerEmpleadosEmpresa(empleadoEmpresa).Tables[0];

                Session["Empleado"] = empleadoDT;
                Session["EmpleadoEmpresa"] = empleadoempresaDT;

                Response.Redirect("../GUI/EditarEmpleado.aspx");
            }
            if (e.CommandName.Contains("Eliminar") & IsPostBack)
            {
                empleado.EmpleadoID = id;
                empleadoEmpresa.EmpleadoID = id;

                empleadoempresaSRV.EliminacionEmpleadoEmpresa(empleadoEmpresa);
                empleadoSRV.EliminaEmpleado(empleado);

                Response.Redirect("../GUI/Empleados.aspx");
            }
        }

        protected void gvEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtDepartamento_OnTextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.ToString().Length > 0)
            {
                ModelEpleadoEmpresa mdEmpleado = new ModelEpleadoEmpresa();
                mdEmpleado.Nombredepartamento = txtBuscar.Value.ToString();

                try
                {
                    DataTable dataTable = empleadoSRV.ObtenerEmpleados(mdEmpleado).Tables[0];
                    
                    if (dataTable.Rows.Count != 0)
                    {
                        gvEmpleados.DataSource = dataTable;
                        gvEmpleados.DataBind();
                    }
                    else
                    {
                        DataBinderEmpleados();
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("../GUI/Empleados.aspx");
                }
            }
        }
    }
}