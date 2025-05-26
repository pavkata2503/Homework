using IMBD_Movies.Base_Models;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMBD_Movies.Models
{
    public class Cast : BaseModel
    {

        public ICollection<MovieActor> MovieActors { get; set; }


    }
}
