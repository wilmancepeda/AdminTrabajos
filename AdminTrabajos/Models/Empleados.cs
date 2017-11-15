using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminTrabajos.Models
{
    public class Empleados
    {
        public int EmpleadoId { get; set; }
        public string Name { get; set; }
        public double Tarifa { get; set; }
        public string Oficio { get; set; }
        public int Supervisor { get; set; }

    }
}