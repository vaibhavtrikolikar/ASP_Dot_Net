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
            if (!IsPostBack)
            {
                BindListItems(DropDownList1);
                BindListItems(CheckBoxList1);
                BindListItems(RadioButtonList1);
                BindListItems(ListBox1);
                BindListItems(BulletedList1);
            }
        }

        private void BindListItems(ListControl listControl)
        {
            ListItem listItem1 = new ListItem("Item1","1");
            ListItem listItem2 = new ListItem("Item2","2");
            ListItem listItem3 = new ListItem("Item3","3");
            ListItem listItem4 = new ListItem("Item4","4");

            listControl.Items.Add(listItem1);
            listControl.Items.Add(listItem2);
            listControl.Items.Add(listItem3);
            listControl.Items.Add(listItem4);
        }

        private void GetSelectedText(ListControl listControl)
        {
            foreach (ListItem li in listControl.Items)
            {
                if (li.Selected)
                {
                    Response.Write("Text = " +li.Text + " Value = " + li.Value + " Index = " + listControl.Items.IndexOf(li) + "<br>");
                }
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            GetSelectedText(ListBox1);  //Here You can pass other control which You want details
        }
    }
}