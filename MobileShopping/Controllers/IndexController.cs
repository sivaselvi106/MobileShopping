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
        [ActionName("Create")]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Create")]
        //public ActionResult Create(Mobile mobile)
        //{
        //    mobileRepository.AddMobile(mobile);
        //    TempData["Message"] = "Mobile added successfully!!!";
        //    return RedirectToAction("Index");
        //}
        //public ActionResult Create_Post()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Mobile mobile = new Mobile();
        //        UpdateModel(mobile);
        //        mobileRepository.AddMobile(mobile);
        //        TempData["Message"] = "Mobile added successfully!!!";
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        public ActionResult Create_Post()
        {
            Mobile mobile = new Mobile();
            TryUpdateModel(mobile);
            if (ModelState.IsValid)
            {
                mobileRepository.AddMobile(mobile);
                TempData["Message"] = "Mobile added successfully!!!";
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            mobileRepository.DeleteMobile(id);
            TempData["Message"] = "Mobile deleted successfully";
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Mobile mobile = mobileRepository.GetMobileId(id);
            return View(mobile);
        }
        [HttpPost]
        public  ActionResult Update(Mobile mobile)
        { 
                mobileRepository.UpdateMobile(mobile);
                TempData["Message"] = "Updated successfully";
                return RedirectToAction("Index");
        }
    }
}