using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserApplication.Models;

namespace UserApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult REG()
        {
            return View();
        }

        [HttpPost]
        public ActionResult REG(User user)
        {
            if (ModelState.IsValid)
            {
                return View("Thank", user);
            }
            else
            {
                return View();
            }

        }

    }
}