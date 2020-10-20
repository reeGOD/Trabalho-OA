using Microsoft.EntityFrameworkCore.Migrations;

namespace Connect.Server.Migrations
{
    public partial class pedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Pedido_PedidoId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Lanches_LancheId",
                table: "Pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedido",
                table: "Pedido");

            migrationBuilder.RenameTable(
                name: "Pedido",
                newName: "Pedidos");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_LancheId",
                table: "Pedidos",
                newName: "IX_Pedidos_LancheId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Pedidos_PedidoId",
                table: "Items",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Lanches_LancheId",
                table: "Pedidos",
                column: "LancheId",
                principalTable: "Lanches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Pedidos_PedidoId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Lanches_LancheId",
                table: "Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos");

            migrationBuilder.RenameTable(
                name: "Pedidos",
                newName: "Pedido");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_LancheId",
                table: "Pedido",
                newName: "IX_Pedido_LancheId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedido",
                table: "Pedido",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Pedido_PedidoId",
                table: "Items",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Lanches_LancheId",
                table: "Pedido",
                column: "LancheId",
                principalTable: "Lanches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
