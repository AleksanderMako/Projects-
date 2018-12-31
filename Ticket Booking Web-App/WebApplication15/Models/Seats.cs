using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication15.Models
{
    public class Seats
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int row { get; set; }
        [Required]
        public string seatLetter { get; set; }
        Flight whatflight { get; set; }
        public int whatflightId{ get; set; }
       public int seatcapacity { get; set; }
        public  int? idoftheCustomer { get; set; }


    }
}