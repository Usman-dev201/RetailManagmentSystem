namespace RMS.Models.Entities
{
    public class SalesTransactionDetail
    {
        public int TransactionDetailId { get; set; }

        public int TransactionId { get; set; }
        public virtual SalesTransaction SalesTransaction { get; set; }
        public int StockId { get; set; }
        public virtual Stock Stock { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public float TotalPrice { get; set; }
        public float AmountPaid { get; set; }
        public float Change { get; set; }
        public int DiscountId { get; set; }
        public virtual Discount Discount { get; set; }
        public int DraftOrderDetailId { get; set; }
        public virtual DraftOrderDetail DraftOrderDetail { get; set; }
        public virtual ICollection<MarketingCampaign> MarketingCampaigns { get; set; } = new List<MarketingCampaign>();
        public virtual ICollection<CustomerFeedback> CustomerFeedbacks { get; set; } = new List<CustomerFeedback>();
        public virtual ICollection<CustomerLoyaltyRecord> CustomerLoyaltyRecords { get;set; } = new List<CustomerLoyaltyRecord>();
        public virtual ICollection<ReturnandExchange> ReturnandExchanges { get; set; } = new List<ReturnandExchange>();
        public virtual ICollection<ShippingDetail> ShippingDetails { get; set; } = new List<ShippingDetail>();
    }

}
