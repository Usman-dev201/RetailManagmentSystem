namespace RMS.Models.Entities
{
    public class RackProductRecord
    {
        public int RackProductId { get; set; }

        public int RackId { get; set; }

        public Rack Rack { get; set; }

        public int ProductId { get; set; }

        public  Product Product { get; set; }

    }
}
