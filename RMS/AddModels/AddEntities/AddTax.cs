using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddTax
    {
        public string TaxName { get; set; }

        public float TaxPercentage { get; set; }

        public int LocationId { get; set; }

        public Location Location { get; set; }

        public IList<ProductTaxRecord> ProductTaxRecords { get; } = new List<ProductTaxRecord>();
    }
}
