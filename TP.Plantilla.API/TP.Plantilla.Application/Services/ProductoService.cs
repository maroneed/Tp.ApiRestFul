using SqlKata;
using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Commands;
using TP.Plantilla.Domain.DTOs;
using TP.Plantilla.Domain.Entities;
using TP.Plantilla.Domain.Queries;

namespace TP.Plantilla.Application.Services
{

    public interface IProductoService
    {
        Producto CreateProducto(ProductoDto Producto);
        public List<Producto> ListarProductos(string codigo);

    }
    public class ProductoService : IProductoService
    {
        private readonly IGenericsRepository _repository;
        private readonly IProductoQuery _query;
        public ProductoService(IGenericsRepository repository, IProductoQuery query)
        {
            _repository = repository;
            _query = query;
        }   


        public Producto CreateProducto(ProductoDto producto)
        {
            var entity = new Producto
            {
                codigo = producto.codigo,
                marca = producto.marca,

                nombre = producto.nombre,
                precio = producto.precio,

            };
            _repository.Add<Producto>(entity);

            return entity;
        }

        public List<Producto> ListarProductos(string codigo)
        {
            return _query.GetProductos( codigo);
        }
 
        
    }

    
}
