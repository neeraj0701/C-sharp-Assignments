using System;
using BAL;
using BusinessModel;

namespace Application_Layer
{
    /// <summary>
    /// represents all the methods related to Registration Page
    /// </summary>
    public partial class Registration : System.Web.UI.Page
    {
        /// <summary>
        /// user clicks the button it's validates and send data to Registration method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Registration_Click(object sender, EventArgs e)
        {
            Literals literals = new Literals();

            if (password.Text == confirmPassword.Text)
            {
                User userObj = new User() { UserName = username.Text, Name = name.Text, Mail = mail.Text, Mobile = Int32.Parse(mobile.Text), Password = password.Text };
                IBALAuthentication bALObj = new BALFactory().GetBALAuthObj();
                string result = bALObj.Registration(userObj);

                if (result == "registration successful")
                {
                    Response.Redirect(literals.RegisterSuccessful);
                }
                else if (result == "user exist")
                {
                    Response.Write("<script>alert('" + literals.userExist + "')</script>");
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