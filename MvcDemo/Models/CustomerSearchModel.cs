using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDemo.Models
{
    public class CustomerSearchModel
    {
        [Display(Name = "Kundnamn")]
        public string CustomerName { get; set; }
    }
}