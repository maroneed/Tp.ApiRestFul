using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TP.Plantilla.Domain.Entities;

namespace TP.Plantilla.AccessData
{
    public class SystemContext : DbContext
    {
        public SystemContext(DbContextOptions<SystemContext> options) : base(options)
        {

        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Carrito> Carritos { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<Carrito_Producto> Carrito_Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //producto

            modelBuilder.Entity<Producto>().Property(s => s.productoId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Producto>().Property(s => s.precio).HasColumnType("decimal(15,2)").IsRequired();
            modelBuilder.Entity<Producto>().Property(s => s.codigo).HasMaxLength(45).IsRequired();
            modelBuilder.Entity<Producto>().HasIndex(s => s.codigo).IsUnique();

            modelBuilder.Entity<Producto>().Property(s => s.marca).HasMaxLength(45).IsRequired();
            modelBuilder.Entity<Producto>().Property(s => s.nombre).HasMaxLength(45).IsRequired();

            //Cliente

            modelBuilder.Entity<Cliente>().Property(t => t.clienteId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Cliente>().Property(t => t.dni).HasMaxLength(45).IsRequired();
            modelBuilder.Entity<Cliente>().HasIndex(t => t.dni).IsUnique();
            modelBuilder.Entity<Cliente>().Property(t => t.nombre).HasMaxLength(45).IsRequired();
            modelBuilder.Entity<Cliente>().Property(t => t.apellido).HasMaxLength(45).IsRequired();
            modelBuilder.Entity<Cliente>().Property(t => t.direccion).HasMaxLength(45).IsRequired();
            modelBuilder.Entity<Cliente>().Property(t => t.telefono).HasMaxLength(45);

            //venta

            modelBuilder.Entity<Ventas>().Property(v => v.ventasId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Ventas>().HasIndex(v => v.carritoId).IsUnique();

            //carrito

            modelBuilder.Entity<Carrito>().Property(v => v.carritoId).ValueGeneratedOnAdd();


            //carrito_producto

            modelBuilder.Entity<Carrito_Producto>().Property(v => v.carrito_productoId).ValueGeneratedOnAdd();




        }
    }
}
