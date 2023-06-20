using BusinessModels;

namespace DataLayer
{
    /// <summary>
    /// contains the methods to be implemented in BALAuthentication class
    /// </summary>
    public interface IDALAuthentication
    {
        /// <summary>
        /// checks the login credentials
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool Login(User userObj);

        /// <summary>
        /// stores the users data
        /// </summary>
        /// <param name="user"></param>
        void Register(User userObj);

        /// <summary>
        /// update the new password
        /// </summary>
        /// <param name="user"></param>
        void ForgotPassword(User userObj);

        /// <summary>
        /// checks username already exists
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool IsUsernameExists(User user);
    }
}
