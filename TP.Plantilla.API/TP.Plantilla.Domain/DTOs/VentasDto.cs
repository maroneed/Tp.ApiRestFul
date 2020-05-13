using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Entities;

namespace TP.Plantilla.Domain.DTOs
{
    public class VentasDto
    {
        public int ventasId { get; set; }
        public int carritoId { get; set; }
        public DateTime fecha { get; set; }
        public Carrito carritoNavigator { get; set; }
    }
}
