using Microsoft.AspNetCore.Mvc;

namespace HelloWeb.Controllers
{
    public class NumberController : Controller
    {
        public IActionResult Multiplication()
        {
            return View();
        }

        public IActionResult MultiplicationFrom(int value) 
        {
            return View(value);
        }
    }


}