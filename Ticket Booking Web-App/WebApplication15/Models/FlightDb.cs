using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication15.Models
{
    public class FlightDb : DbContext
    {
        public DbSet<Flight> flights_table { get; set; }
        public DbSet<Customer> customer_table { get; set; }
       public DbSet<creditcard> card_table { get; set; }
        public DbSet<Seats> tableof_seats { get; set; }      //  public DbSet<airlines> airlines_table { get; set; }
    }
}