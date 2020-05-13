using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Entities;

namespace TP.Plantilla.Domain.DTOs
{
    public class ResponseGetAllCarrito_ProductoDto
    {
        public int carrito_productoId { get; set; }
        public ICollection<Producto> productoNavigator { get; set; }

    }
}
