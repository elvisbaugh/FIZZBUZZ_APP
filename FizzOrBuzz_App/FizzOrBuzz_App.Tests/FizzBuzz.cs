using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzOrBuzz_App.Controllers;
using System.Web.Mvc;

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
    }
}
