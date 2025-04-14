using FlightManager.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class Continent : BaseModel
    {
        [MaxLength(20)]
        public string ContinentName { get; set; }
        public ICollection<Country> Countries { get; set; } = new List<Country>();
    }
}
