using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminTrabajos.Models
{
    public class Asignaciones
    {
        public int AsignacioneId { get; set; }
        public int EdificioId { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public byte DiasTrabajados { get; set; }

    }
}