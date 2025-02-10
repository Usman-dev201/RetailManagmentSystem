namespace RMS.Models.Entities
{
    public class DraftOrderDetail
    {
        public int DraftOrderDetailId {  get; set; }
        public int DraftOrderId { get; set; }
        public virtual DraftOrder DraftOrder { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public float TotalAmount { get; set; }
       
        public int DiscountId { get; set; }
        public virtual Discount Discount { get; set; }

        public virtual SalesTransactionDetail SalesTransactionDetail { get; set; }
        

    }
}
