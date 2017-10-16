using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarSystem.Models
{
    public class Customer
    {
        [DisplayName("Customer ID")]
        public int Id { get; set; }

        [Required]
        [DisplayName("Customer Name")]
        public string Name { get; set; }

        [Required]
        public int CPR { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}