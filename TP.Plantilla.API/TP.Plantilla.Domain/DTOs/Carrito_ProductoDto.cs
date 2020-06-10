using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Entities;

namespace TP.Plantilla.Domain.DTOs
{
    public class Carrito_ProductoDto
    {
        public int carrito_productoId { get; set; }

        public int productoId { get; set; }

        public int carritoId { get; set; }
        public Carrito carritoNavigator { get; set; }

    }
}
