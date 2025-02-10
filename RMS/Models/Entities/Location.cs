namespace RMS.Models.Entities
{
    public class Location
    {
        public int LocationId { get; set; }

        public string LocationName { get; set; }

        public string LoctionAddress { get; set; }
        public virtual ICollection<Tax> Taxes { get; set; } = new List<Tax>();
        public virtual ICollection<ProductPurchaseRecord> ProductPurchaseRecords { get; set; } = new List<ProductPurchaseRecord>();

        public virtual ICollection<Rack> Racks { get; set; } = new List<Rack>();
        public virtual ICollection<StockTransfer> FromStockTransfers { get; set; } = new List<StockTransfer>();
        public virtual ICollection<StockTransfer> ToStockTransfers { get; set; } = new List<StockTransfer>();

        public virtual ICollection<StockAdjustment> StockAdjustments { get; set; } = new List<StockAdjustment>();

    }
}
