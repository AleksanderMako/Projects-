using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ClassLibrary2
{
    public class credit_card
    {
        [Required(ErrorMessage = "Credit card number required ")]
        [RegularExpression(@"^(\d{16})$", ErrorMessage = "Please enter valid credit card number")]
        public string creditcard_number { get; set; }
        [Required(ErrorMessage = "cvc is required ")]
        [RegularExpression(@"^(\d{3})$", ErrorMessage = "Invalid cvc,3 digits only ")]
        public string cvc { get; set; }
        [Required(ErrorMessage = "Card Holder name is required is required ")]
        public string Card_Holder { get; set; }
    }
}
