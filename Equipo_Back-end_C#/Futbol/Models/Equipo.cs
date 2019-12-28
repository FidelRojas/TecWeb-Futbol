using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futbol.Models
{
    public class Equipo
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string info { get; set; }
        public string entrenador { get; set; }
        public string fundacion { get; set; }
        public string estadio { get; set; }

    }
}
