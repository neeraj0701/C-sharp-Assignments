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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// user clicks the button it's validates and send data to Registration method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Registration_Click(object sender, EventArgs e)
        {
            string _username = username.Text.Trim();
            string _name = name.Text.Trim();
            string _mail = mail.Text.Trim();
            long _mobile = Int64.Parse(mobile.Text.Trim());
            string _password = password.Text.Trim();
            string _confirmPassword = confirmPassword.Text.Trim();
            Literals literals = new Literals();

            if (password.Text == confirmPassword.Text)
            {
                User userObj = new User() { UserName = _username, Name = _name, Mail = _mail, Mobile = _mobile, Password = _password };
                IBALAuthentication bALObj = new BALFactory().GetBALAuthObj();
                int result = bALObj.Registration(userObj);

                if (result == 0)
                {
                    Response.Redirect(literals.RegisterSuccessful);
                }
                else if (result == 1)
                {
                    Response.Write("<script>alert('" + literals.userExist + "')</script>");
                }
                else
                {
                    Response.Write("<script>alert('" + literals.insertData + "')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('" + literals.PasswordMatch + "')</script>");
            }
        }
    }
}