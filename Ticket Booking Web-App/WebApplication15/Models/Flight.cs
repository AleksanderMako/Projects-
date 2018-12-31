using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication15.Models
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Flight number is required ")]
        public string flightNumber { get; set; }

        [Required(ErrorMessage = "Location is required ")]
        public string location { get; set; }

        [Required(ErrorMessage = "Destination is required")]
        public string destination { get; set; }

        [Required (ErrorMessage ="Aircraft type is required ")]
        public string aircrafttype { get; set; }

        [Required(ErrorMessage = "Departure is required ")]
        public DateTime Departure_date { get; set; }

        [Required(ErrorMessage = "Arrival  is required ")]
        public DateTime Arrival_date { get; set; }

        [Required(ErrorMessage ="Flight capacity is neccessary ")]
        public int flight_capacity { get; set; }

       // public airlines Airline { get; set; }
       // [Required(ErrorMessage = "Flight capacity is neccessary ")]
       // public int? AirlineId{ get; set; }
    }
}