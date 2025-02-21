using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddExpenseCategory
    {
        public int ExpenseCatergoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public IList<ExpenseTracking> ExpenseTrackings { get; } = new List<ExpenseTracking>();
    }
}
