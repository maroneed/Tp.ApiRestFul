﻿using Microsoft.AspNetCore.Mvc;
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
        private readonly SystemContext context;
        

        public VentasController(IVentasService service,SystemContext c,IVentasQuery query)
        {
            _service = service;
            
            context = c;

            _query = query;

        }

        [HttpPost]
        public Ventas Post(VentasDto ventas) //que reciba un list de productos
        {
            
           
            return _service.CreateVenta(ventas);
        }

        [HttpGet]
        public List<GetVentas> Get()
        {
            return _query.ListarVentas();
            //return context.Ventas.Include(v => v.carritoNavigator).ToList();
        }
    }
}
