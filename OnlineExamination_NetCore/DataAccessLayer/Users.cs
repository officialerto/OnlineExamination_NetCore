namespace DataAccessLayer
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int Role { get; set; }
        public ICollection<Groups>? Groups { get; set; } = new HashSet<Groups>();

    }
}