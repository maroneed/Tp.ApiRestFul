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
        public IActionResult Post(ClienteDto cliente)
        {
            try
            {
                return new JsonResult(_service.CreateCliente(cliente)) { StatusCode = 201 };

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }

        

        [HttpGet]
        public IActionResult GetCliente(string dni, string nombre,string apellido)
        {

            try
            {
                return new JsonResult(_service.GetCliente(dni,nombre,apellido)) { StatusCode = 201 };

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            
            //return context.Ventas.Include(v => v.carritoNavigator).ToList();
        }


        

        
    }
}
