using IMBD_Movies.Base_Models;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IMBD_Movies.Model;

namespace IMBD_Movies.Models
{
    public class Genre:BaseModel
    {

        public ICollection<MovieGenre> MovieGenres { get; set; }
    }

}
