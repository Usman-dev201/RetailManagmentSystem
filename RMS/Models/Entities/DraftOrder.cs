namespace RMS.Models.Entities
{
    public class DraftOrder
    {
        public int DraftOrderId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public DateTime CreatedDate { get; set; }
        public string PayTerms { get; set; }
        public DraftOrderStatus Status { get; set; }
        public DateTime DueDate { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<DraftOrderDetail> DraftOrderDetails { get; set; } = new List<DraftOrderDetail>();    
    }
    public enum DraftOrderStatus
    {
        Pending,
        Confirmed,
        Cancelled
    }
}
