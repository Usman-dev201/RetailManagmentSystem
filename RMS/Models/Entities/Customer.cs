namespace RMS.Models.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public DateTime DateofBirth { get; set; } 
        public string Gender { get; set; }
        public DateTime RegisterationDate { get; set; } 
        public string ShippingAddress { get; set; }
        public float CreditLimit { get; set; }
        
        public virtual ICollection<SalesTransaction> SalesTransactions { get; set; } = new List<SalesTransaction>();

        public virtual ICollection<DraftOrder> DraftOrders { get; set; } = new List<DraftOrder>();
    }
}
