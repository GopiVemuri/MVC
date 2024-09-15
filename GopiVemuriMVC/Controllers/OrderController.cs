using GopiVemuriMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GopiVemuriMVC.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Order()
        {
            return View();
        }
        //[HttpPost]
        public ActionResult CreateOrder()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateOrder(OrderMDL orderMDL)
        {
            return View(orderMDL);
        }
    }
}