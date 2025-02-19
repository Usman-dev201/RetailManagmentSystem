namespace RMS.Models.Entities
{
    public class Location
    {
        public int LocationId { get; set; }

        public string LocationName { get; set; }

        public string LoctionAddress { get; set; }
        public  IList<Tax> Taxes { get; } = new List<Tax>();
        public  IList<ProductPurchaseRecord> ProductPurchaseRecords { get;  } = new List<ProductPurchaseRecord>();

        public  IList<Rack> Racks { get;  } = new List<Rack>();
        public  IList<StockTransfer> FromStockTransfers { get;} = new List<StockTransfer>();
        public  IList<StockTransfer> ToStockTransfers { get;  } = new List<StockTransfer>();

        public IList<StockAdjustment> StockAdjustments { get; } = new List<StockAdjustment>();

    }
}
