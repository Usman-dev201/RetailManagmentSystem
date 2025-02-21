using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddCategory
    {
        public string CategoryName { get; set; }

        public IList<Product> Products { get; } = new List<Product>();
    }
}
