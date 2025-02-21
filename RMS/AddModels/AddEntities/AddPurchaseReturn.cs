using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddPurchaseReturn
    {
        public int LotId { get; set; }
        public ProductPurchaseRecord ProductPurchaseRecord { get; set; }
        public int QuantityReturned { get; set; }
        public RefundStatus RefundStatus { get; set; }
        public float RefundAmount { get; set; }
        public string ReasonforRefund { get; set; }
        public DateTime Date { get; set; }

        public StockAdjustment StockAdjustment { get; }
        public IList<ExpenseTracking> ExpenseTrackings { get; } = new List<ExpenseTracking>();
    }

    public enum RefundStatus
    {
        Pending,
        Approved,
        Rejected,
        Processed
    }
}
