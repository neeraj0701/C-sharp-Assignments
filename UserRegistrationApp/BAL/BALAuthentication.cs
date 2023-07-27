using BusinessModel;
using DAL;
using System.Collections.Generic;
using Web_Application;

namespace BAL
{
    /// <summary>
    /// Represent the authentication of all the pages
    /// </summary>
    internal class BALAuthentication : IBALAuthentication
    {
        /// <summary>
        /// Sends the data to SaveRegistrationDetails method
        /// </summary>
        /// <param name="username"></param>
        /// <param name="name"></param>
        /// <param name="mail"></param>
        /// <param name="mobile"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string Registration(User userObj)
        {
            userObj.Password = DataPrivacy.EncryptDecrypt(userObj.Password, 200);
            IDataAccess dataObj = new DALFactory().GetDataAccessObj();

            if (dataObj.FetchLoginDetails(userObj).Count == 0)
            {
                return dataObj.SaveRegistrationDetails(userObj);
            }
            else
            {
                return "username exist";
            }
        }

        /// <summary>
        /// fetch data from fetchlogindetails and validate them
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string Login(User userObj)
        {
            IDataAccess dataObj = new DALFactory().GetDataAccessObj();
            List<string> data = dataObj.FetchLoginDetails(userObj);

            if (data[2] != null)
            {
                if (data.Count > 0)
                {
                    if (DataPrivacy.EncryptDecrypt(data[1], 200) != userObj.Password)
                    {
                        return "incorrect password";
                    }
                    else
                    {
                        return "login successful";
                    }
                }
                else
                {
                    return "incorrect username";
                }
            }
            else
            {
                return data[2];
            }
        }

        /// <summary>
        /// Sends the data to UpdatePassword method
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string ForgotPassword(User userObj)
        {
            userObj.Password = DataPrivacy.EncryptDecrypt(userObj.Password, 200);
            IDataAccess dataObj = new DALFactory().GetDataAccessObj();

            if (dataObj.FetchLoginDetails(userObj).Count == 1)
            {
                return dataObj.SaveRegistrationDetails(userObj);
            }
            else
            {
                return "user not exist";
            }
        }
    }
}
