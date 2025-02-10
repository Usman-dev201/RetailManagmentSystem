using System.Transactions;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace RMS.Models.Entities
{
    public class SalesTransaction
    {
        public int TransactionId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public DateTime TransactionDateandTime { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public TransactionStatus Status { get; set; }
        public ShippingStatus ShippingStatus { get; set; }
        public int TotalItems { get; set; }
        public int PointsPerTransaction { get; set; }
        public virtual ICollection<SalesTransactionDetail> SalesTransactionDetails { get; set; } = new List<SalesTransactionDetail>();

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
