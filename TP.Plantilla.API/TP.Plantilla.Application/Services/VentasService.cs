using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Commands;
using TP.Plantilla.Domain.DTOs;
using TP.Plantilla.Domain.Entities;
using TP.Plantilla.Domain.Queries;


namespace TP.Plantilla.Application.Services
{
    public interface IVentasService
    {
        Ventas CreateVenta(ConcretarVentaDto ventas);
        public List<GetVentas> ListarVentas(string nombre);
        public List<GetVentas> ListarVentasDeHoy();

    }
    public class VentasService : IVentasService
    {
        private readonly IGenericsRepository _repository;
        private readonly IVentasQuery _query;


        public VentasService(IGenericsRepository repository, IVentasQuery query)
        {
            _repository = repository;
            _query = query;
        }

        public Ventas CreateVenta(ConcretarVentaDto ventas)
        {



            var carrito = new Carrito
            {
                clienteId = Int32.Parse(ventas.clienteId),
            };

            _repository.Add<Carrito>(carrito);

            var venta = new Ventas
            {
                carritoId = carrito.carritoId,
                fecha = DateTime.Now
            };

            _repository.Add<Ventas>(venta);

            foreach (string productoId in ventas.ListaProductos)
            {
                var cp = new Carrito_Producto
                {
                    carritoId = carrito.carritoId,
                    productoId = Int32.Parse(productoId)
                };
                _repository.Add<Carrito_Producto>(cp);
            }

            return venta;
        }
        public List<GetVentas> ListarVentas(string nombre)
        {
            return _query.FiltrarVentaPorProducto(nombre);
        }

        public List<GetVentas> ListarVentasDeHoy()
        {
            return _query.ListarVentas();
        }
    }
}
