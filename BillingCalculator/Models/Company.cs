using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingCalculator.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyISOCode { get; set; }
        public string CompanyAddress { get; set; }
        public List<Customer> Customer { get; set; }
        public Company(int companyId, string companyName, string companyISOCode, string companyAddress, List<Customer> customer)
        {
            this.CompanyId = companyId;
            this.CompanyName = companyName;
            this.CompanyISOCode = companyISOCode;
            this.CompanyAddress = CompanyAddress;
            this.Customer = customer;
        }
        
    }
}
