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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// user clicks the button it's validates and send data to BALAuthentcation class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ForgotPassword_Click(object sender, EventArgs e)
        {
            string _username = username.Text.Trim();
            string _password = password.Text.Trim();
            Literals literals = new Literals();

            if (password.Text == confirmPassword.Text)
            {
                User userObj = new User() { UserName = _username, Password = _password };
                IBALAuthentication bALObj = new BALFactory().GetBALAuthObj();
                int result = bALObj.ForgotPassword(userObj);

                if (result == 0)
                {
                    Response.Redirect(literals.passwordupdated);
                }
                else if (result == 1)
                {
                    Response.Write("<script>alert('" + literals.userNotExist + "')</script>");
                }
                else
                {
                    Response.Write("<script>alert('" + literals.UpdateData + "')</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('" + literals.PasswordMatch + "')</script>");
            }
        }
    }
}