using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingCalculator.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int CustCompanyId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public List<Project> Project { get; set; }
        public Customer(int customerId, int custCompanyId, string customerName, string customerAddress, List<Project> project)
        {
            this.CustomerId = customerId;
            this.CustCompanyId = custCompanyId;
            this.CustomerName = customerName;
            this.CustomerAddress = customerAddress;
            this.Project = project;
        }
    }
}
