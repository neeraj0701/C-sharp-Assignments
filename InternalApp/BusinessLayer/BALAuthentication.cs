using BusinessModels;
using DataLayer;

namespace BusinessLayer
{
    /// <summary>
    /// sends the data to data layer and checks the validations by send data to validation class 
    /// </summary>
    internal class BALAuthentication : IBALAuthentication
    {
        /// <summary>
        /// send the login details to BALAuthentication class
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string Login(User user)
        {
            Validation validationObj = new Validation();

            if (validationObj.IsValidUsername(user, 0))
            {
                return Literals.validUsername;
            }
            else if (validationObj.IsValidPassword(user, 0))
            {
                return Literals.validPassword;
            }
            else
            {
                IDALAuthentication iDALAuthObj = new DALFactory().GetDALAuthObj();

                if (iDALAuthObj.Login(user))
                {
                    return Literals.inValidLogin;
                }
                return Literals.successfulLogin;
            }
        }

        /// <summary>
        /// send data to BALAuthentication after validating the inputs
        /// </summary>
        /// <param name="user"></param>
        public string Register(User user)
        {
            Validation validationObj = new Validation();

            if (validationObj.IsValidUsername(user, 0))
            {
                return Literals.validUsername;
            }
            else if (validationObj.IsValidEmail(user))
            {
                return Literals.validMail;
            }
            else if (validationObj.IsValidMobile(user))
            {
                return Literals.validMobile;
            }
            else if (validationObj.IsValidPassword(user, 0))
            {
                return Literals.validPassword;
            }
            else if (validationObj.IsValidUsername(user, 1))
            {
                return Literals.usernameExists;
            }
            else
            {
                IDALAuthentication iDALAuthObj = new DALFactory().GetDALAuthObj();
                iDALAuthObj.Register(user);
                return Literals.successfulRegistration;
            }
        }

        /// <summary>
        /// update the password after validating the inputs
        /// </summary>
        /// <param name="user"></param>
        public string ForgotPassword(User user)
        {
            Validation validationObj = new Validation();

            if (validationObj.IsValidUsername(user, 0))
            {
                return Literals.validUsername;
            }
            else if (validationObj.IsValidPassword(user, 0))
            {
                return Literals.validPassword;
            }
            else if (validationObj.IsValidPassword(user, 2))
            {
                return Literals.validConfirmPassword;
            }
            else if (user.password1 != user.password2)
            {
                return Literals.passwordMatch;
            }
            else
            {
                IDALAuthentication iDALAuthObj = new DALFactory().GetDALAuthObj();
                iDALAuthObj.ForgotPassword(user);
                return Literals.passwordUpdated;
            }
        }
    }
}
