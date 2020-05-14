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
    public class ProductoQuery: IProductoQuery
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public ProductoQuery(IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public List<Producto> GetProductos(string codigo) 
        {
            var db = new QueryFactory(connection, sqlKataCompiler);
            
            var query = db.Query("Productos")
                .Select("Productos.productoId",
                "Productos.nombre",
                "Productos.marca",
                "Productos.codigo",
                "Productos.precio")
                .When(!string.IsNullOrWhiteSpace(codigo), c => c.WhereLike("Productos.codigo", $"%{codigo}%"));

            var result = query.Get<Producto>();

            return result.ToList();
        }



        


    }
}
