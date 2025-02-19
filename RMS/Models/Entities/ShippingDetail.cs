namespace RMS.Models.Entities
{
    public class ShippingDetail
    {
        public int ShippingId { get; set; }
        public int TransactionDetailId { get; set; }
        public  SalesTransactionDetail SalesTransactionDetail { get; set; }
        public int TransferId { get; set; }
        public  StockTransfer StockTransfer { get; set; }

        public ShippingMethod ShippingMethod { get; set; }
        public float ShippingCost { get; set; }
        public string EstimatedDeliveryDate { get; set; }
        public ShipStatus Status { get; set; }
        public string CourierService {  get; set; }
        public string DestinationAddress { get; set; }
        public int Quantity { get; set; }
       
       
    }
    public enum ShipStatus
    {
        Pending,
        Shipped,
        InTransit,
        Delivered,
        Cancelled,
        Returned
    }

    public enum ShippingMethod
    {
        Standard,
        Express,
        Overnight,
        SameDay,
        International
    }
}
