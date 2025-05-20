using IMBD_Movies.Base_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IMBD_Movies.Models
{
    public class Movie : BaseModel
    {
        public string MovieName { get; set; }
        public int Duration { get; set; }
        public int RateId { get; set; }
        public Rate Rate { get; set; }
        public int ReleaseYearId { get; set; }
        public ReleaseYear ReleaseYear { get; set; }
        public List<Genre> Genres { get; set; }
        public int CastId { get; set; }
        public Cast Cast { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }


    }
}
