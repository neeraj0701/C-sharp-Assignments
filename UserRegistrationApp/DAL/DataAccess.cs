using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using BusinessModel;
using System.Collections.Generic;
using System;
using System.IO;

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
        public string SaveRegistrationDetails(User userObj)
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
                return "registration successful";
            }
            catch (InvalidCastException)
            {
                return "Invalid Cast Exception";
            }
            catch (InvalidOperationException)
            {
                return "Invalid Operation Exception";
            }
            catch (IOException)
            {
                return "Input Output Exception";
            }
            catch (SqlException)
            {
                return "Sql Exception";
            }
        }

        /// <summary>
        /// Fetch data checks the user details valid or not
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        public List<string> FetchLoginDetails(User userObj)
        {
            List<string> list = new List<string>();
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
                list[0] = row[0].ToString();
                list[1] = row[1].ToString();
                return list;
            }
            catch (InvalidCastException)
            {
                list[2] = "Invalid Cast Exception";
                return list;
            }
            catch (InvalidOperationException)
            {
                list[2] = "Invalid Operation Exception";
                return list;
            }
            catch (IOException)
            {
                list[2] = "Input Output Exception";
                return list;
            }
            catch (SqlException)
            {
                list[2] = "Sql Exception";
                return list;
            }
        }

        /// <summary>
        /// Updates the password of user 
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        public string UpdatePassword(User userObj)
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
                return "password updated";
            }
            catch (InvalidCastException)
            {
                return "Invalid Cast Exception";
            }
            catch (InvalidOperationException)
            {
                return "Invalid Operation Exception";
            }
            catch (IOException)
            {
                return "Input Output Exception";
            }
            catch (SqlException)
            {
                return "Sql Exception";
            }

        }
    }
}


