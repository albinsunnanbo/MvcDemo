using MvcDemo.Entities;
using MvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class CustomerController : Controller
    {

        public ActionResult New()
        {
            return View(new CustomerModel());
        }
    }
}