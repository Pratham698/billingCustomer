using BillingCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BillingCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creating One company
            Company comp = new Company(1, "ABC", "INTY78", "Bill Tower, Hungary", new List<Customer>());

            //Creating Customers and adding to created company
            Customer cus1 = new Customer(11, 1, "customer1", "customer1, address", new List<Project>());
            Customer cus2 = new Customer(12, 1, "customer2", "customer2, address", new List<Project>());
            Customer cus3 = new Customer(13, 1, "customer3", "customer3, address", new List<Project>());
            Customer cus4 = new Customer(14, 1, "customer4", "customer4, address", new List<Project>());
            Customer cus5 = new Customer(15, 1, "customer5", "customer5, address", new List<Project>());
            comp.Customer.Add(cus1);
            comp.Customer.Add(cus2);
            comp.Customer.Add(cus3);
            comp.Customer.Add(cus4);
            comp.Customer.Add(cus5);

            //Craeting projects and adding to created customers above

            //For customer 1
            Project proj1 = new Project(101, 11, BillingModes.TimeAndMaterial, 100);
            Project proj2 = new Project(102, 11, BillingModes.MilestoneBased, 150);
            Project proj3 = new Project(103, 11, BillingModes.TimeAndMaterial, 200);
            cus1.Project.Add(proj1);
            cus1.Project.Add(proj2);
            cus1.Project.Add(proj3);

            //For customer 2
            Project proj11 = new Project(104, 12, BillingModes.TimeAndMaterial, 300);
            Project proj21 = new Project(105, 12, BillingModes.MilestoneBased,200);
            Project proj31 = new Project(106, 12, BillingModes.TimeAndMaterial, 100);
            cus2.Project.Add(proj11);
            cus2.Project.Add(proj21);
            cus2.Project.Add(proj31);


            //Sheet Generated
            PaymentSheet paymentSheet = new PaymentSheet(System.DateTime.UtcNow, AmountType.Credit, 500);
            decimal amountToBeMatched = paymentSheet.Amount;

            //Checking for first client
            decimal[] invoiceAmountsForClient1 = cus1.Project.Select(s => s.InvoiceAmount).ToArray();
            Array.Sort(invoiceAmountsForClient1);

            int start1 = 0;
            int end1 = invoiceAmountsForClient1.Length - 1;

            while(start1 <= end1)
            {
                decimal total = invoiceAmountsForClient1[start1] + invoiceAmountsForClient1[end1];
                if(total == amountToBeMatched) {
                    Console.WriteLine("Amount Found for client1");
                    break;
                }
                else if(total > amountToBeMatched)
                {
                    end1--;
                }
                else
                {
                    start1++;
                }
            }

            //Checking for second client
            decimal[] invoiceAmountsForClient2 = cus2.Project.Select(s => s.InvoiceAmount).ToArray();
            Array.Sort(invoiceAmountsForClient2);

            int start2 = 0;
            int end2 = invoiceAmountsForClient2.Length - 1;

            while (start2 <= end2)
            {
                decimal total = invoiceAmountsForClient2[start2] + invoiceAmountsForClient2[end2];
                if (total == amountToBeMatched)
                {
                    Console.WriteLine("Amount Found for client2");
                    break;
                }
                else if (total > amountToBeMatched)
                {
                    end2--;
                }
                else
                {
                    start2++;
                }
            }
        }
    }
}
