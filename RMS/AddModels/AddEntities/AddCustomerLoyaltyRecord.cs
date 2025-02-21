using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddCustomerLoyaltyRecord
    {
        public int TransactionDetailId { get; set; }
        public SalesTransactionDetail SalesTransactionDetail { get; set; }
        public int LoyaltyProgramId { get; set; }
        public LoyaltyProgram LoyaltyProgram { get; set; }
        public int PointsAccumulated { get; set; }

        public int? PointsRedeemed { get; set; }
        public int TotalPoints { get; set; }

    }
}
