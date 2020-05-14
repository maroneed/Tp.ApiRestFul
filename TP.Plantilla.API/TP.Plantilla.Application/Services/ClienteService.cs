using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Commands;
using TP.Plantilla.Domain.DTOs;
using TP.Plantilla.Domain.Entities;
using TP.Plantilla.Application;
using TP.Plantilla.Domain.Queries;


namespace TP.Plantilla.Application.Services
{

    public interface IClienteService
    {
        Cliente CreateCliente(ClienteDto Cliente);
        // public List <Cliente> ListarClientes();
        public List<ResponseGetCliente> GetCliente(string dni);

    }
    public class ClienteService : IClienteService
    {
        private readonly IGenericsRepository _repository;
        private readonly IClienteQuery _query;

        public ClienteService(IGenericsRepository repository, IClienteQuery query)
        {
            _repository = repository;
            _query = query;
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

        public List<ResponseGetCliente> GetCliente(string dni)
        {

            return _query.GetClienteDni(dni);
            //return context.Ventas.Include(v => v.carritoNavigator).ToList();
        }

        

    }
}