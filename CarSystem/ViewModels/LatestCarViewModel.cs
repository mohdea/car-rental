using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarSystem.Models;

namespace CarSystem.ViewModels
{
    public class LatestCarViewModel
    {
        public Car Car { get; set; }
        public List<Customer> Customers { get; set; }

    }
}