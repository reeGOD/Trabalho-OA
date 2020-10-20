using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Connect.Server.Migrations
{
    public partial class Ingrediente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IngredienteId",
                table: "Lanches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Ingredientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredientes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lanches_IngredienteId",
                table: "Lanches",
                column: "IngredienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lanches_Ingredientes_IngredienteId",
                table: "Lanches",
                column: "IngredienteId",
                principalTable: "Ingredientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lanches_Ingredientes_IngredienteId",
                table: "Lanches");

            migrationBuilder.DropTable(
                name: "Ingredientes");

            migrationBuilder.DropIndex(
                name: "IX_Lanches_IngredienteId",
                table: "Lanches");

            migrationBuilder.DropColumn(
                name: "IngredienteId",
                table: "Lanches");
        }
    }
}
