using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication15.Models
{
    public class FlightReport
    {

      public   List<Customer> customer_list { get; set; }
       public  Flight currentflight { get; set; }
    }
}