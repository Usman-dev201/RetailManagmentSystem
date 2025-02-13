namespace RMS.Models.Entities
{
    public class CustomerFeedback
    {
        public int FeedbackId { get; set; }
        public int TransactionDetailId { get; set; }
        public virtual SalesTransactionDetail SalesTransactionDetail { get; set; }
        public Feedback  FeedbackType { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }
        public DateTime Date { get; set; } 
    }
    public enum Feedback
    {
        Complaint, 
        Suggestion,
        Review
    }
}
