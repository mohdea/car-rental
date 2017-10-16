using CarSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarSystem.Controllers
{
    public class CarRentalController : Controller

    { //identify Connection Type to DB
        private ApplicationDbContext DB;

        //Wrtie 'stor' then click double Tab to get below action automaticly 
        public CarRentalController()
        {
            DB = new ApplicationDbContext();
        }

        // GET: CarRental
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DisplayCarRental()
        {
            var CarsRental = DB.CarRental.ToList();
            return View(CarsRental);
        }


        public ActionResult AddNewCarRental()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveCarRental(CarRental CarRentalValues)
        {
            DB.CarRental.Add(CarRentalValues);
            DB.SaveChanges();
            return RedirectToAction("DisplayCarRental", "CarRental");
        }

    }
}