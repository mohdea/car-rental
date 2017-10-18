using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarSystem.Models;

namespace CarSystem.Controllers.API
{
    public class CustomersAPIController : ApiController
    {
        private ApplicationDbContext DB;

        public CustomersAPIController()
        {
            DB = new ApplicationDbContext();
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            var Customers = DB.Customer.ToList();
            return(Customers);
        }

        public Customer GetSpecificCustomers(int id)
        {
            var CustomerName = DB.Customer.SingleOrDefault(c => c.Id.Equals(id));
            return CustomerName;
        }

        //Create New Customer - API
        [HttpPost]        
        public Customer CreateCustomers(Customer CustomerValues)
        {
            DB.Customer.Add(CustomerValues);
            DB.SaveChanges();
            return CustomerValues;
        }

        //Update Customer info - API
        [HttpPut]
        public Customer UpdateCustomer(Customer CustomerValues)
        {
            var cust = DB.Customer.SingleOrDefault(a => a.Id.Equals(CustomerValues.Id));

            cust = CustomerValues;

            ///cust.Name = CustomerValues.Name;
            //cust.CPR = 

            DB.SaveChanges();
            return cust;
        }

        //Delete Customer info - API
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var cust = DB.Customer.SingleOrDefault(a => a.Id.Equals(id));
            DB.Customer.Remove(cust);
            DB.SaveChanges();
            //var Customer = DB.Customer.ToList();
            //return(Customer);
        }
    }
}
