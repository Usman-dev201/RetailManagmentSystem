using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddRole
    {
        public string RoleName { get; set; }
        public IList<User> Users { get; } = new List<User>();
    }
}
