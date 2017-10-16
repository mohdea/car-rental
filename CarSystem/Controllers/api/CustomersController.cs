using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarSystem.Models;

namespace CarSystem.Controllers.api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext db;
        public CustomersController()
        {
            db = new ApplicationDbContext();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return db.Customer.ToList();
        }

        public Customer GetCustomer(int id)
        {
            IEnumerable<Customer> customer = from a in db.Customer where a.Id == id select a;
            //var customer = db.Customer.SingleOrDefault(a => a.Id == id);
            return customer.First();
        }

        [HttpPost]
        public IHttpActionResult CreateCustomer(Customer request)
        {
            if (ModelState.IsValid)
            {
                db.Customer.Add(request);
                db.SaveChanges();

                return Ok(request);
            } else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if (db.Customer.Count(a => a.Id == id) > 0)
            {
                var customer = db.Customer.SingleOrDefault(a => a.Id == id);
                db.Customer.Remove(customer);
                db.SaveChanges();
                return Ok();
            } else
            {
                return NotFound();
            }
        }

        [HttpPut]
        public IHttpActionResult Update(Customer request)
        {
            if (ModelState.IsValid)
            {
                var cust = db.Customer.SingleOrDefault(a => a.Id == request.Id);
                cust.selfUpdate(request);
                //db.Entry(cust).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return Ok(cust);
            } else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
