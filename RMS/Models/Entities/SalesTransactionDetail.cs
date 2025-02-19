namespace RMS.Models.Entities
{
    public class SalesTransactionDetail
    {
        public int TransactionDetailId { get; set; }

        public int TransactionId { get; set; }
        public  SalesTransaction SalesTransaction { get; set; }
        public int StockId { get; set; }
        public  Stock Stock { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public float TotalPrice { get; set; }
        public float AmountPaid { get; set; }
        public float Change { get; set; }
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }
        public int DraftOrderDetailId { get; set; }
        public  DraftOrderDetail DraftOrderDetail { get; set; } 
        public  IList<MarketingCampaign> MarketingCampaigns { get;  } = new List<MarketingCampaign>();
        public IList<CustomerFeedback> CustomerFeedbacks { get; } = new List<CustomerFeedback>();
        public IList<CustomerLoyaltyRecord> CustomerLoyaltyRecords { get; } = new List<CustomerLoyaltyRecord>();
        public IList<ReturnandExchange> ReturnandExchanges { get;  } = new List<ReturnandExchange>();
        public IList<ShippingDetail> ShippingDetails { get;  } = new List<ShippingDetail>();
        public IList<SalesCommissionAgent> SalesCommissionAgents { get; } = new List<SalesCommissionAgent>();
    }

}
