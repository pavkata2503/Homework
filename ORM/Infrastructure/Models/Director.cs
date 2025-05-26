using IMBD_Movies.Base_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IMBD_Movies.Model;

namespace IMBD_Movies.Models
{
    public class Director:BaseModel
    {

        public ICollection<Movie> Movies { get; set; }
    }

}
