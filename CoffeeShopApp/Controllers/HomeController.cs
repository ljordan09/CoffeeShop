using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
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
        public ActionResult SaveUser(User NewUserRecord)
        {
            //1.validate data

            if (ModelState.IsValid)
            {
                //2.add the new record to the ORM, save changes to DB
                CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();
                ORM.Users.Add(NewUserRecord);
                ORM.SaveChanges();

                //3. showing the list of all the customers

                return RedirectToAction("DisplayName");

            }
            else
            {
                //If validation fails
                //go back to the form and show the list of errors
                return View("NewCustomerForm");
            }
        }

        public ActionResult DisplayName(SignUps NewSignUp)
        {

            ViewBag.Name = NewSignUp.FirstName;
            return View();
        }


       


    }
}