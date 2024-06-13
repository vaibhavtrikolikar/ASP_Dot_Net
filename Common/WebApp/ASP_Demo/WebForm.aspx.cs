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

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DateTime selectedDate in Calendar1.SelectedDates)
            {
                Response.Write(selectedDate.ToShortDateString() + "<br/>");
            }
            
        }
    }
}