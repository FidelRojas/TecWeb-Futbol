using Futbol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futbol.Service
{
    public interface IEquipoService
    {
        IEnumerable<Equipo> GetEquipos();
        Equipo postEquipo(Equipo equipo);
        Equipo GetEquipo(int id);
        Equipo UptateEquipo(int id, Equipo newEquipo);
        bool deleteEquipo(int id);
    }
}
