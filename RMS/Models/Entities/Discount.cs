namespace RMS.Models.Entities
{
    public class Discount
    {
        public int DiscountId { get; set; }

        public string DiscountCode { get; set; }
        public DiscountType DiscountType { get; set; }
        public float DiscountAmount { get; set; }
        public DateTime ValidFrom { get; set; } 
        public DateTime ValidUntil { get; set; }
        public float MinimumPurchaseAmount { get; set; }
        public float MaxDiscountLimit { get; set; }
        public DiscountStatus Status { get; set; }
        public IList<SalesTransactionDetail> SalesTransactionDetails { get;  } = new List<SalesTransactionDetail>();
        public  IList<DraftOrderDetail> DraftOrderDetails { get;  } = new List<DraftOrderDetail>();
        public  IList<Product> Products { get;}  = new List<Product>();
    }
    public enum DiscountStatus
    {
        Active,
        Expired
    }
    public enum DiscountType
    {
        Percentage,
        FixedAmount
    }
}
