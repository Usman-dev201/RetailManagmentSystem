using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddBrand
    {
        public string BrandName { get; set; }

        public IList<Product> Products { get; } = new List<Product>();
    }
}
