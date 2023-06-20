using BusinessModels;

namespace BusinessLayer
{
    /// <summary>
    /// contains the methods to be implemented in BALAuthentication class
    /// </summary>
    public interface IBALAuthentication
    {
        /// <summary>
        /// sends data to BALAuthentication after validating the inputs
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        string Register(User userObj);

        /// <summary>
        /// send the login details to BALAuthentication class
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        string Login(User userObj);

        /// <summary>
        /// update the password after validating the inputs
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        string ForgotPassword(User userObj);
    }
}
