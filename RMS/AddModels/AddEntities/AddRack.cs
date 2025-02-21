using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class Addrack
    {
        public string RackName { get; set; }
        public int RackCapacity { get; set; }

        public int LocationId { get; set; }

        public Location Location { get; set; }
        public IList<Product> Products { get; } = new List<Product>();

    }
}
