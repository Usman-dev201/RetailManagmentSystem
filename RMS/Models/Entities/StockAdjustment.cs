using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

namespace RMS.Models.Entities
{
    public class StockAdjustment
    {
        public int AdjustmentId { get; set; }
        public AdjustmentType AdjustmentType { get; set; }
        public int QuantityAdjust { get; set; }
        public float TotalAmount { get; set; }
        public float TotalAmountRecovered { get; set; }
        public string Reason { get; set; }
        public int LocationId { get; set; }

        public virtual Location Location { get; set; }
    

        public int PurchaseReturnId { get; set; }
        public virtual PurchaseReturn PurchaseReturn { get; set; }
        public int SalesReturnId { get; set; }
        public virtual ReturnandExchange ReturnandExchange { get; set; }
        public ICollection<Stock> Stocks { get; set; } = new List<Stock>();

    }
    public enum AdjustmentType
    {
        Increase,
        Decrease,
        Damage,
        Return
    }
}
