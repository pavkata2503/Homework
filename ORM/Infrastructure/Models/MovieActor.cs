using IMBD_Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models
{
        public class MovieActor
        {
            public int Id { get; set; }
            public int MovieId { get; set; }
            public Movie Movie { get; set; }

            public int ActorId { get; set; }
            public Cast Cast { get; set; }
        }
}
