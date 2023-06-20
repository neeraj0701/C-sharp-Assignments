using BusinessLayer;
using BusinessModels;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    /// <summary>
    /// Takes the input from user
    /// </summary>
    public class Authentication
    {
        /// <summary>
        /// takes the input from login page
        /// </summary>
        public void Login()
        {
            User userObj = new User();

            Console.WriteLine(Literals.login);
            Console.Write(Literals.username);
            userObj.username = Console.ReadLine();
            Console.Write(Literals.password);
            userObj.password = Console.ReadLine();

            IBALAuthentication iBALAuthObj = new BALFactory().GetBALAuthObj();

            string loginOutput = iBALAuthObj.Login(userObj);

            while (loginOutput != Literals.successfulLogin)
            {
                if (loginOutput == Literals.validUsername)
                {
                    Console.WriteLine(Literals.validUsername);
                    Console.Write(Literals.username);
                    userObj.username = Console.ReadLine();
                    loginOutput = iBALAuthObj.ForgotPassword(userObj);
                }
                else if (loginOutput == Literals.validPassword)
                {
                    Console.WriteLine(Literals.validPassword);
                    Console.Write(Literals.password);
                    userObj.password = Console.ReadLine();
                    loginOutput = iBALAuthObj.ForgotPassword(userObj);
                }
                else
                {
                    Console.WriteLine(loginOutput);
                    break;
                }
            }

            if (loginOutput == Literals.invalidInput)
            {
                Console.WriteLine(Literals.inValidLogin);
                Console.WriteLine(Literals.forgotPasswordInput);
                string option = Console.ReadLine();
                int value;

                if (!Regex.IsMatch(option, @"[0-9]"))
                {
                    Console.WriteLine(Literals.invalidInput);
                }
                else
                {
                    value = Int32.Parse(option);

                    switch (value)
                    {
                        case (int)Operator.ForgotPassword:
                            ForgotPassword();
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine(Literals.successfulLogin);
                Console.WriteLine(Literals.logoutInput);
                string option = Console.ReadLine();
                int value;

                if (!Regex.IsMatch(option, @"[0-9]"))
                {
                    Console.WriteLine(Literals.invalidInput);
                }
                else
                {
                    value = Int32.Parse(option);

                    switch (value)
                    {
                        case (int)Operator.Logout:
                            Logout();
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// take the input from register page
        /// </summary>
        public void Register()
        {
            User userObj = new User();

            Console.WriteLine(Literals.register);
            Console.Write(Literals.username);
            userObj.username = Console.ReadLine();
            Console.Write(Literals.name);
            userObj.name = Console.ReadLine();
            Console.Write(Literals.mail);
            userObj.mail = Console.ReadLine();
            Console.Write(Literals.phone);
            userObj.mobile = Console.ReadLine();
            Console.Write(Literals.password);
            userObj.password = Console.ReadLine();

            IBALAuthentication iBALAuthObj = new BALFactory().GetBALAuthObj();
            String registrationOutput = iBALAuthObj.Register(userObj);

            while (registrationOutput != Literals.successfulRegistration)
            {
                if (registrationOutput == Literals.validUsername)
                {
                    Console.WriteLine(Literals.validUsername);
                    Console.Write(Literals.username);
                    userObj.username = Console.ReadLine();
                    registrationOutput = iBALAuthObj.Register(userObj);
                }
                else if (registrationOutput == Literals.validMail)
                {
                    Console.WriteLine(Literals.validMail);
                    Console.Write(Literals.mail);
                    userObj.mail = Console.ReadLine();
                    registrationOutput = iBALAuthObj.Register(userObj);
                }
                else if (registrationOutput == Literals.validMobile)
                {
                    Console.WriteLine(Literals.validMobile);
                    Console.Write(Literals.phone);
                    userObj.mobile = Console.ReadLine();
                    registrationOutput = iBALAuthObj.Register(userObj);
                }
                else if (registrationOutput == Literals.validPassword)
                {
                    Console.WriteLine(Literals.validPassword);
                    Console.Write(Literals.password);
                    userObj.password = Console.ReadLine();
                    registrationOutput = iBALAuthObj.Register(userObj);
                }
                else if (registrationOutput == Literals.usernameExists)
                {
                    Console.WriteLine(Literals.usernameExists);
                    Console.Write(Literals.usernameExists);
                    userObj.username = Console.ReadLine();
                    registrationOutput = iBALAuthObj.Register(userObj);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(Literals.successfulRegistration);
        }

        /// <summary>
        /// take input from forgot password page
        /// </summary>
        public void ForgotPassword()
        {
            User userObj = new User();

            Console.WriteLine(Literals.forgotPassword);
            Console.Write(Literals.username);
            userObj.username = Console.ReadLine();
            Console.Write(Literals.password);
            userObj.password1 = Console.ReadLine();
            Console.Write(Literals.confirmPassword);
            userObj.password2 = Console.ReadLine();

            IBALAuthentication iBALAuthObj = new BALFactory().GetBALAuthObj();
            string forgotPasswordOutput = iBALAuthObj.ForgotPassword(userObj);

            while (forgotPasswordOutput != Literals.passwordUpdated)
            {
                if (forgotPasswordOutput == Literals.validUsername)
                {
                    Console.WriteLine(Literals.validUsername);
                    Console.Write(Literals.username);
                    userObj.username = Console.ReadLine();
                    forgotPasswordOutput = iBALAuthObj.ForgotPassword(userObj);
                }
                else if (forgotPasswordOutput == Literals.validPassword)
                {
                    Console.WriteLine(Literals.validPassword);
                    Console.Write(Literals.password);
                    userObj.password1 = Console.ReadLine();
                    forgotPasswordOutput = iBALAuthObj.ForgotPassword(userObj);
                }
                else if (forgotPasswordOutput == Literals.validConfirmPassword)
                {
                    Console.WriteLine(Literals.validConfirmPassword);
                    Console.Write(Literals.confirmPassword);
                    userObj.password2 = Console.ReadLine();
                    forgotPasswordOutput = iBALAuthObj.ForgotPassword(userObj);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(Literals.passwordUpdated);
        }
        /// <summary>
        /// user has logout
        /// </summary>
        public void Logout()
        {
            Console.WriteLine(Literals.logout);
        }
    }
}
