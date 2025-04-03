using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManifacute.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        
        public int EngineId { get; set; }
        public Engine Engine { get; set; }

        public int Seats { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
    }
}
