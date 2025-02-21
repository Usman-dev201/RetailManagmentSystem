using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddSalesTransaction
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public DateTime TransactionDateandTime { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public TransactionStatus Status { get; set; }
        public ShippingStatus ShippingStatus { get; set; }
        public int TotalItems { get; set; }
        public int PointsPerTransaction { get; set; }
        public IList<SalesTransactionDetail> SalesTransactionDetails { get; } = new List<SalesTransactionDetail>();
        public IList<SalesCommissionAgent> SalesCommissionAgents { get; } = new List<SalesCommissionAgent>();
    }
    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        DebitCard,
        OnlinePayment,
        BankTransfer
    }
    public enum TransactionStatus
    {
        Pending,
        Completed,
        Failed,
        Canceled
    }
    public enum ShippingStatus
    {
        NotShipped,
        Shipped,
        Delivered,
        Returned
    }
}
