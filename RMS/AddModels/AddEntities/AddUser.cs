using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddUser
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Passward { get; set; }
        public string UserPhone { get; set; }
        public string Address { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public DateTime Cretaedat { get; set; }
        public DateTime Updatedat { get; set; }
        public IList<SalesTransaction> SalesTransactions { get; } = new List<SalesTransaction>();
        public IList<SalesCommissionAgent> SalesCommissionAgents { get; } = new List<SalesCommissionAgent>();
    }
}
