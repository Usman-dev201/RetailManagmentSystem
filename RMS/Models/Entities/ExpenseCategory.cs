namespace RMS.Models.Entities
{
    public class ExpenseCategory
    {
        public int ExpenseCatergoryId { get; set; }
        public string CategoryName { get; set; }
         public string Description { get; set; }
        public  IList<ExpenseTracking> ExpenseTrackings { get; } = new List<ExpenseTracking>();

    }
}
