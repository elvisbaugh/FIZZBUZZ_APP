using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using BusinessLayer.FizzBuzzLogic;

namespace FizzOrBuzz_App.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult Index(int value)
        {
            FizzOrBuzz getData = new FizzOrBuzz(new Buzz());
           bool isBuzz =   getData.ReturnFizzOrBuzz(value);
            return View();
        }
    }
}