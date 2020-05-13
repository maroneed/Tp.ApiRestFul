using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Entities;

namespace TP.Plantilla.Domain.DTOs
{
    public class GetVentas
    {
        
        public int ventasId { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteApellido { get; set; }

        public DateTime fecha { get; set; }

        //public GetCliente Cliente { get; set; }
        //public List<GetProducto> Producto { get; set; }
    }

    public class GetCliente
    {
        public string nombre { get; set; }
        public string apellido { get; set; }

    }
    public class GetProducto
    {
        public string nombre { get; set; }
        public int precio { get; set; }
    }
}
