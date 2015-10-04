﻿using MvcDemo.Entities;
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
        public ActionResult Index()
        {
            using (var db = new DemoContext())
            {
                var model = from c in db.Customers
                            select new CustomerModel
                            {
                                CustomerId = c.CustomerId,
                                CustomerName = c.Name,
                            };

                return View(model.ToList());
            }

        }

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

                return RedirectToAction("Index");
            }

            // Return the same model with validation errors
            return View(model);
        }
    }
}