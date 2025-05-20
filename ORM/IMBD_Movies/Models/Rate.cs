using IMBD_Movies.Base_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMBD_Movies.Models
{
    public class Rate : BaseModel
    {
        public double IMDBrating { get; set; }
        public double Votes { get; set; }
        public double MetaScore { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
