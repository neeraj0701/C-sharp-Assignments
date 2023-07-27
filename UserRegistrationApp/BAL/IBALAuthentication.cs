using BusinessModel;

namespace BAL
{
    /// <summary>
    /// represents methods used for validations and authentication
    /// </summary>
    public interface IBALAuthentication
    {
        /// <summary>
        /// checks user exists and saves the data
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        string Registration(User userObj);

        /// <summary>
        /// validate the login details
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        string Login(User userObj);

        /// <summary>
        /// checks user exists and update the password
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        string ForgotPassword(User userObj);
    }
}
