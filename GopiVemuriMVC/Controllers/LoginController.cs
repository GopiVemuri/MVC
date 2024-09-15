using GopiVemuriMVC.AppDbContext;
using GopiVemuriMVC.BOs;
using GopiVemuriMVC.Common;
using GopiVemuriMVC.Models;
using GopiVemuriMVC.UserDLs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GopiVemuriMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginMDL loginMDL)
        {

            using (GopiDbContext db = new GopiDbContext())
            {
                //var user = db.UserBOs.Get(v=>v.UserName == loginMDL.UserName).FirstOrDefault();

                var obj = db.UserBOs.Where(a => a.UserName.Equals(loginMDL.UserName) && a.UserPassword.Equals(loginMDL.UserPassword)).FirstOrDefault();
                if (obj != null)
                {
                    loginMDL.UserID = obj.UserID;
                    loginMDL.UserName = obj.UserName.ToString();
                    loginMDL.Email = obj.Email;
                    return RedirectToAction("Home","Home",loginMDL);
                }
                else
                {
                    return View(loginMDL);
                }
            }

            //return View();
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            LoginMDL loginMDL = new LoginMDL();
            return View(loginMDL);
        }

        [HttpPost]
        public ActionResult SignUp(LoginMDL loginMDL)
        {
            LoginMDL loginMDL1 = new LoginMDL();
            ResponseBO<UserBO> resp = new ResponseBO<UserBO>();

            resp = (new UsersDL()).RegisterUserInsertUpdate(loginMDL);
            //return View(loginMDL);
            return RedirectToAction("Login", "Login", loginMDL);
        }


        [HttpGet]
        public ActionResult ForgetPassword()
        {
            LoginMDL loginMDL = new LoginMDL();
            return View(loginMDL);
        }

        [HttpPost]
        public ActionResult ForgetPassword(LoginMDL loginMDL)
        {
            LoginMDL loginMDL1 = new LoginMDL();

            using (GopiDbContext db = new GopiDbContext())
            {
                var obj = db.UserBOs.Get(v=>v.UserName == loginMDL.UserName || v.Email == loginMDL.Email).FirstOrDefault();
                if (obj != null)
                {                   
                    loginMDL.UserName = obj.UserName.ToString();
                    loginMDL.UserPassword = obj.UserPassword;
                    return View(loginMDL);
                }
                else
                {
                    return View(loginMDL);
                }
            }

        }


       



    }
}