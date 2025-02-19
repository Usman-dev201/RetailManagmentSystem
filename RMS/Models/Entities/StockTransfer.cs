namespace RMS.Models.Entities
{
    public class StockTransfer
    {
        public int TransferId { get; set; }
        public int FromLocationId { get; set; }
        public Location FromLocation { get; set; }
        public int ToLocationId { get; set; }

        public Location ToLocation { get; set; }
       
        public TransferStatus Status { get; set; }
        public float ShippingCharges { get; set; }
        public string AdditionalNotes { get; set; }
        public DateTime CreatedAt { get; set; }

        public int QuantityTransfered { get; set; }
      
        public IList<ShippingDetail> ShippingDetails { get; } = new List<ShippingDetail>();
        public IList<Stock> Stocks { get;  } = new List<Stock>();
    }

    public enum TransferStatus
    {
        Pending,
        InProgress,
        Completed,
        Canceled
    }
}
