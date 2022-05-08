using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RazorPagesMovie.Models
{
    public class Movie
    {

        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;

       // [Datatype(Datatype.Date)]

        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; }





    }
}
