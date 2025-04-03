using BookingFlight.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingFlight.Models
{
    public class Role : BaseModel
    {
        [MaxLength(20)]
        public string RoleName { get; set; }
        public ICollection<Crew> Crews { get; set; } = new List<Crew>();
    }
}
