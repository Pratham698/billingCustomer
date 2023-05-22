using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingCalculator.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public int ProjCustomerId { get; set; }
        public BillingModes BillingModes { get; set; }
        public decimal InvoiceAmount { get; set; }
        public Project(int projectId, int projCustomerId, BillingModes billingModes, decimal invoiceAmount)
        {
            this.ProjectId = projectId;
            this.ProjCustomerId = projCustomerId;
            this.BillingModes = billingModes;
            this.InvoiceAmount = invoiceAmount;
        }
    }
}
