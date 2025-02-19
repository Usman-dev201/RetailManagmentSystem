namespace RMS.Models.Entities
{
    public class DraftOrder
    {
        public int DraftOrderId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public DateTime CreatedDate { get; set; }
        public string PayTerms { get; set; }
        public DraftOrderStatus Status { get; set; }
        public DateTime DueDate { get; set; }
        public string Notes { get; set; }

        public  IList<DraftOrderDetail> DraftOrderDetails { get; } = new List<DraftOrderDetail>();    
    }
    public enum DraftOrderStatus
    {
        Pending,
        Confirmed,
        Cancelled
    }
}
