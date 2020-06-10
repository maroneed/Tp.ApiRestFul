using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Commands;
using TP.Plantilla.Domain.Entities;
using TP.Plantilla.Domain.DTOs;
using TP.Plantilla.Domain.Queries;

using SqlKata.Compilers;
using SqlKata.Execution;


namespace TP.Plantilla.Application.Services
{

    public interface ICarrito_ProductoService 
    {
        public GenericCreateResponseDto createCarrito_producto(Carrito_ProductoDto carrito_productoDto);
        public List<ResponseGetAllCarrito_ProductoDto> GetCarrito_producto();
        public ResponseGetCarrito_ProductoById GetById(int Id);
    }


    public class Carrito_ProductoService: ICarrito_ProductoService
    {
        private readonly IGenericsRepository _repository;
        private readonly ICarrito_ProductoQuery _query;

        public Carrito_ProductoService(IGenericsRepository repository,ICarrito_ProductoQuery query)
        {
            _repository = repository;
            _query = query;
        }

        public GenericCreateResponseDto createCarrito_producto(Carrito_ProductoDto carrito_productoDto) 
        {

            //List<Producto> productos = new List<Producto>();

            var entity = new Carrito_Producto
            {
                productoId = carrito_productoDto.productoId,
                carritoId = carrito_productoDto.carritoId,
                carritoNavigator = carrito_productoDto.carritoNavigator
                

            };
            _repository.Add(entity);
            return new GenericCreateResponseDto { Entity = "Carrito_Producto", Id = entity.carrito_productoId.ToString() };
        }

        public ResponseGetCarrito_ProductoById GetById(int carrito_productoId)
        {
            return _query.GetById(carrito_productoId);
        }

        public List<ResponseGetAllCarrito_ProductoDto> GetCarrito_producto()
        {
            return _query.GetAllCarrito_producto();
        }
        
    }
}
