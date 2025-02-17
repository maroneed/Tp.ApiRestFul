﻿using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Entities;
namespace TP.Plantilla.Domain.DTOs
{
    public class ResponseGetCarrito_ProductoById
    {
        public int carrito_productoId { get; set; }
        public ICollection<Producto> productoNavigator { get; set; }


    }

    public class ResponseGetCarrito_ProductoByIdProducto 
    {
        public int productoId { get; set; }
        public string codigo { get; set; }
        public string marca { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
    }

    
}
