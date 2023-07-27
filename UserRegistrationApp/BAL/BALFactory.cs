namespace BAL
{
    /// <summary>
    /// creates object for BAL Library classes
    /// </summary>
    public class BALFactory
    {
        /// <summary>
        /// its create an object for BALAuthentication class
        /// </summary>
        /// <returns></returns>
        public IBALAuthentication GetBALAuthObj()
        {
            return new BALAuthentication();
        }
    }
}
