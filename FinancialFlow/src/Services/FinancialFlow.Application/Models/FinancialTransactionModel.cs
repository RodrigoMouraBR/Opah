using FinancialFlow.Core.DomainObjects.Enums;
using System.ComponentModel.DataAnnotations;

namespace FinancialFlow.Application.Models
{
    public class FinancialTransactionModel
    {        
        public Guid CustomerId { get; set; }
        public DateTime DateRef { get; private set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public ETransactionType TransactionType { get; set; }
    }
}
