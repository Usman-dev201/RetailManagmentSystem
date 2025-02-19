namespace RMS.Models.Entities
{
    public class ProductTaxRecord
    {
        public int ProductTaxRecordId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int TaxId { get; set; }
        public Tax Tax { get; set; }
        public DateTime Effectivedate { get; set; }
    }
}
