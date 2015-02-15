using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatalayerMonthlyBills;

namespace Monthlybills.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {


        MonthlyBillsEntities db = new MonthlyBillsEntities();
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login()
        {
           
            return View();
        }

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult AddBill()
        {
            var ObjBill = new Bill();
            return View(ObjBill);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddBill(Bill model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            db.Bill.Add(model);
            db.SaveChanges();


            return RedirectToAction("Index");
        }

        public ActionResult Payments()
        {
            return View(db.Bill.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}