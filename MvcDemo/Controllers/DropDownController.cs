using MvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class DropDownController : Controller
    {
        public ActionResult Index()
        {
            return View(new DropDownModel
            {
                County = Länskoder.Stockholms_län
            });
        }

        public ActionResult KommunerILän(DropDownModel model)
        {
            return View(model);
        }
    }
}