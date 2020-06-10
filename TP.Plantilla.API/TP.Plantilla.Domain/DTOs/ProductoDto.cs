using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Entities;

namespace TP.Plantilla.Domain.DTOs
{
    public class ProductoDto
    {
        public int productoId { get; set; }
        public string codigo { get; set; }
        public string marca { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public ICollection<Carrito_Producto> carritoProductoNavigator { get; set; }
    }
}
