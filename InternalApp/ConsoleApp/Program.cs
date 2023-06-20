using BusinessModels;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            Authentication authnObj = new Authentication();

            while (true)
            {
                Console.WriteLine(Literals.mainInput);
                string option = Console.ReadLine();
                int value;

                if (!Regex.IsMatch(option, @"[0-9]"))
                {
                    break;
                }
                else
                {
                    value = Int32.Parse(option);
                }

                switch (value)
                {
                    case (int)Operator.Login:
                        authnObj.Login();
                        break;
                    case (int)Operator.Register:
                        authnObj.Register();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}