namespace RMS.Models.Entities
{
    public class RackProductRecord
    {
        public int RackProductId { get; set; }

        public int RackId { get; set; }

        public virtual Rack Rack { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

    }
}
