using FlightManager.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class Crew:BaseModel
    {
        public string Name { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;
        public ICollection<Airplane> airplanes { get; set; }=new List<Airplane>();
    }
}
