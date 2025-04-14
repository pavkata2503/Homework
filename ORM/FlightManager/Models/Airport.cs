using FlightManager.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class Airport : BaseModel
    {
        [MaxLength(100)]
        public string AirportName { get; set; }
        public int? CityId { get; set; }
        public City? City { get; set; } = null!;
        public ICollection<Flight> Flights { get; set; } = new List<Flight>();
    }
}
