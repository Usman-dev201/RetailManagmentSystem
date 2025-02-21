using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddProduct
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public float SellingPrice { get; set; }

        public string SKU { get; set; }
        public string ImageURL { get; set; }

        public int? CategoryId { get; set; }


        public int? BrandId { get; set; }
        public int? DiscountId { get; set; }
        public Discount Discount { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }


        public DateTime CreatedAt { get; set; }

        public IList<ProductPurchaseRecord> ProductPurchaseRecords { get; } = new List<ProductPurchaseRecord>();
        public IList<Rack> Racks { get; } = new List<Rack>();
        public IList<DraftOrderDetail> DraftOrderDetails { get; } = new List<DraftOrderDetail>();

        public IList<ProductTaxRecord> ProductTaxRecords { get; } = new List<ProductTaxRecord>();
    }
}

