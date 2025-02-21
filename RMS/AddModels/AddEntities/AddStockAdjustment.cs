using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddStockAdjustment
    {
        public AdjustmentType AdjustmentType { get; set; }
        public int QuantityAdjust { get; set; }
        public float TotalAmount { get; set; }
        public float TotalAmountRecovered { get; set; }
        public string Reason { get; set; }
        public int LocationId { get; set; }

        public Location Location { get; set; }


        public int PurchaseReturnId { get; set; }
        public PurchaseReturn PurchaseReturn { get; set; }
        public int SalesReturnId { get; set; }
        public ReturnandExchange ReturnandExchange { get; set; }
        public IList<Stock> Stocks { get; } = new List<Stock>();

    }
    public enum AdjustmentType
    {
        Increase,
        Decrease,
        Damage,
        Return
    }
}
