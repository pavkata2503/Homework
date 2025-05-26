using System;
using System.Collections.Generic;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public int Duration { get; set; }
        public decimal IMDBRating { get; set; }
        public decimal? Metascore { get; set; }
        public int Votes { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
        public decimal? Gross { get; set; }
    }
} 