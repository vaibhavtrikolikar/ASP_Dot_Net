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

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {
            ListItem item= BulletedList1.Items[e.Index];

            Response.Write("Text " + item.Text +"<br/>");
            Response.Write("Value " + item.Value +"<br/>");
            Response.Write("Index " + e.Index +"<br/>");
        }
    }
}