using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddProductTaxRecord
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int TaxId { get; set; }
        public Tax Tax { get; set; }
        public DateTime Effectivedate { get; set; }
    }
}
