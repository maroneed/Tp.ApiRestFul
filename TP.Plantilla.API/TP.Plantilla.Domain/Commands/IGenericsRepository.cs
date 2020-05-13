using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Entities;

namespace TP.Plantilla.Domain.Commands
{
    public interface IGenericsRepository
    {
        void Add<T>(T entity) where T : class; //recibe cualquier entidad
        //public void AddCliente(Cliente cliente);
        //public void AddCarritoProductos(Carrito_Producto carritop, int carritoId);
        //public void AddProductos(Producto producto, int carritopId);
        //public void AddVentas(Ventas venta, int carritoId);


    }
}
