using System;
using System.Collections.Generic;
using System.Linq;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    Response.Write("Text :" + li.Text + " ");
                    Response.Write("Value :" + li.Value + " ");
                    Response.Write("Index :" + CheckBoxList1.Items.IndexOf(li).ToString() + "<br/>");
                }
            }
        }
    }
}