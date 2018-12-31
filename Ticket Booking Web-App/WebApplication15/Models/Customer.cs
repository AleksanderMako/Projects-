using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication15.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        public string First_Name { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Last_name { get; set; }
        [Required(ErrorMessage = "Email  is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }

        
        public Flight flight { get; set; }
        [Required(ErrorMessage = "flight is required")]
        public int flightId { get; set; }
       // [Required(ErrorMessage = "Seat is required")]
        public string SeatLetter { get; set; }
        //[Required(ErrorMessage = "rowseat is required")]
        public int? rowseat { get; set; }


    }
}