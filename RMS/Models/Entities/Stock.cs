namespace RMS.Models.Entities
{
    public class Stock
    {
        public int StockId { get; set; }

        public int LotId { get; set; }

        public virtual ProductPurchaseRecord ProductPurchaseRecord { get; set; }

        public int CurrentStock {  get; set; }
        public int MinimumStock { get; set; }
        public int TotalUnitSold { get; set; }

        public ICollection<StockAdjustment> StockAdjustments { get; set; } = new List<StockAdjustment>();
        public ICollection<StockTransfer> StockTransfers { get; set; } = new List<StockTransfer>();
        public virtual ICollection<SalesTransactionDetail> SalesTransactionDetails { get; set; } = new List<SalesTransactionDetail>();

    }
}
