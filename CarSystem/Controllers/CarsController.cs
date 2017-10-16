using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarSystem.Models;
using CarSystem.ViewModels;

namespace CarSystem.Controllers
{
    public class CarsController : Controller
    {
        //Connection Type to DB
        private ApplicationDbContext DB;

        //Wrtie 'stor' then double Tab to get below action automatic
        public CarsController()
        {
            DB = new ApplicationDbContext();
        }

        // GET: Cars          
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Latest()
        {
            var car = new Car() { Make = "Toyota" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Isa"},
                new Customer { Name = "Mahdi"},
                new Customer { Name = "Zahraa Alnasr"}
            };

            var latestViewModel = new LatestCarViewModel()
            {
                Car = car,
                Customers = customers
            };

            return View(latestViewModel);
        }

        public ActionResult DisplayToyota()
        {

            return View();
        }

        public ActionResult DisplayCars()
        {
            var CarsResult = DB.Car.ToList();
            return View(CarsResult);
            
        }

        public ActionResult AddCar()
        {
            return View();
        }

        public ActionResult saveCar(Car CarValues)
        {
            DB.Car.Add(CarValues);
            DB.SaveChanges();
            return RedirectToAction("DisplayCars", "Cars");
        }




    }
}