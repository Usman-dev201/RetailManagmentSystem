namespace RMS.Models.Entities
{
    public class LoyaltyProgram
    {
        public int ProgramID { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float DiscountPrercentage { get; set; }
        public int PointsPrePurchase { get; set; }
        public  IList<CustomerLoyaltyRecord> CustomerLoyaltyRecords { get; } = new List<CustomerLoyaltyRecord>();
    }
}
