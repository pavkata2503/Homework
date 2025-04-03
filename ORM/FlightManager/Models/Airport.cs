using FlightManager.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class Airport:BaseModel
    {
        public string Name { get; set; }
        public int CityId { get; set; }
        public City City { get; set; } = new City();
    }
}
