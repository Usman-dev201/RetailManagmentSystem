using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddSalesComissionAgent
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int TransactionDetailId { get; set; }
        public SalesTransactionDetail SalesTransactionDetail { get; set; }
        public string AgentName { get; set; }
        public string AgentAddress { get; set; }
        public int ContactNo { get; set; }

        public float SalesCommissionPercentage { get; set; }
    }
}
