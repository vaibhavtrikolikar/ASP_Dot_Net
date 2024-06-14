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
        string CS = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadEmployee();
            }
        }

        private void LoadEmployee()
        {            
            using (SqlConnection con = new SqlConnection(CS))
            {
                string Query = "SELECT [Id],[Name],[Gender],[DeptName] FROM [Test].[dbo].[tblEmployees] WHERE id=202";
                SqlCommand cmd = new SqlCommand(Query, con);
                con.Open();
                using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        txtName.Text = sqlDataReader["Name"].ToString();
                        txtGender.Text = sqlDataReader["Gender"].ToString();
                        txtDept.Text = sqlDataReader["DeptName"].ToString();
                        HiddenField1.Value = sqlDataReader["Id"].ToString();
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Query = "Update tblEmployees set Name=@Name, Gender=@Gender, DeptName=@DeptName where Id=@Id";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand(Query,con);
                con.Open();

                cmd.Parameters.AddWithValue("Name", txtName.Text);
                cmd.Parameters.AddWithValue("Gender", txtGender.Text);
                cmd.Parameters.AddWithValue("DeptName", txtDept.Text);
                cmd.Parameters.AddWithValue("Id", HiddenField1.Value);

                cmd.ExecuteNonQuery();               
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            LoadEmployee();
        }
    }
}