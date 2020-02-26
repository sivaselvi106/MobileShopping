using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileShopping.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp()
        {
            return View();
        }
    }
}