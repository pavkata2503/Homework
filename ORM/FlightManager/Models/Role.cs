using FlightManager.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class Role:BaseModel
    {
        public string RoleName { get; set; }
        public ICollection<Crew> Crew { get; set; }=new List<Crew>();
    }
}
