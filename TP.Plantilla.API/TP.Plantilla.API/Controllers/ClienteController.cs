﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP.Plantilla.AccessData;
using TP.Plantilla.Application.Services;
using TP.Plantilla.Domain.DTOs;
using TP.Plantilla.Domain.Entities;

namespace TP.Plantilla.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IClienteService _service;
        private readonly SystemContext context;

        public ClienteController(IClienteService service,SystemContext c)
        {
            _service = service;
            context = c;
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
        
        
    }
}
