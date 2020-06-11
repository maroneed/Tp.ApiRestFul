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
        public Cliente CreateCliente(ClienteDto Cliente);
        // public List <Cliente> ListarClientes();
        public List<ResponseGetCliente> GetCliente(string nombre,string dato2,string dato3);

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
                direccion = cliente.direccion,
            };
            
            _repository.Add<Cliente>(entity);
            
            return entity;
        }

        public List<ResponseGetCliente> GetCliente(string dato,string dato2,string dato3)
        {

            return _query.GetCliente(dato,dato2,dato3);
            //return context.Ventas.Include(v => v.carritoNavigator).ToList();
        }

        

    }
}