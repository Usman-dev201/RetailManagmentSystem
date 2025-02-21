using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddDiscount
    {
        public string DiscountCode { get; set; }
        public RMS.Models.Entities.DiscountType DiscountType { get; set; }
        public float DiscountAmount { get; set; }
        public DateTime ValidFrom { get; set; }
        public string ValidUntil { get; set; }
        public float MinimumPurchaseAmount { get; set; }
        public float MaxDiscountLimit { get; set; }
        public RMS.Models.Entities.DiscountStatus Status { get; set; }
        public IList<SalesTransactionDetail> SalesTransactionDetails { get; } = new List<SalesTransactionDetail>();
        public IList<DraftOrderDetail> DraftOrderDetails { get; } = new List<DraftOrderDetail>();
        public IList<Product> Products { get; } = new List<Product>();
    }
   
}


