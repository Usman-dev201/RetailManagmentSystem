namespace RMS.Models.Entities
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Email { get; set; }

        public int ContactNo { get; set; }

        public string Address { get; set; }

        public IList<ProductPurchaseRecord> ProductPurchaseRecords { get;  } = new List<ProductPurchaseRecord>();
    }
}
