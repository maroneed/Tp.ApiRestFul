using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP.Plantilla.AccessData;
using TP.Plantilla.Application.Services;
using TP.Plantilla.Domain.DTOs;
using TP.Plantilla.Domain.Entities;
using TP.Plantilla.Domain.Queries;

namespace TP.Plantilla.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IClienteService _service;
        private readonly IClienteQuery _query;

        public ClienteController(IClienteService service, IClienteQuery query)
        {
            _service = service;
            _query = query;
        }

        [HttpPost]
        public Cliente Post(ClienteDto cliente)
        {
            return _service.CreateCliente(cliente);
        }

        // [HttpGet]
        // public IEnumerable<Cliente> Get()
        // {
        //     return context.Clientes.ToList();
        //}

        [HttpGet]
        public List<ResponseGetCliente> GetClienteDni(string dni)
        {
            return _query.GetClienteDni(dni);
            //return context.Ventas.Include(v => v.carritoNavigator).ToList();
        }


        [HttpGet("{Nombre}")]
        public List<ResponseGetCliente> GetClienteNombreApellido(string nombre)
        {
            return _query.GetClienteNombreApellido(nombre);
            //return context.Ventas.Include(v => v.carritoNavigator).ToList();
        }

        
    }
}
