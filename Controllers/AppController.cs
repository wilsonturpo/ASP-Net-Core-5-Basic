using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers{
    public class AppController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}