using System;
using System.Collections.Generic;
using System.Text;

namespace TP.Plantilla.Domain.Entities
{
    public class Cliente
    {
        public int clienteId { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

    }
}
