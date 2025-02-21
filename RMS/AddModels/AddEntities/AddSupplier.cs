using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddSupplier
    {
        public string SupplierName { get; set; }
        public string Email { get; set; }

        public int ContactNo { get; set; }

        public string Address { get; set; }

        public IList<ProductPurchaseRecord> ProductPurchaseRecords { get; } = new List<ProductPurchaseRecord>();
    }
}
