using System.Text;

namespace Web_Application
{
    /// <summary>
    /// represents data encryptions and decryptions methods 
    /// </summary>
    public class DataPrivacy
    {
        /// <summary>
        /// Encrypt and Decrypt the data
        /// </summary>
        /// <param name="text"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string EncryptDecrypt(string text, int key)
        {
            StringBuilder strInput = new StringBuilder(text);
            StringBuilder strOutput = new StringBuilder(text.Length);
            char character;

            for (int i = 0; i < text.Length; i++)
            {
                character = strInput[i];
                character = (char)(character ^ key);
                strOutput.Append(character);
            }
            return strOutput.ToString();
        }
    }
}