using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddLoyaltyProgram
    {
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float DiscountPrercentage { get; set; }
        public int PointsPrePurchase { get; set; }
        public IList<CustomerLoyaltyRecord> CustomerLoyaltyRecords { get; } = new List<CustomerLoyaltyRecord>();
    }
}

