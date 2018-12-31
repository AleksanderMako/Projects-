using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication15.Models;
 
using WebApplication15.NewFolder1;

namespace WebApplication15.Controllers
{
    public class FlightsController : Controller
    {
        private FlightDb db = new FlightDb();
        
        
        // GET: Flights
        public ActionResult Index()
        {
            flightmodelfortheview flight = new flightmodelfortheview { flightlist = db.flights_table/*Include/*(c=>c.airline)*/.ToList() };
            return View(flight);
           
        }

        [HttpPost]


        public ActionResult Index(DateTime ?departure)
        {
            /*var filter = from a in db.flights_table
                         where a.Departure_date == departure
                         select a;*/
  flightmodelfortheview flight = new flightmodelfortheview { flightlist = Librarydll.executeLinq_forfiltering_flights(ref db, departure) };
            if (flight == null) return Content("I am null ");
            return View(flight);


        }

       
        // GET: Flights/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Flight flight = db.flights_table.Find(id);

            var customerlist = from r in db.customer_table
                               where r.flightId == id
                               select r;
            FlightReport report = new FlightReport { customer_list = customerlist.ToList(), currentflight = flight };
            if (flight == null)
            {
                return HttpNotFound();
            }
            return View(report);
        }

        // GET: Flights/Create
        public ActionResult Create()
        {
            if (Session["try"] == null) return RedirectToAction("Confirmation", "Home");
            //    ViewBag.airline = new SelectList(db.airlines_table, "Id", "AirlineName");
            return View();
        }

        // POST: Flights/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,flightNumber,location,destination,aircrafttype,Departure_date,Arrival_date,flight_capacity,AirlineId")] Flight flight)
        {
            
            if (ModelState.IsValid)
            {
                db.flights_table.Add(flight);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
           // ViewBag.airline = new SelectList(db.airlines_table, "AirlineId", "AirlineName",flight.AirlineId);
            return View(flight);
        }
            
        // GET: Flights/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Flight flight = db.flights_table.Find(id);
            if (flight == null)
            {
                return HttpNotFound();
            }
            return View(flight);
        }

        // POST: Flights/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,flightNumber,location,destination,aircrafttype,Departure_date,Arrival_date,flight_capacity")] Flight flight)
        {
            if (ModelState.IsValid)
            {
                db.Entry(flight).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(flight);
        }

        // GET: Flights/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Flight flight = db.flights_table.Find(id);
            if (flight == null)
            {
                return HttpNotFound();
            }
            return View(flight);
        }

        // POST: Flights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Flight flight = db.flights_table.Find(id);
            db.flights_table.Remove(flight);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
