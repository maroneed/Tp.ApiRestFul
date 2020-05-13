using Microsoft.EntityFrameworkCore.Migrations;

namespace TP.Plantilla.AccessData.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrito_Productos_Carritos_carritoId",
                table: "Carrito_Productos");

            migrationBuilder.DropIndex(
                name: "IX_Carrito_Productos_carritoId",
                table: "Carrito_Productos");

            migrationBuilder.DropColumn(
                name: "carritoId",
                table: "Carrito_Productos");

            migrationBuilder.AddColumn<int>(
                name: "carrito_ProductoNavigatorcarrito_productoId",
                table: "Carritos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carritos_carrito_ProductoNavigatorcarrito_productoId",
                table: "Carritos",
                column: "carrito_ProductoNavigatorcarrito_productoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carritos_Carrito_Productos_carrito_ProductoNavigatorcarrito_productoId",
                table: "Carritos",
                column: "carrito_ProductoNavigatorcarrito_productoId",
                principalTable: "Carrito_Productos",
                principalColumn: "carrito_productoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carritos_Carrito_Productos_carrito_ProductoNavigatorcarrito_productoId",
                table: "Carritos");

            migrationBuilder.DropIndex(
                name: "IX_Carritos_carrito_ProductoNavigatorcarrito_productoId",
                table: "Carritos");

            migrationBuilder.DropColumn(
                name: "carrito_ProductoNavigatorcarrito_productoId",
                table: "Carritos");

            migrationBuilder.AddColumn<int>(
                name: "carritoId",
                table: "Carrito_Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Carrito_Productos_carritoId",
                table: "Carrito_Productos",
                column: "carritoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Carrito_Productos_Carritos_carritoId",
                table: "Carrito_Productos",
                column: "carritoId",
                principalTable: "Carritos",
                principalColumn: "carritoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
