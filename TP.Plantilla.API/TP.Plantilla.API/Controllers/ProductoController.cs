using Microsoft.AspNetCore.Mvc;
using SqlKata;
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
    public class ProductoController: ControllerBase
    {
        private readonly IProductoService _service;
        private readonly IProductoQuery _query;

        public ProductoController(IProductoService service,IProductoQuery query)
        {
            _service = service;
            _query = query;
        }

        [HttpPost]
        public Producto Post(ProductoDto producto)
        {
            return _service.CreateProducto(producto);
        }

        //[HttpGet]
        //public IEnumerable<Producto> Get()
       // {
       //     return context.Productos.ToList();
        //}
        [HttpGet]
        public List<Producto> GetProductos(string codigo)
        {
            return _query.GetProductos(codigo);

        }
        

    }
}
