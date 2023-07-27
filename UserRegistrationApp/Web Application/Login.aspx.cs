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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

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
            int result = bALObj.Login(userObj);

            if (result == 0)
            {
                Response.Redirect(literals.loginSucessful);
            }
            else if (result == 1)
            {
                Response.Write("<script>alert('" + literals.incorrectUserName + "')</script>");
            }
            else if (result == 2)
            {
                Response.Write("<script>alert('" + literals.incorrectPassword + "')</script>");
            }
            else
            {
                Response.Write("<script>alert('" + literals.fetchData + "')</script>");
            }
        }
    }
}