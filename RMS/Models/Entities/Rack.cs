namespace RMS.Models.Entities
{
    public class Rack
    {
        public int RackId { get; set; }

        public string RackName { get; set; }
        public int RackCapacity { get; set; }

        public int LocationId { get; set; }

        public virtual Location Location { get; set; }

        public virtual ICollection<RackProductRecord> RacksProductRecords { get; set; } = new List<RackProductRecord>();
    }
}
