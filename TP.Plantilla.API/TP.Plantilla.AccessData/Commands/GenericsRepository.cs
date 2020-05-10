using TP.Plantilla.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace TP.Plantilla.AccessData.Commands
{
    public class GenericsRepository: IGenericsRepository
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
    }
}
