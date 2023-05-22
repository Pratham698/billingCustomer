using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingCalculator.Models
{
    public class PaymentSheet
    {
        public DateTime Date { get; set; }
        public AmountType AmountType { get; set; }

        public decimal Amount { get; set; }
        public PaymentSheet(DateTime date, AmountType amountType, decimal amount) { 
            this.Date = date;
            this.Amount = amount;
            this.AmountType = amountType;
        }
    }
}
