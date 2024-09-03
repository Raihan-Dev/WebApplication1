using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //int a = 5;
            //ViewBag.a = a;

            //List<int> a = new List<int>();
            //a.Add(5);
            //a.Add(6);
            //a.Add(7);

            //int a;
            //staff a = new staff();// a is an Object

            //List<int> a = new List<int>();
            List<staff> myData= new List<staff>();

            staff a = new staff();// a is an Object
            a.name = "Karim";
            a.address = "Khulna";
            a.staffID = 1;
            myData.Add(a);

            staff b = new staff();// a is an Object
            b.name = "Rahim";
            b.address = "Dhaka";
            b.staffID = 2;
            myData.Add(b);

            ViewBag.myData = myData;

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
    }
}
