using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nomina2018
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterClientScriptBlock(typeof(Page), "Error", "<script> alert('prueba esto!');</script>");
        }
    }
}