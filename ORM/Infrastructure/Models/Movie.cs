using IMBD_Movies.Base_Models;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IMBD_Movies.Models
{
    public class Movie:BaseModel
    {
        public int ReleaseYear { get; set; }
        public int Duration { get; set; }
        public double ImdbRating { get; set; }
        public double? Metascore { get; set; }
        public double Votes { get; set; }
        public double Gross { get; set; }

        // Navigation properties
        public int? DirectorId { get; set; }
        public Director? Director { get; set; }

        public ICollection<MovieGenre>? MovieGenres { get; set; }
        public ICollection<MovieActor>? MovieActors { get; set; }
    }

}
