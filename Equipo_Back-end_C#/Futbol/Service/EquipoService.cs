using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Futbol.Models;

namespace Futbol.Service{

    public class EquipoService : IEquipoService
    {
        private List<Equipo> equipos;
        
        public EquipoService()
        {
            equipos = new List<Equipo>()
            {
                new Equipo()
                {
                    id= 1,
                    nombre="Arsenal",
                    info="El Arsenal Football Club es un club de fútbol profesional con sede en Holloway, Londres, Inglaterra, que juega en la máxima categoría del fútbol de ese país, la Premier League.",
                    entrenador=" Mikel Arteta",
                    estadio="Emirates Stadium",
                    fundacion = "1886"

                },  
                new Equipo()
                {
                    id= 2,
                    nombre="Chelsea",
                    info="El Chelsea Football Club, conocido simplemente como Chelsea, es un club de fútbol profesional de Inglaterra con sede en el distrito de Fulham, que disputa actualmente la Premier League, máxima competición futbolística de ese país.",
                    entrenador="Frank Lampard",
                    estadio="Stamford Bridge",
                    fundacion = "1905"
                },
                new Equipo()
                {
                    id= 3,
                    nombre="Liverpool",
                    info="El Liverpool Football Club es un club de fútbol profesional con sede en Liverpool, Inglaterra, que disputa la Premier League, máxima competición futbolística en ese país.",
                    entrenador="Jürgen Klopp",
                    estadio="Anfield",
                    fundacion = "1941"

                },
                new Equipo()
                {
                    id= 4,
                    nombre="Leicester",
                    info="El Leicester City Football Club, conocido también por su apodo The Foxes, es un club profesional de fútbol con sede en Leicester, Inglaterra, fundado en 1884. Actualmente juega en la Premier League. Ascendió como campeón del Football League Championship 2013-14, luego de más de diez años relegado de esta división",
                    entrenador=" Brendan Rodgers",
                    estadio="King Power Stadium",
                    fundacion = "1924"

                },
                new Equipo()
                {
                    id= 5,
                    nombre="Manchester City",
                    info="El Manchester City Football Club es un club de fútbol de Mánchester, Inglaterra que juega en la Premier League. Fue fundado en 1880 bajo el nombre de St. Mark's, luego pasó a llamarse Ardwick Association Football Club en 1887 y finalmente, el 16 de abril de 1894, se convirtió en el Manchester City. ",
                    entrenador="Pep Guardiola",
                    estadio="Estadio Ciudad de Mánchester",
                    fundacion = "1831"

                }
            };
        }

        public bool deleteEquipo(int id)
        {
            var equipoEliminar=equipos.SingleOrDefault(x => x.id == id);
            if(equipos.Remove(equipoEliminar))
            {
                return true;
            }
            return false;
        }

        public Equipo GetEquipo(int id)
        {
            var equipo = equipos.SingleOrDefault(a => a.id == id);
            //if (estudiantes.Exists(a => a.id == id))
            //{
            //    return estudiantes.Find(a => a.id == id);

            //}
            //else
            //    return null;
            //if (equipo == null)
            //{
            //    throw new NotFoundItemException($"cannot found student with id {id}");

            //}

            return equipo;
        }

        public IEnumerable<Equipo> GetEquipos()
        {
            return equipos;
        }

        public Equipo postEquipo(Equipo newEquipo)
        {
            
            var lastEquipo = equipos.OrderByDescending(a => a.id).FirstOrDefault();
            var nexId = lastEquipo == null ? 1 : lastEquipo.id + 1;
            newEquipo.id = nexId;
            equipos.Add(newEquipo);
            //if (newEquipo != null)
            //{
            //    return newEquipo;

            //}
            //else
            //    throw new MensajeError("Error");

            return newEquipo;

        }

        public Equipo UptateEquipo(int id, Equipo newEquipo)
        {
            if (equipos.Exists(e => e.id == id))
            {
                equipos.Find(s => s.id == id).nombre = newEquipo.nombre;
                equipos.Find(s => s.id == id).info = newEquipo.info;
                equipos.Find(s => s.id == id).entrenador = newEquipo.entrenador;
                equipos.Find(s => s.id == id).estadio = newEquipo.estadio;
                equipos.Find(s => s.id == id).fundacion = newEquipo.fundacion;

            }
            //else
            //    throw new BadRequestOperationException("id URL should be euqual to body");
            return equipos.Find(s => s.id == id);


        }
    }
}
