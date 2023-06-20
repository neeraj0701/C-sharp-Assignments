using BusinessModels;

namespace DataLayer
{
    /// <summary>
    /// fetching and updating data in done here
    /// </summary>
    internal class DALAuthentication : IDALAuthentication
    {
        /// <summary>
        /// save the data in database
        /// </summary>
        /// <param name="user"></param>
        public void Register(User userObj)
        {
            DataSource.data.Add(userObj);
        }

        /// <summary>
        /// updates the password
        /// </summary>
        /// <param name="user"></param>
        public void ForgotPassword(User userObj)
        {
            User findUser = DataSource.data.Find(findUser => findUser.username == userObj.username);

            if (findUser != null)
            {
                findUser.password = userObj.password;
            }
        }

        /// <summary>
        /// checks the username already exists or not
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool IsUsernameExists(User userObj)
        {
            User findUser = DataSource.data.Find(findUser => findUser.username == userObj.username);

            if (findUser != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// sends the data to bll for validation
        /// </summary>
        /// <returns></returns>
        public bool Login(User userObj)
        {
            User findUser = DataSource.data.Find(findUser => findUser.username == userObj.username);

            if (findUser != null)
            {
                if (findUser.password == userObj.password)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
    }
}
