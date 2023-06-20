using BusinessModels;
using DataLayer;
using System.Text.RegularExpressions;

namespace BusinessLayer
{
    /// <summary>
    /// Validation of inputs is done here
    /// </summary>
    public class Validation
    {
        /// <summary>
        /// checks username is valid or its already exists
        /// </summary>
        /// <param name="username"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public bool IsValidUsername(User userObj, int flag)
        {
            if (flag == 0)
            {
                return !Regex.IsMatch(userObj.username, @"[A-Za-z0-9]{7,15}");
            }
            else
            {
                IDALAuthentication iDALAuthObj = new DALFactory().GetDALAuthObj();
                return iDALAuthObj.IsUsernameExists(userObj);
            }
        }

        /// <summary>
        /// checks given password is in correct format or not
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsValidPassword(User userObj, int flag)
        {
            if (flag == 0)
            {
                return !(Regex.IsMatch(userObj.password, @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$"));
            }
            else if (flag == 1)
            {
                return !(Regex.IsMatch(userObj.password1, @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$"));
            }
            else
            {
                return !(Regex.IsMatch(userObj.password2, @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$"));
            }
        }
        /// <summary>
        /// Checks it contains mail or not
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public bool IsValidEmail(User userObj)
        {
            return !Regex.IsMatch(userObj.mail, @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$");
        }

        /// <summary>
        /// given mobile is in correct format or not
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public bool IsValidMobile(User userObj)
        {
            return !Regex.IsMatch(userObj.mobile, @"^[0-9]{10}$");
        }
    }
}