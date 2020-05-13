﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TP.Plantilla.Domain.Entities
{
    public class Carrito
    {
        public int carritoId { get; set; }
        
        public int clienteId { get; set; }
        
        public int carritoProductoId { get; set; }

        public Carrito_Producto carrito_ProductoNavigator { get; set; }
        public Cliente ClienteNavigator { get; set; }


    }
}
