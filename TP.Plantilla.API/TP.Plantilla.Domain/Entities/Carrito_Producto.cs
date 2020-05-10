using System;
using System.Collections.Generic;
using System.Text;

namespace TP.Plantilla.Domain.Entities
{
    public class Carrito_Producto
    {
        public int carrito_productoId { get; set; }
        public int carritoId { get; set; }
        public Carrito carritoNavigator { get; set; }
        public ICollection<Producto> productoNavigator { get; set; }
    }
}
