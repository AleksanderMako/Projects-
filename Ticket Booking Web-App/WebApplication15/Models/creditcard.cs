using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using ClassLibrary1;
using ClassLibrary2;
using System.ComponentModel.DataAnnotations;
namespace WebApplication15.Models
{
    public class creditcard:ClassLibrary2.credit_card
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email_address { get; set; }
       
    }
}