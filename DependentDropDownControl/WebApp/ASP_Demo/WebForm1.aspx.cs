using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ASP_Demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateContinentsDropDownList();
            }
        }

        /// <summary>
        /// Generic/Common method to Deal with SQL and Return Response
        /// </summary>
        /// <param name="SpName"></param>
        /// <param name="sqlParameter"></param>
        /// <returns></returns>
        private DataSet GetData(string SpName, SqlParameter sqlParameter)
        {
            string CS = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlDataAdapter da = new SqlDataAdapter(SpName, CS);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (sqlParameter != null)
            {
                da.SelectCommand.Parameters.Add(sqlParameter);
            }
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        /// <summary>
        /// Funtion to Bind Defualt Text and Value to Drop Down Control 
        /// </summary>
        private void PopulateContinentsDropDownList()
        {
            ddlContinents.DataSource = GetData("spGetContinents", null);
            ddlContinents.DataBind();

            ListItem liContinent = new ListItem("Select Continent", "-1");
            ddlContinents.Items.Insert(0, liContinent);

            ListItem liCountries = new ListItem("Select Country", "-1");
            ddlCountries.Items.Insert(0, liCountries);

            ListItem liCities = new ListItem("Select City", "-1");
            ddlCities.Items.Insert(0, liCities);

            ddlCountries.Enabled = false;
            ddlCities.Enabled = false;
        }

        protected void ddlContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlContinents.SelectedValue == "-1")
            {
                ddlCities.SelectedIndex = 0;
                ddlCountries.SelectedIndex = 0;
                ddlCities.Enabled = false;
                ddlCountries.Enabled = false;
            }
            else 
            {
                ddlCountries.Enabled = true;
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@ContinentId";
                parameter.Value = ddlContinents.SelectedValue;

                ddlCountries.DataSource = GetData("spGetCountriesByContinentId",parameter);
                ddlCountries.DataBind();

                ListItem liCountry = new ListItem("Select Country", "-1");
                ddlCountries.Items.Insert(0, liCountry);

                ddlCities.SelectedIndex = 0;
                ddlCities.Enabled = false;
            }
        }

        protected void ddlCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void ddlCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCountries.SelectedValue == "-1")
            {
                ddlCities.SelectedIndex = 0;
                ddlCities.Enabled = false;
            }
            else
            {
                ddlCities.Enabled = true;
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@CountryId";
                parameter.Value = ddlCountries.SelectedValue;

                ddlCities.DataSource = GetData("spGetCitiesByCountryId", parameter);
                ddlCities.DataBind();

                ListItem liCity = new ListItem("Select City", "-1");
                ddlCities.Items.Insert(0, liCity);
            }
        }
    }
}