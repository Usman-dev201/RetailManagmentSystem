namespace RMS.Models.Entities
{
    public class ProductPurchaseRecord
    {
        public int LotId { get; set; } 

        public int ProductId { get; set; } 
        public int PurchaseId { get; set; } 
        public int SupplierId { get; set; } 
        public int LocationId { get; set; } 
        public virtual Product Product { get; set; }
        public virtual PurchaseRecord PurchaseRecord { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Location Location { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();
        public virtual ICollection<PurchaseReturn> PurchaseReturns { get; set; } = new List<PurchaseReturn>();
        public virtual ICollection<ExpenseTracking> ExpenseTrackings { get; set; } = new List<ExpenseTracking>();


    }
}
