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
        Ventas CreateVenta(VentasDto ventas);
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

        public Ventas CreateVenta(VentasDto ventas)
        {



            DateTime fechaDeHoy = DateTime.Now;
            
            var entity = new Ventas
            {
                carritoId = ventas.carritoId,
                fecha = fechaDeHoy,
                carritoNavigator = ventas.carritoNavigator
               

            };


            _repository.Add<Ventas>(entity);

            return entity;
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
