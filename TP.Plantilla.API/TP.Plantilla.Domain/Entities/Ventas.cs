using System;
using System.Collections.Generic;
using System.Text;

namespace TP.Plantilla.Domain.Entities
{
    public class Ventas
    {
        public int ventasId { get; set; }
        public int carritoId { get; set; }
        public DateTime fecha { get; set; }
        public Carrito carritoNavigator { get; set; }


    }
}
