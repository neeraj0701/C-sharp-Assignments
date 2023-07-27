using System;

namespace Application_Layer
{
    /// <summary>
    /// represents all the methods related to Main Page
    /// </summary>
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// user clicks the button, user will logout from application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}