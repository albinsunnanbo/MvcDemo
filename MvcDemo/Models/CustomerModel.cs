using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDemo.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }

        [Display(Name = "Kundnamn")]
        [Required]
        public string CustomerName { get; set; }
    }
}