namespace RMS.Models.Entities
{
    public class MarketingCampaign
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string TargetAudience { get; set; }
        public CampaignStatus Status { get; set; }
        public ActionTaken ActionTaken { get; set; }

        //public virtual ICollection<CampaignTargetRecord> CampaignTargetRecords { get; set; } = new List<CampaignTargetRecord>();
        public virtual ICollection<SalesTransactionDetail> SalesTransactionDetails { get; set; } = new List<SalesTransactionDetail>();
    }
}

public enum CampaignStatus
{
    Draft,
    Scheduled,
    Active,
    Paused,
    Completed,
    Cancelled,
    Failed
}
public enum ActionTaken
{
    None,
    EmailsSent,
    LeadsGenerated,
    AdPublished,
    CampaignExtended,
    CampaignStopped,
    BudgetIncreased,
    OfferApplied
}