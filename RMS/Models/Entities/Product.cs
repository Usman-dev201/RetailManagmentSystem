namespace RMS.Models.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
         public float SellingPrice { get; set; }

        public string SKU { get; set; }
        public string ImageURL { get; set; }

        public int? CategoryId { get; set; }

        public int? TaxId { get; set; }
        public int? BrandId { get; set; }
        public int? DiscountId { get; set; }
        public virtual Discount Discount { get; set; }
        public virtual Category Category { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Tax Tax { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual ICollection<ProductPurchaseRecord> ProductPurchaseRecords { get; set; } = new List<ProductPurchaseRecord>();
        public virtual ICollection<RackProductRecord> RacksProductRecords { get; set;} = new List<RackProductRecord>();
        public virtual ICollection<DraftOrderDetail> DraftOrderDetails { get; set; } = new List<DraftOrderDetail>();
    }
}
