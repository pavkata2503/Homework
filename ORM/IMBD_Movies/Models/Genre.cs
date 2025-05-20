using IMBD_Movies.Base_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IMBD_Movies.Model;

namespace IMBD_Movies.Models
{
    public class Genre : BaseModel
    {
        public string GenreName { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
