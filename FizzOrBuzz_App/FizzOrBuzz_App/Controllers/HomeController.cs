using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using BusinessLayer.FizzBuzzLogic;
using BusinessLayer.Models;

namespace FizzOrBuzz_App.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult Index(int valueEntered)
        {
            if (ModelState.IsValid)
            {
                FizzOrBuzz getData = new FizzOrBuzz(new Buzz());

                bool isBuzz = getData.ReturnFizzOrBuzz(valueEntered);

                //strategy changed
                getData.getFizzOrBuzz = new Fizz();

                bool isFizz = getData.ReturnFizzOrBuzz(valueEntered);

                FizzBuzzResultData getString = new FizzBuzzResultData();

                if (isBuzz)
                {
                    getString.Result = "Buzz";
                }
                else if (isFizz)
                {
                    getString.Result = "Fizz";
                }
                return View("DisplayResult", getString);
            }
            else
            {
                return View();
            }
        }

        public  ActionResult DisplayResult()
        {
            FizzBuzzResultData getString = new FizzBuzzResultData();

            return View(getString.Result);
        }
    }
}