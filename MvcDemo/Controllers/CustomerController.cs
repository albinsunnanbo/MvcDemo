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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(CustomerSearchModel inputModel)
        {
            using (var db = new DemoContext())
            {
                IQueryable<Customer> source = db.Customers;
                if (!string.IsNullOrWhiteSpace(inputModel.CustomerName))
                {
                    source = source.Where(c => c.Name.Contains(inputModel.CustomerName));
                }
                var model = from c in source
                            orderby c.Name
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

        public ActionResult Edit(int id)
        {
            using (var db = new DemoContext())
            {
                var dbCustomer = db.Customers.Single(c => c.CustomerId == id);
                return View(new CustomerModel
                {
                    CustomerId = dbCustomer.CustomerId,
                    CustomerName = dbCustomer.Name,
                });
            }
        }

        [HttpPost]
        public ActionResult Edit(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new DemoContext())
                {
                    var dbCustomer = db.Customers.Single(c => c.CustomerId == model.CustomerId);
                    dbCustomer.Name = model.CustomerName;
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }

            // Return the same model with validation errors
            return View(model);
        }
    }
}