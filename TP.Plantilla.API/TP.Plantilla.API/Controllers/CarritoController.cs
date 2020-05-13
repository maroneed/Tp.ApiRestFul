using Microsoft.AspNetCore.Mvc;
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
    public class CarritoController : ControllerBase
    {
        private readonly ICarritoService _service;
        private readonly SystemContext context;
        public CarritoController(ICarritoService service, SystemContext c)
        {
            _service = service;
            context = c;
        }

        [HttpPost]
        public Carrito Post(CarritoDto carrito)
        {
            return _service.CreateCarrito(carrito);
        }

        [HttpGet]
        [HttpGet]
        public IEnumerable<Carrito> Get()
        {
            return context.Carritos.ToList();
        }
    }
}
