using Microsoft.AspNetCore.Cors;
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
        public IActionResult Post(ProductoDto producto)
        {
            try
            {
                return new JsonResult(_service.CreateProducto(producto)) { StatusCode = 201 };

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        
        [HttpGet]
        public IActionResult GetProductos(string codigo)
        {
            try
            {
                return new JsonResult(_service.ListarProductos(codigo)) { StatusCode = 201 };

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            

        }
        

    }
}
