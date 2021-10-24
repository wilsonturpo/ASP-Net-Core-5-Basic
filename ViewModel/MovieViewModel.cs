using System;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.ViewModel{
    public class MovieViewModel{

        public Guid Id {get; set;}

        [Required(ErrorMessage ="El Nombre es requerido")]
        [MaxLength(30, ErrorMessage ="Texto demasiado largo")]
        public string Name {get; set;}
        
        [Required(ErrorMessage ="El Género es requerido")]
        [MaxLength(30, ErrorMessage ="Texto demasiado largo")]
        public string Genre {get; set;}
    }
}