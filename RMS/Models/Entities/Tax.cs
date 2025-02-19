using Microsoft.CodeAnalysis.Elfie.Serialization;

namespace RMS.Models.Entities
{
    public class Tax
    {
        public int TaxId { get; set; }

        public string TaxName { get; set; }

        public float TaxPercentage { get; set; }

        public int LocationId   { get; set; }

        public  Location Location { get; set; }
      
        public IList<ProductTaxRecord> ProductTaxRecords { get;  } = new List<ProductTaxRecord>();  
        
    }
}
