using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    public class SeatsController : Controller
    {
        private FlightDb db = new FlightDb();

        // GET: Seats
        public ActionResult Index()
        {
            return View(db.tableof_seats.ToList());
        }

        // GET: Seats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seats seats = db.tableof_seats.Find(id);
            if (seats == null)
            {
                return HttpNotFound();
            }
            return View(seats);
        }

        // GET: Seats/Create
        public ActionResult Create()
        {
            if (Session["try"] == null) return RedirectToAction("Confirmation", "Home");
            ViewBag.whatflightId = new SelectList(db.flights_table, "Id", "flightNumber");
            return View();
        }

        // POST: Seats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,row,seatLetter,whatflightId,idoftheCustomer,seatcapacity")] Seats seats)
        {
            if (Session["try"] == null) return RedirectToAction("Confirmation", "Home");
            if (ModelState.IsValid)
            {
                db.tableof_seats.Add(seats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.whatflightId = new SelectList(db.flights_table, "Id", "flightNumber",seats.whatflightId);
            return View(seats);
        }

        // GET: Seats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seats seats = db.tableof_seats.Find(id);
            if (seats == null)
            {
                return HttpNotFound();
            }
            ViewBag.whatflightId = new SelectList(db.flights_table, "Id", "flightNumber", seats.whatflightId);
            return View(seats);
        }

        // POST: Seats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,row,seatLetter,whatflightId,idoftheCustomer,seatcapacity")] Seats seats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(seats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.whatflightId = new SelectList(db.flights_table, "Id", "flightNumber", seats.whatflightId);
            return View(seats);
        }

        // GET: Seats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seats seats = db.tableof_seats.Find(id);
            if (seats == null)
            {
                return HttpNotFound();
            }
            return View(seats);
        }

        // POST: Seats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Seats seats = db.tableof_seats.Find(id);
            db.tableof_seats.Remove(seats);
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
