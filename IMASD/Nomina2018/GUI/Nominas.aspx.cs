using System;
using Nomina2018.Servicios;
using Nomina2018.BO;
using System.Data;

namespace Nomina2018.GUI
{
    public partial class Nominas : System.Web.UI.Page
    {

        EmpleadosSRV empleadosSRV = new EmpleadosSRV();
        NominasSRV nominasSRV = new NominasSRV();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataBinderNominas();
        }

        public void DataBinderNominas()
        {
            gvNominas.DataSource = ListaNominas();
            gvNominas.DataBind();
        }

        public DataTable ListaNominas()
        {
            DataTable dataTable;
            ModelNominas nominasM = new ModelNominas();

            dataTable = nominasSRV.ObtenerNominasEmpleado(nominasM).Tables[0];

            return dataTable;
        }

        protected void BuscarEmpleado_OnClick(object sender, EventArgs e)
        {
            if (txtBuscar.Value.Length > 0)
            {
                ModelEpleadoEmpresa empleadoEmpresaBO = new ModelEpleadoEmpresa()
                {
                    Nombreempleado = txtBuscar.Value.ToString()
                };

                try
                {
                    DataTable empleadoEmpresaDT = empleadosSRV.ObtenerEmpleados(empleadoEmpresaBO).Tables[0];
                    if (empleadoEmpresaDT.Rows[0].ToString().Length > 0)
                    {
                        txtEmpleadoEmpresaID.Value = empleadoEmpresaDT.Rows[0]["empleadoempresaID"].ToString();
                        txtNombreEmpleado.Text = empleadoEmpresaDT.Rows[0]["nombreempleado"].ToString();
                        txtApellidoPaterno.Text = empleadoEmpresaDT.Rows[0]["apellidopaterno"].ToString();
                        txtApellidoMaterno.Text = empleadoEmpresaDT.Rows[0]["apellidomaterno"].ToString();
                        txtDepartamento.Text = empleadoEmpresaDT.Rows[0]["nombredepartamento"].ToString();
                        txtPuesto.Text = empleadoEmpresaDT.Rows[0]["nombrepuesto"].ToString();
                        txtSalario.Text = double.Parse(empleadoEmpresaDT.Rows[0]["sueldo"].ToString()).ToString();
                    }

                    txtBuscar.Value = "";
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
        }

        protected void btnGuardarNomina_OnClick(object sender, EventArgs e)
        {
            if (txtDiasTrj.Text.Length > 0 & txtSueldoDiario.Text.Length > 0 & txtFechaPago.Text.Length > 0)
            {
                NominasBO nominasBO = new NominasBO()
                {
                    Fechapago = DateTime.Parse(txtFechaPago.Text.ToString()),
                    EmpleadoempresaID = int.Parse(txtEmpleadoEmpresaID.Value.ToString()),
                    Diastrabajados = int.Parse(txtDiasTrj.Text.ToString()),
                    Sueldodiario = double.Parse(txtSueldoDiario.Text.ToString()),
                    Sueldoquincenal = double.Parse(txtSueldoQuincenal.Text.ToString()),
                    Bonoasistencia = double.Parse(txtBonoAsistencia.Text.ToString()),
                    Bonopuntualidad = double.Parse(txtBonoPuntualidad.Text.ToString()),
                    Despensa = double.Parse(txtDespensa.Text.ToString()),
                    Imss = double.Parse(txtIMSS.Text.ToString()),
                    Isr = double.Parse(txtISR.Text.ToString()),
                    Prestamocrediticio = double.Parse(txtPrestamoCrd.Text.ToString()),
                    Creditoinfonavit = double.Parse(txtCreditoInfonavit.Text.ToString()),
                    Totalpercepcion = double.Parse(txtTotalPercepciones.Text.ToString()),
                    Totaldeduccion = double.Parse(txtTotalDeducciones.Text.ToString()),
                    Totalsueldo = double.Parse(txtTotalPercepciones.Text.ToString()) - double.Parse(txtTotalDeducciones.Text.ToString())
                };

                nominasSRV.RegistroNominas(nominasBO);
            }
            Response.Redirect("../GUI/Nominas.aspx");
        }

        protected void txtBuscarD_OnClick(object sender, EventArgs e)
        {
            if (txtBuscar.ToString().Length > 0)
            {
                ModelNominas mdNominas = new ModelNominas();
                mdNominas.Nombredepartamento = txtBuscarD.Value.ToString();
                mdNominas.Nombreempleado = txtBuscarD.Value.ToString();

                try
                {
                    DataTable dataTable = nominasSRV.ObtenerNominasEmpleado(mdNominas).Tables[0];

                    if (dataTable.Rows.Count != 0)
                    {
                        gvNominas.DataSource = dataTable;
                        gvNominas.DataBind();
                    }
                    else
                    {
                        DataBinderNominas();
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("../GUI/Nominas.aspx");
                }
            }
        }
    }
}