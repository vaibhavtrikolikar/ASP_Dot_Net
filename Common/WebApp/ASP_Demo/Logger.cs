using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.UI.WebControls;
using System.Diagnostics.Tracing;
using System.Net.Mail;

namespace ASP_Demo
{
    public class Logger
    {        
        public void Log(string ErrorMessage)
        {            
            string LogDestination = ConfigurationManager.AppSettings["LogDestination"].ToString();            


            if (LogDestination == "Database")
            {
                //Destination is Database
                LogErrorToDatabase(ErrorMessage);
            }
            else if (LogDestination == "EventViewer")
            {
                //Destination is Windows Log Event Viewer
                LogToEventViewer(ErrorMessage);
            }
            else if (LogDestination == "Both")
            {
                //Destination is Both
                LogErrorToDatabase(ErrorMessage);
                LogToEventViewer(ErrorMessage);
            }            
        }

        /// <summary>
        /// Funtion to Log value to Database
        /// </summary>
        /// <param name="ErrorMessage"></param>
        private void LogErrorToDatabase(string ErrorMessage)
        {
            string conString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("LogInser", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter("@ExceptionMessage", ErrorMessage);
            cmd.Parameters.Add(parameter);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        /// <summary>
        /// Funtion to log error to Windows Event Viewer
        /// </summary>
        /// <param name="ErrorMessage"></param>
        private void LogToEventViewer(string ErrorMessage)
        {
            if (EventLog.SourceExists("PragimTech.com"))
            {
                EventLog eventlog = new EventLog("PragimTech");
                eventlog.Source = "PragimTech.com";
                eventlog.WriteEntry(ErrorMessage, EventLogEntryType.Error);
            }
        }       
    }
}