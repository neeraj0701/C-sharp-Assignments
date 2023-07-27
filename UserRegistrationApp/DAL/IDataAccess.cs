using BusinessModel;
using System.Collections.Generic;

namespace DAL
{
    public interface IDataAccess
    {
        /// <summary>
        /// saves the data into database
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        int SaveRegistrationDetails(User userObj);

        /// <summary>
        /// fetch the login details
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        List<List<string>> FetchLoginDetails(User userObj);

        /// <summary>
        /// update the password
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        int UpdatePassword(User userObj);
    }
}
