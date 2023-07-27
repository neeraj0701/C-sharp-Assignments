namespace DAL
{
    /// <summary>
    /// creates object for classes in DAL library
    /// </summary>
    public class DALFactory
    {
        /// <summary>
        /// its create an object for DataAccess class
        /// </summary>
        /// <returns></returns>
        public IDataAccess GetDataAccessObj()
        {
            return new DataAccess();
        }
    }
}
