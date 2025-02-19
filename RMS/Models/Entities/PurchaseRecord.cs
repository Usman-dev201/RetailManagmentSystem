using System.ComponentModel.DataAnnotations;

namespace RMS.Models.Entities
{
    public class PurchaseRecord
    {
        
        public int PurchaseId { get; set; }

        public int QuantityOrder { get; set; }

        public int QuantitySupplied { get; set; }

        public int QuantityBackOrdered { get; set; }
        public DateTime OrderDate { get; set; }

        public float  UnitPrice { get; set; }

        public float TotalPrice { get; set; }
        public PurchaseStatus PurchaseStatus { get; set; }
        public PaymentStatus PaymentStatus { get; set; }

        public float  AmountPaid { get; set; }
        public float PaymentDue { get; set; }

        public  IList<ProductPurchaseRecord> ProductPurchaseRecords { get;  } = new List<ProductPurchaseRecord>();
    }

    public enum PurchaseStatus
    {
        Pending,
        Completed,
        Canceled,
        BackOrdered
    }

    
    public enum PaymentStatus
    {
        Unpaid,
        PartiallyPaid,
        Paid,
        Overdue
    }
}
