using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Queries;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Data;
using System.Linq;
using TP.Plantilla.Domain.DTOs;
using TP.Plantilla.Domain.Entities;

namespace TP.Plantilla.AccessData.Queries
{
    public class VentasQuery: IVentasQuery
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public VentasQuery(IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public List<GetVentas> ListarVentas()
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            var query = db.Query("Ventas")
                .Select("Ventas.ventasId", "Ventas.fecha",
                "Clientes.nombre as ClienteNombre", "Clientes.apellido as ClienteApellido",
                 "Productos.nombre as ProductoNombre","Productos.precio as ProductoPrecio"
                )
                .Join("Carritos", "Ventas.carritoId", "Carritos.carritoId")
                .Join("Carrito_Productos", "Carritos.carritoProductoId", "Carrito_Productos.carrito_productoId")
                .Join("Clientes", "Carritos.clienteId", "Clientes.clienteId")
                .Join("Productos", "Carrito_Productos.carrito_productoId", "Productos.carrito_productoId");

            
            var result = query.Get<GetVentas>();
                

            
            return result.ToList();
        }
    }
}
