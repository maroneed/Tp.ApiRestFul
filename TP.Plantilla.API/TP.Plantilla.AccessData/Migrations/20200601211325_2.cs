using Microsoft.EntityFrameworkCore.Migrations;

namespace TP.Plantilla.AccessData.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Carrito_Productos_carrito_productoId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_carrito_productoId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "carrito_productoId",
                table: "Productos");

            migrationBuilder.CreateIndex(
                name: "IX_Carrito_Productos_productoId",
                table: "Carrito_Productos",
                column: "productoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carrito_Productos_Productos_productoId",
                table: "Carrito_Productos",
                column: "productoId",
                principalTable: "Productos",
                principalColumn: "productoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrito_Productos_Productos_productoId",
                table: "Carrito_Productos");

            migrationBuilder.DropIndex(
                name: "IX_Carrito_Productos_productoId",
                table: "Carrito_Productos");

            migrationBuilder.AddColumn<int>(
                name: "carrito_productoId",
                table: "Productos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_carrito_productoId",
                table: "Productos",
                column: "carrito_productoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Carrito_Productos_carrito_productoId",
                table: "Productos",
                column: "carrito_productoId",
                principalTable: "Carrito_Productos",
                principalColumn: "carrito_productoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
