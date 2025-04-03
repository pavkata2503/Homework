using FlightManager.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class Country:BaseModel
    {
        public string CountryName { get; set; }
        public int ContinentId { get; set; }
        public Continent Continent { get; set; } = null!;
        public ICollection<City> Cities { get; set; } = new List<City>();
    }
}
