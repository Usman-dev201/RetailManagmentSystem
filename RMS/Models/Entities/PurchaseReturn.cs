namespace RMS.Models.Entities
{
    public class PurchaseReturn
    {
        public int PurchaseReturnId { get; set; }

        public int LotId { get; set; }
        public virtual ProductPurchaseRecord ProductPurchaseRecord { get; set; }
        public int QuantityReturned { get; set; }
        public RefundStatus RefundStatus { get; set; }
        public float RefundAmount { get; set; }
        public string ReasonforRefund { get; set; }
        public DateTime Date { get; set; }

        public virtual StockAdjustment StockAdjustment { get; set; }
    }

    public enum RefundStatus
    {
        Pending,
        Approved,
        Rejected,
        Processed
    }
}
