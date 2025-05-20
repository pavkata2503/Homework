using IMBD_Movies.Base_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMBD_Movies.Models
{
    public class Cast : BaseModel
    {
        public string ActorName { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
