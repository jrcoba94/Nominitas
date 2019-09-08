using System;
using System.Data;
using Nomina2018.BO;
using Nomina2018.Servicios;

namespace Nomina2018.GUI
{

    public partial class EditarEmpleado : System.Web.UI.Page
    {
        EmpleadosSRV empleadoSRV = new EmpleadosSRV();
        EmpleadoEmpresaSRV empleadoEmpresaSRV = new EmpleadoEmpresaSRV();

        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateDDL();
            if (!IsPostBack){
                PopulateForm();
            }
        }

        protected void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            EmpleadosBO empleadoBO;
            EmpleadoEmpresaBO empleadoEmpresaBO;
            try
            {
                string date = string.IsNullOrEmpty(txtFechaNacimiento.Text) ? txtFecha.Value.ToString() : DateTime.Parse(txtFechaNacimiento.Text).ToString();

                empleadoBO = new EmpleadosBO()
                {
                    EmpleadoID = int.Parse(txtEmpleadoID.Value.ToString()),
                    Nombreempleado = txtNombre.Text,
                    Apellidopaterno = txtApellidoPaterno.Text,
                    Apellidomaterno = txtApellidoMaterno.Text,
                    Direccion = txtDireccion.Text,
                    Correoelectronico = txtCorreoElectronico.Text,
                    Curp = txtCurp.Text,
                    Fechanacimiento = DateTime.Parse(date),
                    Ciudad = txtCiudad.Text,
                    Estado = txtEstado.Text,
                    Telefono1 = txtTelefono1.Text,
                };

                empleadoEmpresaBO = new EmpleadoEmpresaBO()
                {
                    EmpleadoempresaID = int.Parse(txtEmpleadoEmpresaID.Value.ToString()),
                    EmpresaID = int.Parse(dpEmpresa.SelectedValue.ToString()),
                    EmpleadoID = int.Parse(txtEmpleadoID.Value.ToString()),
                    Numeroempleado = int.Parse(txtNoEmpleado.Text),
                    DepartamentoID = int.Parse(dpDepartamento.SelectedValue.ToString()),
                    PuestoID = int.Parse(dpPuesto.SelectedValue.ToString()),
                    Antiguedad = txtAntiguedad.Text,
                    Nss = txtNoSS.Text,
                    Rfc = txtRFC.Text
                };
                                
                empleadoSRV.EdicionEmpleado(empleadoBO);                
                empleadoEmpresaSRV.EdicionEmpleadoEmpresa(empleadoEmpresaBO);

                Response.Redirect("Empleados.aspx");
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        public void PopulateDDL()
        {
            dpEmpresa.DataSource = empleadoEmpresaSRV.GEtEmpresa();
            dpEmpresa.DataBind();

            dpDepartamento.DataSource = empleadoEmpresaSRV.GetDepartamento();
            dpDepartamento.DataBind();

            dpPuesto.DataSource = empleadoEmpresaSRV.GetPuesto();
            dpPuesto.DataBind();
        }

        public void PopulateForm()
        {
            DataTable empleadoDT = (DataTable)Session["Empleado"];
            DataTable empleadoempresaDT = (DataTable)Session["EmpleadoEmpresa"];

            txtEmpleadoID.Value = empleadoDT.Rows[0]["empleadoID"].ToString();
            txtNombre.Text = empleadoDT.Rows[0]["nombreempleado"].ToString();
            txtApellidoPaterno.Text = empleadoDT.Rows[0]["apellidopaterno"].ToString();
            txtApellidoMaterno.Text = empleadoDT.Rows[0]["apellidomaterno"].ToString();
            txtCorreoElectronico.Text = empleadoDT.Rows[0]["correoelectronico"].ToString();
            txtFecha.Value = empleadoDT.Rows[0]["fechanacimiento"].ToString();
            txtTelefono1.Text = empleadoDT.Rows[0]["telefono1"].ToString();
            txtDireccion.Text = empleadoDT.Rows[0]["direccion"].ToString();
            txtEstado.Text = empleadoDT.Rows[0]["estado"].ToString();
            txtCiudad.Text = empleadoDT.Rows[0]["ciudad"].ToString();
            txtCurp.Text = empleadoDT.Rows[0]["curp"].ToString();

            txtEmpleadoEmpresaID.Value = empleadoempresaDT.Rows[0]["empleadoempresaID"].ToString();
            txtNoEmpleado.Text = empleadoempresaDT.Rows[0]["numeroempleado"].ToString();
            dpEmpresa.Items.FindByValue(empleadoempresaDT.Rows[0]["empresaID"].ToString()).Selected = true;
            dpDepartamento.Items.FindByValue(empleadoempresaDT.Rows[0]["departamentoID"].ToString()).Selected = true;
            dpPuesto.Items.FindByValue(empleadoempresaDT.Rows[0]["puestoID"].ToString()).Selected = true;
            txtAntiguedad.Text = empleadoempresaDT.Rows[0]["antiguedad"].ToString();
            txtNoSS.Text = empleadoempresaDT.Rows[0]["nss"].ToString();
            txtRFC.Text = empleadoempresaDT.Rows[0]["rfc"].ToString();

        }
    }
}