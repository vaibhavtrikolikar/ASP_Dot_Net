using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Demo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblStatus.Text = "Data has been Submitted";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            else {
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}