namespace BusinessModel
{
    /// <summary>
    /// represents all details that stores in database
    /// </summary>
    public class User
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public long Mobile { get; set; }
        public string Password { get; set; }
    }

}
