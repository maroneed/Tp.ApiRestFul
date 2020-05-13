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
    public class ProductoController: ControllerBase
    {
        private readonly IProductoService _service;
        private readonly SystemContext context;

        public ProductoController(IProductoService service,SystemContext c)
        {
            _service = service;
            context = c;
        }

        [HttpPost]
        public Producto Post(ProductoDto producto)
        {
            return _service.CreateProducto(producto);
        }

        [HttpGet]
        public IEnumerable<Producto> Get()
        {
            return context.Productos.ToList();
        }
    }
}
