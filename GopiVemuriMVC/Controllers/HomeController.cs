using GopiVemuriMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GopiVemuriMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Home()
        //{
        //    return View();
        //}
       // [HttpPost]
        public ActionResult Home(LoginMDL loginMDL)
        {
            loginMDL.UserName =loginMDL.UserName;

            return View(loginMDL);
        }
    }
}