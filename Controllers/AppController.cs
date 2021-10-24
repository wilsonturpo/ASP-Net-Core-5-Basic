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

        [HttpPost]
        public IActionResult Edit(object model){
            return View();
        }

        [HttpGet("About")]
        public IActionResult About(){
            throw new InvalidOperationException();
            return View();
        }
    }
}