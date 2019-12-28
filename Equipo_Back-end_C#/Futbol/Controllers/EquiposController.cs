using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Futbol.Models;
using Futbol.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Futbol.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class EquiposController : ControllerBase
    {
        private IEquipoService equipoService;
        public EquiposController(IEquipoService equipoService)
        {
            this.equipoService = equipoService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Equipo>> Get()
        {
            var equipos = equipoService.GetEquipos();
            return Ok(equipos);

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Equipo> Get(int id)
        {
            try
            {
                return Ok(equipoService.GetEquipo(id));
            }
            //catch (NotFoundItemException ex)
            //{
            //    return NotFound(ex.Message);
            //}
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        } 

        // POST api/values
        [HttpPost]
        public ActionResult<Equipo> Post([FromBody] Equipo equipo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createEquipo = equipoService.postEquipo(equipo);
            return createEquipo;

            //Console.WriteLine(equipo);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<Equipo> PutEquipo(int id, [FromBody]Equipo equipo)
        {
            try
            {
                return Ok(equipoService.UptateEquipo(id, equipo));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            if (equipoService.deleteEquipo(id))
                return true;
            return false;
        }

    }
}