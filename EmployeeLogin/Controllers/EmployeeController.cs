using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using EmployeeLogin.Models;
namespace WebSite.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Pavan
        public ActionResult Index()
        {
            return View("Login");
        }
        public ActionResult Login(Model v)
        {
            if (v.UserName == "seshu" && v.Password == "123")
            {
                ViewBag.s = "Hi";
                ViewData["result"] = "Welcome";
                Model employee = new Model()
                {
                    EmployeeId = 101,
                    EmployeeName = "Ravi seshu",
                    EmployeeAddress = "kakinada",
                    EmployeePhoneNo = 8341358889,
                    IsPermenent = false,
                };
                return View("Info", employee);
            }
            else
            {
                ViewBag.x = "Invalid Username or Password";
                return View("Login");
            }
        }

    }
}