namespace RMS.Models.Entities
{
    public class ReturnandExchange
    {
        public int SalesReturnId { get; set; }
        public int TransactionDetailId { get; set; }
        public virtual SalesTransactionDetail SalesTransactionDetail { get; set; }
        public int ReturnQuantity { get; set; }
        public float RefundAmount { get; set; }
        public DateTime ReturnDate { get; set; }
        public string ReturnReason {  get; set; }
        
        public Status ReturnStatus { get; set; }
        public virtual StockAdjustment StockAdjustment { get; set; }

    }
    public enum Status
    {
        Pending,
        Approved,
        Rejected
    }
}
