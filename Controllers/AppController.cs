using System;
using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers{
    public class AppController : Controller{
        public IActionResult Index(){
            //throw new InvalidOperationException();
            return View();
        }

        public IActionResult Edit(){
            return View();
        }
    }
}