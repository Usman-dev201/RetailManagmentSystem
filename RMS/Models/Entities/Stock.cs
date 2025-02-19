namespace RMS.Models.Entities
{
    public class Stock
    {
        public int StockId { get; set; }

        public int LotId { get; set; }

        public  ProductPurchaseRecord ProductPurchaseRecord { get; set; }

        public int CurrentStock {  get; set; }
        public int MinimumStock { get; set; }
        public int TotalUnitSold { get; set; }

        public IList<StockAdjustment> StockAdjustments { get;  } = new List<StockAdjustment>();
        public IList<StockTransfer> StockTransfers { get;  } = new List<StockTransfer>();
        public  IList<SalesTransactionDetail> SalesTransactionDetails { get; } = new List<SalesTransactionDetail>();

    }
}
