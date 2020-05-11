using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP.Plantilla.Application.Services;
using TP.Plantilla.Domain.DTOs;
using TP.Plantilla.Domain.Entities;

namespace TP.Plantilla.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Carrito_ProductoController : ControllerBase
    {
        private readonly ICarrito_ProductoService _service;

        public Carrito_ProductoController(ICarrito_ProductoService service)
        {
            _service = service;
            
        }

        [HttpPost()]
        public IActionResult Post(Carrito_ProductoDto carrito_producto)
        {
            try
            {
                return new JsonResult(_service.createCarrito_producto(carrito_producto)) { StatusCode = 201 };

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

     //   [HttpGet]
     //    public IActionResult GetCarrito_Producto([FromQuery] Carrito_ProductoDto carrito_pro)
     //   {
     //       try
     //       {
      //        return new JsonResult(_service.createCarrito_Producto(carrito_pro)) { StatusCode = 200 };
      //      }
      //      catch
        //    {

          //  }
       // }
        [HttpGet("{Id}")]
        public IActionResult GetCarrito_productoById(int Id)
        {
            try
            {
                return new JsonResult(_service.GetById(Id)) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
    

}
