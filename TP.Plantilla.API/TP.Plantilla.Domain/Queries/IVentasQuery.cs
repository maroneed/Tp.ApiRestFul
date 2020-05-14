
using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.DTOs;

namespace TP.Plantilla.Domain.Queries
{
    public interface IVentasQuery
    {
        public List<GetVentas> ListarVentas();
        public List<GetVentas> FiltrarVentaPorProducto(string nombre);



    }
}
