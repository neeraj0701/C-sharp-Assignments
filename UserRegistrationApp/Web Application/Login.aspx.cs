using System;
using BAL;
using BusinessModel;

namespace Application_Layer
{
    /// <summary>
    /// represents all the methods related to Login Page
    /// </summary>
    public partial class Login : System.Web.UI.Page
    {
        /// <summary>
        /// user clicks the button it's validates and send data to Login method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Login_Click(object sender, EventArgs e)
        {
            string _username = username.Text.Trim();
            string _password = password.Text.Trim();
            IBALAuthentication bALObj = new BALFactory().GetBALAuthObj();
            Literals literals = new Literals();
            User userObj = new User() { UserName = _username, Password = _password };
            string result = bALObj.Login(userObj);

            if (result == "login successful")
            {
                Response.Redirect(literals.loginSucessful);
            }
            else if (result == "incorrect username")
            {
                Response.Write("<script>alert('" + literals.incorrectUserName + "')</script>");
            }
            else if (result == "incorrect password")
            {
                Response.Write("<script>alert('" + literals.incorrectPassword + "')</script>");
            }
            else if (result == "Invalid Cast Exception")
            {
                Response.Write("<script>alert('" + literals.invalidCast + "')</script>");
            }
            else if (result == "Invalid Operation Exception")
            {
                Response.Write("<script>alert('" + literals.invalidOperation + "')</script>");
            }
            else if (result == "Input Output Exception")
            {
                Response.Write("<script>alert('" + literals.iOException + "')</script>");
            }
            else
            {
                Response.Write("<script>alert('" + literals.sqlException + "')</script>");
            }
        }
    }
}