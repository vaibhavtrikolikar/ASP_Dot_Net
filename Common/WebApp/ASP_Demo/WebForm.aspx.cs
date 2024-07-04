using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ASP_Demo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
				DataSet ds = new DataSet(); ;
				ds.ReadXml(Server.MapPath("~/XMLFile1.xml"));
				GridView1.DataSource = ds;
				GridView1.DataBind();			
        }

        protected void Page_Error(object sender, EventArgs e)
        {
            // Get the exception details and log it in the database or event viewer
            Exception ex = Server.GetLastError();
            Server.ClearError();  // Clear the exception
            Response.Redirect("~/ErrorPage.aspx"); //Redirect user to Error page
        }
    }
}