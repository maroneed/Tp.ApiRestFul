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
    public class Carrito_ProductoQuery : ICarrito_ProductoQuery
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public Carrito_ProductoQuery(IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public List<ResponseGetAllCarrito_ProductoDto> GetAllCarrito_producto()
        {
            var db = new QueryFactory(connection, sqlKataCompiler);
            var query = db.Query("Carrito_Producto");


            var result = query.Get<ResponseGetAllCarrito_ProductoDto>();

            return result.ToList();

        }
        public ResponseGetCarrito_ProductoById GetById(int cursoId)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);
            var carrito_producto = db.Query("Cursos")
                
                .FirstOrDefault<ResponseGetAllCarrito_ProductoDto>();



            return new ResponseGetCarrito_ProductoById
            {
                carritoId = carrito_producto.carritoId
            };
        }
    }

}

    
