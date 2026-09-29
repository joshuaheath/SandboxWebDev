using Microsoft.AspNetCore.Mvc;
using SandboxWebDev.Models;
using System.Diagnostics;

namespace SandboxWebDev.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Current Changes for practice
        public ContentResult testOne()
        {
            return Content("Hello, This is a plain text from the ContentResult Action Method");
        }

        public ActionResult testTwo()
        {
            return View();
        }

        public ViewResult test3(string message = "Test 3") //Needs a view
        {
            return View();
        }

        public JsonResult json()
        {
            var data = new
            {
                orderId = "ORD-2025-1001",
                customer = new
                {
                    id = 501,
                    name = "Michael Chen",
                    email = "michael.chen@example.com"
                },
                items = new[]
                {
                    new { productId = "PROD-001", name = "Wireless Mouse", quantity = 2, price = 29.99 },
                    new { productId = "PROD-002", name = "USB-C Cable", quantity = 1, price = 9.99 }
                },
                shippingAddress = new
                {
                    street = "456 Oak Avenue",
                    city = "Portland",
                    state = "OR",
                    zipCode = "97201"
                },
                paymentStatus = "paid",
                totalAmount = 69.97
            };
            return Json(data);
        }
    }
}
