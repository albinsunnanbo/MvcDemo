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

        [HttpPost]
        public ActionResult New(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new DemoContext())
                {
                    db.Customers.Add(new Customer
                    {
                        Name = model.CustomerName,
                    });
                    db.SaveChanges();
                }

                return RedirectToAction("New");
            }

            // Return the same model with validation errors
            return View(model);
        }
    }
}