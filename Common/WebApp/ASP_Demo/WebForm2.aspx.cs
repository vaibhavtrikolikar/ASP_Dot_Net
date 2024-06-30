using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Demo
{
    public partial class WebForm21 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Name"].ToString() != null)
                {
                    lblName.Text = Session["Name"].ToString();
                }
                if (Session["Email"].ToString() != null)
                {
                    lblEmail.Text = Session["Email"].ToString();
                }
            }
        }
    }
}