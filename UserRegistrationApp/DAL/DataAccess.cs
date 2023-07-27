using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using BusinessModel;
using System.Collections.Generic;

namespace DAL
{
    /// <summary>
    /// Represents the methods used for storing and retrieving data
    /// </summary>
    public class DataAccess : IDataAccess
    {
        /// <summary>
        /// Saves the input data
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        public int SaveRegistrationDetails(User userObj)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Registration_Details VALUES(@username,@name,@mail,@mobile,@password)", conn);
                command.Parameters.AddWithValue("username", userObj.UserName);
                command.Parameters.AddWithValue("name", userObj.Name);
                command.Parameters.AddWithValue("mail", userObj.Mail);
                command.Parameters.AddWithValue("mobile", userObj.Mobile);
                command.Parameters.AddWithValue("password", userObj.Password);
                command.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException e)
            {
                return 2;
            }
        }

        /// <summary>
        /// Fetch data checks the user details valid or not
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        public List<string> FetchLoginDetails(User userObj)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("SELECT username,password FROM Registration_Details WHERE username = @username", conn);
                command.Parameters.AddWithValue("username", userObj.UserName);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DataRow row = dataTable.Rows[0];
                List<string> list = new List<string>() { row[0].ToString(), row[1].ToString() };
                return list;
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Updates the password of user 
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        public int UpdatePassword(User userObj)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("SELECT username,password FROM Registration_Details WHERE username = @username", conn);
                command.Parameters.AddWithValue("username", userObj.UserName);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DataRow row = dataTable.Rows[0];
                row["password"] = userObj.Password;
                adapter.Update(dataTable);
                return 0;
            }
            catch (SqlException e)
            {
                return 2;
            }
        }
    }
}


