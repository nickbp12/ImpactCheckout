using DataBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Levering()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Levering(Models.HomeViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return RedirectToAction("Success");
        }
        public ActionResult faabynavn(string postnr)
        {
            DataBases.DataBaseClasses.tbl_Post Bynavn = new DataBases.DataBaseClasses.tbl_Post();

            Bynavn = db.Post.Where(b => b.Postnr == postnr).FirstOrDefault();

            if (Bynavn != null)
            {
                return Json(new { bynavn = Bynavn.Bynavn, success = true }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult Nope()
        {
            return View();
        }

        public ActionResult GLS()
        {
            return View();
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}