using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeShopApp.Models;//don't forget to add

namespace CoffeeShopApp.Controllers
{
    public class HomeController : Controller
    {



        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Please fill in the form:";

            return View();
        }

        public ActionResult DisplayName(SignUps NewSignUp)
        {

            ViewBag.Name = NewSignUp.FirstName;
            return View();
        }

       


    }
}