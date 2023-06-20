namespace BusinessLayer
{
    /// <summary>
    /// creates object for classes
    /// </summary>
    public class BALFactory
    {
        /// <summary>
        /// its create an object for DALAuthentication class
        /// </summary>
        /// <returns></returns>
        public IBALAuthentication GetBALAuthObj()
        {
            return new BALAuthentication();
        }
    }
}
