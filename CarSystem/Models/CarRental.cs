using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarSystem.Models
{
    public class CarRental
    {

        public int ID { get; set; }
        [Required]
        [Display(Name = "Car ID")]
        public int CarID { get; set; }

        [Required]
        [Display(Name = "Customer ID")]
        public int CustomerID { get; set; }

        [Required]
        [Display(Name = "Employee ID")]
        public int EmployeeID { get; set; }

        [Required]
        [Display(Name = "Rental Date")]
        public DateTime RentalDate { get; set; }

        [Required]
        [Display(Name = "Return Date")]
        public DateTime ReturnDate { get; set; }

        [Required]
        [Display(Name = "Paid Amount")]
        public int paidAmount { get; set; }

        [Required]
        [Display(Name = "Actual Returned Date")]
        public DateTime ActualReturnDate { get; set; }
    }
}