using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarSystem.Models;

namespace CarSystem.Controllers.api
{
    public class CarsController : ApiController
    {
        private ApplicationDbContext db;
        public CarsController()
        {
            db = new ApplicationDbContext();
        }

        public IEnumerable<Car> GetCars()
        {
            return db.Car.ToList();
        }

        public Car GetCar(int id)
        {
            IEnumerable<Car> Car = from a in db.Car where a.ID == id select a;
            //var Car = db.Car.SingleOrDefault(a => a.Id == id);
            return Car.First();
        }

        [HttpPost]
        public IHttpActionResult CreateCar(Car request)
        {
            if (ModelState.IsValid)
            {
                db.Car.Add(request);
                db.SaveChanges();

                return Ok(request);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if (db.Car.Count(a => a.ID == id) > 0)
            {
                var Car = db.Car.SingleOrDefault(a => a.ID == id);
                db.Car.Remove(Car);
                db.SaveChanges();
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut]
        public IHttpActionResult Update(Car request)
        {
            if (ModelState.IsValid)
            {
                var cust = db.Car.SingleOrDefault(a => a.ID == request.ID);
                cust.selfUpdate(request);
                //db.Entry(cust).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return Ok(cust);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
