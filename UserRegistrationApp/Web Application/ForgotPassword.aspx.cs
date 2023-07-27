using System;
using BAL;
using BusinessModel;

namespace Application_Layer
{
    /// <summary>
    /// represents all the methods related to ForgotPassword Page
    /// </summary>
    public partial class ForgotPassword : System.Web.UI.Page
    {
        /// <summary>
        /// user clicks the button it's validates and send data to BALAuthentcation class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ForgotPassword_Click(object sender, EventArgs e)
        {
            Literals literals = new Literals();

            if (password.Text == confirmPassword.Text)
            {
                User userObj = new User() { UserName = username.Text, Password = password.Text };
                IBALAuthentication bALObj = new BALFactory().GetBALAuthObj();
                string result = bALObj.ForgotPassword(userObj);

                if (result == "password updated")
                {
                    Response.Redirect(literals.passwordupdated);
                }
                else if (result == "user not exist")
                {
                    Response.Write("<script>alert('" + literals.userNotExist + "')</script>");
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
            else
            {
                Response.Write("<script>alert('" + literals.PasswordMatch + "')</script>");
            }
        }
    }
}