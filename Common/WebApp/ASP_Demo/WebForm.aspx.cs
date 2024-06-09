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
            Response.Write("Text: " +ListBox1.SelectedItem.Text + "<br>");
            Response.Write("Value: "+ListBox1.SelectedItem.Value + "<br>");
            Response.Write("Index: "+ListBox1.SelectedIndex.ToString());
        }
    }
}