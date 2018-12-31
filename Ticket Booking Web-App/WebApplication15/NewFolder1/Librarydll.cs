using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication15.Models;
namespace WebApplication15.NewFolder1
{
    public class Librarydll
    {

        public static List<Flight> executeLinq_forfiltering_flights( ref FlightDb  dbobj ,DateTime ?filterdate)
        {

           var mylist= from a in dbobj.flights_table
            where a.Departure_date == filterdate
                       select a;
            return mylist.ToList();


        }
    }
}