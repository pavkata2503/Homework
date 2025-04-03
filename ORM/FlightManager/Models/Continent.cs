using FlightManager.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class Continent:BaseModel
    {
        public string ContinentName { get; set; }
        public ICollection<Country> Countries { get; set; }=new List<Country>();
    }
}
