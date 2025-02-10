namespace RMS.Models.Entities
{
    public class ExpenseCategory
    {
        public int ExpenseCatergoryId { get; set; }
        public string CategoryName { get; set; }
         public string Description { get; set; }
        public virtual ICollection<ExpenseTracking> ExpenseTrackings { get; set; } = new List<ExpenseTracking>();

    }
}
