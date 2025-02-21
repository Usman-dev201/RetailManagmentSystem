using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddCustomer
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Gender { get; set; }
        public DateTime RegisterationDate { get; set; }
        public string ShippingAddress { get; set; }
        public float CreditLimit { get; set; }

        public IList<SalesTransaction> SalesTransactions { get; } = new List<SalesTransaction>();

        public IList<DraftOrder> DraftOrders { get; } = new List<DraftOrder>();
    }
}
