using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddDraftOrderDetail
    {
        public int DraftOrderId { get; set; }
        public DraftOrder DraftOrder { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public float TotalAmount { get; set; }

        public int DiscountId { get; set; }
        public Discount Discount { get; set; }

        public SalesTransactionDetail SalesTransactionDetail { get; }

    }
}
