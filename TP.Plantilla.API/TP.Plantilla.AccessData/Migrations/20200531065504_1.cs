using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TP.Plantilla.AccessData.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    clienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dni = table.Column<string>(maxLength: 45, nullable: false),
                    nombre = table.Column<string>(maxLength: 45, nullable: false),
                    apellido = table.Column<string>(maxLength: 45, nullable: false),
                    direccion = table.Column<string>(maxLength: 45, nullable: false),
                    telefono = table.Column<string>(maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.clienteId);
                });

            migrationBuilder.CreateTable(
                name: "Carritos",
                columns: table => new
                {
                    carritoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carritos", x => x.carritoId);
                    table.ForeignKey(
                        name: "FK_Carritos_Clientes_clienteId",
                        column: x => x.clienteId,
                        principalTable: "Clientes",
                        principalColumn: "clienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carrito_Productos",
                columns: table => new
                {
                    carrito_productoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productoId = table.Column<int>(nullable: false),
                    carritoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrito_Productos", x => x.carrito_productoId);
                    table.ForeignKey(
                        name: "FK_Carrito_Productos_Carritos_carritoId",
                        column: x => x.carritoId,
                        principalTable: "Carritos",
                        principalColumn: "carritoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    ventasId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carritoId = table.Column<int>(nullable: false),
                    fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.ventasId);
                    table.ForeignKey(
                        name: "FK_Ventas_Carritos_carritoId",
                        column: x => x.carritoId,
                        principalTable: "Carritos",
                        principalColumn: "carritoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    productoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(maxLength: 45, nullable: false),
                    marca = table.Column<string>(maxLength: 45, nullable: false),
                    nombre = table.Column<string>(maxLength: 45, nullable: false),
                    precio = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    carrito_productoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.productoId);
                    table.ForeignKey(
                        name: "FK_Productos_Carrito_Productos_carrito_productoId",
                        column: x => x.carrito_productoId,
                        principalTable: "Carrito_Productos",
                        principalColumn: "carrito_productoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carrito_Productos_carritoId",
                table: "Carrito_Productos",
                column: "carritoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carritos_clienteId",
                table: "Carritos",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_dni",
                table: "Clientes",
                column: "dni",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_carrito_productoId",
                table: "Productos",
                column: "carrito_productoId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_codigo",
                table: "Productos",
                column: "codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_carritoId",
                table: "Ventas",
                column: "carritoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Carrito_Productos");

            migrationBuilder.DropTable(
                name: "Carritos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
