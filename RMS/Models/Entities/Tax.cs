namespace RMS.Models.Entities
{
    public class Tax
    {
        public int TaxId { get; set; }

        public string TaxName { get; set; }

        public float TaxPercentage { get; set; }

        public int LocationId   { get; set; }

        public virtual Location Location { get; set; }
        public DateTime EffectiveDate { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
