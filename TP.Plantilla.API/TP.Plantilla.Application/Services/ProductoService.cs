using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Commands;
using TP.Plantilla.Domain.DTOs;
using TP.Plantilla.Domain.Entities;


namespace TP.Plantilla.Application.Services
{

    public interface IProductoService
    {
        Producto CreateProducto(ProductoDto Producto);
    }
    public class ProductoService : IProductoService
    {
        private readonly IGenericsRepository _repository;

        public ProductoService(IGenericsRepository repository)
        {
            _repository = repository;
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

        
    }

    
}
