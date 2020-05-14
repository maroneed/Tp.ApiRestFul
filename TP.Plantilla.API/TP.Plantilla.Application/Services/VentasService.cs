using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Commands;
using TP.Plantilla.Domain.DTOs;
using TP.Plantilla.Domain.Entities;

namespace TP.Plantilla.Application.Services
{
    public interface IVentasService
    {
        Ventas CreateVenta(VentasDto ventas);
    }
    public class VentasService : IVentasService
    {
        private readonly IGenericsRepository _repository;
        


        public VentasService(IGenericsRepository repository)
        {
            _repository = repository;
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
    }
}
