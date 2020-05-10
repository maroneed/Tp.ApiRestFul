using System;
using System.Collections.Generic;
using System.Text;

namespace TP.Plantilla.Domain.Entities
{
    public class Producto
    {
        public int productoId { get; set; }
        public string codigo { get; set; }
        public string marca { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
    }
}
