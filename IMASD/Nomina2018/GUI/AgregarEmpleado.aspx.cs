using Nomina2018.BO;
using Nomina2018.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nomina2018.GUI
{
    public partial class AgregarEmpleado : System.Web.UI.Page
    {
        EmpleadosSRV empleadoSRV = new EmpleadosSRV();
        EmpleadoEmpresaSRV empleadoEmpresaSRV = new EmpleadoEmpresaSRV();

        protected void Page_Load(object sender, EventArgs e)
        {
            dpEmpresa.DataSource = empleadoEmpresaSRV.GEtEmpresa();
            dpEmpresa.DataBind();

            dpDepartamento.DataSource = empleadoEmpresaSRV.GetDepartamento();
            dpDepartamento.DataBind();

            PuestoBO puestoBO = new PuestoBO();
            dpPuesto.DataSource = empleadoEmpresaSRV.GetPuesto(puestoBO);
            dpPuesto.DataBind();
        }

        protected void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            EmpleadosBO empleadoBO;
            EmpleadoEmpresaBO empleadoEmpresaBO;
            try
            {
                empleadoBO = new EmpleadosBO()
                {
                    Nombreempleado = txtNombre.Text,
                    Apellidopaterno = txtApellidoPaterno.Text,
                    Apellidomaterno = txtApellidoMaterno.Text,
                    Direccion = txtDireccion.Text,
                    Correoelectronico = txtCorreoElectronico.Text,
                    Curp = txtCurp.Text,
                    Fechanacimiento = DateTime.Parse(txtFechaNacimiento.Text),
                    Ciudad = txtCiudad.Text,
                    Estado = txtEstado.Text,
                    Telefono1 = txtTelefono1.Text,
                    Telefono2 = "0"
                };
                
                empleadoSRV.RegistroEmpleado(empleadoBO);
                
                empleadoEmpresaBO = new EmpleadoEmpresaBO()
                {
                    EmpresaID = int.Parse(dpEmpresa.SelectedValue.ToString()),
                    EmpleadoID = empleadoBO.EmpleadoID,
                    Numeroempleado = int.Parse(txtNoEmpleado.Text),
                    DepartamentoID = int.Parse(dpDepartamento.SelectedValue.ToString()),
                    PuestoID = int.Parse(dpPuesto.SelectedValue.ToString()),
                    Fechaingreso = DateTime.Today,
                    Antiguedad = txtAntiguedad.Text,
                    Nss = txtNoSS.Text,
                    Rfc = txtRFC.Text,
                    Estatus = 1
                };
                empleadoEmpresaSRV.RegistroEmpleadoEmpresa(empleadoEmpresaBO);

                Response.Redirect("Empleados.aspx");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}