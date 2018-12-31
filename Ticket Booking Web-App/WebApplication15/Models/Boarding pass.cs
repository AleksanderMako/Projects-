using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication15.Models
{
    public class Boarding_pass
    {

       public  Flight thisflight { get; set; }
      public   Customer current_customer { get; set; }
        public Seats seat_of_the_customer { get; set; }

    }
}