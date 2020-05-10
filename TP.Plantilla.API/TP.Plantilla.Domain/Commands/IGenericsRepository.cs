using System;
using System.Collections.Generic;
using System.Text;

namespace TP.Plantilla.Domain.Commands
{
    public interface IGenericsRepository
    {
        void Add<T>(T entity) where T : class; //recibe cualquier entidad
    }
}
