﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TP.Plantilla.Domain.Entities
{
    public class Carrito_Producto
    {
        public int carrito_productoId { get; set; }
        public ICollection<Producto> productoNavigator { get; set; }
    }
}
