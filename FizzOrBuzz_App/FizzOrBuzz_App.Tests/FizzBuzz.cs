using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzOrBuzz_App.Controllers;
using System.Web.Mvc;
using BusinessLayer;

namespace FizzOrBuzz_App.Tests
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void FizzBuzzShouldReturnIndexView()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void FizzBuzzShouldReturnBuzzWhenFiveIsEntered()
        {
            var controller = new HomeController();
            var result = controller.Index(5) as ViewResult;
            var buzz = (FizzBuzzData) result.ViewData.Model;
            Assert.AreEqual("Buzz", buzz.Result);
        }

        [TestMethod]
        public void FizzBuzzShouldReturnBuzzWhenTenIsEntered()
        {
            var controller = new HomeController();
            var result = controller.Index(10) as ViewResult;
            var buzz = (FizzBuzzData)result.ViewData.Model;
            Assert.AreEqual("Buzz", buzz.Result);
        }

        [TestMethod]
        public void FizzBuzzShouldReturnBuzzWhenFiftenIsEntered()
        {
            var controller = new HomeController();
            var result = controller.Index(15) as ViewResult;
            var buzz = (FizzBuzzData)result.ViewData.Model;
            Assert.AreEqual("Buzz", buzz.Result);
        }

        [TestMethod]
        public void FizzBuzzShouldReturnFizzWhenThreeIsEntered()
        {
            var controller = new HomeController();
            var result = controller.Index(3) as ViewResult;
            var fizz = (FizzBuzzData)result.ViewData.Model;
            Assert.AreEqual("Fizz", fizz.Result);
        }

        [TestMethod]
        public void FizzBuzzShouldReturnFizzWhenSixIsEntered()
        {
            var controller = new HomeController();
            var result = controller.Index(6) as ViewResult;
            var fizz = (FizzBuzzData)result.ViewData.Model;
            Assert.AreEqual("Fizz", fizz.Result);
        }

        [TestMethod]
        public void FizzBuzzShouldReturnFizzWhen9IsEntered()
        {
            var controller = new HomeController();
            var result = controller.Index(9) as ViewResult;
            var fizz = (FizzBuzzData)result.ViewData.Model;
            Assert.AreEqual("Fizz", fizz.Result);
        }

        [TestMethod]
        public void FizzBuzzShouldReturnNothingWhenSevenIsEntered()
        {
            var controller = new HomeController();
            var result = controller.Index(7) as ViewResult;
            var nothing = (FizzBuzzData)result.ViewData.Model;
            Assert.AreEqual(null, nothing.Result);
        }

        [TestMethod]
        public void FizzBuzzShouldReturnNothingWhenEightIsEntered()
        {
            var controller = new HomeController();
            var result = controller.Index(8) as ViewResult;
            var nothing = (FizzBuzzData)result.ViewData.Model;
            Assert.AreEqual(null, nothing.Result);
        }

        [TestMethod]
        public void FizzBuzzShouldReturnNothingWhenNineteenIsEntered()
        {
            var controller = new HomeController();
            var result = controller.Index(19) as ViewResult;
            var nothing = (FizzBuzzData)result.ViewData.Model;
            Assert.AreEqual(null, nothing.Result);
        }
    }
}
