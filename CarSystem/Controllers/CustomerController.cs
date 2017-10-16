using CarSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarSystem.Controllers
{
    public class CustomerController : Controller
    {
        //identify Connection Type to DB
        private ApplicationDbContext DB;

        //Wrtie 'stor' then click double Tab to get below action automaticly 
        public CustomerController()
        {
            DB = new ApplicationDbContext();
        }        

        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustomerResult()
        {
            var CustomersResult = DB.Customer.ToList();
            return View(CustomersResult);
        }

        public ActionResult ShowCustomerEqual()
        {
            var Customers = DB.Customer.Where(c => c.Name.Equals("isa"));
            return View(Customers);
        }

        public ActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveCustomer(Customer customerValues)
        {
            DB.Customer.Add(customerValues);
            DB.SaveChanges();
            return RedirectToAction("CustomerResult" , "Customer");

        }
    }
    
}