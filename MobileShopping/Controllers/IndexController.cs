using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileShopping.entity;
using MobileShopping.Repository;
namespace MobileShopping.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
       
        MobileRepository mobileRepository;
        public IndexController()
        {
            mobileRepository = new MobileRepository();
        }
        public ActionResult Index()
        {
            IEnumerable<Mobile> mobile = mobileRepository.GetMobileDetails();
            return View(mobile);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Mobile mobile)
        {

            mobileRepository.AddMobile(mobile);
            TempData["Message"] = "Mobile added successfully!!!";
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            mobileRepository.DeleteMobile(id);
            TempData["Message"] = "Mobile deleted successfully";
            return RedirectToAction("Index");
        }
    }
}