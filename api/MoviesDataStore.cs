using System.Collections.Generic;
using api.Models;

namespace api{
    public class MoviesDataStore{

        public static MoviesDataStore Current {get; set;} = new MoviesDataStore();
        public List<MovieDto> Movies {get; set;}
        public MoviesDataStore() => Movies = new List<MovieDto>(){            
            new MovieDto(){
                Id = 1,
                Name = "Walk",
                Description = "Dead",
                Casts = new List<CastDto>(){
                    new CastDto {Id = 1, Name = "Daniel", Character = "Hero"}
                }
            },
            new MovieDto(){
                Id = 2,
                Name = "breaking",
                Description = "bad",
                Casts = new List<CastDto>(){
                    new CastDto {Id = 1, Name = "Lener", Character = "Batman"}
                }
            }
        };
    }
}
