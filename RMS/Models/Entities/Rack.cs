namespace RMS.Models.Entities
{
    public class Rack
    {
        public int RackId { get; set; }

        public string RackName { get; set; }
        public int RackCapacity { get; set; }

        public int LocationId { get; set; }

        public Location Location { get; set; }

        public IList<RackProductRecord> RacksProductRecords { get;  } = new List<RackProductRecord>();
    }
}
