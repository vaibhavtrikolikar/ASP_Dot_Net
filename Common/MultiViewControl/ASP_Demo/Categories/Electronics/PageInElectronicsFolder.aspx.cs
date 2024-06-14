using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace ASP_Demo.Categories.Electronics
{
    public partial class PageInElectronicsFolder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(". returns " + Server.MapPath(".") + "<br/>");
            Response.Write(".. returns " + Server.MapPath("..") + "<br/>");
            Response.Write("~ returns " + Server.MapPath("~") + "<br/>");
            Response.Write("../.. returns " + Server.MapPath("../..") + "<br/>");            

            //Response.Write(Server.MapPath(".")+ "<br/>" +"Used .");     //Returns the current physical directory of the page that you are running
            //Response.Write(Server.MapPath("..") + "<br/>" + "Used ..");   //returns the parent pysical directory of the page that you are running
            //Response.Write(Server.MapPath("~")+ "<br/>"+"Used ~");    //returns the physical path of the root directory of the application
            //Response.Write(Server.MapPath("../..") + "<br/>" + "Used ../.."); //Alternate option to returns the physical path of the root directory of the application
        }
    }
}