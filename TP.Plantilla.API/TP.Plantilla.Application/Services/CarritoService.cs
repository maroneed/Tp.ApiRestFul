using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Commands;
using TP.Plantilla.Domain.DTOs;
using TP.Plantilla.Domain.Entities;

namespace TP.Plantilla.Application.Services
{

    public interface ICarritoService
    {
        Carrito CreateCarrito(CarritoDto Ventas);
    }
    public class CarritoService : ICarritoService
    {
        private readonly IGenericsRepository _repository;

        public CarritoService(IGenericsRepository repository)
        {
            _repository = repository;
        }

        public Carrito CreateCarrito(CarritoDto carrito)
        {
            var entity = new Carrito
            {
                clienteId = carrito.clienteId,
                carritoProductoId = carrito.carritoProductoId


            };
            _repository.Add<Carrito>(entity);

            return entity;
        }
    }
}
