using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarSystem.Models
{
    public class Car
    {
        [DisplayName("Car ID")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Car Make is required")]
        [StringLength(30)]
        public string Make { get; set; }

        [Required]
        [StringLength(30)]
        public string Model { get; set; }

        [Required]        
        public int Year { get; set; }

        [Required]
        [StringLength(20)]
        public string Type { get; set; }
        
        [StringLength(255)]
        public string Transmission { get; set; }

        [DisplayName("Rate Per Day")]
        public int RatePerDay { get; set; }
        public string ImageURL { get; set; }

        public void selfUpdate(Car x)
        {
            this.ID = x.ID;
            this.ImageURL = x.ImageURL;
            this.Make = x.Make;
            this.Model = x.Model;
            this.RatePerDay = x.RatePerDay;
            this.Transmission = x.Transmission;
            this.Type = x.Type;
            this.Year = x.Year;
        }
    }

}