using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleAppForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            List<string> result = new List<string> { "Pedro" };
            result.Add("Carlos");
            result.Add("Ramon");

            string concat = string.Join(",", result);
            Console.WriteLine(concat);

            string concat2 = "Pedro, Carlos, Ramon";

            List<string> result2 = concat2.Split(',').ToList<string>();
            Console.WriteLine(result2);

            //****************************
            List<Customer.customermodel> customermodels = Customer.GetModel();

            foreach (Customer.customermodel item in customermodels.Where(x=>x.name=="Rey").Select(x=>x))
            {
                item.name = "jose";
            }

            customermodels.Where(c => c.name =="Javier").Select(c => { c.name = "Pedro"; c.lastname="Garcia"; return c; }).ToList();
            Customer.customermodel Addcustomermodel = new Customer.customermodel { CustId = 4, name = "Papo", lastname = "DelPueblo" };
            customermodels.Add(Addcustomermodel);

        }

        
    }

    public static class Customer
    {
        public static List<customermodel> GetModel()
        {
            List<customermodel> customers = new List<customermodel>
            {
                new customermodel { CustId = 1, name = "Javier", lastname = "Perez" },
                new customermodel { CustId = 2, name = "Carlos", lastname = "Ramirez" },
                new customermodel { CustId = 3, name = "Rey", lastname = "Ortiz" }

            };
            

            return customers;
        }

        public class customermodel
        {
            public int CustId { get; set; }
            public string name { get; set; }
            public string lastname { get; set; }
        }
    }
}
