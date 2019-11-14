using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class PassDataController : Controller
    {
        // GET: PassData
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PassViewData()
        {
            ViewData["Name"] = "Harry";
            ViewData["Age"] = 29;
            ViewData["Single"] = true;

            return View();
        }
        public ActionResult PassViewBag()
        {

            ViewBag.Nickname = "Mary";
            ViewBag.Height = 168;
            ViewBag.Weidth = 52;
            ViewBag.Married = false;

            return View();
        }
        public ActionResult PetShop()
        {
            ViewData["Company"] = "寵物店";
            ViewBag.Address = "台北市";
            List<string> pets = new List<string>
            {
                "狗","貓","魚","鼠","變色龍","鳥"
            };
            ViewData.Model = pets;
            return View();
        }
        public ActionResult PassTempData()
        {
            TempData["ErrorMessage"] = "無足夠權限";
            TempData["UserName"] = "Harry";
            TempData["Time"] = DateTime.Now.ToLongTimeString();

            return RedirectToAction("ErrorMessage", "ErrorHandler");
        }
    }
}