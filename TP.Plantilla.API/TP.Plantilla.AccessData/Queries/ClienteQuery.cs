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
    public class ClienteQuery: IClienteQuery
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public ClienteQuery(IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public List<ResponseGetCliente> GetClienteDni(string dni) //sino se trae parametro, muestra todos los registros
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            var query = db.Query("Clientes")
                .Select("Clientes.nombre",
                "Clientes.apellido",
                "Clientes.dni",
                "Clientes.direccion",
                "Clientes.telefono")
                
                .When(!string.IsNullOrWhiteSpace(dni), c => c.WhereLike("Clientes.dni", $"{dni}"));
                

            var result = query.Get<ResponseGetCliente>();

            return result.ToList();
        }

        public List<ResponseGetCliente> GetClienteNombreApellido(string nombre)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            var query = db.Query("Clientes")
                .Select("Clientes.nombre",
                "Clientes.apellido",
                "Clientes.dni",
                "Clientes.direccion",
                "Clientes.telefono")
                .When(!string.IsNullOrWhiteSpace(nombre), c => c.WhereLike("Clientes.nombre", $"%{nombre}%"));



            var result = query.Get<ResponseGetCliente>();

            return result.ToList();
        }

    }
}
