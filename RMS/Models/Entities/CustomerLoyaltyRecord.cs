namespace RMS.Models.Entities
{
    public class CustomerLoyaltyRecord
    {
        public int CustomerLoyaltyRecordId { get; set; }
        public int TransactionDetailId { get; set; }
        public virtual SalesTransactionDetail SalesTransactionDetail { get; set; }
        public int LoyaltyProgramId { get; set; }
        public virtual LoyaltyProgram LoyaltyProgram { get; set; }
        public int PointsAccumulated { get; set; }

        public int? PointsRedeemed { get; set; }
        public int TotalPoints{ get; set; }

    }
}
