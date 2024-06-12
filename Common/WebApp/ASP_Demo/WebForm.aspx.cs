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
            //Hide Calendar for initial get request
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
            }
        }

        /// <summary>
        /// When we click button it will display calendar and when click again it will hide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else {
                Calendar1.Visible = true;
            }            
        }

        /// <summary>
        /// Used to Set selected date to textbox control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }
    }
}