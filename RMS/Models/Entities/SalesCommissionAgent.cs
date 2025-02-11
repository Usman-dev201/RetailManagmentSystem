namespace RMS.Models.Entities
{
    public class SalesCommissionAgent
    {
        public int AgentId { get; set; }
        public string AgentName { get; set; }
        public string AgentAddress { get; set; }
        public int ContactNo { get; set; }

        public float SalesCommissionPercentage { get; set; }

    }
}
