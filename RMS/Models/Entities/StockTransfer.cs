namespace RMS.Models.Entities
{
    public class StockTransfer
    {
        public int TransferId { get; set; }
        public int FromLocationId { get; set; }
        public virtual Location FromLocation { get; set; }
        public int ToLocationId { get; set; }

        public virtual Location ToLocation { get; set; }
       
        public TransferStatus Status { get; set; }
        public float ShippingCharges { get; set; }
        public string AdditionalNotes { get; set; }
        public DateTime CreatedAt { get; set; }

        public int QuantityTransfered { get; set; }
      
        public virtual ICollection<ShippingDetail> ShippingDetails { get; set; } = new List<ShippingDetail>();
        public ICollection<Stock> Stocks { get; set; } = new List<Stock>();
    }

    public enum TransferStatus
    {
        Pending,
        InProgress,
        Completed,
        Canceled
    }
}
