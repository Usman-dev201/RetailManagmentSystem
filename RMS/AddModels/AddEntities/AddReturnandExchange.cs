using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddReturnandExchange
    {
        public int TransactionDetailId { get; set; }
        public SalesTransactionDetail SalesTransactionDetail { get; set; }
        public int ReturnQuantity { get; set; }
        public float RefundAmount { get; set; }
        public DateTime ReturnDate { get; set; }
        public string ReturnReason { get; set; }

        public Status ReturnStatus { get; set; }
        public StockAdjustment StockAdjustment { get; set; }

    }
    public enum Status
    {
        Pending,
        Approved,
        Rejected
    }
}

