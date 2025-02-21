using RMS.Models.Entities;

namespace RMS.AddModels.AddEntities
{
    public class AddExpenseTracking
    {
        public int ExpenseCategoryId { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }
        public float TotalAmout { get; set; }
        public MethodofPayment PaymentMethod { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; }
        public int LotId { get; set; }
        public ProductPurchaseRecord ProductPurchaseRecord { get; set; }

    }
    public enum MethodofPayment
    {
        Cash,
        CreditCard,
        DebitCard,
        BankTransfer,
        MobilePayment,
        Check
    }

}

