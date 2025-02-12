namespace RMS.Models.Entities
{
    public class SalesCommissionAgent
    {
        public int AgentId { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int TransactionDetailId { get; set; }
        public virtual SalesTransactionDetail SalesTransactionDetail { get; set; }
        public string AgentName { get; set; }
        public string AgentAddress { get; set; }
        public int ContactNo { get; set; }

        public float SalesCommissionPercentage { get; set; }


    }
}
