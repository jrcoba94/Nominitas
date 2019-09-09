using System;
using Nomina2018.BO;
using System.Web.UI.WebControls;
using Nomina2018.Servicios;
using System.Data;

namespace Nomina2018.GUI
{
    public partial class Sueldos : System.Web.UI.Page
    {
        PuestosSRV puestoSRV = new PuestosSRV();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataBinderPuestos();
        }

        public void DataBinderPuestos()
        {
            PuestoBO puestoBO = new PuestoBO();
            DataTable dataTable = puestoSRV.ObtenerPuestos(puestoBO).Tables[0];
            gvPuestos.DataSource = dataTable;
            gvPuestos.DataBind();
        }

        protected void btnGuardarPuesto_OnClick(object sender, EventArgs e)
        {
            if (txtNombrePuesto.Text.ToString().Length > 0 & txtSueldo.Text.ToString().Length > 0)
            {
                try
                {
                    PuestoBO puestoBO = new PuestoBO()
                    {
                        PuestoID = int.Parse(string.IsNullOrEmpty(txtpuestoID.Value.ToString()) ? "0" : txtpuestoID.Value.ToString()),
                        Nombrepuesto = txtNombrePuesto.Text.ToString(),
                        Nivel = int.Parse(txtNivel.Text.ToString()),
                        Sueldo = double.Parse(txtSueldo.Text.ToString())
                    };

                    if(puestoBO.PuestoID == 0)
                    {
                        puestoSRV.RegistroPuesto(puestoBO);
                    }
                    else
                    {
                        puestoSRV.EdicionPuesto(puestoBO);
                    }
                    Response.Redirect("../GUI/Sueldos.aspx");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        protected void gvPuestos_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            int indice = Convert.ToInt32(e.CommandArgument);
            int id = (int)gvPuestos.DataKeys[indice].Value;

            if (e.CommandName.Contains("Editar"))
            {
                try
                {
                    PuestoBO puestoBO = new PuestoBO()
                    {
                        PuestoID = id
                    };
                    DataTable puestoDT = puestoSRV.ObtenerPuestos(puestoBO).Tables[0];
                    txtpuestoID.Value = puestoDT.Rows[0]["puestoID"].ToString();
                    txtNombrePuesto.Text = puestoDT.Rows[0]["nombrepuesto"].ToString();
                    txtNivel.Text = puestoDT.Rows[0]["nivel"].ToString();
                    txtSueldo.Text = double.Parse(puestoDT.Rows[0]["sueldo"].ToString()).ToString();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}