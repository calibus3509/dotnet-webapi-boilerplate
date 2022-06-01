using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    public partial class DogShowCatClassesInDog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_DogShowClassCategories_DogShowClassCategoryId",
                schema: "Dsc",
                table: "Dogs");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_DogShowClassCategoryId",
                schema: "Dsc",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "DogShowClassCategoryId",
                schema: "Dsc",
                table: "Dogs");

            migrationBuilder.CreateTable(
                name: "DogDogShowClassCategory",
                schema: "Dsc",
                columns: table => new
                {
                    DogShowClassCategorysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DogsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogDogShowClassCategory", x => new { x.DogShowClassCategorysId, x.DogsId });
                    table.ForeignKey(
                        name: "FK_DogDogShowClassCategory_Dogs_DogsId",
                        column: x => x.DogsId,
                        principalSchema: "Dsc",
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DogDogShowClassCategory_DogShowClassCategories_DogShowClassCategorysId",
                        column: x => x.DogShowClassCategorysId,
                        principalSchema: "Dsc",
                        principalTable: "DogShowClassCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DogDogShowClassCategory_DogsId",
                schema: "Dsc",
                table: "DogDogShowClassCategory",
                column: "DogsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogDogShowClassCategory",
                schema: "Dsc");

            migrationBuilder.AddColumn<Guid>(
                name: "DogShowClassCategoryId",
                schema: "Dsc",
                table: "Dogs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_DogShowClassCategoryId",
                schema: "Dsc",
                table: "Dogs",
                column: "DogShowClassCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_DogShowClassCategories_DogShowClassCategoryId",
                schema: "Dsc",
                table: "Dogs",
                column: "DogShowClassCategoryId",
                principalSchema: "Dsc",
                principalTable: "DogShowClassCategories",
                principalColumn: "Id");
        }
    }
}
