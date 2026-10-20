using Microsoft.AspNetCore.Mvc;

namespace bai2.Controllers
{
    public class HomeController1 : Controller
    {
        public String Greeting()
        {
            return "Chao mung cac ban den voi mon hoc ASP.NET";
        }
        public String Welcome(int id, string name)
        {
            return $"Xin chao {id} - {name}, chuc ban hoc tot";
        }
        public IActionResult Welcome1(int id1, string name)
        {
            return View();
        }
    }
 
    }   
