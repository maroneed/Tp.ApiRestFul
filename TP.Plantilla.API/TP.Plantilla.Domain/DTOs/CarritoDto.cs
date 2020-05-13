using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Entities;

namespace TP.Plantilla.Domain.DTOs
{
    public class CarritoDto
    {
        public int carritoId { get; set; }

        public int clienteId { get; set; }

        public int carritoProductoId { get; set; }

        public Carrito_Producto carrito_ProductoNavigator { get; set; }
        public Cliente ClienteNavigator { get; set; }
    }
}
