using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace creando_api.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Salario { get; set; }
        public DateTime FechaPago { get; set; }
        public int ValorComisiones { get; set; }
        public int ValorSalud { get; set; }
        public int ValorPension { get; set; }
        public int PagoNeto { get; set; }

    }
}