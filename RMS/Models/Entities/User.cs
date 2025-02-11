namespace RMS.Models.Entities
{
    public class User
    {
        public int UserID {  get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Passward { get; set; }
        public string UserPhone { get; set; }
        public string Address { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public DateTime Cretaedat { get; set; }
        public DateTime Updatedat {  get; set; }
        public virtual ICollection<SalesTransaction> SalesTransactions { get; set; } = new List<SalesTransaction>();


    }
}
