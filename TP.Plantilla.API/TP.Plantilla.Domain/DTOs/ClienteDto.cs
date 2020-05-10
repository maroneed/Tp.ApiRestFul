using System;
using System.Collections.Generic;
using System.Text;

namespace TP.Plantilla.Domain.DTOs
{
    public class ClienteDto
    {
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
    }
}
