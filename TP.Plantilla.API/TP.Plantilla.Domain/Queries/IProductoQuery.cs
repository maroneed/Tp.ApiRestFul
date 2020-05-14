using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Entities;
using TP.Plantilla.Domain.DTOs;

namespace TP.Plantilla.Domain.Queries
{
    public interface IProductoQuery
    {
        public List<Producto> GetProductos(string codigo);

    }
}
