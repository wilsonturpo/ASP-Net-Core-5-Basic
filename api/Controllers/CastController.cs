using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers{
    [ApiController]
    [Route("api/movies/{movieId}/casts")]
    public class CastController : ControllerBase{
        
        [HttpGet]
        public IActionResult GetCasts(int movieId){
            var movie = MoviesDataStore.Current
            .Movies.FirstOrDefault(x => x.Id == movieId);
            
            if(movie == null){
                return NotFound();
            }

            return Ok(movie.Casts);
        }

        [HttpGet("{id}")]
        public IActionResult GetCast(int movieId, int id){
            var movie = MoviesDataStore.Current
            .Movies.FirstOrDefault(x => x.Id == movieId);

            if(movie == null){
                return NotFound();
            }

            var cast = movie.Casts.FirstOrDefault(x => x.Id == id);

            if(cast == null){
                return NotFound();
            }
            return Ok(cast);
        }
    }
}