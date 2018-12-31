using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication15.Models;
using WebApplication15.Exceptions;


namespace WebApplication15.Controllers
{
    public class CustomersController : Controller
    {
        private FlightDb db = new FlightDb();
        private List<Seats> availableseatstochoose;
        // GET: Customers
        public ActionResult Index()
        {   
            
                try
                {
                    if (Session["currentId"] == null) throw new Myexception();
                    int id = (int)Session["currentId"];

                    var customer_table = (from a in db.customer_table.Include(c => c.flight)

                                          where a.Id == id
                                          select a);
                    Session["currentId"] = null;
                    return View(customer_table.ToList());
                }
                catch (Myexception ex)
                {
                if (Session["try"] == null) {
                  return RedirectToAction("Confirmation", "Home"); }



                var all = db.customer_table.Include(c => c.flight);
                    return View(all.ToList());

                }
                
            }
        

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.customer_table.Find(id);
            var flight = (from r in db.flights_table
                         where r.Id == customer.flightId
                         select r).SingleOrDefault();
            var customerSeat = (from s in db.tableof_seats
                               where s.idoftheCustomer == customer.Id
                               select s).SingleOrDefault();
            if (customerSeat == null)
            {

                return Content("i AM NULL");
            }
           // ViewBag.seat = customerSeat.seatLetter;
          //  ViewBag.row = customerSeat.row;
            Boarding_pass boardingpass = new Boarding_pass { current_customer = customer, thisflight = flight ,seat_of_the_customer=customerSeat };
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(boardingpass);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            ViewBag.flightId = new SelectList(db.flights_table, "Id", "flightNumber");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,First_Name,Last_name,email,flightId,SeatLetter,rowseat")] Customer customer)
        {
            if (ModelState.IsValid)
            {

                
                db.customer_table.Add(customer);
                db.SaveChanges();
                Session["idofcustomer"] = customer.Id;
                Flight thislight=db.flights_table.Find(customer.flightId);
                Session["flight"] = thislight.Id;
                thislight.flight_capacity=thislight.flight_capacity-1;
                db.Entry(thislight).State = EntityState.Modified;
                db.SaveChanges();
                Session["currentId"] = customer.Id;
                return RedirectToAction("Seatdetails","Customers");
            }

            ViewBag.flightId = new SelectList(db.flights_table, "Id", "flightNumber", customer.flightId);
            return View(customer);
        }
        [HttpGet]
        public ActionResult Seatdetails()
        {
            availableseatstochoose = getSeats(ref db);

            ViewBag.seatletter = new SelectList(availableseatstochoose, "seatLetter", "seatLetter");
            return View();


        }
        public List<Seats> getSeats(ref FlightDb dbobj)
        {
            int fligthid = (int)Session["flight"];
            var somelist =(from a in dbobj.tableof_seats
            where a.seatcapacity > 0 && a.whatflightId== fligthid
                           select a).ToList();

            return somelist;
        }
        [HttpPost]
        public ActionResult Seatdetails([Bind(Include ="")]Seats customerseat)
        {
            availableseatstochoose = getSeats(ref db);
            ViewBag.seatletter = new SelectList(availableseatstochoose, "seatLetter", "seatLetter",customerseat.seatLetter);
            int customerid = (int)Session["idofcustomer"];
            Customer currentcustomer = db.customer_table.Find(customerid);
            currentcustomer.SeatLetter = customerseat.seatLetter;
            currentcustomer.rowseat = customerseat.row;
            Flight someflight = db.flights_table.Find(currentcustomer.flightId);
   //  return Content(currentcustomer.First_Name + " " + currentcustomer.rowseat.ToString() + " " + " " + currentcustomer.SeatLetter);

            var thisseat = from r in db.tableof_seats
                           where r.whatflightId == someflight.Id
                           select r;
            if (thisseat == null)
            { return Content("notheing gos in thisseat"); }
            var available = (from a in thisseat
                             where a.row == currentcustomer.rowseat && a.seatLetter == currentcustomer.SeatLetter
                             select a).SingleOrDefault();
            try
            {if (available == null) throw new NullReferenceException();
                Seats cseat = available;
                if (cseat.seatcapacity == 0)
                {
                    ViewBag.seatfull = "Seat is already booked try another ";

                    return View();
                }
                cseat.seatcapacity = cseat.seatcapacity - 1;
                cseat.idoftheCustomer = currentcustomer.Id;

                db.Entry(cseat).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (NullReferenceException)
            {

                ViewBag.rowError = "The row you select is unavailable try choosing another one ";
                return View();

            }
            
            //update customer with seat details 
            
            db.Entry(currentcustomer).State = EntityState.Modified;
            db.SaveChanges();
          
return RedirectToAction("Create","creditcards");

        }
        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.customer_table.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            ViewBag.flightId = new SelectList(db.flights_table, "Id", "flightNumber", customer.flightId);
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,First_Name,Last_name,email,flightId")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                
                return RedirectToAction("Index");
            }
            ViewBag.flightId = new SelectList(db.flights_table, "Id", "flightNumber", customer.flightId);
            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.customer_table.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.customer_table.Find(id);
            db.customer_table.Remove(customer);
            Flight someflight = db.flights_table.Find(customer.flightId);
            someflight.flight_capacity = someflight.flight_capacity + 1;
            db.Entry(someflight).State = EntityState.Modified;
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
