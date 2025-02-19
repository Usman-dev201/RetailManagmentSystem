namespace RMS.Models.Entities
{
    public class CustomerLoyaltyRecord
    {
        public int CustomerLoyaltyRecordId { get; set; }
        public int TransactionDetailId { get; set; }
        public  SalesTransactionDetail SalesTransactionDetail { get; set; }
        public int LoyaltyProgramId { get; set; }
        public  LoyaltyProgram LoyaltyProgram { get; set; }
        public int PointsAccumulated { get; set; }

        public int? PointsRedeemed { get; set; }
        public int TotalPoints{ get; set; }

    }
}
