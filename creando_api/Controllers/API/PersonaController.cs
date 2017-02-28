using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using creando_api.Models;

namespace creando_api.Controllers.API
{
    public class PersonaController : ApiController
    {
        Persona[] personas = new Persona[]
         {
            new Persona(){Id=0,Nombres="Camilo Alexander",Apellidos="Rodríguez Cuarán", FechaPago= new DateTime(2013,05,05), Salario=2500000, ValorComisiones=0, ValorPension=100000, ValorSalud=50000, PagoNeto=2350000},
            new Persona(){Id=1,Nombres="Jazmín",Apellidos="Hernandez", FechaPago= new DateTime(2013,05,05), Salario=2500000, ValorComisiones=0, ValorPension=100000, ValorSalud=50000, PagoNeto=2350000},
            new Persona(){Id=2,Nombres="Rosalba",Apellidos="Cuarán Fonseca", FechaPago= new DateTime(2013,05,05), Salario=2500000, ValorComisiones=0, ValorPension=100000, ValorSalud=50000, PagoNeto=2350000},
            new Persona(){Id=3,Nombres="Rosy Tatiana",Apellidos="Pachón Cuarán", FechaPago= new DateTime(2013,05,05), Salario=2500000, ValorComisiones=0, ValorPension=100000, ValorSalud=50000, PagoNeto=2350000},
            new Persona(){Id=4,Nombres="Yohis",Apellidos="Ramirez", FechaPago= new DateTime(2013,05,05), Salario=2500000, ValorComisiones=0, ValorPension=100000, ValorSalud=50000, PagoNeto=2350000},
            new Persona(){Id=5,Nombres="Hugo Enrique",Apellidos="Marín", FechaPago= new DateTime(2013,05,05), Salario=2500000, ValorComisiones=0, ValorPension=100000, ValorSalud=50000, PagoNeto=2350000}
         };

        // GET api/<controller>
        public IEnumerable<Persona> Get()
        {
            return personas;
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var persona = personas.FirstOrDefault((p) => p.Id == id);
            if (persona == null)
            {
                return NotFound();
            }
            return Ok(persona);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}