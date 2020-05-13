using TP.Plantilla.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Entities;
using System.Linq;

namespace TP.Plantilla.AccessData.Commands
{
    public class GenericsRepository : IGenericsRepository
    {
        private readonly SystemContext _context;

        public GenericsRepository(SystemContext dbContext)
        {
            _context = dbContext;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity); //recibe cualquier entidad
            _context.SaveChanges(); //guarda el objeto en db
        }
        
        
        public void AddCliente(Cliente cliente) //asocio un cliente a un carrito
        {
            var entity = _context.Set<Carrito>().FirstOrDefault();
            entity.ClienteNavigator = cliente;
            _context.SaveChanges();
        }
        public void AddCarritoProductos(Carrito_Producto carritop, int carritoId)
        {
            var entity = _context.Set<Carrito>().FirstOrDefault(c => c.carritoId == carritoId);
           //entity.
        }

        public SystemContext Contexto()
        {
            return _context;
        }





    }
}
