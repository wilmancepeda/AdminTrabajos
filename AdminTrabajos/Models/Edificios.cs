using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminTrabajos.Models
{
    public class Edificios
    {
        public int EdificioId { get; set; }
        public string Direccion { get; set; }
        public string Tipo { get; set; }
        public byte NivelCalidad { get; set; }
        public byte Categoria { get; set; }

    }
}