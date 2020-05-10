using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Commands;
using TP.Plantilla.Domain.DTOs;
using TP.Plantilla.Domain.Entities;

namespace TP.Plantilla.Application.Services
{

    public interface IClienteService
    {
        Cliente CreateCliente(ClienteDto Cliente);
    }
    public class ClienteService : IClienteService
    {
        private readonly IGenericsRepository _repository;
        public ClienteService(IGenericsRepository repository)
        {
            _repository = repository;
        }

        public Cliente CreateCliente(ClienteDto cliente)
        {
            var entity = new Cliente
            {
                nombre = cliente.nombre,
                apellido = cliente.apellido,
                dni = cliente.dni,
                telefono = cliente.telefono,
                direccion = cliente.direccion
            };
            _repository.Add<Cliente>(entity);

            return entity;
        }
    }
}