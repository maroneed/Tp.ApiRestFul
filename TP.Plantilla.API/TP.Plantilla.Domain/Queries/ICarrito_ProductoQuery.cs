using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.DTOs;

namespace TP.Plantilla.Domain.Queries
{
    public interface ICarrito_ProductoQuery
    {
        public List<ResponseGetAllCarrito_ProductoDto> GetAllCarrito_producto();
        public ResponseGetCarrito_ProductoById GetById(int id);
    }
}
