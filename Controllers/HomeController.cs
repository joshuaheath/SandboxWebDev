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

        public ActionResult pokemon()
        {
            return View();
        }

        public ActionResult Create() //Needs a view
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

        //Challnge 3
        public ActionResult trailModel()
        {
            Models.Trail trailOne = new Trail();
            trailOne.Id = 1;
            trailOne.Title = "Joe";
            trailOne.Length = 0;
            trailOne.Location = "TimbuckTwo";
            trailOne.Description = "TESTING";
            trailOne.ElevationGain = 100;
            trailOne.CreatedDate = DateTime.Now;

            Models.Trail trailTwo = new Trail();
            trailTwo.Id = 2;
            trailTwo.Title = "Micheal";
            trailTwo.Length = 806;
            trailTwo.Location = "California";
            trailTwo.Description = "Another description that i have no clue what to type";
            trailTwo.ElevationGain = 4546;
            trailTwo.CreatedDate = DateTime.Now;

            Models.Trail trailThree = new Trail();
            trailThree.Id = 3;
            trailThree.Title = "Ben";
            trailThree.Length = 500;
            trailThree.Location = "Calgary";
            trailThree.Description = "I dont know what to type here but it is a description";
            trailThree.ElevationGain = 405;
            trailThree.CreatedDate = DateTime.Now;

            List<Trail> trailList = new List<Trail>{ trailOne, trailTwo, trailThree };
            

            return View(trailList);
        }
    }
}
