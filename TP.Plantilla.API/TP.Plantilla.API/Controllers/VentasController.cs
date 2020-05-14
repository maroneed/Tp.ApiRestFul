using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

    public class VentasController : ControllerBase
    {
        private readonly IVentasService _service;
        private readonly IVentasQuery _query;



        public VentasController(IVentasService service, IVentasQuery query)
        {
            _service = service;



            _query = query;

        }

        [HttpPost]
        public IActionResult Post(VentasDto ventas) //que reciba un list de productos
        {

            try
            {
                return new JsonResult(_service.CreateVenta(ventas)) { StatusCode = 201 };

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }

       
      
        [HttpGet]
        public IActionResult FiltrarVentaPorProducto(string nombre)
        {
            try
            {
                return new JsonResult(_service.ListarVentas(nombre)) { StatusCode = 201 };

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            

        }


    }
}
