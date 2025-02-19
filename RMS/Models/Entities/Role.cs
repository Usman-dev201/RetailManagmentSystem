namespace RMS.Models.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public  IList<User> Users { get; } = new List<User>();

    }
}
