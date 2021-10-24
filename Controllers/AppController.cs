using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MovieApp.ViewModel;
using System.Linq;

namespace MovieApp.Controllers{
    public class AppController : Controller{

        private static List<MovieViewModel> _movies = new List<MovieViewModel>();
        public IActionResult Index(){
            //throw new InvalidOperationException();
            return View(_movies);
        }

        public IActionResult AddOrEdit(Guid id){
            var movie = _movies.FirstOrDefault(x => x.Id == id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult AddOrEdit(MovieViewModel model){
            
            var movie = _movies.FirstOrDefault(x => x.Id == model.Id);            

            if(ModelState.IsValid){
                if(movie == null){
                    model.Id = Guid.NewGuid();
                    _movies.Add(model);                    
                }else{
                    movie.Genre = model.Genre;
                    movie.Name = model.Name;
                }
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Delete(Guid id){
            _movies.Remove(_movies.FirstOrDefault(x => x.Id == id));
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("About")]
        public IActionResult About(){
            //throw new InvalidOperationException();
            return View();
        }
    }
}