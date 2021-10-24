using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MovieApp.ViewModel;

namespace MovieApp.Controllers{
    public class AppController : Controller{

        private static List<MovieViewModel> _movies = new List<MovieViewModel>();
        public IActionResult Index(){
            //throw new InvalidOperationException();
            return View(_movies);
        }

        public IActionResult AddOrEdit(){
            return View();
        }

        [HttpPost]
        public IActionResult AddOrEdit(MovieViewModel model){
            if(ModelState.IsValid){
                _movies.Add(model);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet("About")]
        public IActionResult About(){
            throw new InvalidOperationException();
            return View();
        }
    }
}