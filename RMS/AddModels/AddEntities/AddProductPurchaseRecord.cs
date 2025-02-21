using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddProductPurchaseRecord
    {
        public int ProductId { get; set; }
        public int PurchaseId { get; set; }
        public int SupplierId { get; set; }
        public int LocationId { get; set; }
        public Product Product { get; set; }
        public AddPurchaseRecord PurchaseRecord { get; set; }
        public Supplier Supplier { get; set; }
        public Location Location { get; set; }

        public IList<Stock> Stocks { get; } = new List<Stock>();
        public IList<PurchaseReturn> PurchaseReturns { get; } = new List<PurchaseReturn>();
        public IList<ExpenseTracking> ExpenseTrackings { get; } = new List<ExpenseTracking>();

    }
}
