using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult myFirstPage()
        {
            staff a= new staff();
            a.staffID = 1;
            a.address = "Khulna";
            a.name = "Karim";

            thing b = new thing();
            b.productID = 1;
            b.productPrice = 100;
            b.productName = "Pencil";
            b.category = "Stationary Item";

            ViewBag.a=a; 
            ViewBag.b=b;   

            return View();
        }
    }
}
