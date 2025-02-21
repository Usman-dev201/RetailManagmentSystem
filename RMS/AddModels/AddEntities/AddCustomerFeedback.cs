using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddCustomerFeedback
    {
        public int TransactionDetailId { get; set; }
        public SalesTransactionDetail SalesTransactionDetail { get; set; }
        public Feedback FeedbackType { get; set; }
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

