using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers{

    [ApiController]
    [Route("api/movies")]
    public class MoviesController : ControllerBase{
        
        public JsonResult GetMovies(){
            return new JsonResult( 
                new List<object>(){
                new {
                    id = 1, 
                    Name="Walk"
                    },

                new {
                    id = 2,
                    Name = "Dead"
                }
            });
        }
    }
}