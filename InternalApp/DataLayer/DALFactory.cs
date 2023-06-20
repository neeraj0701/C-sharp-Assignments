namespace DataLayer
{
    /// <summary>
    /// creates object for classes
    /// </summary>
    public class DALFactory
    {
        /// <summary>
        /// its create an object for DALAuthentication class
        /// </summary>
        /// <returns></returns>
        public IDALAuthentication GetDALAuthObj()
        {
            return new DALAuthentication();
        }
    }
}
